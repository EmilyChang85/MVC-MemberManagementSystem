using MemberMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberMangementSystem.Service
{
    public class UserService
    {
        MemberMangementSystemEntities db = new MemberMangementSystemEntities();

        public List<User> GetAllUser()
        {
            return db.User.ToList();
        }

        public User findUser(int Id)
        {
            return db.User.SingleOrDefault(x => x.Id == Id);
        }

        public void updateUserData(User user)
        {
            User u = findUser(user.Id);
            u.Name = user.Name;
            u.Tel = user.Tel;
            u.Age = user.Age;
            u.Address = user.Address;
            db.SaveChanges();
        }

        public void deleteUser(int Id)
        {
            User u = findUser(Id);
            db.User.Remove(u);
            db.SaveChanges();
        }

        public void createUser(User user)
        {
            db.User.Add(user);
            db.SaveChanges();
        }
    }
}