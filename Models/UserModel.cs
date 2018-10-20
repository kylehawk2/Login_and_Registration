using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login_and_Registration.Models
{
    public class User
    {
        [Key]
        public int id {get;set;}
        public string First_Name {get;set;}
        public string Last_Name {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public string Cpassword {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
}