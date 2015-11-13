using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

//"Data Source=APACHEW-PC\\SQLEXPRESS;Initial Catalog=CocoaExport;Integrated Security=True"
namespace DAL
{
    public class Conexion
    {
        SqlConnection con;
        SqlCommand cmd;

        public Conexion()
        {
            con = new SqlConnection("Data Source=GEORGE-PC\\SQLEXPRESS;Initial Catalog=CocoaExport;Integrated Security=True");
            cmd = new SqlCommand();
        }

        public bool Ejecutar(String comando)
        {
            bool retorno = false;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = comando;
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }

        public DataTable getDatos(String SqlComando)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = SqlComando;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public object ObtenerDatos(String SqlCommando)
        {
            object retorno = null;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = SqlCommando;
                retorno = cmd.ExecuteScalar();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }
    }
}
