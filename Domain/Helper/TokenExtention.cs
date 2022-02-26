using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Domain.Helper
{
    public static class TokenExtensions
    {
        public static UserInfo GetUserClaim(this ClaimsIdentity claimsIdentity)
        {
            return new UserInfo
            {
                Id =claimsIdentity.FindFirst("id").Value,
                PhoneNumber = claimsIdentity.FindFirst(ClaimTypes.MobilePhone)?.Value,
                Roles=claimsIdentity.FindFirst(ClaimTypes.Role).Value
            };
        }
    }
} 
