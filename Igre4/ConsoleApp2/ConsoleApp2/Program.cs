
bool uredu = false;
while(true)
{
    string n = Console.ReadLine();
    if(n != "kraj")
    {
        if (int.Parse(n) < 90)
        {
            uredu = false;
        }

    }
    else break;
}
if (uredu)
    Console.WriteLine("Nije potrebno ponoviti kontrolni");
else
    Console.WriteLine("Potrebno ponoviti kontrolni");
