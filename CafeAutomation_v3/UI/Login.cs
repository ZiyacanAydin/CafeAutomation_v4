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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesUI siparisekle = new SalesUI();
            siparisekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductUI urunekle = new ProductUI();
            urunekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableUI masaekle = new TableUI();
            masaekle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CategoryUI katek = new CategoryUI();
            katek.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KasaUI kasaekle = new KasaUI();
            kasaekle.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
