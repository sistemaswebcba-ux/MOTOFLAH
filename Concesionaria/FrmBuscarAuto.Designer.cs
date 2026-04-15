namespace Concesionaria
{
    partial class FrmBuscarAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grupo = new System.Windows.Forms.GroupBox();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo
            // 
            this.Grupo.Controls.Add(this.txtCertificado);
            this.Grupo.Controls.Add(this.label8);
            this.Grupo.Controls.Add(this.txtChasis);
            this.Grupo.Controls.Add(this.label7);
            this.Grupo.Controls.Add(this.cmbModelo);
            this.Grupo.Controls.Add(this.txtDescripcion);
            this.Grupo.Controls.Add(this.label3);
            this.Grupo.Controls.Add(this.txtPatente);
            this.Grupo.Controls.Add(this.label2);
            this.Grupo.Controls.Add(this.chkStock);
            this.Grupo.Controls.Add(this.btnAceptar);
            this.Grupo.Controls.Add(this.btnBuscar);
            this.Grupo.Controls.Add(this.cmbMarca);
            this.Grupo.Controls.Add(this.label1);
            this.Grupo.Controls.Add(this.Grilla);
            this.Grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupo.Location = new System.Drawing.Point(3, 12);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(1059, 497);
            this.Grupo.TabIndex = 3;
            this.Grupo.TabStop = false;
            // 
            // txtCertificado
            // 
            this.txtCertificado.Location = new System.Drawing.Point(638, 41);
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(130, 23);
            this.txtCertificado.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Certificado";
            // 
            // txtChasis
            // 
            this.txtChasis.Location = new System.Drawing.Point(383, 42);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(167, 23);
            this.txtChasis.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Chasis";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(100, 41);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(214, 24);
            this.cmbModelo.TabIndex = 82;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(730, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(61, 23);
            this.txtDescripcion.TabIndex = 81;
            this.txtDescripcion.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Modelo";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(383, 12);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(101, 23);
            this.txtPatente.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Patente";
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Checked = true;
            this.chkStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStock.Location = new System.Drawing.Point(638, 12);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(62, 21);
            this.chkStock.TabIndex = 44;
            this.chkStock.Text = "Stcok";
            this.chkStock.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(967, 458);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Concesionaria.Properties.Resources.zoom2;
            this.btnBuscar.Location = new System.Drawing.Point(774, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 27);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(100, 12);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(214, 24);
            this.cmbMarca.TabIndex = 41;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Marca";
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(15, 68);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla.ShowEditingIcon = false;
            this.Grilla.Size = new System.Drawing.Size(1027, 371);
            this.Grilla.TabIndex = 26;
            // 
            // FrmBuscarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 512);
            this.Controls.Add(this.Grupo);
            this.Name = "FrmBuscarAuto";
            this.Text = "FrmBuscarAuto";
            this.Load += new System.EventHandler(this.FrmBuscarAuto_Load);
            this.Grupo.ResumeLayout(false);
            this.Grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grupo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.TextBox txtChasis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.Label label8;
    }
}