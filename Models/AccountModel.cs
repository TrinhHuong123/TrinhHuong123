using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1721050522_Trinh_Thu_Huong_BTL_LTQL.Models
{
    public class AccountModel
    {
        //validation with Model
        //User ko dc để trống
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        //password ko dc để trống
        [Required(ErrorMessage = "Password is required.")]
        //định nghĩa datatype
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}