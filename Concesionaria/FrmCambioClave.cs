using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concesionaria.Clases;

namespace Concesionaria
{
    public partial class FrmCambioClave : FrmBase
    {
        public FrmCambioClave()
        {
            InitializeComponent();
        }

        private void FrmCambioClave_Load(object sender, EventArgs e)
        {
            int CodUsuario = Convert.ToInt32(Principal.CodUsuarioLogueado);
            cUsuario usuario = new Clases.cUsuario();
            txt_Nombre.Text = usuario.GetNombreUsuarioxCodUsuario(CodUsuario);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txt_Clave.Text =="")
            {
                MessageBox.Show("Debe ingresar una clave ");
                return;
            }

            if (txt_Clave.Text != txtReingresarClave.Text)
            {
                MessageBox.Show("Debe Reingresar una clave ");
                return;
            }

            cUsuario usuario = new cUsuario();
            usuario.ActualizarClave(Principal.CodUsuarioLogueado, txt_Clave.Text);
            MessageBox.Show("Datos guardados correctamente ");
            txt_Clave.Text = "";
            txtReingresarClave.Text = "";
        }
    }
}
