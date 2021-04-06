using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

namespace b9039646_WAD_Assignment.Models
{
    public class Role : IdentityRole
    {
        public string country;
    }
}
