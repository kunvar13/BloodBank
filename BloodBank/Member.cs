using System;
using System.Collections.Generic;
using System.Text;

namespace BloodBank
{
    public abstract class Member
    {
        public Member(string FirstName, string LastName, BloodType MemberBloodType, DateTime DateOfBirth)
        {
            /* FirstName = firstName;
             LastName = lastName;
             MemberBloodType = memberBloodType;
             DateOfBirth = dateOfBirth;*/
            firstName = FirstName;
            lastName = LastName;
            memberBloodType = MemberBloodType;
            dateOfBirth = DateOfBirth;
            Id = Guid.NewGuid();
            

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public BloodType memberBloodType { get; set; }
        public DateTime dateOfBirth { get; set; }

        public Guid Id { get; set; }
        public string FullName
        {
            get
            {
                return firstName + "," + lastName;

            }
        }

        public abstract void SendUpdate();


        public abstract string GetDetail();
       
        
    }


}
