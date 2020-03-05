using NSubstitute;
using Pixogram.BusinessLayer.Services;
using Pixogram.DataLayer.NHibernate;
using Pixogram.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pixogram.Test
{
    public class BoundaryTest
    {

        private readonly UserService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();




        public BoundaryTest()
        {
            _service = new UserService(_session);
        }



        [Fact]
        public void BoundaryTestForPassword()
        {
            User user = new User { Password = "111111111" };
            var MinLenghthRequired = 8;
            var MaxLenghthRequired = 12;

            //Action
            var actualLenghth = user.Password.Length;

            //Assert
            Assert.InRange(actualLenghth, MinLenghthRequired, MaxLenghthRequired);
        }

        [Fact]
        public void BoundaryTestForContent()
        {
            Content user = new Content { Caption = "welcome...." };

            
            var MaxLenghthRequired = 500;

            //Action
            var actualLenghth = user.Caption.Length;

            //Assert
            Assert.Equal(MaxLenghthRequired, actualLenghth);
        }
        [Fact]
        public void BoundaryTestForUsername()
        {
            User user = new User { UserName = "userabc" };
            var MinLength = 8;
            var MaxLength = 12;

            //Action
            var ActualLength = user.UserName.Length;

            //Assert
            Assert.InRange(ActualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTestForEmail()
        {
            User user = new User { Email = "", Password="12" };
            User users = new User { Email = "abc@@gmail.com",Password="123" };
           

            //Action
          
            //Assert
            Assert.Equal(user, users);

        }
        
    }
}
