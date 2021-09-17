using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class Bloodbank
    {
        public Bloodbank(IStoreDonors DonorStorageArgs)
        {
            _donorstorage = DonorStorageArgs;
            _members = new List<Member>();
            _donorstorage = new DonorList();
            _receiver = new List<Receiver>();
            _donation = new List<Donation>();

            Donor FirstDonor = new Donor("Kalpesh", "Kunvar", abPos, new DateTime(1987, 05, 18), new DateTime(2021, 01, 01), 2);
            Console.WriteLine(FirstDonor.Id);
            Donor SecondDonor = new Donor("Mayur", "Chavda", abNeg, new DateTime(1989, 09, 30), new DateTime(2020, 01, 01), 3);
            Receiver FirstReceiver = new Receiver("Gayatri", "Kunvar", abNeg, new DateTime(1990, 02, 01), new DateTime(2020, 01, 01));

            _donorstorage.createDonor(FirstDonor);
            _donorstorage.createDonor(SecondDonor);
            _receiver.Add(FirstReceiver);
                                    
            


        }

        private List<Member> _members;
        private IStoreDonors _donorstorage;
        private List<Receiver> _receiver;
        private List<Donation> _donation;
        
        
        BloodType abPos = new BloodType("AB", '+');
        BloodType abNeg = new BloodType("AB", '-');
        BloodType OPos = new BloodType("O", '+');
        BloodType ONeg = new BloodType("O", '-');

        
        public Donation MakingDonation (Guid DonorId)
            
        {
            var _Donor = _donorstorage.getDonor(DonorId);

                Donation newDonation = new Donation()
                {
                    DonationId = Guid.NewGuid(),
                    lastDonated = DateTime.Now,
                    _donor = _Donor

                };

                //Storing the Donation

                _donation.Add(newDonation);

                return newDonation;
            

            

        }

        public void ReceivingDonation()
        {
            
        }


        public void Update()
        {
            for (int i =0; i <_members.Count; i++)
            {
                var nextmember = _members[i];
                nextmember.SendUpdate();
            }
        }

        public string GetMemberDetails()
        {
            string fullmemberDetail = "";

            for (int i =0; i<_members.Count; i++)
            {
                var _nextmember = _members[i];
                fullmemberDetail += _nextmember.GetDetail() + "\n";

             }
            return fullmemberDetail;
        }
    }

}
