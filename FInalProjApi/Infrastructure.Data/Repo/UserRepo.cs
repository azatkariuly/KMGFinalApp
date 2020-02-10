using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repo
{
    public class UserRepo : IRepo<User>
    {
        private readonly MyContext _db;
        
        public UserRepo(MyContext db)
        {
            _db = db;
        }

        public void add(User obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
        }

        public User get(int id)
        {
            return _db.Users.Find(id);
        }

        public void update(User obj)
        {
            _db.Users.Update(obj);
            _db.SaveChanges();
        }

        public void delete(int id)
        {
            var user = get(id);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }

        public List<User> getList()
        {
            return _db.Users.ToList();
        }

        
    }
}