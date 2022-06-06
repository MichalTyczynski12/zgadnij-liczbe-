using System;

public class Program
{
	public static void Main()
	{
		Random rnd = new Random();
		int liczbaSzukana = rnd.Next(1, 11); // liczba losowa od 1 do 10

		while (true)
		{
			Console.Write("Wpisz liczbe: ");
			int liczba = int.Parse(Console.ReadLine());
			if (liczba == liczbaSzukana)
            {
				Console.Write("gratulacje zgadłeś liczbę");
				break;
			}
            else if(liczba < liczbaSzukana)
            {
				Console.Write("Liczba szukana jest wieksza!\n");
			}
            else
            {
				Console.Write("Liczba szukana jest mniejsza!\n");
			}


		}

	}
}