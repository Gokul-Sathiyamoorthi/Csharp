using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationAssignment
{
    class BeneficiariesDetail
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long Number { get; set; }
        public string Gender { get; set; }
        public int RegistrationNo { get; set; }


        public string City { get; set; }
        public int Id = 105;
        public int ListIncrementer = 0;
        public List<BeneficiariesDetail> VaccinationList = new List<BeneficiariesDetail>(1);
        public BeneficiariesDetail()
        {

            
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your mobile number:");
            Number = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Gender:");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            City = Console.ReadLine();
            


            this.Name = Name;
            this.Number = Number;
            this.Age = Age;
            this.Gender = Gender;
            this.City = City;
            this.RegistrationNo = RegistrationNo;
        }
        public BeneficiariesDetail(int id)
        {
            ListIncrementer++;
            BeneficiariesDetail[] List = new BeneficiariesDetail[100];
            VaccinationList.Add(List[ListIncrementer]);
            for (int i = 0;i < List.Length; i++)
            {
                Console.WriteLine("Name:", this.Name[i]);
                Console.WriteLine("Number:", this.Number);
                Console.WriteLine("Age:", this.Age);
            }
            
        }
        public void Detail()
        {
            
            
        }
        public void showDetail()
        {
            
            
        }
    }
}
