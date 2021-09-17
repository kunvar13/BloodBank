using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class Donation
        {
      
       public Guid DonationId { get; set; }

        public Donor _donor {get; set;}

        public DateTime lastDonated { get; set; }


    }
}
