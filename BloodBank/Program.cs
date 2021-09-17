using System;

namespace BloodBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var DonorStorageArgs = new DonorList();
            var bloodBank = new Bloodbank(DonorStorageArgs);

           

            while(true)
            {
                Console.WriteLine("Please choose from following \n Choose D to Donate \n " +
                    "Choose R to receive \n Choose U to Update \n Choose Q to Quit \n Choose P to PrintDetails");
                string userInput = Console.ReadLine();

                if (userInput == "D")
                {
                    Console.WriteLine("Enter the Member ID");
                    var DonorId = Console.ReadLine();
                    try
                    {
                        Guid DonorIdGuid = Guid.Parse(DonorId);
                        Donation donation =  bloodBank.MakingDonation(DonorIdGuid);
                        Console.WriteLine($"The Donation Id is {donation.DonationId}");

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine($"Exception handeled{e.Message}");
                    }
                    
                }

                if (userInput == "R")
                {
                    bloodBank.ReceivingDonation();
                }

                if (userInput == "U")
                {
                    bloodBank.Update();
                }

                if (userInput == "P")
                {
                    string detail = bloodBank.GetMemberDetails();
                    Console.WriteLine(detail);

                    
                }

                if(userInput == "Q")
                {
                    break;
                }

            }
        }
    }
}
