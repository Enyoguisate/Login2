using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int AreaCode { get; set; }
        public Int64 Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public int TrainerLvl { get; set; }

        
    }
}
