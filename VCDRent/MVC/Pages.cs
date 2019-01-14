using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCDRent.MVC
{
    public static partial class Pages
    {
       
        #region Dashboard
        public static class Dashboard
        {
            public const string Name = "Home";
        }

        public static class Home
        {
            public const string Controller = "Home";
            public const string Action = "Index";
            public const string Role = "Home";
            public const string Url = "/Home/Index";
            public const string Name = "Home";
        }

        public static class UserManage
        {
            public const string Controller = "UserManage";
            public const string Action = "Index";
            public const string Role = "UserManage";
            public const string Url = "/UserManage/Index";
            public const string Name = "Management User";
        }

        public static class ApplicationUser
        {
            public const string Controller = "ApplicationUser";
            public const string Action = "Index";
            public const string Role = "ApplicationUser";
            public const string Url = "/ApplicationUser/Index";
            public const string Name = "Menu Manager";
        }

        public static class MemberManage
        {
            public const string Controller = "MemberManage";
            public const string Action = "Index";
            public const string Role = "MemberManage";
            public const string Url = "/MemberManage/Index";
            public const string Name = "Member";
        }

        public static class MemberConfirmContactManage
        {
            public const string Controller = "MemberConfirmContactManage";
            public const string Action = "Index";
            public const string Role = "MemberConfirmContactManage";
            public const string Url = "/MemberConfirmContactManage/Index";
            public const string Name = "Member Confirm";
        }

        public static class ReportContactPersonManage
        {
            public const string Controller = "MemberConfirmContactManage";
            public const string Action = "Index";
            public const string Role = "MemberConfirmContactManage";
            public const string Url = "/MemberConfirmContactManage/ReportContact";
            public const string Name = "Report Contact Person";
        }

        public static class ConfirmContactManage
        {
            public const string Controller = "ConfirmContactManage";
            public const string Action = "Index";
            public const string Role = "ConfirmContactManage";
            public const string Url = "/ConfirmContactManage/Index";
            public const string Name = "Master Confirm Contact";
        }

        public static class PackageManage
        {
            public const string Controller = "PackageManage";
            public const string Action = "Index";
            public const string Role = "PackageManage";
            public const string Url = "/PackageManage/Index";
            public const string Name = "Master Package";
        }

        public static class KnowThisManage
        {
            public const string Controller = "KnowThisManage";
            public const string Action = "Index";
            public const string Role = "KnowThisManage";
            public const string Url = "/KnowThisManage/Index";
            public const string Name = "Master Know This";
        }
        #endregion Dashboard

    }
}
