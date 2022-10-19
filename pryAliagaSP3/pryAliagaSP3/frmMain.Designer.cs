namespace pryAliagaSP3
{
    partial class frmAutoTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAñoFabricacion = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroTurno = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.nudAñoFabricacion = new System.Windows.Forms.NumericUpDown();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.lblAñoAntiguo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.txtAñoAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadDominio = new System.Windows.Forms.TextBox();
            this.mrcRegistroTurnos = new System.Windows.Forms.GroupBox();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoFabricacion)).BeginInit();
            this.mrcRegistroTurnos.SuspendLayout();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Location = new System.Drawing.Point(6, 27);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "Numero de Turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(51, 64);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(9, 105);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(87, 13);
            this.lblAñoFabricacion.TabIndex = 2;
            this.lblAñoFabricacion.Text = "Año Fabricación ";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(60, 145);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(493, 146);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(493, 63);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 39);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(102, 143);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(205, 20);
            this.txtTitular.TabIndex = 6;
            // 
            // txtNumeroTurno
            // 
            this.txtNumeroTurno.Location = new System.Drawing.Point(102, 24);
            this.txtNumeroTurno.MaxLength = 5;
            this.txtNumeroTurno.Name = "txtNumeroTurno";
            this.txtNumeroTurno.Size = new System.Drawing.Size(77, 20);
            this.txtNumeroTurno.TabIndex = 7;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(102, 61);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(111, 20);
            this.txtDominio.TabIndex = 8;
            // 
            // nudAñoFabricacion
            // 
            this.nudAñoFabricacion.Location = new System.Drawing.Point(102, 103);
            this.nudAñoFabricacion.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudAñoFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudAñoFabricacion.Name = "nudAñoFabricacion";
            this.nudAñoFabricacion.Size = new System.Drawing.Size(51, 20);
            this.nudAñoFabricacion.TabIndex = 9;
            this.nudAñoFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(493, 337);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 36);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(10, 39);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantidadTurnos.TabIndex = 11;
            this.lblCantidadTurnos.Text = "Cantidad de Turnos";
            // 
            // lblAñoAntiguo
            // 
            this.lblAñoAntiguo.AutoSize = true;
            this.lblAñoAntiguo.Location = new System.Drawing.Point(10, 72);
            this.lblAñoAntiguo.Name = "lblAñoAntiguo";
            this.lblAñoAntiguo.Size = new System.Drawing.Size(104, 13);
            this.lblAñoAntiguo.TabIndex = 12;
            this.lblAñoAntiguo.Text = "Año del mas Antiguo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(10, 103);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(186, 13);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidad con dominio de 6 carácteres";
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(221, 36);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(72, 20);
            this.txtCantidadTurnos.TabIndex = 14;
            // 
            // txtAñoAntiguo
            // 
            this.txtAñoAntiguo.Location = new System.Drawing.Point(221, 69);
            this.txtAñoAntiguo.Name = "txtAñoAntiguo";
            this.txtAñoAntiguo.ReadOnly = true;
            this.txtAñoAntiguo.Size = new System.Drawing.Size(72, 20);
            this.txtAñoAntiguo.TabIndex = 15;
            // 
            // txtCantidadDominio
            // 
            this.txtCantidadDominio.Location = new System.Drawing.Point(221, 100);
            this.txtCantidadDominio.Name = "txtCantidadDominio";
            this.txtCantidadDominio.ReadOnly = true;
            this.txtCantidadDominio.Size = new System.Drawing.Size(72, 20);
            this.txtCantidadDominio.TabIndex = 16;
            // 
            // mrcRegistroTurnos
            // 
            this.mrcRegistroTurnos.Controls.Add(this.lblNumeroTurno);
            this.mrcRegistroTurnos.Controls.Add(this.lblDominio);
            this.mrcRegistroTurnos.Controls.Add(this.lblAñoFabricacion);
            this.mrcRegistroTurnos.Controls.Add(this.nudAñoFabricacion);
            this.mrcRegistroTurnos.Controls.Add(this.lblTitular);
            this.mrcRegistroTurnos.Controls.Add(this.txtDominio);
            this.mrcRegistroTurnos.Controls.Add(this.txtTitular);
            this.mrcRegistroTurnos.Controls.Add(this.txtNumeroTurno);
            this.mrcRegistroTurnos.Location = new System.Drawing.Point(20, 12);
            this.mrcRegistroTurnos.Name = "mrcRegistroTurnos";
            this.mrcRegistroTurnos.Size = new System.Drawing.Size(432, 233);
            this.mrcRegistroTurnos.TabIndex = 17;
            this.mrcRegistroTurnos.TabStop = false;
            this.mrcRegistroTurnos.Text = "Registro de Turnos";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.lblCantidadTurnos);
            this.mrcEstadisticas.Controls.Add(this.lblAñoAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantidadDominio);
            this.mrcEstadisticas.Controls.Add(this.lblCantidad);
            this.mrcEstadisticas.Controls.Add(this.txtAñoAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantidadTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(27, 277);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(425, 161);
            this.mrcEstadisticas.TabIndex = 0;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadísticas";
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcRegistroTurnos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmAutoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Test";
            this.Load += new System.EventHandler(this.frmAutoTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAñoFabricacion)).EndInit();
            this.mrcRegistroTurnos.ResumeLayout(false);
            this.mrcRegistroTurnos.PerformLayout();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroTurno;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblAñoFabricacion;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumeroTurno;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.NumericUpDown nudAñoFabricacion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.Label lblAñoAntiguo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.TextBox txtAñoAntiguo;
        private System.Windows.Forms.TextBox txtCantidadDominio;
        private System.Windows.Forms.GroupBox mrcRegistroTurnos;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
    }
}

