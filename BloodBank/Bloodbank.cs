using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class Bloodbank
    {
        public Bloodbank()
        {
            _members = new List<Member>();
            _donor = new List<Donor>();
            _receiver = new List<Receiver>();
            _donation = new List<Donation>();

            Donor FirstDonor = new Donor("Kalpesh", "Kunvar", abPos, new DateTime(1987, 05, 18), new DateTime(2021, 01, 01), 2);
            Console.WriteLine(FirstDonor.Id);
            Donor SecondDonor = new Donor("Mayur", "Chavda", abNeg, new DateTime(1989, 09, 30), new DateTime(2020, 01, 01), 3);
            Receiver FirstReceiver = new Receiver("Gayatri", "Kunvar", abNeg, new DateTime(1990, 02, 01), new DateTime(2020, 01, 01));

            _donor.Add(FirstDonor);
            _donor.Add(SecondDonor);
            _receiver.Add(FirstReceiver);

        }

        private List<Member> _members;
        private List<Donor> _donor;
        private List<Receiver> _receiver;
        private List<Donation> _donation;
        
        
        BloodType abPos = new BloodType("AB", '+');
        BloodType abNeg = new BloodType("AB", '-');
        BloodType OPos = new BloodType("O", '+');
        BloodType ONeg = new BloodType("O", '-');

        
        public void MakingDonation(Guid DonorId)
            
        {
            Donor _Donor = null;

            for (int i = 0; i < _donor.Count; i++)
            {


                if (_donor[i].Id == DonorId)
                {
                    Console.WriteLine($"Found the Donor {_donor[i].FullName}");
                    Donation _donation = new Donation();
                    string detailOfDonation = "";
                    detailOfDonation += $"Donation Id is {_donation.DonationId} \n";
                    detailOfDonation += $" Donor - {_donor[i].FullName} made a donation \n";
                    detailOfDonation += $" Bloodgroup {_donor[i].memberBloodType.bloodGroup} \n";
                    detailOfDonation += $"Time {_donor[i].lastDonated} \n";
                    _donor[i].Donorupdate();
                    Console.WriteLine(detailOfDonation);


                }

                else
                {

                    Console.WriteLine($"Donor with {DonorId} not found");

                }
            }
            




            




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
