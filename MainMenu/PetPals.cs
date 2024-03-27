using CodingChallenge.Models;
using CodingChallenge.Repositories;
using CodingChallenge.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

namespace CodingChallenge.MainMenu
{
    internal class PetPals
    {
        IAdoptableService adoptableService = new IAdoptableService();
        PetShelterService petShelterService = new PetShelterService();
        UserService usersService = new UserService();

        public void Handlemenu()
        {
            bool log = false;
            do
            {
                Console.WriteLine("\n1: Login\n2: Register\n3: Exit\n");
                Console.WriteLine("Enter your choice: ");
                int loginChoice = int.Parse(Console.ReadLine());

                switch (loginChoice)
                {
                    case 1:
                        Console.WriteLine("Enter username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string password = Console.ReadLine();
                        log = usersService.Login(username, password);
                        if (!log)
                        {
                            Console.WriteLine("Invalid username or password. Please try again.");
                            Console.WriteLine("Press any key to continue..");
                            Console.ReadKey(true);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter username: ");
                        string newUsername = Console.ReadLine();
                        Console.WriteLine("Enter password: ");
                        string newPassword = Console.ReadLine();
                        Users newUser = new Users() { Username = newUsername, Password = newPassword };
                        usersService.Register(newUser);
                        Console.WriteLine("Registration successfull. Please continue to Login");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        break;

                    case 3:
                        Console.WriteLine("Exiting....");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                        break;
                }
            } while (!log);

            MainMenu();
        }
        

        public void MainMenu()
        {
                PetShelterService petShelterService = new PetShelterService();
                IAdoptableService adoptableService = new IAdoptableService();
                bool exit = false;
                while (!exit)
                {
                    Console.Clear();
                    Console.WriteLine("Main Menu:");
                    Console.WriteLine("1. Add a pet");
                    Console.WriteLine("2. Remove a pet");
                    Console.WriteLine("3. List available pets");
                    Console.WriteLine("4. Record cash donation");
                    Console.WriteLine("5. Record item donation");
                    Console.WriteLine("6. Host adoption event");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter your choice: ");

                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter Pet Name:");
                                String p_name = Console.ReadLine();
                                Console.WriteLine("Enter species::");
                                String p_species = Console.ReadLine();
                                Console.WriteLine("Enter pet Age:");
                                int p_age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter pet breed::");
                                String p_breed = Console.ReadLine();
                                Console.WriteLine("Enter available status::");
                                int p_status = int.Parse(Console.ReadLine());
                                Pets pets = new Pets() { Name = p_name, Species = p_species, Age = p_age, Breed = p_breed, Available_status = p_status };
                                petShelterService.InsertPet(pets);
                                Console.WriteLine("Added successfully");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            break;
                            case 2:
                                Console.WriteLine("Enter Pet Id:");
                                int pid = int.Parse(Console.ReadLine()); 
                                
                                petShelterService.DeletePet(pid);
                                Console.WriteLine("Removed successfully");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            break;
                            case 3:
                                Console.WriteLine("Enter available status:");
                                int status = int.Parse(Console.ReadLine());
                                petShelterService.AvailablePets(status);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            break;
                
                                break;
                            case 4:
                                Console.Write("Enter donor's name: ");
                                string name = Console.ReadLine();
                                Console.Write("Enter donation amount: ");
                                decimal donationAmount = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Enter donation date (yyyy-MM-dd): ");
                                DateTime donationDate = Convert.ToDateTime(Console.ReadLine());
                                CashDonation donation = new CashDonation(name, donationAmount, donationDate);
                                IDonationRepository donationRepository = new IDonationRepository();

                                donationRepository.RecordDonation(donation);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            break;
                            case 5:
                                Console.WriteLine("Enter adoption status::");
                                String adop_status = Console.ReadLine();
                                adoptableService.EventHost(adop_status);
                                break;
                            case 6:
                                Console.WriteLine("Enter participant name::");
                                String pa_name = Console.ReadLine();
                                Console.WriteLine("Enter participant type::");
                                String pa_type = Console.ReadLine();
                                Console.WriteLine("Enter email");
                                String pa_email = Console.ReadLine();
                                Console.WriteLine("Enter phone number::");
                                String pa_phone = Console.ReadLine();
                                Console.WriteLine("Enter address::");
                                String pa_address = Console.ReadLine();
                                Console.WriteLine("Enter adopted id::");
                                int ad_id = int.Parse(Console.ReadLine());
                                Console.WriteLine( "Enter the adoption status::");
                                String ado_status = Console.ReadLine();
                                Console.WriteLine("Enter the date::");
                                DateTime pa_date = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the notes::");
                                String pa_notes = Console.ReadLine();
                                AdoptionEvent adoptionEvent = new AdoptionEvent() { ParticipantName = pa_name, ParticipantType = pa_type, ContactEmail = pa_email, ContactPhone = pa_phone, ParticipantAddress = pa_address, AdoptedPetID = ad_id, AdoptionStatus = ado_status, RegistrationDate = pa_date, Notes = pa_notes };
                                adoptableService.Addparticipant(adoptionEvent);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey(true);
                            break;
                            case 7:
                                exit = true;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }

                    Console.WriteLine();
                }
            }
        }
    }


           