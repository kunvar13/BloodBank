using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class Donor : Member
    {
        public Donor(string FirstName, string LastName, BloodType MemberBloodType, DateTime DateOfBirth, DateTime LastDonated, int numberOfTimesDonated)
            :base (FirstName, LastName,MemberBloodType , DateOfBirth)
        {
            LastDonated = DateTime.MinValue;
            NumberOfTimesDonated = numberOfTimesDonated;
        }

        public DateTime lastDonated { get; private set; }

        public int NumberOfTimesDonated { get; private set; }

        public void Donorupdate ()
        {
            if ((DateTime.Now - lastDonated).Days < 40)
            {
                throw new Exception("\n Donor cant donate the blood yet");
            }

            lastDonated = DateTime.Now;
            NumberOfTimesDonated++;
                
            
            

            

        }

        public override void SendUpdate()
        {
            Console.WriteLine($"Hello {FullName} the last time you donated blood is{lastDonated} \n" +
                $"So far you have donated {NumberOfTimesDonated}");
        }

        public override string GetDetail()
        {
            string Detail = "Hello Donor";

            Detail += $"Name of the donor {FullName}\n";
            Detail += $"Member Blood group {memberBloodType.bloodGroup + memberBloodType.sign}\n";
            Detail += $"Numbe rof times donated {NumberOfTimesDonated}\n";


            return Detail;
        }




    }
}
