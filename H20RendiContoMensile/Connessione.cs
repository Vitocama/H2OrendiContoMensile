using System.Data.SqlClient;
using System.Data;


namespace H20RendiContoMensile
{
    public class Connessione
    {
       public string connectionString = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=MMI;Integrated Security=True;Encrypt=False;";
        public DataTable TableGi_comuni_cap()
        {
            System.Data.DataTable DtGi_comuni_cap = new DataTable();

            string query = "SELECT * FROM gi_comuni_cap";



            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(DtGi_comuni_cap);
            }



            return DtGi_comuni_cap;
        }

        public DataTable Anagrafe_Prova()
        {
            System.Data.DataTable Anagrafe_prova = new DataTable();

            string query = "SELECT * FROM anagrafe";



            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(Anagrafe_prova);
            }



            return Anagrafe_prova;
        }


        public DataTable TableGi_comuni_nazioni_cf()
        {
            DataTable DtGi_comuni_nazioni_cf = new DataTable();

            string query = "SELECT * FROM gi_comuni_nazioni_cf";




            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(DtGi_comuni_nazioni_cf);
            }


            return DtGi_comuni_nazioni_cf;

        }

        public DataTable TableGi_comuni_validita()
        {
            DataTable DtGi_comuni_validita = new DataTable();

            string query = "SELECT * FROM gi_comuni_validita";




            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(DtGi_comuni_validita);
            }


            return DtGi_comuni_validita;

        }

        public DataTable TableGi_nazioni()
        {
            DataTable DtGi_nazioni = new DataTable();

            string query = "SELECT * FROM gi_nazioni";




            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(DtGi_nazioni);
            }


            return DtGi_nazioni;

        }

        public DataTable TableGi_province()
        {
            DataTable DtGi_province = new DataTable();

            string query = "SELECT * FROM gi_province";




            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(DtGi_province);
            }

            return DtGi_province;

        }

        public DataTable TableGi_regioni()
        {
            DataTable DtGi_regioni = new DataTable();

            string query = "SELECT * FROM gi_regioni";




            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
            {
                adapter.Fill(DtGi_regioni);
            }

            return DtGi_regioni;

        }


        public DataTable Tablerendi_contoAnnuale_2025_Anagrafe()
        {

            {
                DataTable rendi_contoAnnuale_2025_Anagrafe = new DataTable();

                string query = "SELECT * FROM rendi_contoAnnuale_2025_Anagrafe";




                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
                {
                    adapter.Fill(rendi_contoAnnuale_2025_Anagrafe);
                }

                return rendi_contoAnnuale_2025_Anagrafe;

            }
        }


        public DataTable TableRendicontoAnnuale_2025()
        {

            {
                DataTable rendi_contoAnnuale_2025 = new DataTable();

                string query = "SELECT * FROM rendicontoAnnuale_2025";




                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
                {
                    adapter.Fill(rendi_contoAnnuale_2025);
                }

                return rendi_contoAnnuale_2025;

            }
        }




        public DataTable Tablegi_cap()
        {

            {
                DataTable DtGi_cap = new DataTable();

                string query = "SELECT * FROM gi_cap";




                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
                {
                    adapter.Fill(DtGi_cap);
                }

                return DtGi_cap;

            }
        }

        public DataTable TableGi_comuni()
        {

            {
                DataTable DtGi_comuni = new DataTable();

                string query = "SELECT * FROM gi_comuni";




                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString))
                {
                    adapter.Fill(DtGi_comuni);
                }

                return DtGi_comuni;

            }





        }










    }
}

