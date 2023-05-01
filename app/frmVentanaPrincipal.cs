using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class frmVentanaPrincipal : Form
    {
        NegocioArticulo negocio;
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        // METODOS
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            negocio = new NegocioArticulo();
            dgvPanel.DataSource = negocio.Leer();
        }
    }
}
