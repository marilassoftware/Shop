using Shop.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    public class Country : IEntity
    {
        public int Id { get ; set ; }

        public String Name { get; set; }
    }
}
