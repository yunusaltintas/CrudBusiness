using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.DATA.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
