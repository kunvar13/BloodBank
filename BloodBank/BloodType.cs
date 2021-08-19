using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class BloodType
    {
        public BloodType(string BloodGroup, char Sign)
        {
            bloodGroup = BloodGroup;
            sign = Sign;
        }


        public string bloodGroup { get; set; }
        public char sign { get; set; }
      
    }
}
