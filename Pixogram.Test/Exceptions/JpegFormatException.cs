using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.Test.Exceptions
{
   public class JpegFormatException: Exception
    {

        public string Messages = "Should Contain jpeg Format";

        public JpegFormatException(string message)
        {
            Messages = message;
        }

    }
}
