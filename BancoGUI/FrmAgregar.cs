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
    public partial class FrmAgregar : Form
    {
        FrmCuentasAhorro cuentasAhorro;

        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void BtnCuentaCorriente_Click(object sender, EventArgs e)
        {
            FrmCuentasCorriente frmcuentasCorriente = new FrmCuentasCorriente();
            frmcuentasCorriente.Show();
        }

        private void BtnCuentaAhorro_Click(object sender, EventArgs e)
        {
            FrmCuentasAhorro frmcuentasAhorro = new FrmCuentasAhorro();
            frmcuentasAhorro.Show();
        }
    }
}
