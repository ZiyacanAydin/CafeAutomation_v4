using CafeAutomation_v3.Business;
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

namespace CafeAutomation_v3.UI
{
    public partial class KasaUI : Form
    {
        public KasaUI()
        {
            InitializeComponent();
        }
        KasaManager kasaManager=new KasaManager();
        private void KasaUI_Load(object sender, EventArgs e)
        {

            listele();  

        }
        void listele()
        {
            dataGridView1.DataSource = kasaManager.GetAll().Select(x => new { x.Id,x.SalesId, x.TableId,x.ProductId,x.OrderTime,x.Sum }).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KasaManager kasaManager = new KasaManager();

           var result = kasaManager.GetAll().Where(x => x.OrderTime <= dateTimePicker2.Value && x.OrderTime >= dateTimePicker1.Value).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
