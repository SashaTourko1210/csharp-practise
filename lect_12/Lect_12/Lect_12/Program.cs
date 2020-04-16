using System;

namespace Lect_12
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Start numer : ");

			int num = Convert.ToInt32(Console.ReadLine());

			if (num != 0)
			{
				UniqueItem.id = num;
			}

			UniqueItem uniq1 = new UniqueItem();
			UniqueItem uniq2 = new UniqueItem();
			UniqueItem uniq3 = new UniqueItem();
			UniqueItem uniq4 = new UniqueItem();

			UniqueItem.Count();
		}

		 class UniqueItem
		{
			public static int id = 0;
			public UniqueItem()
			{
				id++;
			}
			public static void Count()
			{
				Console.WriteLine($"Count: {id} id");
			}
		}
	}
}
