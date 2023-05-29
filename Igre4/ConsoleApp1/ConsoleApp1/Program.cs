using System.Security.Authentication.ExtendedProtection;
/*
 	int godina = int.Parse(Console.ReadLine());
	if(godina >= 18)
		Console.WriteLine("Osoba je punoletna.");
	else
		Console.WriteLine("Osoba je maloletna.");
    Console.ReadKey();*/
double popust = 0;
int knjiga = int.Parse(Console.ReadLine());
if (knjiga == 1)
    popust = 0.20;
else if (knjiga == 2)
    popust = 0.25;
else if (knjiga == 3)
    popust = 0.30;
else if (knjiga >= 4)
    popust = 0.35;
for (int i = 0; i < knjiga; i++)
{
    Console.WriteLine("Unesite cenu knjige: ");
    int cena = int.Parse(Console.ReadLine());
    Console.WriteLine("Cena knjige je: " + (cena - (cena * popust)));
}
