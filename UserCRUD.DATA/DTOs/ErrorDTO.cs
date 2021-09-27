using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCRUD.DATA.DTOs
{
    public class ErrorDTO
    {
        public ErrorDTO()
        {
            Errors = new List<string>();
        }

        public List<String> Errors { get; set; }
        public int Status { get; set; }
    }
}
