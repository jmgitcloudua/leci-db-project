using System.Data.SqlClient;

namespace BD2122
{
    internal class DBManager
    {
        private SqlConnection con;

        public DBManager()
        {
            con = getSGBDConnection();
            con.Open();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;integrated security=false;initial catalog=p7g1; password=20222329@BD; uid=p7g1");
            
        }
        
		public Recipie? getRecipie(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from project.recipie where recipieName = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Recipie r = new Recipie(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                reader.Close();
                return r;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public List<Recipie> listRecipiesByAuthor(string author)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from recipie where recipie.author = @author";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Connection = con;

            List<Recipie> list = new List<Recipie>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Recipie(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3)));
            }

            reader.Close();
            return list;
        }
        
        public List<string> listIngredients(string recipie)
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

            List<string> ingredients = new List<string>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ingredients.Add(reader.GetString(0));
            }

            reader.Close();
            return ingredients;
        }

        public List<Ingredient> listIngredientAmounts(string recipie, string mass, string capacity, string temperature)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                "select * from dbo.GetIngredientAmounts(@Recipie, @Mass, @Capacity, @Temperature);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Recipie", recipie);
            cmd.Parameters.AddWithValue("@Mass", mass);
            cmd.Parameters.AddWithValue("@Capacity", capacity);
            cmd.Parameters.AddWithValue("@Temperature", temperature);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();

            List<Ingredient> res = new List<Ingredient>();
            while (reader.Read())
            {
                res.Add(new Ingredient(reader.GetString(0), reader.GetDouble(1), reader.GetString(2)));
            }

            return res;
        }

        /*
        public void listIngredientAmounts(string recipie, string ingredient)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select usesIngredient.quantity, usesIngredient.unit
                    from
                    usesIngredient 
                    join (
                        has join step
                        on has.stepID = step.stepID
                    ) on usesIngredient.stepID = step.stepID
                    where has.recipieName = @recipie
                        and usesIngredient.ingredientName = @ingredient; ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipie", recipie);
            cmd.Parameters.AddWithValue("@ingredient", ingredient);
            cmd.Connection = con;

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
                return;

            float quantity = reader.GetFloat(0);
            string unit = reader.GetString(1);

            while (reader.Read())
            {
                quantity += 1; // convertUnit(reader.GetString(1), unit, reader.GetFloat(0));
            }

            reader.Close();
            Console.WriteLine(quantity + unit);
        }
        */

        public List<string> listUtensils(string recipie)
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

            List<string> list = new List<string>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            reader.Close();
            return list;
        }

        public List<string> listSteps(string recipie)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select step.description
                    from project.has join project.step
                        on has.stepID = step.stepID
                    where has.recipieName = @recipie
                    order by has.stepNum;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipie", recipie);
            cmd.Connection = con;

            List<string> list = new List<string>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            reader.Close();
            return list;
        }

        public List<string> findByCategory(string category)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select belongs.recipieName
                    from belongs 
                    where belongs.categoryName = @category;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Connection = con;

            List<string> list = new List<string>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }

            return list;
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

        public void insertRecipie(string recipieName, string author, int calories, int preparingTime)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.recipie
                    (recipieName, author, calories, preparingTime)
                    values
                    (@recipieName, @author, @calories, @preparingTime);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipieName", recipieName);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@calories", calories);
            cmd.Parameters.AddWithValue("@preparingTime", preparingTime);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void insertUtensil(string utensilName, int dimention, string unit)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.utensil
                    (utensilName, dimention, unit)
                    values
                    (@utensilName, @dimention, @unit);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@utensilName", utensilName);
            cmd.Parameters.AddWithValue("@dimention", dimention);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void insertIngredient(string ingredientName, string description)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.ingredient
                    (ingredientName, description)
                    values
                    (@ingredientName, @description);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ingredientName", ingredientName);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void insertCategory(string categoryName, string description)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.category
                    (categoryName, description)
                    values
                    (@categoryName, @description);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void insertStep(int stepID, string description, string image)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.step
                    (stepID, description, image)
                    values
                    (@stepID, @description, @image);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@stepID", stepID);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void addStepToRecipie(string recipieName, int stepID, int id, int stepNum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.has
                    (recipieName, stepID, id, stepNum)
                    values
                    (@recipieName, @stepID, @id, @stepNum);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipieName", recipieName);
            cmd.Parameters.AddWithValue("@stepID", stepID);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@stepNum", stepNum);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void addUtensilToStep(string utensilName, int stepID, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.usesUtensil
                    (utensilName, stepID, id)
                    values
                    (@utensilName, @stepID, @id);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@utensilName", utensilName);
            cmd.Parameters.AddWithValue("@stepID", stepID);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void addStepTran(string recipieName, int stepNum, string description, string image)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                "exec AddStep @recipieName, @stepNum, @description, @image";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipieName", recipieName);
            cmd.Parameters.AddWithValue("@stepNum", stepNum);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@image", image);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void addIngredientTran(string ingredientName, string description, int stepID, int quantity, string unit)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                "exec AddStep @ingredientName, @description, @stepID, @quantity, @unit";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ingredientName", ingredientName);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@stepID", stepID);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void addIngredientToStep(string ingredientName, int stepID, int id, int quantity, string unit)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.usesIngredient
                    (ingredientName, stepID, id, quantity, unit)
                    values
                    (@ingredientName, @stepID, @id, @quantity, @unit);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ingredientName", ingredientName);
            cmd.Parameters.AddWithValue("@stepID", stepID);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        public void addCategoryToStep(string recipieName, int categoryName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  insert into project.belongs
                    (recipieName, categoryName)
                    values
                    (@recipieName, categoryName);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@recipieName", recipieName);
            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }

        /*
        public float convertUnit(string from, string to, float value)
        {
            switch (from) {
                case "g":
                    switch (to)
                    {
                        case "kg": // g -> kg
                            return 1000 * value;
                        case "oz": // g -> oz
                            return value / f;
                        default:
                            return -1;
                    }
                case "kg":
                    switch (to)
                    {
                        case "g": // kg -> g
                            return value/ 1000;
                        case "oz": // kg -> oz
                            return value / (1000 * 28.34952f);
                        default:
                            return -1;
                    }
                case "oz":
                    switch (to)
                    {
                        case "g": // oz -> g
                            return 28.34952f * value;
                        case "kg": // oz -> kg
                            return 1000 * 28.34952f * value;
                        default:
                            return -1;
                    }
                case "C":
                    switch (to)
                    {
                        case "F": // C -> F
                            return 32 + (value * (9 / 5));
                        case "K": // C -> K
                            return value - 273.15f;
                        default:
                            return -500; // 0K = -457.87F
                    }
                case "F":
                    switch (to)
                    {
                        case "C": // F -> C
                            return (value - 32) * (5 / 9);
                        case "K": // F -> K
                            return (value - 32) * (5 / 9) - 273.15f;
                        default:
                            return -500; // 0K = -273.15C
                    }
                case "K":
                    switch (to)
                    {
                        case "C": // K -> C
                            return value + 273.15f;
                        case "F": // K -> F
                            return 32 + ((value + 273.15f) * (9 / 5));
                        default:
                            return -500;
                    }
                case "cal":
                    switch (to)
                    {
                        case "J": // cal -> J
                            return value / 4.1868f;
                        default:
                            return -1;
                    }
                case "J":
                    switch (to)
                    {
                        case "cal": // J -> cal
                            return value * 4.1868f;
                        default:
                            return -1;
                    }
                default:
                    return -1;
            }
        }
        */
    }
}
