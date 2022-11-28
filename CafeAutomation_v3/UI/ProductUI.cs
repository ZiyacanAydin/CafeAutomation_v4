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

namespace CafeAutomation_v3.UI
{
    public partial class ProductUI : Form
    {       
        ProductManager productManager = new ProductManager();
        public ProductUI()
        {
            InitializeComponent();
        }
        Product product = new Product();
        private void ProductUI_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            dataGridView1.DataSource = productManager.GetAll().Select(x => new { x.CategoryId, x.Name, x.Price, x.Description }).ToList();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            product.CategoryId = Convert.ToInt32(textBox2.Text);
            product.Name = textBox3.Text;
            product.Price = Convert.ToDecimal(textBox4.Text);
            product.Description = textBox5.Text;
            productManager.Add(product);
            listele();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            productManager.Delete(id);
            listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id=int.Parse(textBox1.Text);
            product.CategoryId=int.Parse(textBox2.Text);
            product.Name=textBox3.Text;
            product.Price=Convert.ToDecimal(textBox4.Text);
            product.Description=textBox5.Text;
            productManager.Update(product);
            listele();
           

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var satir = dataGridView1.CurrentRow.Cells;
            textBox1.Text = satir[0].Value.ToString();
            textBox2.Text = satir[1].Value.ToString();
            textBox3.Text=satir[2].Value.ToString();
            textBox4.Text=satir[3].Value.ToString();
            textBox5.Text=satir[4].Value.ToString();
        }
    }
}
