using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakediş
{
   public class UpdateMail
    {
        public string ToEmail { get; set; }
        public String UpdateDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
