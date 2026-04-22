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
    public partial class FrmBuscarAuto : FrmBase
    {
        cFunciones fun;
        public FrmBuscarAuto()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            string Patente = "";
            Int32? CodMarca = null;
            string Descripcion = "";
            string Chasis = "";
            string Certificado = "";
            if (cmbMarca.SelectedIndex > 0)
            {
                CodMarca = Convert.ToInt32(cmbMarca.SelectedValue);
            }

            if (txtPatente.Text != "")
            {
                Patente = txtPatente.Text;
            }

            if (cmbModelo.SelectedIndex >0)
            {
                Descripcion = cmbModelo.Text;
            }

            if (txtChasis.Text !="")
            {
                Chasis = txtChasis.Text;
            }

            if (txtCertificado.Text !="")
            {
                Certificado = txtCertificado.Text;
            }

            /*
            if (txtDescripcion.Text != "")
            {
                Descripcion = txtDescripcion.Text;
            }
            */
            DataTable trdo;
            cAuto auto = new cAuto();
            cStockAuto stock = new cStockAuto();
            if (chkStock.Checked == true)
                trdo = stock.GetStockResumidoVigente(Patente, CodMarca, Descripcion, Chasis, Certificado);
            else
                trdo = auto.GetAutoResumido(Patente, CodMarca, Descripcion);
            Grilla.DataSource = trdo;
            string ancho = "0;8;10;15;6;0;10;17;17;17";
            fun.AnchoColumnas(Grilla, ancho );
           
            Grilla.Columns[2].HeaderText = "Marca";
            Grilla.Columns[3].HeaderText = "Modelo";
            Grilla.Columns[4].HeaderText = "Año";
            
        }

        private void FrmBuscarAuto_Load(object sender, EventArgs e)
        {
            fun = new Clases.cFunciones();
            fun.LlenarCombo(cmbMarca, "Marca", "Nombre", "CodMarca");
            Buscar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Grilla.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un regisstro", "Sistema");
                return;
            }
            Principal.CodigoPrincipalAbm = Grilla.CurrentRow.Cells[0].Value.ToString();
            Principal.CodStock = Convert.ToInt32(Grilla.CurrentRow.Cells[5].Value.ToString());
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex > 0)
            {
                int CodMarca = Convert.ToInt32(cmbMarca.SelectedValue);
                cModelo modelo = new cModelo();
                DataTable trdo = modelo.GetModelosxMarca(CodMarca);
                cFunciones fun = new cFunciones();
                fun.LlenarComboDatatable(cmbModelo, trdo, "nombre", "CodModelo");
            }
        }
    }
}
