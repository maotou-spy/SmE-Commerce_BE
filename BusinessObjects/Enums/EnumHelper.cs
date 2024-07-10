using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Enums
{
    public static class ShopSettings
    {
        public const string ShopName = "ShopName";
        public const string Address = "Address";
        public const string Phone = "Phone";
        public const string Email = "Email";
        public const string LogoUrl = "LogoUrl";
        public const string MaximumTopReview = "MaximumTopReview"; //Max top review is 7
        public const string PrivacyPolicy = "PrivacyPolicy";
        public const string TermsOfService = "TermsOfService";
        public const string PointsConversionRate = "PointsConversionRate"; //Tỷ lệ phần trăm tích điểm
    }

    public static class CodeStatus
    {
        public const string active = "Active";
        public const string inactive = "Inactive";
        public const string used = "Used";
        public const string deleted = "Deleted";
    }

    public static class simpleStatus
    {
        public const string active = "Active";
        public const string inactive = "Inactive";
        public const string deleted = "Deleted";
    }

    public static class orderStatus
    {
        public const string pending = "Pending";
        public const string processing = "Processing";
        public const string completed = "Completed";
        public const string cancelled = "Cancelled";
        public const string rejected = "Rejected";
    }

    public static class accountStatus
    {
        public const string active = "Active";
        public const string inactive = "Inactive";
        public const string suspended = "Susspended";
    }

    public static class blogStatus
    {
        public const string draft = "Draft";
        public const string pending = "Pending";
        public const string published = "Published";
        public const string unpublished = "Unpublished";
        public const string deleted = "Deleted";
    }
}
