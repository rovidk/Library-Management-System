using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace myLibrary.Data_Layer
{
    class DAL
    {
        public string sql = "Data Source = localhost; Initial Catalog = myLibrary; Integrated Security = True;";
        SqlConnection con = new SqlConnection();
        public int User_Register(string username, string password)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("Insert_User", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = username;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = password;
            try
            {
                int data = 0;
                data = cmd.ExecuteNonQuery();
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }
        public int User_login(string username, string password)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("Validate_User", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = username;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = password;
            try
            {
                int data = 0;
                data = Convert.ToInt16(cmd.ExecuteScalar());
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }
        public int Update_Record(string username, string password)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 100).Value = username;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = password;
            try
            {
                int data = 0;
                data = Convert.ToInt16(cmd.ExecuteScalar());
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public int Add_Category(string category)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("AddCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Book_Category", SqlDbType.VarChar, 100).Value = category;
            try
            {
                int data = 0;
                data = cmd.ExecuteNonQuery();
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable LoadCategory()
        {
            DataTable dt = new DataTable();
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books_Category", con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public int Remove_Category(int cat)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("RemCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Category", SqlDbType.Int, 100).Value = cat;
            try
            {
                int data = 0;
                data = cmd.ExecuteNonQuery();
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int InsertBook(string book, int cat, decimal price, string quantity, string author)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("AddBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Book", SqlDbType.VarChar, 256).Value = book;
            cmd.Parameters.Add("@Category", SqlDbType.Int, 100).Value = cat;
            cmd.Parameters.Add("@Price", SqlDbType.Decimal, 1000).Value = price;
            cmd.Parameters.Add("@Quantity", SqlDbType.VarChar, 100).Value = quantity;
            cmd.Parameters.Add("@Author", SqlDbType.VarChar, 256).Value = author;
            try
            {
                int data = 0;
                data = cmd.ExecuteNonQuery();
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable LoadBookData(string bookname)
        {
            SqlDataReader dr;
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("GetDetailsByBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Bookname", SqlDbType.VarChar, 256).Value = bookname;
            try
            {
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable LoadCatData(string catname)
        {
            SqlDataReader dr;
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("GetDetailsByCategory", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catname", SqlDbType.VarChar, 256).Value = catname;
            try
            {
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public int RemoveBook(string book, int qnt)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("RemBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.VarChar, 256).Value = book;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int, 100).Value = qnt;
            try
            {
                int data = cmd.ExecuteNonQuery();
                return data;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public int IssuedBook(string username, string book)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("IssueBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 256).Value = username;
            cmd.Parameters.Add("@Bookname", SqlDbType.VarChar, 256).Value = book;
            try
            {
                int result;
                result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }
        
        public int ReturnBook(string book, string username)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("ReturnBook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@bookname", SqlDbType.VarChar, 256).Value = book;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 256).Value = username;
            try
            {
                int result = 0;
                result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable ReadData()
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ReadLibraryData", con);
            try
            {
                DataTable dt = new DataTable();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable ReadDataWithUser(string user)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("BooksRecordViaUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 256).Value = user;
            try
            {
                DataTable dt = new DataTable();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable GetIssueData()
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DisplayIssueData", con);
            try
            {
                DataTable dt = new DataTable();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable GetAmountDetails(string username)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("GetSecurityAmountViaUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            try
            {
                DataTable dt = new DataTable();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }
        public DataTable UserAmounts()
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id AS [Id], Username, User_Active AS [Currently Active], SecurityAmount AS [Users Amount] FROM User_Register", con);
            try
            {
                DataTable dt = new DataTable();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Dispose();
                con.Dispose();
            }
        }
        public int AddSecurityAmount(string username, int amount)
        {
            con.ConnectionString = sql;
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE User_Register SET SecurityAmount = SecurityAmount + @SecurityAmount WHERE Username = @Username", con);
            cmd.Parameters.Add("@SecurityAmount", SqlDbType.Int, 32).Value = amount;
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 256).Value = username;
            try
            {
                int result = 0;
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
    }
}
