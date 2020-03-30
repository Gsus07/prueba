using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoGUI
{
    public partial class FrmCuentasCorriente : Form
    {
        public FrmCuentasCorriente()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            FrmCuentasCorriente frmcuentasCorriente = new FrmCuentasCorriente();
            frmcuentasCorriente.MdiParent = this;
            frmcuentasCorriente.Show();
            
        }
    }
}
