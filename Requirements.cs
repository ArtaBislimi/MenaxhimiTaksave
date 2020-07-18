using MenaxhimiTaksit.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.Export;

namespace MenaxhimiTaksit.BO
{
    public class Requirements:BaseObject
    {
        public static int ID { get; set; } 
        public string User_ID { get; set; }
        public int Role_ID { get; set; }
        public string DepaturePlace { get; set; }
      
        public DateTime Day { get; set; }
        public string SpecialRequirements { get; set; }
        public decimal Price { get; set; }

       
    }
}
