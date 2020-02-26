
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
    public class FunctionalTest
    {
        private readonly UserService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        


        public FunctionalTest()
        {
            _service = new UserService(_session);
        }


        [Fact]
        public void TestForValidRegistrations()
        {
            //Arrange

            User user = new User{Id = 11, FirstName = "John", LastName = "HS", UserName = "John",
               Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs"};

            //Action
            var isRegistered = _service.Register(user);

            //Assert
            Assert.Equal(true, isRegistered);
            Assert.True(isRegistered);
        }

        [Fact]
        public void TestForValidLogin()
        {
            //Arrange

            User user = new User { Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs" };


            //Action
            var isLogged = _service.Login(user.UserName, user.Password);

            //Assert
            Assert.Equal(true, isLogged);
            Assert.True(isLogged);

        }

        [Fact]
        public void TestForValidResetPassword()
        {
            //Arrange

            User user = new User { Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs" };


            //Action
            var isResetted = _service.ResetPassword(user.Password);

            //Assert
            Assert.Equal(true, isResetted);
            Assert.True(isResetted);
        }

        [Fact]
        public void GetProfile()
        {
            //Arrange

            User user = new User { Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs" };


            //Action
            var RecievedUser = _service.GetProfile(user.Id);
            var DbRecievedUser = _service.GetUserById(user.Id);

            //Assert
            Assert.Equal(DbRecievedUser, RecievedUser);


        }
        [Fact]
        public void TestForVaidUpadtingProfile()
        {
            //Arrange

            User user = new User{Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs"};


            //Action
            var isUpDated = _service.UpdateProfile(user);

            //Assert
            Assert.Equal(true, isUpDated);
            Assert.True(isUpDated);

        }
        [Fact]
        public void DeleteProfle()
        {
            //Arrange

            User user = new User { Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs" };


            //Action
            var isDeleted = _service.DeleteProfile(user.Id);

            //Assert
            Assert.Equal(true, isDeleted);
            Assert.True(isDeleted);

        }
        [Fact]
       public void TestForValidAddContent()
       {
         //Arrange
          List<Content> contentlist = new List<Content>();
          Content contentOne = new Content();
          Content contentTwo = new Content();
          contentlist.Add(contentOne);
          contentlist.Add(contentTwo);
          User user = new User{ Id= 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs"};


           //Action
           var isAdded = _service.AddContent(contentlist, user.Id);

           //Assert
           Assert.Equal(true, isAdded);
           Assert.True(isAdded);

        }

         [Fact]
        public void TestValidOrganiceImage()
        {
    //Arrange
            List<Content> contentlist = new List<Content>();
            User user = new User{Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs"};


            //Action
            var Organised = _service.OrganizeImage(user.Id,contentlist);
            var isOrganised = _service.GetContentByUserId(user.Id);

            //Assert
            Assert.Equal(isOrganised, Organised);

        }

        [Fact]
        public void TestForValidOrganiceVideo()
        {
    //Arrange
         List<Content> contentlist = new List<Content>();
         User user = new User{Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs"};


            //Action
         var Organised = _service.OrganizeVideo(user.Id, contentlist);
         var isOrganised = _service.GetContentByUserId(user.Id);

            //Assert
         Assert.Equal(isOrganised, Organised);

        }
        [Fact]
        public void TestForValidUpdateContent()
        {
         //Arrange
         Content content = new Content{Id = 1, Image = "https://unsplash.com/photos/p7mo8-CG5Gs", Video = "https://unsplash.com/photos/p7mo8-CG5Gs", Caption = "Images", Description = "Flowers", Visibility = true, UserId = 11};
         User user = new User { Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs" };

            //Action
         var isContetUpadated = _service.UpdateContent(user.Id, content);

            //Assert
         Assert.Equal(true, isContetUpadated);
         Assert.True(isContetUpadated);


        }
        [Fact]
        public void TestForValidAddComment()
        {
            //Arrange
            Feedback feedback = new Feedback();
            //Action
            var isAdded = _service.AddComment(feedback);

            //Assert
            Assert.Equal(true, isAdded);
            Assert.True(isAdded);
        }

         [Fact]
         public void TestForValidFollowUser()
        {
            //Arrange
          User user = new User{Id = 11, FirstName = "John", LastName = "HS", UserName = "John", Email = "John@gmail.com", Password = "1234567890", ProfilePicture = "https://unsplash.com/photos/p7mo8-CG5Gs"};

            //Action
          var isFollowed = _service.FollowUser(user.Id, 2);

            //Assert
          Assert.Equal(true, isFollowed);
          Assert.True(isFollowed);

         }

        [Fact]
        public void TestForValidHideMedia()
        {
            //Arrange
            Content content = new Content{ Image = "https://unsplash.com/photos/p7mo8-CG5Gs", Visibility=true, Video = "https://unsplash.com/photos/p7mo8-CG5Gs" };

            //Action
            var isHided = _service.HideMedia(content.Image,content.Visibility,content.Video) ;

            //Assert
            Assert.Equal(true, isHided);
            Assert.True(isHided);

        }

    }
}
