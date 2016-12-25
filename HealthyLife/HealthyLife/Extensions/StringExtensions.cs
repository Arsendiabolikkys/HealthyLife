using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.Extensions
{
    public static class StringExtensions
    {
        public static string FormatWith(this string value, params object[] args)
        {
            return String.Format(value, args);
        }
    }
}