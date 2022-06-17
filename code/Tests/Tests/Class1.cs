using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class Class1
    {
        private SqlConnection con;

        public Class1()
        {
            con = getSGBDConnection();
            con.Open();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= localhost;integrated security=true;initial catalog=dbname");
        }

        public int test(string recipieName, int stepNum, string description, string image)
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

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            int res = -1;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                res = reader.GetInt32(0);
            }

            reader.Close();
            return res;
        }

        public List<string> listSteps(string recipie)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText =
                @"  select step.description
                    from has join step
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
    }
}
