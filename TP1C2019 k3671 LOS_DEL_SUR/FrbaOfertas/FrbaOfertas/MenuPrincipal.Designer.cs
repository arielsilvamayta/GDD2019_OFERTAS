namespace FrbaOfertas
{
    partial class MenuPrincipal
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
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnCrearOferta = new System.Windows.Forms.Button();
            this.btnCargaCredito = new System.Windows.Forms.Button();
            this.btnCompraOferta = new System.Windows.Forms.Button();
            this.btnAbmCliente = new System.Windows.Forms.Button();
            this.btnAbmProveedor = new System.Windows.Forms.Button();
            this.btnAbmRol = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelMenuPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoEstadistico.Location = new System.Drawing.Point(612, 170);
            this.btnListadoEstadistico.Margin = new System.Windows.Forms.Padding(4);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(168, 66);
            this.btnListadoEstadistico.TabIndex = 22;
            this.btnListadoEstadistico.Tag = "LISTADO_ESTADISTICO";
            this.btnListadoEstadistico.Text = "Listado Estadístico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Visible = false;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(612, 285);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(168, 66);
            this.btnFacturar.TabIndex = 21;
            this.btnFacturar.Tag = "FACTURAR";
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Visible = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnPagarReserva_Click);
            // 
            // btnCrearOferta
            // 
            this.btnCrearOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearOferta.Location = new System.Drawing.Point(410, 285);
            this.btnCrearOferta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearOferta.Name = "btnCrearOferta";
            this.btnCrearOferta.Size = new System.Drawing.Size(168, 66);
            this.btnCrearOferta.TabIndex = 20;
            this.btnCrearOferta.Tag = "CREAR_OFERTA";
            this.btnCrearOferta.Text = "Crear Oferta";
            this.btnCrearOferta.UseVisualStyleBackColor = true;
            this.btnCrearOferta.Visible = false;
            this.btnCrearOferta.Click += new System.EventHandler(this.btnReservarViaje_Click);
            // 
            // btnCargaCredito
            // 
            this.btnCargaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaCredito.Location = new System.Drawing.Point(207, 285);
            this.btnCargaCredito.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargaCredito.Name = "btnCargaCredito";
            this.btnCargaCredito.Size = new System.Drawing.Size(168, 66);
            this.btnCargaCredito.TabIndex = 19;
            this.btnCargaCredito.Tag = "CARGA_CREDITO";
            this.btnCargaCredito.Text = "Carga Credito";
            this.btnCargaCredito.UseVisualStyleBackColor = true;
            this.btnCargaCredito.Visible = false;
            this.btnCargaCredito.Click += new System.EventHandler(this.btnComprarViaje_Click);
            // 
            // btnCompraOferta
            // 
            this.btnCompraOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraOferta.Location = new System.Drawing.Point(8, 285);
            this.btnCompraOferta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompraOferta.Name = "btnCompraOferta";
            this.btnCompraOferta.Size = new System.Drawing.Size(168, 66);
            this.btnCompraOferta.TabIndex = 18;
            this.btnCompraOferta.Tag = "COMPRA_OFERTA";
            this.btnCompraOferta.Text = "Compra Oferta";
            this.btnCompraOferta.UseVisualStyleBackColor = true;
            this.btnCompraOferta.Visible = false;
            this.btnCompraOferta.Click += new System.EventHandler(this.btnGenerarViaje_Click);
            // 
            // btnAbmCliente
            // 
            this.btnAbmCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbmCliente.Location = new System.Drawing.Point(8, 170);
            this.btnAbmCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbmCliente.Name = "btnAbmCliente";
            this.btnAbmCliente.Size = new System.Drawing.Size(168, 66);
            this.btnAbmCliente.TabIndex = 17;
            this.btnAbmCliente.Tag = "ABM_CLIENTE";
            this.btnAbmCliente.Text = "ABM Cliente";
            this.btnAbmCliente.UseVisualStyleBackColor = true;
            this.btnAbmCliente.Visible = false;
            this.btnAbmCliente.Click += new System.EventHandler(this.btnAbmRoles_Click);
            // 
            // btnAbmProveedor
            // 
            this.btnAbmProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbmProveedor.Location = new System.Drawing.Point(207, 170);
            this.btnAbmProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbmProveedor.Name = "btnAbmProveedor";
            this.btnAbmProveedor.Size = new System.Drawing.Size(168, 66);
            this.btnAbmProveedor.TabIndex = 15;
            this.btnAbmProveedor.Tag = "ABM_PROVEEDOR";
            this.btnAbmProveedor.Text = "ABM Proveedor";
            this.btnAbmProveedor.UseVisualStyleBackColor = true;
            this.btnAbmProveedor.Visible = false;
            this.btnAbmProveedor.Click += new System.EventHandler(this.btnAbmRecorrido_Click);
            // 
            // btnAbmRol
            // 
            this.btnAbmRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbmRol.Location = new System.Drawing.Point(410, 170);
            this.btnAbmRol.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbmRol.Name = "btnAbmRol";
            this.btnAbmRol.Size = new System.Drawing.Size(168, 66);
            this.btnAbmRol.TabIndex = 14;
            this.btnAbmRol.Tag = "ABM_ROL";
            this.btnAbmRol.Text = "ABM Rol";
            this.btnAbmRol.UseVisualStyleBackColor = true;
            this.btnAbmRol.Visible = false;
            this.btnAbmRol.Click += new System.EventHandler(this.btnAbmCruceros_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(876, 415);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 34);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // labelMenuPrincipal
            // 
            this.labelMenuPrincipal.AutoSize = true;
            this.labelMenuPrincipal.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuPrincipal.Location = new System.Drawing.Point(391, 26);
            this.labelMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuPrincipal.Name = "labelMenuPrincipal";
            this.labelMenuPrincipal.Size = new System.Drawing.Size(224, 98);
            this.labelMenuPrincipal.TabIndex = 12;
            this.labelMenuPrincipal.Text = "Menú";
            this.labelMenuPrincipal.Click += new System.EventHandler(this.labelMenuPrincipal_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 557);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCrearOferta);
            this.Controls.Add(this.btnCargaCredito);
            this.Controls.Add(this.btnCompraOferta);
            this.Controls.Add(this.btnAbmCliente);
            this.Controls.Add(this.btnAbmProveedor);
            this.Controls.Add(this.btnAbmRol);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labelMenuPrincipal);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnCrearOferta;
        private System.Windows.Forms.Button btnCargaCredito;
        private System.Windows.Forms.Button btnCompraOferta;
        private System.Windows.Forms.Button btnAbmCliente;
        private System.Windows.Forms.Button btnAbmProveedor;
        private System.Windows.Forms.Button btnAbmRol;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label labelMenuPrincipal;
    }
}