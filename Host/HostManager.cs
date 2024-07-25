using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    internal class HostManager
    {
        public static List<string> GetCategories()
        {
            string sql = "select * from Categories";
            SqlDataReader reader = DBConnection.runSQL(sql);

            List<string> categories = new List<string>();

            while (reader.Read())
            {
                categories.Add(reader.GetString(1));
            }
            DBConnection.CloseConnection();
            return categories;
        }

        public static List<string> GetFilteredCategories(string searchCategory)
        {
            string sql = "SELECT * FROM Categories WHERE Category_name LIKE @search_category +'%'";
            string[] paramters = { "@search_category" };
            string[] values = { searchCategory };
            SqlDataReader reader = DBConnection.runSQL(sql, paramters, values);

            List<string> categories = new List<string>();

            while (reader.Read())
            {
                categories.Add(reader.GetString(1));
            }
            DBConnection.CloseConnection();
            return categories;
        }

        public static void InsertCategory(string category_name) 
        {
            string sql = "INSERT INTO Categories (category_name) values(@category_name)";
            string[] paramters = { "@category_name" };
            string[] values = { category_name };
            DBConnection.RunSqlBySearch(sql, paramters, values);
            //DBConnection.CloseConnection();
        }

        public static void DeleteCategory(string category_name)
        {
            string sql = "DELETE FROM Categories WHERE Category_name = @category_name;";
            string[] paramters = { "@category_name" };
            string[] values = { category_name };
            DBConnection.RunSQLDeleteQuery(sql, paramters, values);
            //DBConnection.CloseConnection();
        }



        public static DataTable GetDishesSummary(string category_name)
        {
            string sql = "select Foods.Food_name as dish, count(Foods.Food_name) as amount from Foods join Categories on Categories.ID= Foods.Category_id where Categories.category_name= @category_name group by Foods.Food_name";
            string[] paramters = { "@category_name" };
            string[] values = { category_name };
            return DBConnection.RunSqlTableResults(sql, paramters, values);
        }
    }
}
            
