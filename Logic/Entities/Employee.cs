using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Logic.Entities
{
   public class Employee
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string TelephoneNumber { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
       
        public Employee()
        {
        }

        public Employee(string userName, string email, string password,string confirmpassword,string telphoneNumber,string firstname,string surename)
        {
            this.UserName = userName;
            this.Email = email;
            this.Password = password;
            this.ConfirmPassword = confirmpassword;
            this.TelephoneNumber = telphoneNumber;
            this.Firstname = firstname;
            this.Surname = surename;
        }
    }
}
