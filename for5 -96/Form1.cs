using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for5__96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();

            int baslangic = Convert.ToInt32(txtBaslangic.Text);
            int bitis = Convert.ToInt32(txtBitis.Text);
            int degisim = Convert.ToInt32(txtDegisim.Text);    

            for (int i = baslangic; i <= bitis; i= i + degisim)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
