using System;
using OpenClosedPrinciple;
using Liscov_Substitution;

namespace Inheritance_Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Violating Open-Closed Principle + Violating Single Responsibility Principle
            Vehicle passangersVehicle = new PassangersVehicle(40);
            Vehicle cargoVehicle = new CargoVehicle(5000);
            Rout.WhatRout(passangersVehicle);
            Rout.WhatRout(cargoVehicle);
            Console.WriteLine();

            //Compliance with the Open-Closed Principle + Compliance with the Single Responsibility Principle
            CorrectVehicle correctPassangersVehicle = new CorrectPassangersVehicle(60);
            CorrectVehicle correctCargoVehicle = new CorrectCargoVehicle(10000);
            CorrectClassRout.ThisIsCorrectRout(correctPassangersVehicle);
            CorrectClassRout.ThisIsCorrectRout(correctCargoVehicle);
            Console.WriteLine();

            //Violating Liscov Substitution Principle
            NotLiscovPassangersVehicle notLiscovPassangersVehicle = new NotLiscovPassangersVehicle(100);
            NotLiscovCargoVehicle notLiscovCargoVehicle = new NotLiscovCargoVehicle(15000);
            NotLiscovRout.NotLiscovPassangersRout(notLiscovPassangersVehicle);
            NotLiscovRout.NotLiscovCargoRout(notLiscovCargoVehicle);
            Console.WriteLine();

            //Compliance with the Liscov Substitution Principle
            LiscovVehicle liscovPassangersVehicle = new LiscovPassangersVehicle(10);
            LiscovVehicle liscovCargoVehicle = new LiscovCargoVehicle(20000);
            LiscovRout.ThisIsLiscovRout(liscovPassangersVehicle);
            LiscovRout.ThisIsLiscovRout(liscovCargoVehicle);
            Console.WriteLine();
        }
    }
}
