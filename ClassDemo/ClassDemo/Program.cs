﻿
using System;

namespace ClassDemo
{
	class Staff
	{
		private string nameOfStaff;
		private const int hourlyRate = 30;
		private int hWorked;

		public Staff(string name)
		{
			nameOfStaff = name;
			Console.WriteLine("\n" + nameOfStaff);
			Console.WriteLine("--------------------------");
		}
  

        public int HoursWorked
		{
			get
			{
				return hWorked;	
			}
			set
			{
				if (value > 0)
					hWorked = value;
				else
					hWorked = 0;
            }
		}
		// public int HoursWorked { get; set; } 
		// shorthand for setting the private field
        public void PrintMessage()
		{
			Console.WriteLine("Calculating pay...");
		}

        public int CalculatePay()
		{
			PrintMessage();
			int staffPay;
			staffPay = hWorked * hourlyRate;

			if (hWorked > 0)
				return staffPay;
			else
				return 0;
		}

        public int CalculatePay(int bonus, int allowance)
		{
			PrintMessage();
			if (hWorked > 0)
				return hWorked * hourlyRate + bonus + allowance;
			else
				return 0;
		}

        public override string ToString()
		{
			return "Name of staff = " + nameOfStaff + ", hourlyRate = "
				+ hourlyRate + ", hWorked = " + hWorked;
		}
	}
    class Program
    {
        static void Main()
        {
			int pay;
			Staff staff1 = new Staff("Peter");
			staff1.HoursWorked = 160;
			pay = staff1.CalculatePay(1000, 400);
			Console.WriteLine("Pay = {0}", pay);

			Staff staff2 = new Staff("Jessie");
			staff2.HoursWorked = -50;
			pay = staff2.CalculatePay();
			Console.WriteLine("pay = {0}", pay);
        }
    }
}
