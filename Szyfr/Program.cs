using System;
{
    char[] litery = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    Console.WriteLine("Podaj tekst który chcesz zaszyfrować:");
    string tekst = Console.ReadLine();

    Console.WriteLine("Podaj wartość przesunięcia:");
    int wartość = Convert.ToInt32(Console.ReadLine());

    char[] szyfr = tekst.ToCharArray();
    char[] szyfrowanie = new char[szyfr.Length];

    for (int i = 0; i < szyfr.Length; i++)
    {
        int x = Array.IndexOf(litery, szyfr[i]);
        int przesuniecie = (x += wartość);
        szyfrowanie[i] = litery[przesuniecie];
    }
    string zaszyfrowane = new string(szyfrowanie);
    Console.WriteLine("Szyfrowanie:");
    Console.Write(zaszyfrowane);
}