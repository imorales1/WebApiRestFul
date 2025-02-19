﻿using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace WebApiAutores.DTOs
{
    public class CredencialesUsuario
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
