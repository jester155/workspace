using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcTutorial.Models
{
    public class Model
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ModelDb : DbContext
    {
        public DbSet<Model> model { get; set; }
    }
}