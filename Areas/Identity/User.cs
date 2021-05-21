using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Areas.Identity
{
    public class User : IdentityUser
    {
        /* Existing 
        [Id]
        [UserName]
        [NormalizedUserName]
        [Email]
        [NormalizedEmail]
        [EmailConfirmed]
        [PasswordHash]
        [SecurityStamp]
        [ConcurrencyStamp]
        [PhoneNumber]
        [PhoneNumberConfirmed]
        [TwoFactorEnabled]
        [LockoutEnd]
        [LockoutEnabled]
        [AccessFailedCount]
         */

        public string MyProperty { get; set; }
    }
}
