using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            

            string userChoice = "";
            int RegistrationNo = 1155;
            List<int> IdList = new List<int>(1150);
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Beneficiaries Registration \n2.Vaccination \n3.Exit \n4.BeneficiariesList");
                Console.WriteLine("----------------------------------");
                int Choice = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------");

                if (Choice < 5)
                {
                    switch (Choice)
                    {
                        case 1:
                            //Beneficiaries Registration
                            BeneficiariesDetail bd = new BeneficiariesDetail();
                            RegistrationNo++;
                            Console.WriteLine($"Your registration Id is {RegistrationNo}");
                            IdList.Add(RegistrationNo);
                            break;

                        case 2:
                            //Vaccination
                            Console.WriteLine("Enter the registration no:");
                            int regNo = int.Parse(Console.ReadLine());
                            if (IdList.Contains(regNo))
                            {
                                Console.WriteLine("Enter your choice:");
                                //Console.WriteLine("1.Take Vaccination \n2.Vaccination history \n3.Next Duedate \n4.Exit");
                                //int vaccChoice = int.Parse(Console.ReadLine());
                                //switch (vaccChoice)
                                //{
                                //    case 1:
                                //        VaccineDetails vd = new VaccineDetails();
                                //        break;
                                //    case 2:
                                        
                                //        break;
                                //    case 3:
                                //        break;
                                //    case 4:
                                //        break;
                                //}
                                
                                
                            }
                            else
                            {
                                Console.WriteLine("Register not found");
                                Console.WriteLine("You have to register first");

                            }
                            break;

                        case 3:
                            //Exit

                            break;

                        case 4:
                            //Vaccinalation list
                            Console.WriteLine(IdList.Count);
                            foreach (var i in IdList)
                            {
                                BeneficiariesDetail bD = new BeneficiariesDetail(i);
                                Console.WriteLine(i);
                                //TODO : have to call the showDetail() method from other class which have constructor :(
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid data...Please enter corresponding number:");
                }
                
                
            } while (userChoice != "no");
            
        }
    }
}
