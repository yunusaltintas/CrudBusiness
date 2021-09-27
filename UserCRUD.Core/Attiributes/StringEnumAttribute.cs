using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.Core.Attiributes
{
    public class StringEnumAttribute : System.Attribute
    {
        public StringEnumAttribute(string value) => this.StringValue = value;

        public string StringValue { get; protected set; }
    }
}
