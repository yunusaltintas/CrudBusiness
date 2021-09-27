using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.DATA.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public AddressDTO AddressDto { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public CompanyDTO CompanyDto { get; set; }
    }
}
