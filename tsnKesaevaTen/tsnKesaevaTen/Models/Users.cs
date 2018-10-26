using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace tsnKesaevaTen.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }

    public class UsersContext : DbContext
    {
        public UsersContext (): base ("DefaultConnection") { }
        public DbSet<Users> Users { get; set; }
    }
}