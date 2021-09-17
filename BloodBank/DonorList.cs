using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class DonorList : IStoreDonors
    {
        public DonorList()
        {
            _DonorList = new List<Donor>();
        }

        private List<Donor> _DonorList;
        
        public void createDonor(Donor _DonorCreated)
        {
            _DonorList.Add(_DonorCreated);

        }

        public Donor getDonor(Guid donorId)
        {
            Donor _Donor = null;

            for (int i = 0; i < _DonorList.Count; i++)
            {


                if (_DonorList[i].Id == donorId)
                {
                    Console.WriteLine($"Found the Donor {_DonorList[i].FullName}");
                    //Donation _donation = new Donation();
                    _Donor = _DonorList[i];
                    string detailOfDonation = "";
                    //detailOfDonation += $"Donation Id is {_donation.DonationId} \n";
                    detailOfDonation += $" Donor - {_DonorList[i].FullName} made a donation \n";
                    detailOfDonation += $" Bloodgroup {_DonorList[i].memberBloodType.bloodGroup} \n";
                    detailOfDonation += $"Time {_DonorList[i].lastDonated} \n";
                    _DonorList[i].Donorupdate();
                    Console.WriteLine(detailOfDonation);

                }

                if (_Donor == null)
                {

                    throw new Exception($"Donor with {donorId} not found");

                }


            }

            return _Donor;
        }

    }
}
