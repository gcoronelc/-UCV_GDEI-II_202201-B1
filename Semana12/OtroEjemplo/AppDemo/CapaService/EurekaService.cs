using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaService
{
    public class EurekaService:GeneralService
    {

        public void RegistrarDeposito(string Cuenta, double Importe, string CodEmp)
        {
            // Mensajes por defecto
            this.Estado = 1;
            this.Mensaje = "Proceso ejecutado correctamente";
            // Proceso General
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                try {               
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.usp_deposito";
                    // Agregar los parámetros
                    cmd.Parameters.Add("@cuenta",  SqlDbType.VarChar).Value = Cuenta;
                    cmd.Parameters.Add("@importe", SqlDbType.Decimal).Value = Importe;
                    cmd.Parameters.Add("@codemp", SqlDbType.VarChar).Value = CodEmp;
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar,2000).Direction = ParameterDirection.Output;
                    // Ejecutar procedimiento
                    cmd.ExecuteNonQuery();
                    this.Estado = Convert.ToInt32(cmd.Parameters["@codigo"].Value);
                    this.Mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    // Estado del proceso
                    this.Estado = -1;
                    this.Mensaje = e.Message;
                }
            }
        }


    }
}
