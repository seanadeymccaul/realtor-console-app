using System;
using System.Collections.Generic;
using System.Text;

namespace CAB201_Assignment
{
	class Transaction
	{
		private string transactionName;
		public string TransactionName
		{
			get { return transactionName; }
			set { transactionName = value; }
		}

		public Transaction(string transactionName)
		{
			this.transactionName = transactionName;
		}
	}
}
