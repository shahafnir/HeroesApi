﻿using System.ComponentModel.DataAnnotations;

namespace HeroesApi.Dtos.Requests
{
    public class UserLoginRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
