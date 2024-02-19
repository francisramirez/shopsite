// See https://aka.ms/new-console-template for more information
using ShopPro.OOP.Base;
using ShopPro.OOP.Clases;

//Console.WriteLine("Hello, World!");


Laptop laptop = new Laptop();

laptop.Marca = "Dell";
laptop.Modelo = "inspiron";
laptop.Memoria = 32;

laptop.SubirVolumen();


Desktop desktop = new Desktop();

desktop.Marca = "HP";
desktop.Modelo = "X";
desktop.Memoria = 16;

desktop.SubirVolumen();

//MiniLaptop miniLaptop = new MiniLaptop();




//laptop.AumentarSonido();

//desktop.AumentarSonido();

//IBaseVehiculo motor = new Motor();


//motor.Enceder();
//motor.Apagar();


//IBaseVehiculo autobus = new Autobuses();


//autobus.Enceder();
//autobus.Apagar();


Console.ReadLine();