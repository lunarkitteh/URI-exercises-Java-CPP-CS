using System;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int z = int.Parse(Console.ReadLine());
			Console.WriteLine(z);
			int a = (int)z / 100;


			// NOTE :
			// 	if (a >= 1) to check if the number of note is not 0 , if true, then execute z -= a * 100
			// if it false then it will print "0 nota(s) de R$ x"


			if (a >= 1)
			{
				z -= a * 100;
			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", a, 100);
			int z1 = (int)z / 50;
			if (z1 >= 1)
			{
				z -= (z1 * 50);

			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", z1, 50);

			int z2 = (int)z/ 20;
			if (z2 >= 1)
			{
				z -= (z2 * 20);


			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", z2, 20);

			int z3 = (int)z / 10;
			if (z3 >= 1)
			{
				z -= (z3 * 10);


			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", z3, 10);

			int z4 = (int)z / 5;
			if (z4 >= 1)
			{
				z -= (z4 * 5);

			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", z4, 5);

			int z5 = (int)z / 2;
			if (z5 >= 1)
			{
				z -= (z5 * 2);
			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", z5, 2);

			int z6 = (int)z / 1;
			if (z6 >= 1)
			{
				z -= (z6 * 1);
			}
			Console.WriteLine("{0} nota(s) de R$ {1},00", z6,1);




			int x11 = int.Parse(Console.ReadLine());
			int x10 = x11 / 100;
			x11 -= (x10 * 100); // to substract the input by each 'notes'
			Console.WriteLine("{0} nota(s) de R$ {1}", x10,100);
			Console.WriteLine("x11 = " + x11 );
			int x12 = x11 / 50;
			x11 -= (x12 * 50); // to substract the input by each 'notes'
			Console.WriteLine("{0} nota(s) de R$ {1}", x12, 50);
			Console.WriteLine("x11 = " + x11 );




		}
	}
}
