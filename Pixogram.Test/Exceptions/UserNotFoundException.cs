using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.Test.Exceptions
{
   public class UserNotFoundException : Exception
    {
        public string Messages = "User Not Found";
        public UserNotFoundException(string messages)
        {
            Messages = messages;
        }
    }
}
