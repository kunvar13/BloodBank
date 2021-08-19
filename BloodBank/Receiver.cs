using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public class Receiver : Member
    {
        public Receiver(string FirstName, string LastName, BloodType MemberBloodType, DateTime DateOfBirth, DateTime LastReceiveddate) 
            :base(FirstName, LastName, MemberBloodType, DateOfBirth)
        {
            lastReceivedDate = DateTime.MinValue;

        }

        public DateTime lastReceivedDate { get; set; }

        public override void SendUpdate()
        {
            Console.WriteLine($"Hello {FullName} the last time you received blood is{lastReceivedDate}");
        }

        public override string GetDetail()
        {
            string Detail = "Hello Receiver";

            Detail += $"Name of the donor {FullName}\n";
            Detail += $"Member Blood group {memberBloodType.bloodGroup + memberBloodType.sign}\n";
            Detail += $"Last date you received {lastReceivedDate}\n";


            return Detail;
        }
    }
}
