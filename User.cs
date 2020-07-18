using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiTaksit.BO
{
    public class User : BaseObject
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
         public DateTime ExpiresDate  { get; set; }
        
        public virtual Role Role { get; set; }
    }
}

//ne disa raste duhet me kriju class-function, class -procedure