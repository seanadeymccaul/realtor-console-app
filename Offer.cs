using System;
using System.Collections.Generic;
using System.Text;

namespace CAB201_Assignment
{
	class Offer
	{
		public string offerName;
		public int offerPrice;
		public int propertyID;

		public Offer(string offerName, int offerPrice)
		{
			this.offerName = offerName;
			this.offerPrice = offerPrice;
		}

		public void SubmitOffer(int propertyID)
		{
			foreach (Customer customer in Customer.Data) 
			{
				foreach (Property property in customer.property)
				{
					foreach (Offer offer in property.offerList)
					{
						if (property.propertyID == propertyID)
						{
							property.offerList.Add(new Offer(Customer.currentCustomer.name, this.offerPrice));
							Console.WriteLine($"New offer made by {property.offerList[0].offerName}"); Console.ReadLine();
						}
					}
				}

			}
			
		}
	}
}
