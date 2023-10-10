
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace UserRegistration_Exception_Validation
{
    public class UserRegistration
    {
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                string pattern = "^[A-Z][a-zA-Z]{2,}$";
                return Regex.IsMatch(firstName, pattern);
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating first name", ex);
            }
        }

        public bool ValidateLastName(string lastName)
        {
            try
            {
                string pattern = "^[A-Z][a-zA-Z]{2,}$";
                return Regex.IsMatch(lastName, pattern);
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating last name", ex);
            }
        }

        public bool ValidateEmail(string email)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\.[a-zA-Z]{2,}){1,2}$";
                return Regex.IsMatch(email, pattern);
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating email", ex);
            }
        }

        public bool ValidateMobileNumber(string mobileNumber)
        {
            try
            {
                string pattern = @"^[0-9]{2}\s[0-9]{10}$";
                return Regex.IsMatch(mobileNumber, pattern);
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating mobile number", ex);
            }
        }

        public bool ValidatePassword(string password)
        {
            try
            {
                string pattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&+=]).{8,}$";
                return Regex.IsMatch(password, pattern);
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating password", ex);
            }
        }

        static void Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();

        }
    }

}
