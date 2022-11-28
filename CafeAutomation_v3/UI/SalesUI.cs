using CafeAutomation_v3.Business;
using CafeAutomation_v3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeAutomation_v3.UI
{
    public partial class SalesUI : Form
    {
        public SalesUI()
        {
            InitializeComponent();
        }

        SalesManager salesManager = new SalesManager();
        TableManager tableManager = new TableManager();
        ProductManager productManager = new ProductManager();
        KasaManager kasaManager = new KasaManager();
        private void SalesUI_Load(object sender, EventArgs e)
        {
            listele();

        }

        void listele()
        {
            var sales = salesManager.GetAll();
            var kasas = kasaManager.GetAll().Select(x => x.SalesId).ToList();
            List<Sales> list = new List<Sales>();
                        
            foreach (var item in sales)
            {
               
                if (kasas.IndexOf(item.Id) == -1)
                {
                    list.Add(item);
                }

            }
            var tables = tableManager.GetAll();
            var products = productManager.GetAll();
            dataGridView1.DataSource = list.Select(x => new { x.Id, x.TableId, x.ProductId, x.count, x.Sum, x.DateTime }).ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = tables;



            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Name";
            comboBox2.DataSource = products;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            sale.TableId = Convert.ToInt32(comboBox1.SelectedValue);
            sale.ProductId = Convert.ToInt32(comboBox2.SelectedValue);
            sale.count = Convert.ToInt32(textBox1.Text);
            sale.DateTime = DateTime.Now;

            var price = productManager.Get(sale.ProductId).Price;
            var sum = price * sale.count;
            sale.Sum = sum;

            salesManager.Add(sale);
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            salesManager.Delete(id);
            listele();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tableid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            var sales = salesManager.GetAll().Where(x => x.TableId == tableid).ToList();
            foreach (var item in sales)
            {
                Kasa kasa = new Kasa();
                kasa.TableId = item.TableId;
                kasa.SalesId = item.Id;
                kasa.Count = item.count;
                kasa.Sum = item.Sum;
                kasa.OrderTime = item.DateTime;
                kasa.ProductId = item.ProductId;
                kasaManager.Add(kasa);

            }
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
