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

            //Action
            var actualLenghth = user.Password.Length;

            //Assert
            Assert.Equal(MinLenghthRequired, actualLenghth);



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

    }
}
