using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.DAL.Data
{
    public class AppUser: IdentityUser
    {
        public string PhoneNumber { get; set; }
        public string SmsCode { get; set; }
    }
}
