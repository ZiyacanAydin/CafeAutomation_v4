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
    public partial class FirstLogin : Form
    {
        public FirstLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Giriş Başarılı");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else if (textBox1.Text == "mehmet" && textBox2.Text == "1234")
            {
                MessageBox.Show("Giriş Başarılı");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }

        }
    }
}
