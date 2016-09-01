﻿using System;

namespace SRL.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a string with backslashes before characters that need to be quoted
        /// </summary>
        /// <param name="Value">Text string need to be escape with slashes</param>
        public static string AddSlashes(this string value)
        {
            // List of characters handled:
            // \000 null
            // \010 backspace
            // \011 horizontal tab
            // \012 new line
            // \015 carriage return
            // \032 substitute
            // \042 double quote
            // \047 single quote
            // \134 backslash
            // \140 grave accent

            string result = value;

            try
            {
                result = System.Text.RegularExpressions.Regex.Replace(value, @"[\000\010\011\012\015\032\042\047\134\140]", "\\$0");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Un-quotes a quoted string
        /// </summary>
        /// <param name="InputTxt">Text string need to be escape with slashes</param>
        public static string StripSlashes(this string value)
        {
            // List of characters handled:
            // \000 null
            // \010 backspace
            // \011 horizontal tab
            // \012 new line
            // \015 carriage return
            // \032 substitute
            // \042 double quote
            // \047 single quote
            // \134 backslash
            // \140 grave accent

            string result = value;

            try
            {
                result = System.Text.RegularExpressions.Regex.Replace(value, @"(\\)([\000\010\011\012\015\032\042\047\134\140])", "$2");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
