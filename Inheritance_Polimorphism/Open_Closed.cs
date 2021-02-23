using System;

namespace OpenClosedPrinciple
{
    //Violating Open-Closed Principle
    public abstract class Vehicle
    {
        public abstract void FuelConsumption();
    }
    class PassangersVehicle : Vehicle
    {
        public PassangersVehicle(int passangers)
        {
            this.passangers = passangers;
        }
        private int passangers;
        public int Passangers
        {
            get
            {
                return passangers;
            }
            set
            {
                if (value >= 0)
                    passangers = value;
            }
        }
        public override void FuelConsumption()
        {
            //some cod;
        }       
    }
    class CargoVehicle : Vehicle
    {
        public CargoVehicle(int cargo)
        {
            this.cargo = cargo;
        }
        int cargo
        {
            get
            {
                return cargo;
            }
        set
            {
                if (value >= 0)
                    cargo = value;
            }
        }
        public override void FuelConsumption()
        {
            //some cod;
        }
    }
    class Rout
    { 
        public static string WhatRout(Vehicle vehicle)
        {
            if (vehicle.GetType().IsInstanceOfType(PassangersVehicle.))
                return "Vehicle rout to str. Uzinilor";
            else
                return "Vehicle rout to Gara de Nord";
        }
    }

        //compliance with the liscov substitution principle
        public abstract class liscovvehicle
    {
        public abstract string dayrout();
    }
    class passangersvehicle : liscovvehicle
    {
        public passangersvehicle(int passangers)
        {
            this.passangers = passangers;
        }
        int passangers;
        public int passangers
        {
            get
            {
                return passangers;
            }
            set
            {
                if (value >= 0)
                    passangers = value;
            }
        }
        public override string dayrout()
        {
            return "passangers liscov vehicle rout to gara de nord";
        }
    }
    class cargovehicle : liscovvehicle
    {
        public cargovehicle(int cargo)
        {
            this.cargo = cargo;
        }
        int cargo;
        int cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                if (value >= 0)
                    cargo = value;
            }
        }
        public override string dayrout()
        {
            return "cargo liscov vehicle rout to str. uzinilor";
        }
    }
    class liscovrout
    {
        public static string whatrout(liscovvehicle liscovvehicle)
        {
            return liscovvehicle.dayrout();
        }
    }
}
