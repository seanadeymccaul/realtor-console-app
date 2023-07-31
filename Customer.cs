using System;
using System.Collections.Generic;
using System.Text;

namespace CAB201_Assignment
{
	class Customer
	{
		public string email;		// customer class fields
		public string name;
		public Login login;
		public List<Property> property;
		public List<Transaction> transaction;

		public static List<Customer> Data = new List<Customer>();     // main list to store object data
		 
		public static Customer currentCustomer 	// a variable instance of the Customer session
		{
			get { return Data[Login.LoginStatus]; }
		}

		public Customer(string email,  string fullName, string password)	// customer constructor
		{
			this.email = email;
			this.name = fullName;
			this.login = new Login(email, password);
			this.property = new List<Property>();
			this.transaction = new List<Transaction>();
		}

		public void RegisterCustomer()		// save the customer from database
		{
			Data.Add(new Customer(this.email, this.name, this.login.password));
		}

	}
}
