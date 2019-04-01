using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenericLoginSystem
{
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
    }
}