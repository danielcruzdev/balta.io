﻿using Blog.Models;
using System.Security.Claims;

namespace Blog.Extensions
{
    public static class RoleClaimsExtensions
    {
        public static IEnumerable<Claim> GetClaims (this User user)
        {
            var result = new List<Claim> 
            {
                new (ClaimTypes.Name, user.Name)
            };

            result.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Slug)));

            return result;
        }
    }
}
