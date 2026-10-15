using System;
using System.Collections.Generic;

class Uygulama2
{
    
    public static void Calistir()
    {
        List<string> numaralar = new List<string> { "LAB-001", "LAB-002", "LAB-003" };

        bool varMi = NumaraVarMi(numaralar, "LAB-002");
        Console.WriteLine("Aranan numara listede var mı? " + varMi);
    }

    static bool NumaraVarMi(List<string> liste, string aranan)
    {
        foreach (string numara in liste)
        {
            if (numara == aranan)
            {
                return true; 
            }
        }
        return false; 
    }
}