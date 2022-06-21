using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaService;

namespace AppDemo
{
    public partial class FrmRegistrarDeposito : Form
    {
        private static FrmRegistrarDeposito instancia = null;

        public FrmRegistrarDeposito()
        {
            InitializeComponent();
         txtEmpleado.Text = Cache.UserLoginCache.Usuario;
        }

        public static FrmRegistrarDeposito GetInstance()
        {
            if (((instancia == null) || (instancia.IsDisposed == true)))
            {
                instancia = new FrmRegistrarDeposito();
            }
            instancia.BringToFront();
            return instancia;
        }

      private void btnCerrar_Click(object sender, EventArgs e)
      {
          this.Close();
      }

      private void btnProcesar_Click(object sender, EventArgs e)
      {
         // Datos
         string empleado = Cache.UserLoginCache.Codigo;
         string cuenta = txtCuenta.Text;
         double importe = Double.Parse(txtImporte.Text);
         // Proceso
         EurekaService eurekaService = new EurekaService();
         eurekaService.RegistrarDeposito(cuenta, importe, empleado);
         if (eurekaService.Estado == 1)
         {
            txtCuenta.Text = "";
            txtImporte.Text = "";
         }
         MessageBox.Show(eurekaService.Mensaje);
      }
   }
}
