using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
	public class AppUser : IdentityUser<int>
	{
        public String? Name { get; set; }
        public String? Surname { get; set; }
        public String? District { get; set; }
        public String? City { get; set; }
        public String? ImageUrl { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
