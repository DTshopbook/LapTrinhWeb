﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;
namespace Model.Dao
{
    public class UserDao
    {
        ShopBook3DbContext db = null;
        public UserDao()
        {
            db = new ShopBook3DbContext();
        }
        public string Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.Username;
        }
        public User GetByID(string username)
        {
            return db.Users.SingleOrDefault(x => x.Username == username);
        }

        public User ViewDetail(string username)
        {
            return db.Users.Find(username);
        }

        public bool LoginAdmin(string username, string password)
        {
            var result = db.Users.Count(x => x.Username == username && x.Pasword == password && x.Rank == 1);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Login(string username, string password)
        {
            var result = db.Users.Count(x => x.Username == username && x.Pasword == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.Username);
                user.Username = entity.Username;
                if (!string.IsNullOrEmpty(entity.Pasword))
                {
                    user.Pasword = entity.Pasword;
                }
                user.Rank = entity.Rank;
                user.Statuss = entity.Statuss;
                user.CartID = entity.CartID;
                user.Email = entity.Email;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                //logging
                return false;
            }
        }
        public bool Delete(string username)
        {
            try
            {
                var user = db.Users.Find(username);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ChangeStatus(string username)
        {
            var user = db.Users.Find(username);
            user.Statuss = !user.Statuss;
            db.SaveChanges();
            return user.Statuss;
        }
        public bool CheckUserName(string userName)
        {
            return db.Users.Count(x => x.Username == userName) > 0;
        }
        public IEnumerable<User> ListAllPaging( int page, int pagelist)
        {
            IQueryable<User> model = db.Users;
            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    model = model.Where(x => x.Username.Contains(searchString));
            //}

            return db.Users.OrderByDescending(x=> x.CreateDate).ToPagedList(page,pagelist);
        }

        public List<User> ListCus()
        {
            return db.Users.Where(x => x.Statuss == true).ToList();
        }

    }
}

