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
    public partial class FrmAbmUsuario : FrmBase
    {
        public FrmAbmUsuario()
        {
            InitializeComponent();
        }

        private void Botonera(int Jugada)
        {
            switch (Jugada)
            {
                //estado inicial
                case 1:
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;

                    break;
                case 2:
                    btnNuevo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;

                    break;
                case 3:
                    //viene del buscador
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
            }
        }

        private void FrmAbmUsuario_Load(object sender, EventArgs e)
        {
            Botonera(1);
            Grupo.Enabled = false;
            CargarRol();
        }

        private void CargarRol()
        {
            cUsuario usuario = new Clases.cUsuario();
            DataTable tb = usuario.GetRol();
            cFunciones fun = new Clases.cFunciones();
            fun.LlenarComboDatatable(cmb_CodRol, tb, "Nombre", "CodRol");
        }

        public Boolean Validar()
        {
            if (txt_Nombre.Text =="")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario ");
                return false;
            }

            if (txt_Clave.Text =="")
            {
                MessageBox.Show("Debe ingresar una Clave de usuario ");
                return false;
            }

            if (txt_Clave.Text !=txtReingresarClave.Text)
            {
                MessageBox.Show("El reigreso de la clave debe ser igual a la clave ");
                return false;
            }

          

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Clases.cFunciones fun = new Clases.cFunciones();
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
            Grupo.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Grupo.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar ()==false)
            {
                return;
            }

            if (txt_Nombre.Text.ToUpper ()=="ADMIN")
            {
                cmb_CodRol.SelectedValue = 1;
            }

            cUsuario usuario = new Clases.cUsuario();
            Clases.cFunciones fun = new Clases.cFunciones();
            if (txtCodigo.Text == "")
            {
                if (usuario.Buscar(txt_Nombre.Text) == true)
                {
                    MessageBox.Show("El usuario ya existe ");
                    return;
                }
                fun.GuardarNuevoGenerico(this, "Usuario");
            }
               
            else
            {
                fun.ModificarGenerico(this, "Usuario", "CodUsuario", txtCodigo.Text);
            }
                
            MessageBox.Show("Datos grabados Correctamente", Clases.cMensaje.Mensaje());
            Botonera(1);
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
            Botonera(1);
            Grupo.Enabled = false;
            txtReingresarClave.Text = "";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //nombre de los camposa buscar, se llaman igual que en la base de datos
            Principal.OpcionesdeBusqueda = "Nombre";
            //nombre de la tabla, 
            Principal.TablaPrincipal = "Usuario";
            Principal.OpcionesColumnasGrilla = "CodUsuario; Nombre";
            Principal.ColumnasVisibles = "0;1";
            Principal.ColumnasAncho = "100;580";
            FrmBuscadorGenerico form = new FrmBuscadorGenerico();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clases.cFunciones fun = new Clases.cFunciones();
            //CargarJugador(Convert.ToInt32(PRINCIPAL.CDOGIO_JUGADOR));
            if (Principal.CodigoPrincipalAbm != null)
            {
                if (Principal.CodigoPrincipalAbm != "")
                {
                    Botonera(3);
                    txtCodigo.Text = Principal.CodigoPrincipalAbm.ToString();

                    if (Principal.CodigoPrincipalAbm != "")
                        fun.CargarControles(this, "Usuario", "CodUsuario", txtCodigo.Text);
                    Grupo.Enabled = false;
                    txtReingresarClave.Text = txt_Clave.Text;
                    return;
                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Botonera(1);
            Clases.cFunciones fun = new Clases.cFunciones();
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
        }
    }
}
