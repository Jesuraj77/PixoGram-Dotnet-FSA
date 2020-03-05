using System;
using System.Collections.Generic;
using System.Text;

namespace Emart.Test.Exceptions
{
    
        class InvalidCredentialsExceptions : Exception
        {
            public string Messages = "Please enter valid usename & password";

            public InvalidCredentialsExceptions(string message)
            {
                Messages = message;
            }
        }
  }
