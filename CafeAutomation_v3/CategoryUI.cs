using CafeAutomation_v3.Business;
using CafeAutomation_v3.DAL;
using CafeAutomation_v3.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAutomation_v3
{
    public partial class CategoryUI : Form
    {
        
        public CategoryUI()
        {
            InitializeComponent();
        }
        
        CategoryManager CategoryManager = new CategoryManager();
        Category category = new Category();
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }
        void listele()
        {
            dataGridView1.DataSource = CategoryManager.GetAll().Select(x => new { x.Id, x.Name }).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            category.Name = textBox2.Text;
            CategoryManager.Add(category);
            listele();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            CategoryManager.Delete(id);
            listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = int.Parse(textBox1.Text);
            category.Name = textBox2.Text;
            CategoryManager.Update(category);
            listele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var satir = dataGridView1.CurrentRow.Cells;
            textBox1.Text = satir[0].Value.ToString();
            textBox2.Text = satir[1].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
