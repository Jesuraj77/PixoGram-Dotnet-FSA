using Emart.Test.Exceptions;
using NSubstitute;
using Pixogram.BusinessLayer.Services;
using Pixogram.DataLayer.NHibernate;
using Pixogram.Entities;
using Pixogram.Test.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pixogram.Test
{
    public class ExceptionTest
    {

        private readonly UserService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
      

        public ExceptionTest()
        {
            _service = new UserService(_session);
        }

        [Fact]
        public void ExceptionTestForUserNotFound()
        {

            //Arrange
            User user = new User()
            {
                Id = 1000,
                FirstName = "Raju",
                LastName = "Patil",
                UserName = "User123",
                Email = "user@gmail.com",
                Password = "2111",
                ProfilePicture="img"
            };
  
          
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _service.GetUserById(user.Id));
            Assert.Equal("Company Not Found in Tasks List", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _service.Login("abc@gmail.com", "987654321"));
           
            Assert.Equal("Please enter valid usename & password", ex.Messages);
          
        }


        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
          
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _service.Login("abc@gmail.com", "987654321"));
            
            Assert.Equal("Please enter valid usename & password", ex.Messages);
           

        }


        [Fact]
        public void ExceptionTestFor_InvalidprofileFormat()
        {
            User user = new User()
            {
                Id = 1000,
                FirstName = "Raju",
                LastName = "Patil",
                UserName = "User123",
                Email = "user@gmail.com",
                Password = "2111",
                ConfirmPassword = "12",
                ProfilePicture = "img"
            };
          
            //Action
            //Assert
            var ex = Assert.Throws<JpegFormatException>(() => _service.Register(user));

            Assert.Equal("Should Contain jpeg Format", ex.Messages);



        }




    }
}
