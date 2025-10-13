using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte2.Formularios
{
    public partial class FrmVector : Form
    {
        Nota nota = new Nota();
        public FrmVector()
        {
            InitializeComponent();
        }

        private void tbNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nota.AgregarNota(int.Parse(tbNota.Text));
                tbNota.Clear();
                lblNotas.Text = nota.Show();
            }
        }
    }
}
