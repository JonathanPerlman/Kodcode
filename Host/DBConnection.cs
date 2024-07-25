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
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = PERLMANS\\SQLSERVER;initial catalog=Sabbath; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()

        {
            try
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(connectionString);
                }
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static SqlDataReader runSQL(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (SqlException ex)
                {
                    return null;
                }

            }
            return null;
        }

        public static bool RunSqlBySearch(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }

            }
            return false;
        }

        public static bool RunSQLDeleteQuery(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }

            }
            return false;
        }

        public static DataTable RunSqlTableResults(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    //מחלקה שתפקידה לטפל בפקודות אס קיו אל ולאכלס את הטבלה המתקבלת בdatattable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    // מופע של datatable
                    DataTable dataTable = new DataTable();
                    // הפונקציה הזו מקבלת טבלה היא מריצה פקודת אס קיו אל (שהוגדרה במופע של המחלקה ומחזירה את תוצאות הריצה לתוך הטבלה)
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;    
                }
                finally
                {
                    CloseConnection();
                }

            }
            return null;
        }
        public static void CloseConnection()
        {
            sqlConnection.Close();
        }

    }
}

//public static string RunSQLSingalResult(string sql, string[] parameters = null, string[] values = null)
//{
//    if (Connect())
//    {
//        try
//        {
//            SqlCommand cmd = new SqlCommand();
//            cmd.Connection = sqlConnection;
//            cmd.CommandText = sql;
//            // Add parameters
//            if (parameters != null && values != null)
//            {
//                for (int i = 0; i < parameters.Length; i++)
//                {
//                    cmd.Parameters.AddWithValue(parameters[i], values[i]);
//                }
//            }
//            return cmd.ExecuteScalar().ToString();
//        }
//        catch (SqlException ex)
//        {
//            return ex.Message;
//        }
//    }
//    return "";
//}


//public static string RnSQLNoResult(string sql, string[] parameters = null, string[] values = null)
//{
//    if (Connect())
//    {
//        try
//        {
//            SqlCommand cmd = new SqlCommand();
//            cmd.Connection = sqlConnection;
//            cmd.CommandText = sql;
//            // Add parameters
//            if (parameters != null && values != null)
//            {
//                for (int i = 0; i < parameters.Length; i++)
//                {
//                    cmd.Parameters.AddWithValue(parameters[i], values[i]);
//                }
//            }
//            return cmd.ExecuteScalar().ToString();
//        }
//        catch (SqlException ex)
//        {
//            return ex.Message;
//        }
//    }
//    return "";
//}


//public static SqlDataReader RunSQLAllResult(string sql, string[] parameters = null, string[] values = null)
//{
//    if (Connect())
//    {
//        try
//        {
//            SqlCommand cmd = new SqlCommand();
//            cmd.Connection = sqlConnection;
//            cmd.CommandText = sql;
//            // Add parameters
//            if (parameters != null && values != null)
//            {
//                for (int i = 0; i < parameters.Length; i++)
//                {
//                    cmd.Parameters.AddWithValue(parameters[i], values[i]);
//                }
//            }
//            return cmd.ExecuteReader();
//        }
//        catch (SqlException ex)
//        {
//            Console.WriteLine(ex);
//            return null;
//        }
//    }
//    return null;
//}


//public static datatable runsqltableresult(string sql, string[] parameters = null, string[] values = null)
//    {
//    if (connect())
//    {
//        try
//        {
//            sqlcommand cmd = new sqlcommand();
//            cmd.connection = sqlconnection;
//            cmd.commandtext = sql;
//            // add parameters
//            if (parameters != null && values != null)
//            {
//                for (int i = 0; i < parameters.length; i++)
//                {
//                    cmd.parameters.addwithvalue(parameters[i], values[i]);
//                }
//            }
//            sqldataadapter adapter = new sqldataadapter();
//            datatable datatable = new datatable();
//            adapter.fill(datatable);
//            return datatable;
//        }
//        catch (sqlexception ex)
//        {
//            console.writeline(ex);
//            return null;
//        }
//    }
//    return null;
//}




