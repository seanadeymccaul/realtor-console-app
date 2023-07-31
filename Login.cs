using System;
using System.Collections.Generic;
using System.Text;

namespace CAB201_Assignment
{
	class Login
	{
		public static int LoginStatus = -1;
		public string email;
		public string password;
		
		public Login(string email, string password)
		{
			this.email = email;
			this.password = password;
		}

		public bool AuthenticateLogin()
		{
			for (int i = 0; i < Customer.Data.Count; i++)
			{
				if ((this.email == Customer.Data[i].login.email) && 
					(this.password == Customer.Data[i].login.password))
				{
					LoginStatus = i;
					return true;
				}
			}
			LoginStatus = -1;
			return false;
		}
	}
}
