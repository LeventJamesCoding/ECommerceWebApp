using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constant
{
    public static class Messages
    {
        public static string ProductAdded = "Product was added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "System is on maintenance";
        public static string ProductsListed = "Products was listed successfully";
        public static string? ProductCountOfCategoryError = "There can be only 10 products for each category";
        public static string ProductNameAlreadyExists = "Product name already exists";
        internal static string CategoryCountExceed;
        internal static string? AuthorizationDenied = "You have no authorization";
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;

        public static string UserRegistered { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
    }
}
