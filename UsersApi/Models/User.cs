using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

    }
}
