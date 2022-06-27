Console.Write("Введите число: ");
		string NumberA = Console.ReadLine();
		int NumA = Int32.Parse(NumberA);
		if ( NumA % 2 == 0)
		{
			Console.WriteLine("Заданное число является четным");
		}
		else
		{
			Console.WriteLine("Заданное число не является четным");
		}

