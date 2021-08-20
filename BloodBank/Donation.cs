using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    class Donation
    {
        public Donation()
        {
            DonationId = Guid.NewGuid();

        }

        public Guid DonationId { get; set; }


    }
}
