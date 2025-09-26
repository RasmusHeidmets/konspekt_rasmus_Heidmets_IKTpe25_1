
////1. tuvasta sisu võdluses tühja stringiga, string andmetüüp
//using System.ComponentModel.Design;

//Console.WriteLine("tere kasutaja, kuidas on sinu nimi?:");
//string nimi = Console.ReadLine();

//if (nimi =="")
//{
//    Console.WriteLine("sa ei sisestanud oma nime, sadface🤬");
//}
//else if (nimi !="")
//{
//    Console.WriteLine("tere" + nimi + "! happy face 🤣");
//}
//else
//{
//    Console.WriteLine("tundmatu sisestus.");
//}
////2 - vahemikud
//Console.WriteLine(nimi + ", mis on sinu vanus?:");
//int kasutajavanus = int.Parse(Console.ReadLine());
////2.1 miitu tingimust pesastatud ifide abil
//if (kasutajavanus < 18)
//{
//    Console.WriteLine("ei saa täna juua😊");
//}
//else
//{
//    Console.WriteLine("saad juua");
//}

////2.3 mitu vahemikku is/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"sisesta oma pikkus ka {nimi}!");
//double kasutajapikkus = double.Parse(Console.ReadLine());

//if (kasutajapikkus < 1.00d)
//{
//    Console.WriteLine("oled juntsu");
//}
//else if (kasutajapikkus < 1.25d && kasutajapikkus >= 1.00d)
//{
//    Console.WriteLine("oled peaaegu allameetri mees");
//}
//else if (kasutajapikkus < 1.50d && kasutajapikkus >= 1.25d)
//{
//    Console.WriteLine("läheb paremaks");
//}
//else if (kasutajapikkus < 1.75d && kasutajapikkus >= 1.50d)
//{
//    Console.WriteLine("tuff");
//}
//else if (kasutajapikkus < 2.00d && kasutajapikkus >= 1.75d)
//{
//    Console.WriteLine("oi kui suur sa oled");
//}
//else
//{
//    Console.WriteLine("oi oi kui pikk");
//}
//int arv1 = 0;
//int arv2 = 0;
//Console.WriteLine("tere, palun sisestage esimene arv:");
//arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("sisestage teine arv: ");
//arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("missugust tehet soovid teha? kirjuta kas + - / * ^");
//string tehtetüüp = Console.ReadLine();
//int tehe = 0;

//if (tehtetüüp == "+" /* tingimus siia*/)

//{
//    tehe = arv1 + arv2;
//}
//if (tehtetüüp == "-"/* tingimus siia*/)

//{
//    tehe = arv1 - arv2;

//}
//if (tehtetüüp == "*"/* tingimus siia*/)

//{
//    tehe = arv1 * arv2;
//}
//if (tehtetüüp == "/"/* tingimus siia*/)
//{
//    tehe = arv1 / arv2;
//}
//if (tehtetüüp == "^"/* tingimus siia*/)
//{
//    tehe = (int)Math.Pow(arv1, arv2);
//}
//Console.WriteLine($"{tehtetüüp} tehte tulemus: {tehe}");

////4 parool, if ja string andmetüüp
//Console.WriteLine($"palun vabandust {nimi}, aga on vaja parooli");
//string password = Console.ReadLine();
//if (password == "parool1")
//{
//    Console.WriteLine("parool on õige");
//}
//else if (password == "saatana" || password == "1234")
//{
//    Console.WriteLine("parool on sobimatu");  
//}
//else
//{
//    Console.WriteLine("parool on vale");
//}

////5 värvituvastus
//Console.WriteLine("mis on sinu lemmik värv?:");
//    string favColour = Console.ReadLine();
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "sinine") 
//{
//        Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "kollane") 
//{
//        Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "roheline") 
//{
//        Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favColour == "must") 
//{
//        Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favColour == "helesinine") 
//{
//        Console.BackgroundColor = ConsoleColor.Cyan;
//}
//else if (favColour == "hall") 
//{
//        Console.BackgroundColor = ConsoleColor.Gray;
//}
//else if (favColour == "tumehall") 
//{
//        Console.BackgroundColor = ConsoleColor.DarkGray;
//}
//else if (favColour == "tumepunane") 
//{
//        Console.BackgroundColor = ConsoleColor.DarkRed;
//}
//else if (favColour == "lilla") 
//{
//        Console.BackgroundColor = ConsoleColor.Magenta;
//}
//else if (favColour == "tumelilla") 
//{
//        Console.BackgroundColor = ConsoleColor.DarkMagenta;
//}
//else if (favColour == "tumeroheline") 
//{
//        Console.BackgroundColor = ConsoleColor.DarkGreen;
//}
//else if (favColour == "tumekollane") 
//{
//        Console.BackgroundColor = ConsoleColor.DarkYellow;
//}
//else if (favColour == "valge") 
//{
//        Console.BackgroundColor = ConsoleColor.White;
//}
//else if (favColour == "roosa") 
//{
//    Console.WriteLine("seda värvi pole");
//}
//else if (favColour == "bruun") 
//{
//    Console.WriteLine("seda värvi pole");
//}
//else if (favColour == "kuldne") 
//{
//    Console.WriteLine("seda värvi pole");
//}
//else if (favColour == "oranz") 
//{
//    Console.WriteLine("seda värvi pole");
//}
//Console.WriteLine("värv on vist muutund!");

Console.WriteLine("Tere, kas te tahate mõõta pappkasti või õlitünni?");
string tehtetüüp = Console.ReadLine();
if (tehtetüüp == ("õlitünni"))
    {
    Console.WriteLine("kas te teate, mis on selle raadius või läbimõõt ");
}
else if (tehtetüüp == ("pappkasti"))
{
    Console.WriteLine("kas kast on kuubiku kujuline või risttahuka kujuline?");
}
