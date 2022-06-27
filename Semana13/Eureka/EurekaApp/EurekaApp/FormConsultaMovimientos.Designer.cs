namespace EurekaApp
{
   partial class FormConsultaMovimientos
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.btnCerrar = new System.Windows.Forms.Button();
         this.btnConsultar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txtCuenta = new System.Windows.Forms.TextBox();
         this.lblMensaje = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(42, 146);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.RowTemplate.Height = 28;
         this.dataGridView1.Size = new System.Drawing.Size(873, 391);
         this.dataGridView1.TabIndex = 5;
         // 
         // btnCerrar
         // 
         this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnCerrar.Location = new System.Drawing.Point(544, 16);
         this.btnCerrar.Name = "btnCerrar";
         this.btnCerrar.Size = new System.Drawing.Size(213, 82);
         this.btnCerrar.TabIndex = 4;
         this.btnCerrar.Text = "Cerrar";
         this.btnCerrar.UseVisualStyleBackColor = true;
         this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
         // 
         // btnConsultar
         // 
         this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.btnConsultar.Location = new System.Drawing.Point(311, 16);
         this.btnConsultar.Name = "btnConsultar";
         this.btnConsultar.Size = new System.Drawing.Size(213, 82);
         this.btnConsultar.TabIndex = 3;
         this.btnConsultar.Text = "Consultar";
         this.btnConsultar.UseVisualStyleBackColor = false;
         this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
         this.label1.Location = new System.Drawing.Point(42, 31);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(76, 25);
         this.label1.TabIndex = 6;
         this.label1.Text = "Cuenta:";
         // 
         // txtCuenta
         // 
         this.txtCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.txtCuenta.Location = new System.Drawing.Point(42, 59);
         this.txtCuenta.Name = "txtCuenta";
         this.txtCuenta.Size = new System.Drawing.Size(228, 39);
         this.txtCuenta.TabIndex = 7;
         // 
         // lblMensaje
         // 
         this.lblMensaje.AutoSize = true;
         this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
         this.lblMensaje.Location = new System.Drawing.Point(42, 113);
         this.lblMensaje.Name = "lblMensaje";
         this.lblMensaje.Size = new System.Drawing.Size(0, 30);
         this.lblMensaje.TabIndex = 8;
         // 
         // FormConsultaMovimientos
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1083, 620);
         this.Controls.Add(this.lblMensaje);
         this.Controls.Add(this.txtCuenta);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.btnCerrar);
         this.Controls.Add(this.btnConsultar);
         this.Name = "FormConsultaMovimientos";
         this.Text = "FormConsultaMovimientos";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Button btnCerrar;
      private System.Windows.Forms.Button btnConsultar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtCuenta;
      private System.Windows.Forms.Label lblMensaje;
   }
}