using System;
using System.Collections.Generic;
using System.Text;

namespace CAB201_Assignment
{
	class Property
	{
		public int propertyID;
		public string type;		// property class fields
		public string address;
		public string postcode;
		public string info;
		public List<Offer> offerList;

		public static List<Property> currentProperty		// return a list instance of the current customer properties
		{
			get { return Customer.currentCustomer.property; }
		}

		int i = 0;
		public Property(string postcode = null, string type = null, string address = null, string info = null) // property constructor
		{
			this.propertyID = i++;
			this.type = type;
			this.address = address;
			this.postcode = postcode;
			this.info = info;
			this.offerList = new List<Offer>();
		}

		public void CheckListings() // check listings by current user
		{
			Console.Write($"\n  > Your Active Listings: {currentProperty.Count}");
			foreach (Property property in currentProperty)
			{
				Console.Write($"\n\n  > Listing #: {property.propertyID}\tProperty Type: {property.type}\n    Address: {property.address}\tPO: {property.postcode}\n    Info: {property.info}");
			}
		}

		public void SearchListings()		// search all property by post code
		{
			foreach (Customer customer in Customer.Data)
			{
				foreach (Property property in customer.property)
				{
					if (this.postcode == property.postcode)
					{
						Console.Write($"\n  > PropertyID: {property.propertyID}  > Lister: {customer.name}\tProperty Type: {property.type}\n    Address: {property.address}\tPO: {property.postcode}\n    Info: {property.info}\n");
					}
					else
					{
						Console.Write("not detected"); Console.ReadLine();
					}
				}
			}
		}

		public void ListProperty()		//Add a new property
		{
			currentProperty.Add(new Property(this.postcode, this.type, this.address, this.info));
		}

	}
}
