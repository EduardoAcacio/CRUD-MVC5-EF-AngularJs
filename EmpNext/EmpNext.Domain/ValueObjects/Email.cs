using EmpNext.Helper.Helpers;
using System;
using System.Text.RegularExpressions;

namespace EmpNext.Domain.ValueObjects
{
    public class Email
    {
        public const int AdressMaxLength = 254;
        public string Adress { get; private set; }

        protected Email() { }

        public Email(string adress)
        {
            Guard.ForNullOrEmptyDefaultMessage(adress, "E-mail");
            Guard.StringLength("E-mail", adress, AdressMaxLength);

            if (IsValid(adress) == false)
                throw new Exception("E-mail is invalid");

            Adress = adress;
        }

        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }
    }
}
