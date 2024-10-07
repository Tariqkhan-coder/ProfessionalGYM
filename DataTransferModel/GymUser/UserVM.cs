﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProfessionalGYM.DataTransferModel.GymUser
{
    public class UserVM
    {
       
            
        public string UserEmail { get; set; } = "";    
        public string UserName { get; set; } = "";     
        public string Password { get; set; } = "";     
        public string UserType { get; set; } = "";    
        public string FirstName { get; set; } = "";   
        public string LastName { get; set; } = "";   
        public string Gender { get; set; } = "";
        public string PhoneNumber { get; set; } = "";  
        public DateTime DateOfBirth { get; set; } 
        public string Address { get; set; } = "";
        public string ProfileImageUrl { get; set; } = "";
        //public bool IsEmailVerified { get; set; } = false;
        //public bool IsBlocked { get; set; } = false;

    }
}
