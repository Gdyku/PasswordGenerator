using System;
using System.Linq;
using System.Text;

namespace PasswordGenLib
{
    public class RandomPasswordFunctions
    {
        private readonly string chars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789!@#$%^&*";
        public string ReturnRandomString(int size)
        {
            Random random = new Random();
            
            while(true)
            {
                string password = new string(Enumerable.Repeat(chars, size).Select(s => s[random.Next(s.Length)]).ToArray());

                if(IsPasswordGood(password))
                return password;
            }
        }

        public bool IsPasswordGood(string password)
        {
            return password.Any(c => DoesContainUpperCaseLetter(c)) &&
                password.Any(c => DoesContainLowerCaseLetter(c)) &&
                password.Any(c => DoesContainDigit(c)) &&
                password.Any(c => DoesContainSymbol(c));
        }

        private bool DoesContainUpperCaseLetter(char c)
        {
            return (c >= 'A' && c <= 'Z');
        }
        private bool DoesContainLowerCaseLetter(char c)
        {
            return (c >= 'a' && c <= 'z');
        }
        private bool DoesContainDigit(char c)
        {
            return (c >= '0' && c <= '9');
        }
        private bool DoesContainSymbol(char c)
        {
            return (c > 32 && c <= 94 && !DoesContainDigit(c) && !DoesContainLowerCaseLetter(c) && !DoesContainUpperCaseLetter(c));
        }

    }
}
