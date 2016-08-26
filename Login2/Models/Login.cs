using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Login2.Models
{
    public class Login
    {
        [Required]
        [MaxLength(12,ErrorMessage ="Maximo permitido es 12")]
        public String UserName { get; set; }
        [Required]
        [MaxLength(15,ErrorMessage ="Maximo permitido es 15")]
        
        public String Password { get; set; }



    }
}