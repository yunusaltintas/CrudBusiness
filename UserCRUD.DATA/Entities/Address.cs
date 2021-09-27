using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.DATA.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public int GeoID { get; set; }
        public virtual Geo Geo { get; set; }
    }
}
