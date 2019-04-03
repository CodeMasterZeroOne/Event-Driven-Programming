using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenericLoginSystem
{
    /// <summary>
    /// Public User class with all the fields, getters and setters.
    /// </summary>
    public class User
    {
        private string firstName;
        private string lastName;
        private string userID;
        private string userPassword;
        private string userRole;
        private string accountNumber;
        private string email;
        private bool administrationFullAccess;
        private bool administrationReportPrivileges;
        private bool generateAuditRecords;
        private bool viewAuditRecords;
        private bool inputAccountPayments;
        private bool authoriseAccountPayments;
        private bool manageAccount;
        private bool viewAccountInformation;
        private bool viewAccountBalances;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserID { get => userID; set => userID = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string Email { get => email; set => email = value; }
        public bool AdministrationFullAccess { get => administrationFullAccess; set => administrationFullAccess = value; }
        public bool AdministrationReportPrivileges { get => administrationReportPrivileges; set => administrationReportPrivileges = value; }
        public bool GenerateAuditRecords { get => generateAuditRecords; set => generateAuditRecords = value; }
        public bool ViewAuditRecords { get => viewAuditRecords; set => viewAuditRecords = value; }
        public bool InputAccountPayments { get => inputAccountPayments; set => inputAccountPayments = value; }
        public bool AuthoriseAccountPayments { get => authoriseAccountPayments; set => authoriseAccountPayments = value; }
        public bool ManageAccount { get => manageAccount; set => manageAccount = value; }
        public bool ViewAccountInformation { get => viewAccountInformation; set => viewAccountInformation = value; }
        public bool ViewAccountBalances { get => viewAccountBalances; set => viewAccountBalances = value; }
        /// <summary>
        /// Public method that sets up user privilages based on the Role choosen 
        /// </summary>
        /// <param name="index"></param>
        public void setUsersRole(int index)
        {
            switch (index)
            {
                case 1: //Balance Operator
                    administrationFullAccess = false;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = true;
                    break;
                case 2: //Account Operator
                    administrationFullAccess = false;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = true;
                    viewAccountInformation = true;
                    viewAccountBalances = true;
                    break;
                case 3: //Auditor
                    administrationFullAccess = false;
                    administrationReportPrivileges = true;
                    generateAuditRecords = false;
                    viewAuditRecords = true;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = false;
                    break;
                case 4: //Administrator
                    administrationFullAccess = true;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = false;
                    break;
                case 5: //Super User
                    administrationFullAccess = true;
                    administrationReportPrivileges = true;
                    generateAuditRecords = false;
                    viewAuditRecords = true;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = true;
                    viewAccountBalances = true;
                    break;
                case 6: //Super User (All Payments)
                    administrationFullAccess = true;
                    administrationReportPrivileges = true;
                    generateAuditRecords = true;
                    viewAuditRecords = true;
                    inputAccountPayments = true;
                    authoriseAccountPayments = true;
                    manageAccount = true;
                    viewAccountInformation = true;
                    viewAccountBalances = true;
                    break;
                default: //Customer
                    administrationFullAccess = false;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = true;
                    break;
            }


        }
        public void setUsersRole(string role)
        {
            switch (role)
            {
                case "Customer":
                    administrationFullAccess = false;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = true;
                    break;
                case "Balance Operator":
                    administrationFullAccess = false;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = true;
                    break;
                case "Account Operator":
                    administrationFullAccess = false;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = true;
                    viewAccountInformation = true;
                    viewAccountBalances = true;
                    break;
                case "Auditor":
                    administrationFullAccess = false;
                    administrationReportPrivileges = true;
                    generateAuditRecords = false;
                    viewAuditRecords = true;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = false;
                    break;
                case "Administrator":
                    administrationFullAccess = true;
                    administrationReportPrivileges = false;
                    generateAuditRecords = false;
                    viewAuditRecords = false;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = false;
                    viewAccountBalances = false;
                    break;
                case "Super User":
                    administrationFullAccess = true;
                    administrationReportPrivileges = true;
                    generateAuditRecords = false;
                    viewAuditRecords = true;
                    inputAccountPayments = false;
                    authoriseAccountPayments = false;
                    manageAccount = false;
                    viewAccountInformation = true;
                    viewAccountBalances = true;
                    break;
                case "Super User (All Payments)":
                    administrationFullAccess = true;
                    administrationReportPrivileges = true;
                    generateAuditRecords = true;
                    viewAuditRecords = true;
                    inputAccountPayments = true;
                    authoriseAccountPayments = true;
                    manageAccount = true;
                    viewAccountInformation = true;
                    viewAccountBalances = true;
                    break;
                default:
                    break;
            }
        }
    }
}