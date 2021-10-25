using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "The product has been added.";
        public static string ProductUpdated = "The product has been updated.";
        public static string ProductNameInvalid = "Product name invalid";
        public static string MaintenanceTime = "System is in maintenance.";
        public static string ProductsListed = "Products are listed.";
        public static string ProductFound = "The product has been found.";
        public static string ProductCountOfCategoryError = "There must be maximum of 10 products in a category.";
        public static string ProductNameAlreadyExists = "Product name already exists.";
        internal static string CategoryLimitexceded = "Category limit exceeded. ";
    }
}
