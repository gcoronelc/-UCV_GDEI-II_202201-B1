using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaService;

namespace AppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EurekaService service = new EurekaService();
            service.RegistrarDeposito("00100001", 5000.00, "0003");
            Console.WriteLine("Estado =" + service.Estado);
            Console.WriteLine("EGCC Mensaje =" + service.Mensaje);
            MessageBox.Show(service.Mensaje);
        }
    }
}
