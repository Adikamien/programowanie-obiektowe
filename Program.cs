using System;

class KontoBankowe
{
    private string wlasciciel;
    private decimal saldo;

    public KontoBankowe(string wlasciciel, decimal saldoPoczatkowe)
    {
        this.wlasciciel = wlasciciel;
        saldo = saldoPoczatkowe >= 0 ? saldoPoczatkowe : 0;
    }

    public void PokazInformacje()
    {
        Console.WriteLine($"Właściciel: {wlasciciel} | Aktualne saldo: {saldo} zł");
    }

    public void Wplac(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Zla kwota");
            return;
        }
        saldo += kwota;
        Console.WriteLine($"Wplacono: {kwota} zł");
    }

    public void Wyplac(decimal kwota)
    {
        if (kwota <= 0 || kwota > saldo)
        {
            Console.WriteLine("Brak srodkow lub zla kwota");
            return;
        }
        saldo -= kwota;
        Console.WriteLine($"Wyplacono: {kwota} zł");
    }

    public bool CzyStacMnie(decimal kwota)
    {
        return saldo >= kwota;
    }
}

class Program
{
    static void Main()
    {
    
        KontoBankowe k1 = new KontoBankowe("Jan", 1000);
        KontoBankowe k2 = new KontoBankowe("Anna", 500);
        KontoBankowe k3 = new KontoBankowe("Piotr", 200);
        KontoBankowe k4 = new KontoBankowe("Kasia", 1500);

        
        k1.PokazInformacje();
        k2.PokazInformacje();

        
        k1.Wplac(200);

        
        k2.Wyplac(100);

        
        k3.Wyplac(500);

        
        k3.CzyStacMnie(150);

        
        k3.PokazInformacje();
    }
}
