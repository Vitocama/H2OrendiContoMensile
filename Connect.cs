using System;

public class Class1
{
	public Connessione(string query)
	{
        connectionString = "Data Source=ACER\SQLEXPRESS;Initial Catalog=MMI;Integrated Security=True;Encrypt=False;";

         DataTable dtClienti = new DataTable();


        using (SqlConnection conn = new SqlConnection(connectionString))
        {
         
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand(query, conn);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
        }

    }
}
