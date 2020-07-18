using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiTaksit.BO
{
    public class BaseObject
    {
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int LastUpdateBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int LastUpdateNo { get; set; }

    }
}
