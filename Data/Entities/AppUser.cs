using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Demo_Code.Data.Entities
{
    internal class AppUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        public bool  ConfirmPassword { get; set; }
    }
}
