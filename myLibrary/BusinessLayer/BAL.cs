using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Configuration;
using System.Text;
using myLibrary.Data_Layer;

namespace myLibrary.BusinessLayer
{
    class BAL
    {
        DAL dl = new DAL();
        public static int Books_allowed = 3;
        public int User_Register(string username, string password)
        {
            return dl.User_Register(username, password);
        }
        public int Validate_login(string username, string password)
        {
            return dl.User_login(username, password);
        }
        public int UpdateRecord(string username, string password)
        {
            return dl.Update_Record(username, password);
        }
        public int AddCategory(string category)
        {
            return dl.Add_Category(category);
        }
        public DataTable LoadCategory()
        {
            return dl.LoadCategory();
        }
        public int RemCategory(int category)
        {
            return dl.Remove_Category(category);
        }
        public int AddBook(string book, int cat, decimal price, string qnt, string author)
        {
            return dl.InsertBook(book, cat, price, qnt, author);
        }
        public int RemoveBook(string book, int qnt)
        {
            return dl.RemoveBook(book, qnt);
        }
        public DataTable LoadBookData(string book)
        {
            return dl.LoadBookData(book);
        }
        public DataTable LoadCatData(string category)
        {
            return dl.LoadCatData(category);
        }
        public int CheckBooks(string user, string book)
        {
            return dl.IssuedBook(user, book);
        }
        public int ReturnBook(string book, string user)
        {
            return dl.ReturnBook(book, user);
        }
        public DataTable GetAllData()
        {
            return dl.ReadData();
        }
        public DataTable ReadDataUser(string username)
        {
            return dl.ReadDataWithUser(username);
        }
        public DataTable GetBooksIssued()
        {
            return dl.GetIssueData();
        }
        public DataTable GetSecurityAmountList(string username)
        {
            return dl.GetAmountDetails(username);
        }
        public DataTable GetUsersAmount()
        {
            return dl.UserAmounts();
        }
        public int AddUserAmount(string user, int amount)
        {
            return dl.AddSecurityAmount(user, amount);
        }
    }
}
