using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza5050.Shared
{
        public class User
        {
            public int Id { get; set; }
            public string Uid { get; set; } = Guid.NewGuid().ToString();
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Sex { get; set; }
            public string Image { get; set; }
            public string Email { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string UserType { get; set; }
            public string PhoneNo { get; set; }
            public string Password { get; set; }
            public bool Active { get; set; } = true;
            public string SecretKey { get; set; }
            public DateTime? JoiningDate { get; set; }
            public DateTime? TokenLastRequest { get; set; }
            public int Token { get; set; }
            public string Address { get; set; }
        }
}
