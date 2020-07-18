using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiTaksit.BO
{
     public class UserRole : BaseObject
    {
        public string UserRole_ID { get; set; }
        public User User_ID { get; set; }
        public  Role Role_ID { get; set; }
   
    }
}
