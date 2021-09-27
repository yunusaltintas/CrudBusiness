using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UserCRUD.Core.Attiributes;

namespace UserCRUD.Core.Extensions
{
    public static class AttributeExtensions
    {
        public static string GetStringValue(this Enum value)
        {
            Type type = value.GetType();

            FieldInfo fieldInfo = type.GetField(value.ToString());

            StringEnumAttribute[] attribs = fieldInfo.GetCustomAttributes(
                typeof(StringEnumAttribute), false) as StringEnumAttribute[];

            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
    }
}
