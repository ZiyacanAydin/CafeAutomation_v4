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
    public partial class TableUI : Form
    {
        TableManager tableManager = new TableManager();
        public TableUI()
        {
            InitializeComponent();
        }

        private void TableUI_Load(object sender, EventArgs e)
        {
            listele();
        }

        Table table = new Table();
        void listele()
        {
            dataGridView1.DataSource = tableManager.GetAll().Select(x => new { x.Id, x.Name }).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            table.Name = textBox1.Text;
            tableManager.Add(table);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            tableManager.Delete(id);
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var satir = dataGridView1.CurrentRow.Cells;
            textBox2.Text = satir[0].Value.ToString();
            textBox1.Text = satir[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.Id = int.Parse(textBox2.Text);
            table.Name = textBox1.Text;
            tableManager.Update(table);
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
