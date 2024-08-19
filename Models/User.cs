using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudaspnetcore.Models
{
    public class User
    {
        public int id {get;set;}
        public required string name {get;set;}
        public required string email {get;set;}
    }
}