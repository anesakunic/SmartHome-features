// See https://aka.ms/new-console-template for more information

// Application of OOP principles 

using System;
using System.Collections.Generic;

abstract class smartDevice
{
    public string Ime { get; protected set;}


    protected smartDevice(string ime)   // konstruktor
    {

        Ime=ime;
    }



    public abstract void Ukljuci();
    public abstract void Iskljuci();


}



class smartLighting : smartDevice
{

}


class termostat : smartDevice
{

    
}