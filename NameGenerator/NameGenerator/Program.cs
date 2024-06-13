class Program
{
	static void Main()
	{
		Console.WriteLine("Random Indian Names Generator");

		int numberOfNames = 4200;
		Random random = new Random();

		for (int i = 1; i <= numberOfNames; i++)
		{
			string prefix = GetRandomElement(Prefixes, random);
			string firstName = GetRandomElement(FirstNames, random);
			string middleName = GetRandomElement(MiddleNames, random);
			string lastName = GetRandomElement(LastNames, random);

			Console.WriteLine($" \t{prefix}\t{firstName}\t{middleName}\t{lastName}");
		}

		Console.ReadLine();
	}

	static string GetRandomElement(string[] array, Random random)
	{
		int index = random.Next(array.Length);
		return array[index];
	}

	static string[] Prefixes = { "Mr.", "Ms.", "Mrs." };
	static string[] FirstNames = { "Aarav", "Riya", "Aditya", "Ananya", "Arjun", "Saanvi", "Vihaan", "Zara", "Advait", "Ishaan" };
	static string[] MiddleNames = { "A.", "R.", "S.", "L.", "J.", "M.", "N." };
	static string[] LastNames = { "Patel", "Sharma", "Singh", "Gupta", "Verma", "Desai", "Joshi", "Khan", "Mehta", "Bansal" };
}