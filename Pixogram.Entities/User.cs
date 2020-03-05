using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.Entities
{
   public class User
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual string ConfirmPassword { get; set; }
        public virtual string ProfilePicture { get; set; }
    }
}
