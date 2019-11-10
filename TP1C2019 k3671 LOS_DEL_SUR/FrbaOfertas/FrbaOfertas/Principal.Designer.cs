namespace FrbaOfertas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.TituloPrincipal = new System.Windows.Forms.Label();
            this.imagenPrincipal = new System.Windows.Forms.PictureBox();
            this.labelComboBoxRoles = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(291, 426);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(220, 39);
            this.cmbRoles.TabIndex = 10;
            this.cmbRoles.Text = "Seleccionar . . .";
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // TituloPrincipal
            // 
            this.TituloPrincipal.AutoSize = true;
            this.TituloPrincipal.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloPrincipal.Location = new System.Drawing.Point(196, 77);
            this.TituloPrincipal.Name = "TituloPrincipal";
            this.TituloPrincipal.Size = new System.Drawing.Size(484, 69);
            this.TituloPrincipal.TabIndex = 9;
            this.TituloPrincipal.Text = "FRBA - Ofertas";
            this.TituloPrincipal.Click += new System.EventHandler(this.TituloPrincipal_Click);
            // 
            // imagenPrincipal
            // 
            this.imagenPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("imagenPrincipal.Image")));
            this.imagenPrincipal.Location = new System.Drawing.Point(245, 146);
            this.imagenPrincipal.Name = "imagenPrincipal";
            this.imagenPrincipal.Size = new System.Drawing.Size(310, 194);
            this.imagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPrincipal.TabIndex = 8;
            this.imagenPrincipal.TabStop = false;
            this.imagenPrincipal.Click += new System.EventHandler(this.imagenPrincipal_Click);
            // 
            // labelComboBoxRoles
            // 
            this.labelComboBoxRoles.AutoSize = true;
            this.labelComboBoxRoles.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComboBoxRoles.Location = new System.Drawing.Point(229, 378);
            this.labelComboBoxRoles.Name = "labelComboBoxRoles";
            this.labelComboBoxRoles.Size = new System.Drawing.Size(458, 32);
            this.labelComboBoxRoles.TabIndex = 7;
            this.labelComboBoxRoles.Text = "Por favor elija el tipo de usuario";
            this.labelComboBoxRoles.Click += new System.EventHandler(this.labelComboBoxRoles_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(323, 487);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(154, 49);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 612);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.TituloPrincipal);
            this.Controls.Add(this.imagenPrincipal);
            this.Controls.Add(this.labelComboBoxRoles);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label TituloPrincipal;
        private System.Windows.Forms.PictureBox imagenPrincipal;
        private System.Windows.Forms.Label labelComboBoxRoles;
        private System.Windows.Forms.Button btnIngresar;
    }
}