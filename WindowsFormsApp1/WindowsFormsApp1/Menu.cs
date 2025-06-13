using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaibamais_Click(object sender, EventArgs e)
        {
            saibamais saibamais = new saibamais();
            saibamais.ShowDialog();
        }
    }
}
