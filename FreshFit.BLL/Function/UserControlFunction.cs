using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FreshFit.BLL.Function
{
    public static class UserControlFunction
    {
        
        public static bool CheckForIsDigit(string deger)
        {
            bool returnValue = false;
            for (int i = 0; i < deger.Length; i++)
            {
                if (Char.IsDigit(deger[i]) == true)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }
        public static bool CheckForSpecialCharacter(string ozelKarakter)
        {
            bool returnValue = false;
            for (int i = 0; i < ozelKarakter.Length; i++)
            {
                if (Char.IsPunctuation(ozelKarakter[i]) == true)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }
        public static bool CheckForUpperCharacter(string karakter)
        {
            bool returnValue = false;
            for (int i = 0; i < karakter.Length; i++)
            {
                if (Char.IsUpper(karakter[i]) == true)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }
        public static bool CheckForLowerCharacter(string karakter)
        {
            bool returnValue = false;
            for (int i = 0; i < karakter.Length; i++)
            {
                if (Char.IsLower(karakter[i]) == true)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }
        public static bool CheckForIsEmpty(string text)
        {
            bool returnValue = true;
            if (text != string.Empty)
            {
                returnValue = false;
            }
            return returnValue;
        }
        public static string TrimProcess(string text)
        {
            text = text.Trim();
            return text;
        }
        public static string RemovingWhitespace(string text)
        {
            text = text.Replace(" ", "");
            return text;
        }

        public static string HidingPasswordInDB(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public static string FixingName(string name)
        {
            return  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        }
        public static string ToUpperLastName(string name)
        {
            return name.ToUpper();
        }

    }
}
