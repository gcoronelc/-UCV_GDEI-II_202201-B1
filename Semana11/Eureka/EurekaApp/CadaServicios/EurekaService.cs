using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CadaServicios
{
    public class EurekaService: GeneralService
    {


        public void RegistrarDeposito(string cuenta, double Importe, string CodEmp)
        {
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                try
                {
                    // El procedimiento
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_deposito";
                    // Agregar los parámetros


                }
                catch ()
                {


                }
            }




        }

    }
}
