namespace AppDemo
{
    partial class FrmRegistrarDeposito
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
         this.label1 = new System.Windows.Forms.Label();
         this.txtEmpleado = new System.Windows.Forms.TextBox();
         this.txtCuenta = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtImporte = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.btnCerrar = new System.Windows.Forms.Button();
         this.btnProcesar = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.Location = new System.Drawing.Point(63, 54);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(143, 37);
         this.label1.TabIndex = 0;
         this.label1.Text = "Empleado:";
         // 
         // txtEmpleado
         // 
         this.txtEmpleado.Enabled = false;
         this.txtEmpleado.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtEmpleado.Location = new System.Drawing.Point(222, 51);
         this.txtEmpleado.Name = "txtEmpleado";
         this.txtEmpleado.Size = new System.Drawing.Size(349, 43);
         this.txtEmpleado.TabIndex = 1;
         // 
         // txtCuenta
         // 
         this.txtCuenta.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtCuenta.Location = new System.Drawing.Point(222, 126);
         this.txtCuenta.Name = "txtCuenta";
         this.txtCuenta.Size = new System.Drawing.Size(349, 43);
         this.txtCuenta.TabIndex = 3;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(63, 129);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(107, 37);
         this.label2.TabIndex = 2;
         this.label2.Text = "Cuenta:";
         // 
         // txtImporte
         // 
         this.txtImporte.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtImporte.Location = new System.Drawing.Point(222, 199);
         this.txtImporte.Name = "txtImporte";
         this.txtImporte.Size = new System.Drawing.Size(349, 43);
         this.txtImporte.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label3.Location = new System.Drawing.Point(63, 202);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(117, 37);
         this.label3.TabIndex = 4;
         this.label3.Text = "Importe:";
         // 
         // btnCerrar
         // 
         this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btnCerrar.Location = new System.Drawing.Point(366, 320);
         this.btnCerrar.Name = "btnCerrar";
         this.btnCerrar.Size = new System.Drawing.Size(205, 74);
         this.btnCerrar.TabIndex = 6;
         this.btnCerrar.Text = "Cerrar";
         this.btnCerrar.UseVisualStyleBackColor = true;
         this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
         // 
         // btnProcesar
         // 
         this.btnProcesar.BackColor = System.Drawing.SystemColors.Highlight;
         this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.btnProcesar.ForeColor = System.Drawing.Color.White;
         this.btnProcesar.Location = new System.Drawing.Point(155, 320);
         this.btnProcesar.Name = "btnProcesar";
         this.btnProcesar.Size = new System.Drawing.Size(205, 74);
         this.btnProcesar.TabIndex = 7;
         this.btnProcesar.Text = "Procesar";
         this.btnProcesar.UseVisualStyleBackColor = false;
         this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
         // 
         // FrmRegistrarDeposito
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.btnProcesar);
         this.Controls.Add(this.btnCerrar);
         this.Controls.Add(this.txtImporte);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtCuenta);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtEmpleado);
         this.Controls.Add(this.label1);
         this.Name = "FrmRegistrarDeposito";
         this.Text = "Registrar Depósito";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtEmpleado;
      private System.Windows.Forms.TextBox txtCuenta;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtImporte;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnCerrar;
      private System.Windows.Forms.Button btnProcesar;
   }
}