using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Guest
{
    internal class GuestManager
    {
        public static List<string> guests()
        {
            string sql = "select * from Guests";
            SqlDataReader reader = DBConnection.runSQL(sql);

            List<string> guests = new List<string>();

            while (reader.Read())
            {
                guests.Add(reader.GetString(1));
            }
            DBConnection.CloseConnection();
            return guests;
        }
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
        public static void AddGuest(string name)
        {
            string sql = "insert into guests(Guest_name) values (@GuestName)";
            string[] paramters = { "@GuestName" };
            string[] values = { name };
            DBConnection.RunSqlNonQuery(sql, paramters, values);
            DBConnection.CloseConnection();
        }
        public static DataTable GetDishesSummary(string category_name)
        {
            string sql = "select Foods.Food_name as dish, count(Foods.Food_name) as amount from Foods join Categories on Categories.ID= Foods.Category_id where Categories.category_name= @category_name group by Foods.Food_name";
            string[] paramters = { "@category_name" };
            string[] values = { category_name };
            return DBConnection.RunSqlTableResults(sql, paramters, values);
        }
        public static void AddFood(string dishName,string categoryName,string guestName)
        {
            string sql = "  declare @CategoryId int, @GuestId int\r\n  select @CategoryId=(select ID from Categories where Category_name=@CategoryName)\r\n  select @GuestId=(select ID from Guests where Guest_name=@GuestName)\r\n  insert into foods(Food_name,Category_id,Guest_id) values (@DishName, @CategoryId, @GuestId)";
            string[] paramters = { "@DishName", "@CategoryName", "@GuestName" };
            string[] values = { dishName,categoryName,guestName };
            DBConnection.RunSqlNonQuery(sql, paramters, values);
            DBConnection.CloseConnection();
        }
    }
}






