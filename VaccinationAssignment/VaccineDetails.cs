using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationAssignment
{
    class VaccineDetails
    {
        public int Dosage { get; set; } //To Calulate the Number of Dose

        public string VaccinatedDate { get; set; } 


        List<VaccineDetails> vacDetailList = new List<VaccineDetails>(1);
        public VaccineDetails()
        {
            
            
            Console.WriteLine("1.CoviShield \n2.Covaccine \n3.Sputnik");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                
                if(Dosage == 1)
                {

                    Console.WriteLine($"You are successfully vaccinated second dosage of {Type.Covishield} in(mm/dd/year): {DateTime.Now}");
                    Console.WriteLine("You have completed the vaccination course.");

                    
                }
                else if (Dosage == 0)
                {
                    
                    Dosage++;
                    
                    Console.WriteLine($"You are successfully vaccinated first dosage of {Type.Covishield} in (mm/dd/year): {DateTime.Now}");
                    var dueDate = DateTime.Now.AddDays(30);
                    Console.WriteLine($"DueDate for the next dose is {dueDate}");
                }
               

            }
            else if(type == 2)
            {
                if (Dosage == 0)
                {
                    //BeneficiariesDetail benfitiories = new BeneficiariesDetail();
                    

                    Console.WriteLine($"You are successfully vaccinated first dosage of {Type.Covaccine} in(mm/dd/year): {DateTime.Now}");
                    var dueDate = DateTime.Now.AddDays(30);
                    Console.WriteLine($"DueDate for the next dose is (mm/dd/year):{dueDate}");
                }
                if (Dosage == 1)
                {
                    //BeneficiariesDetail benfitiories = new BeneficiariesDetail();
                    Console.WriteLine($"You are successfully vaccinated second dosage of {Type.Covaccine} in(mm/dd/year): {DateTime.Now}");
                    var dueDate = DateTime.Now.AddDays(30);
                    Console.WriteLine($"DueDate for the next dose is(mm/dd/year): {dueDate}");
                }
            }
            else if(type == 3)
            {
                if (Dosage == 0)
                {
                    //BeneficiariesDetail benfitiories = new BeneficiariesDetail();
                    
                   
                    Console.WriteLine($"You are successfully vaccinated first dosage of {Type.Sputnik} in {DateTime.Now}");
                    var dueDate = DateTime.Now.AddDays(30);
                    Console.WriteLine($"DueDate for the next dose is (mm/dd/year): {dueDate}");

                }
                if (Dosage == 1)
                {
                    
                    Console.WriteLine($"You are successfully vaccinated second dosage of {Type.Sputnik} in {DateTime.Now}");
                    var dueDate = DateTime.Now.AddDays(30);
                    Console.WriteLine($"DueDate for the next dose is (mm/dd/year):{dueDate}");
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

        }
        
        //enum for covaccination type
        public enum Type
        {
            Covishield,
            Covaccine,
            Sputnik
        }
        
    }
}
