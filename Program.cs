using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
    
        var ekipmanlar = new List<Ekipman>
        {
            new Ekipman("LAB-001", "Kamera"),
            new Ekipman("LAB-002", "Mikrofon")
        };

        Ekipman? bulunan = EkipmanBul(ekipmanlar, "LAB-001");
        
        if (bulunan != null)
        {
            bool sonuc = bulunan.OduncVer("1001");
            Console.WriteLine(sonuc ? "Ödünç verildi." : "İşlem reddedildi.");
        }
    }

    static Ekipman? EkipmanBul(List<Ekipman> liste, string no)
    {
        foreach (Ekipman e in liste)
        {
            if (e.DemirbasNo == no) return e;
        }
        return null;
    }
}