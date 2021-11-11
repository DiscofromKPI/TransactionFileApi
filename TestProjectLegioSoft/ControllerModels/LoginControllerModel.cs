﻿using System.ComponentModel.DataAnnotations;

namespace TestProjectLegioSoft.ControllerModels
{
    public class LoginControllerModel
    {
        [Required]
        [Display(Name = "Email")] public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}