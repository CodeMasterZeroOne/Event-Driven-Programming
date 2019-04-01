using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenericLoginSystem
{
    sealed class DataManager
    {
        private static DataManager dataManager;
        private DataTable dataTable;


        private DataManager()
        {
            dataTable = FileManager.getFileManager().LoadData();
        }

        public static DataManager getDataManager()
        {
            if (dataManager == null)
            {
                dataManager = new DataManager();
            }
            return dataManager;
        }

        private bool doesUserExist(string userID)
        {
            return dataTable.AsEnumerable().Any(row => userID == row.Field<String>("User Id"));
        }

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
            //Administration Full Access,Administration Report Privileges,Generate Audit Records,View Audit Records,Input Account Payments,Authorise Account Payments,Manage Account,View Account Information,View Account Balances

            return user;
        }

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
