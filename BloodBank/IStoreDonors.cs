using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public interface IStoreDonors
    {
        void createDonor(Donor _DonorCreated);
      
        Donor getDonor(Guid getId);
       
    }
}
