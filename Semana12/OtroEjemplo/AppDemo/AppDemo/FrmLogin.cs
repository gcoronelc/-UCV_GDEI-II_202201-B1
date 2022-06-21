using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaService;
using CapaModel;

namespace AppDemo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_MouseEnter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Clave")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.LightGray;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_MouseLeave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Clave";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      private void btnIngresar_Click(object sender, EventArgs e)
      {
         string usuario = txtUsuario.Text;
         string clave = txtClave.Text;
         if (usuario != "Usuario" && clave!="Clave")
         {
            LogonService logonService = new LogonService();
            EmpleadoModel empleado = logonService.validarUsuario(usuario, clave);
            if (logonService.Estado == 1)
            {
               FormularioPrincipal principal = new FormularioPrincipal();
               principal.Show();
               this.Hide();
               Cache.UserLoginCache.Codigo=empleado.Codigo;
               Cache.UserLoginCache.Paterno = empleado.Paterno;
               Cache.UserLoginCache.Materno = empleado.Materno;
               Cache.UserLoginCache.Nombre = empleado.Nombre;
               Cache.UserLoginCache.Usuario = empleado.Usuario;
            } else
            {
               mostrarError(logonService.Mensaje);
            }
         } else
         {
            mostrarError("Debe ingresar el usuario y la clave.");
         }
      }

      private void mostrarError(string mensaje)
      {
         lblMensajeError.Text = "    " + mensaje;
         lblMensajeError.Visible = true;
      }
   }
}
