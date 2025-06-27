using Microsoft.Data.SqlClient;
using System;
using System;
using System.Data;
using System.Data.SqlClient;

namespace H20RendiContoMensile
{
    public class Connessione
    {

        public DataTable connessioneTable(string connectionString, string query)
        {
            DataTable dt = new DataTable();

           
                using (SqlDataAdapter adapter = new SqlDataAdapter(query,connectionString))
                {
                    adapter.Fill(dt);

                }
            

            return dt;
        }

    }
}