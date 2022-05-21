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

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3));
            }
        }

        public void listIngredients(string recipie)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = 
                @"  select distinct ingredient.ingredientName
                    from
                    (
                        ingredient join usesIngredient
                        on ingredient.ingredientName = usesIngredient.ingredientName
                    ) join (
                        has join step
                        on has.stepID = step.stepID
                    ) on usesIngredient.stepID = step.stepID
                    where has.recipieName = @recipie; ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipie", recipie);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }

        public void listUtensils(string recipie)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select distinct usesUtensil.utensilName
                    from
	                usesUtensil
	                join (
		                has join step
		                on has.stepID = step.stepID
	                ) on usesUtensil.stepID = step.stepID
                    where has.recipieName = @recipie;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipie", recipie);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }

        public void findByCategory(string category)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select belongs.recipieName
                    from belongs 
                    where belongs.categoryName = @category;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }

        public void findByAuthor(string author)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select *
                    from recipie
                    where recipie.author = @author;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }
    }
}
