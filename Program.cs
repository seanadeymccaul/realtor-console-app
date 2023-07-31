using System;
using System.Collections.Generic;
using System.Text;

namespace CAB201_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();  Console.WriteLine(@$"Logged Out											
	   ____    _    ____ ____   ___  _     ____            _ _             ____            _                 
	  / ___|  / \  | __ )___ \ / _ \/ |   |  _ \ ___  __ _| | |_ _   _    | __ ) _ __ ___ | | _____ _ __ ___ 
	 | |     / _ \ |  _ \ __) | | | | |   | |_) / _ \/ _` | | __| | | |   |  _ \| '__/ _ \| |/ / _ \ '__/ __|
	 | |___ / ___ \| |_) / __/| |_| | |   |  _ <  __/ (_| | | |_| |_| |   | |_) | | | (_) |   <  __/ |  \__ \
	  \____/_/   \_\____/_____|\___/|_|   |_| \_\___|\__,_|_|\__|\__, |   |____/|_|  \___/|_|\_\___|_|  |___/
	                                                             |___/                                       ");
				Console.Write("1 > Register\n2 > Login\n\n  > Selected Input: "); int userInput = int.Parse(Console.ReadLine());
				switch (userInput)
				{
					case 1:
						Console.Write("\n  > Register Name: "); string fullName = Console.ReadLine();
						Console.Write("\n  > Register Email: "); string email = Console.ReadLine();
						Console.Write("\n  > Register Password: "); string password = Console.ReadLine();
						new Customer(email, fullName, password).RegisterCustomer(); // registers a customer object to the database
						break;
					case 2:
						Console.Write("\n  > Login Email: "); email = Console.ReadLine();
						Console.Write("\n  > Login Password: "); password = Console.ReadLine();
						new Login(email, password).AuthenticateLogin(); // sets the current user
						break;
				}
				while (Login.LoginStatus != -1)
				{
					Console.Clear(); Console.WriteLine(@$"Logged in as {Customer.currentCustomer.name}
	   ____    _    ____ ____   ___  _     ____            _ _             ____            _                 
	  / ___|  / \  | __ )___ \ / _ \/ |   |  _ \ ___  __ _| | |_ _   _    | __ ) _ __ ___ | | _____ _ __ ___ 
	 | |     / _ \ |  _ \ __) | | | | |   | |_) / _ \/ _` | | __| | | |   |  _ \| '__/ _ \| |/ / _ \ '__/ __|
	 | |___ / ___ \| |_) / __/| |_| | |   |  _ <  __/ (_| | | |_| |_| |   | |_) | | | (_) |   <  __/ |  \__ \
	  \____/_/   \_\____/_____|\___/|_|   |_| \_\___|\__,_|_|\__|\__, |   |____/|_|  \___/|_|\_\___|_|  |___/
	                                                             |___/                                       ");
					Console.Write("1 > Create Listing\n2 > View Listings\n3 > Search Properties\n4 > Make an Offer\n5 > Log Out\n\n  > Selected Input: ");
					userInput = int.Parse(Console.ReadLine());
					switch (userInput)
					{
						case 1:
							Console.Write("\n1 > Land\n2 > House\n\n  > Selected Input: "); userInput = int.Parse(Console.ReadLine());
							Console.Write("\n  > Street Address of Listing: "); string address = Console.ReadLine();
							Console.Write("\n  > Post Code of Listing: "); string postcode = Console.ReadLine();
							if (userInput == 1)
							{
								string type = "Land";
								Console.Write("\n  > Land Area (Sqm): "); string size = Console.ReadLine();
								new Property(postcode, type, address, size).ListProperty(); Console.Write("\n  > Listing Created Successfully (enter to return)"); Console.ReadLine();
							}
							else if (userInput == 2)
							{
								string type = "House";
								Console.Write("\n  > House Description: "); string description = Console.ReadLine();
								new Property(postcode, type, address, description).ListProperty(); Console.Write("\n  > Listing Created Successfully (enter to return)"); Console.ReadLine();
							}
							break;
						case 2:
							new Property().CheckListings(); Console.Write("\n\n  > Enter Listing # to Manage Offers (enter to return): "); Console.ReadLine();
							break; // make a respond to offer method of object offer here
						case 3:
							Console.Write("\n  > Search Post Code: "); postcode = Console.ReadLine();
							new Property(postcode).SearchListings(); Console.Write("\n  > Enter a Listing ID to Make an Offer (enter to return)"); userInput = int.Parse(Console.ReadLine());
							Console.WriteLine("enter a price: "); int price = int.Parse(Console.ReadLine());
							new Offer(Customer.currentCustomer.name, price).SubmitOffer(userInput);
							break; // make a create offer method of object offer here
						case 4:
							break; // view sales history here 'purhcased this property' or 'sold this property'
						case 5:
							Login.LoginStatus = -1;
							break;

					}
				}
			}
			

		}
	}
}