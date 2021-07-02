using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExercise
{
    public class MailManager
    {
        public MailManager()
        {

        }

        public bool IsValidAddress(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
     
    }
}
