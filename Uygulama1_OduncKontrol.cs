using System;

class Uygulama1
{
    public static void Calistir()
    {
        string demirbasNo = "LAB-001";
        bool oduncte = false;

        Console.Write("Kaç gün? ");
        string? giris = Console.ReadLine();

        if (!int.TryParse(giris, out int gun) || gun < 1 || gun > 7)
        {
            Console.WriteLine("1-7 arası geçerli bir sayı girin.");
            return;
        }

        if (!oduncte && gun >= 1 && gun <= 7)
        {
            Console.WriteLine($"{demirbasNo}: {gun} gün süreyle ödünç verilebilir.");
        }
        else
        {
            Console.WriteLine("Talep uygun değil veya ekipman zaten ödünçte.");
        }
    }
}