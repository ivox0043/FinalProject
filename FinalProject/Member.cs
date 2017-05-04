using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        //public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }
        public int TelNumber {get; set;}
        public string Address { get; set; }
        public Boolean FighterStatus { get; set; }
        public int ProW { get; set; }
        public int ProL { get; set; }
        public int ProD { get; set; }
        public int AmW { get; set; }
        public int AmL { get; set; }
        public int AmD { get; set; }
        
        



        public Member // Member object constructor
            (
                   string firstName, string lastName, string nickName,
                   string nationality, string email,
                   /*DateTime dateOfBirth,*/ int age, double weight,
                   int telNumber, Boolean fighterStatus,
                   int proW, int proL, int proD,
                   int amW, int amL, int amD, string address
            )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.NickName = nickName;
            this.Nationality = nationality;
            this.Email = email;
            //this.DateOfBirth = dateOfBirth;
            this.Age = age;
            this.Weight = weight;
            this.TelNumber = telNumber;
            this.FighterStatus = fighterStatus;
            this.ProW = proW;
            this.ProL = proL;
            this.ProD = proD;
            this.AmD = amW;
            this.AmL = amL;
            this.AmD = amD;
            this.Address = address;
        }
    } 
    
}
