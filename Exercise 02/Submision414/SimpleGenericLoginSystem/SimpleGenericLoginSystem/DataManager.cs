using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenericLoginSystem
{
    /// <summary>
    /// Sealed class DataManager
    /// </summary>
    sealed class DataManager
    {
        private static DataManager dataManager;
        private DataTable dataTable;
        
        private DataManager()
        {
            dataTable = FileManager.getFileManager().LoadData();
        }
        /// <summary>
        /// Gets data manager and if it does not exists it will make one.
        /// </summary>
        /// <returns>DataManager</returns>
        public static DataManager getDataManager()
        {
            if (dataManager == null)
            {
                dataManager = new DataManager();
            }
            return dataManager;
        }
        /// <summary>
        /// Private method to check if user exists.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        private bool doesUserExist(string userID)
        {
            return dataTable.AsEnumerable().Any(row => userID == row.Field<String>("User Id"));
        }
        /// <summary>
        /// Public method for checking the password
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns>Tuple</returns>
        public Tuple<bool, DataRow> doesPasswordMatch(string userID, string password)
        {

            if (doesUserExist(userID))
            {
                var result = dataTable.AsEnumerable().Where(myRow => myRow.Field<string>("User Id") == userID);

                foreach (DataRow row in result)
                {

                    foreach (var item in row.ItemArray)
                    {
                        if (((string)item).Equals(password))
                        {
                            return new Tuple<bool, DataRow>(true, row);
                        }
                    }
                }
            }
            return new Tuple<bool, DataRow>(false, null);
        }
        /// <summary>
        /// Public method that creates the user object from data row
        /// </summary>
        /// <param name="row"></param>
        /// <returns>User</returns>
        public User rowToUser(DataRow row)
        {
            User user = new User();
            user.FirstName = row.Field<string>("First Name");
            user.LastName = row.Field<string>("Last Name");
            user.UserID = row.Field<string>("User Id");
            user.UserPassword = row.Field<string>("Password");
            user.UserRole = row.Field<string>("Role");
            user.AccountNumber = row.Field<string>("Account Number");
            user.Email = row.Field<string>("Email Address");

            return user;
        }
        /// <summary>
        /// Public method responsible for checking if user ID is in our records
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Tuple</returns>
        public Tuple<bool, DataRow> doesUserIdMatch(string userID)
        {

            if (doesUserExist(userID))
            {
                var result = dataTable.AsEnumerable().Where(myRow => myRow.Field<string>("User Id") == userID);

                foreach (DataRow row in result)
                {
                    foreach (var item in row.ItemArray)
                    {
                        return new Tuple<bool, DataRow>(true, row);
                    }
                }
            }
            return new Tuple<bool, DataRow>(false, null);
        }
    }
}
