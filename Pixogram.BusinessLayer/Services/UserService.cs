using Pixogram.DataLayer.NHibernate;
using Pixogram.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixogram.BusinessLayer.Services
{
    public class UserService : IUserServices
    {
        private readonly IMapperSession _session;

        public UserService(IMapperSession session)
        {
            _session = session;
        }


        public bool AddComment(Feedback Feedback)
        {
            return true;
        }

        public bool AddContent(List<Content> content, int UserID)
        {
            return true;
        }

        public bool DeleteProfile(int Id)
        {
            return true;
        }

        public List<Follow> FollowList(int UserId)
        {
            List<Follow> Follows = new List<Follow>();
            return Follows;
        }

        public bool FollowUser(int UserId, int SenderId)
        {
            return true;
        }

        public Content GetContent(int Id)
        {
            Content content = new Content();
            return content;
        }

        public User GetProfile(int Id)
        {
            User user = new User();
            return user;
        }

        public bool HideMedia(string picturePath, bool Visibility, string VideoPath)
        {
            return true;
        }

        public bool Login(string UserName, string Password)
        {
            return true;

        }

        public List<Content> OrganizeImage(int UserId, List<Content> Content)
        {
            List<Content> content = new List<Content>();
            return content;
        }

        public List<Content> OrganizeVideo(int UserId, List<Content> Content)
        {
            List<Content> content = new List<Content>();
            return content;
        }

        public bool Register(User user)
        {
            return true;
        }

        public bool ResetPassword(string Password)
        {
            return true;
        }

        public bool UpdateContent(int UserId, Content Content)
        {
            return true;
        }

        public bool UpdateProfile(User User)
        {
            return true;
        }

        public List<ILog> ActivityLog(int UserId)
        {
            List<ILog> Ilog = new List<ILog>();
            return Ilog;
        }

        public User GetUserById(int UserId)
        {
            User user = new User();
            return user;

        }
        public List<Content> GetContentByUserId(int UserId)
        {
            List<Content> content = new List<Content>();
            return content;
        }


    }
}
