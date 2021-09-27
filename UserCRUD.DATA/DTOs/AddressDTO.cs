using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.DATA.DTOs
{
    public class AddressDTO
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public GeoDTO GeoDto { get; set; }
    }
}
