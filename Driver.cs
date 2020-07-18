using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiTaksit.BO
{
    public class Driver:BaseObject
    {
        public int Driver_ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public User User_ID { get; set; }


    }
}
