using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabele;

namespace Polaczenie
{
    public class Polacz
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connStringBuilder;

        void Polaczenie()
        {
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource = "GORSKI";
            connStringBuilder.InitialCatalog = "Warsztat";
            connStringBuilder.IntegratedSecurity = true;

            conn = new SqlConnection(connStringBuilder.ToString());
        }

        public Polacz()
        {
            Polaczenie();
        }

        public void Loguj (Uzytkownicy u )
        {
            try
            {
               
                //string cmdText = "SELECT* FROM dbo.Uzytkownicy (Login,Haslo,Typ) VALUES (@Login) ";
                //SqlCommand cmd = new SqlCommand(cmdText,conn);
                //cmd.Parameters.AddWithValue("@Login",u.Login);
                //cmd.Parameters.AddWithValue("@Haslo", u.Haslo);
                //cmd.Parameters.AddWithValue("@Typ", u.Typ);
                string cmdText = "SELECT * FROM dbo.Uzytkownicy WHERE Login = '" + u.Login + "' AND Haslo = '" + u.Haslo + "';";
               
                
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@Login",u.Login );
                cmd.Parameters.AddWithValue("@Haslo",u.Haslo);
                cmd.Parameters.AddWithValue("@Typ", u.Typ);
               
                cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {
                
                throw;
            }

            finally
            {
                if (conn !=null)
                {
                    conn.Close();
                }
            }
        }
    }
}
