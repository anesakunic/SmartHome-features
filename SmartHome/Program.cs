// See https://aka.ms/new-console-template for more information

// Application of OOP principles 

using System;
using System.Collections.Generic;

abstract class smartDevice      //my base class
{
    public string Ime { get; protected set;}
    public bool Ukljuceno { get; protected set;} 

    protected smartDevice(string ime)   // konstruktor
    {

        Ime=ime;
        Ukljuceno = false;
    }



    public abstract void Ukljuci();  //abstraktne metode za ukljucivanje i iskljucivanje
    public abstract void Iskljuci();


}
interface Podesavanja
{
    void povecavanje();
    void smanjivanje();
}



class smartLighting : smartDevice
{
    public int Osvjetljivanje { get; private set; }  
    public smartLighting(string ime) : base(ime) { Osvjetljivanje =65;}   //konstr

    public override void Ukljuci()
    {
        Ukljuceno = true;
        Console.WriteLine($"Svjetlo {Ime} je sada ON");

    }
    public override void Iskljuci()
    {
        Ukljuceno = false;
        Console.WriteLine($"Svjetlo {Ime} je sada OFF");
        
    }

}


class smartTermostat : smartDevice, Podesavanja
{
    public int temp { get; private set; }
    public smartTermostat(string ime) : base(ime) { temp = 24; }

    public override void Ukljuci()
    {
        Ukljuceno=true;
        Console.WriteLine($"Termostat {Ime} je sada ON");
    }
    public override void Iskljuci()
    {
        Ukljuceno=false;
        Console.WriteLine($"Termostat {Ime} je sada OFF");
    }

    public void povecavanje()
    {
        temp++;
       
        Console.WriteLine($"Temperatura {Ime} je sada povećana na {temp}°C");
    
    }

    public void smanjivanje()
    {
        temp--;
        Console.WriteLine($"Temperatura {Ime} je sada smanjena na {temp}°C");
    }

    class Program   //glavna klasa
    {
        static void Main()
        {
            List<smartDevice> devices = new List<smartDevice>   //lista pametnih uredjaja
            {
                new smartLighting("Dnevni Boravak"),
                new smartTermostat("Dječija soba")

            };

            foreach (var device in devices )
            {
                device.Ukljuci();
            }

            smartTermostat termostat = devices[1] as smartTermostat;
            termostat?.povecavanje();   //povecavam temp
            termostat?.smanjivanje();   

            foreach (var device in devices)   //iskljuci sve
            {
                device.Iskljuci();
            }
        }
        
    }



}