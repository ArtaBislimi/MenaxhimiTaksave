using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiTaksit.BO;

namespace MenaxhimiTaksit.BO
{
    public class Car:BaseObject
    {
        public int Car_ID { get; set; }
        public string Registration { get; set; }
        public string Firm { get; set; }
        public DateTime Yearofmanufacture { get; set; }
        public DateTime date { get; set; }
        public int Power { get; set; }
        public bool Status { get; set; }

    }
}
