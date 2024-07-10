using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Enums
{
    public static class ErrorEnum
    {
        public const string NOT_FOUND = "Not found!";
        public const string BAD_REQUEST = "Bad request!";
        public const string INVALID_INPUT = "Invalid input!";
        public const string UNAUTHORIZED = "Unauthorized!";
        public const string FORBIDDEN = "Forbidden!";
        public const string INTERNAL_SERVER_ERROR = "Internal server error!";

        public const string INCORRECT_CREDENTIALS = "Incorrect credentials";
        public const string PASSWORD_NOT_MATCH = "Re-password not match";

        public static string IS_EXISTED(string? item) => $"{item ?? "Item"} already exists!";
        public static string IS_NOT_EXISTED(string? item) => $"{item ?? "Item"} is not existed!";
    }
}

