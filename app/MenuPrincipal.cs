﻿using System;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        //TODO: BOTON NUEVO ARTICULO
        private void btnNuevoArt_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAgregarArt))
                    return;
            }
            frmAgregarArt frmAgregarArt = new frmAgregarArt();
            frmAgregarArt.MdiParent = this;
            frmAgregarArt.Show();
        }

        ////TODO: BOTON CONTROL ARTICULO
        private void btnControlArt_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(frmVentanaPrincipal)) 
                    return;
            }
            frmVentanaPrincipal frmVentanaPrincipal = new frmVentanaPrincipal();
            frmVentanaPrincipal.MdiParent = this;
            frmVentanaPrincipal.Show();
        }
    }
}
