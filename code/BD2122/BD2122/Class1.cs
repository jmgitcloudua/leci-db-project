using System.Data.SqlClient;

namespace BD2122
{
    internal class Class1
    {
        private SqlConnection con;

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= localhost;integrated security=true;initial catalog=Northwind");
        }

        public void listRecipiesByAuthor(string author)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from recipie where recipie.author = @author";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }
    }
}
