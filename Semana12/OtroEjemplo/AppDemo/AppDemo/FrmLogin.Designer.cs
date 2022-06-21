namespace AppDemo
{
    partial class FrmLogin
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
         this.panel1 = new System.Windows.Forms.Panel();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.txtUsuario = new System.Windows.Forms.TextBox();
         this.txtClave = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnIngresar = new System.Windows.Forms.Button();
         this.btnCerrar = new System.Windows.Forms.PictureBox();
         this.lblMensajeError = new System.Windows.Forms.Label();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(250, 330);
         this.panel1.TabIndex = 0;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(22, 34);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(208, 254);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // txtUsuario
         // 
         this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtUsuario.ForeColor = System.Drawing.Color.DimGray;
         this.txtUsuario.Location = new System.Drawing.Point(293, 108);
         this.txtUsuario.Name = "txtUsuario";
         this.txtUsuario.Size = new System.Drawing.Size(423, 24);
         this.txtUsuario.TabIndex = 1;
         this.txtUsuario.Text = "Usuario";
         this.txtUsuario.MouseEnter += new System.EventHandler(this.txtUsuario_MouseEnter);
         this.txtUsuario.MouseLeave += new System.EventHandler(this.txtUsuario_MouseLeave);
         // 
         // txtClave
         // 
         this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtClave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtClave.ForeColor = System.Drawing.Color.DimGray;
         this.txtClave.Location = new System.Drawing.Point(293, 157);
         this.txtClave.Name = "txtClave";
         this.txtClave.Size = new System.Drawing.Size(423, 24);
         this.txtClave.TabIndex = 2;
         this.txtClave.Text = "Clave";
         this.txtClave.MouseEnter += new System.EventHandler(this.txtClave_MouseEnter);
         this.txtClave.MouseLeave += new System.EventHandler(this.txtClave_MouseLeave);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
         this.label1.Location = new System.Drawing.Point(360, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(285, 32);
         this.label1.TabIndex = 0;
         this.label1.Text = "INGRESO AL SISTEMA";
         // 
         // btnIngresar
         // 
         this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
         this.btnIngresar.FlatAppearance.BorderSize = 0;
         this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
         this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
         this.btnIngresar.Location = new System.Drawing.Point(293, 254);
         this.btnIngresar.Name = "btnIngresar";
         this.btnIngresar.Size = new System.Drawing.Size(423, 51);
         this.btnIngresar.TabIndex = 3;
         this.btnIngresar.Text = "Ingresar";
         this.btnIngresar.UseVisualStyleBackColor = false;
         this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
         // 
         // btnCerrar
         // 
         this.btnCerrar.Image = global::AppDemo.Properties.Resources.Cerrar2;
         this.btnCerrar.Location = new System.Drawing.Point(730, 2);
         this.btnCerrar.Name = "btnCerrar";
         this.btnCerrar.Size = new System.Drawing.Size(47, 42);
         this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.btnCerrar.TabIndex = 4;
         this.btnCerrar.TabStop = false;
         this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
         // 
         // lblMensajeError
         // 
         this.lblMensajeError.AutoSize = true;
         this.lblMensajeError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.lblMensajeError.ForeColor = System.Drawing.Color.DarkOrange;
         this.lblMensajeError.Image = global::AppDemo.Properties.Resources.alerta;
         this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.lblMensajeError.Location = new System.Drawing.Point(293, 198);
         this.lblMensajeError.Name = "lblMensajeError";
         this.lblMensajeError.Size = new System.Drawing.Size(156, 21);
         this.lblMensajeError.TabIndex = 5;
         this.lblMensajeError.Text = "       Mensaje de error";
         this.lblMensajeError.Visible = false;
         // 
         // FrmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
         this.ClientSize = new System.Drawing.Size(780, 330);
         this.Controls.Add(this.lblMensajeError);
         this.Controls.Add(this.btnCerrar);
         this.Controls.Add(this.btnIngresar);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtClave);
         this.Controls.Add(this.txtUsuario);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "FrmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "FrmLogin";
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCerrar;
      private System.Windows.Forms.Label lblMensajeError;
   }
}