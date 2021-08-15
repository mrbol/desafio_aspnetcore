using Application.DTOs.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Column("PrimeiroNome")]
        public string FirstName { get; set; }
        [Column("UltimoNome")]
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}
