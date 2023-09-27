﻿Laptop.laptop laptop1 = new Laptop.laptop();
laptop1 = new Laptop.Vivobook();
laptop1.vga = new nvidia();
laptop1.processor = new Processor.coreI5();

Laptop.laptop laptop2 = new Laptop.laptop();
laptop2 = new Laptop.IdeaPad();
laptop2.vga = new AMD();
laptop2.processor = new Processor.ryzen();

Laptop.Predator predator = new Laptop.Predator();
predator = new Laptop.Predator();
predator.vga = new AMD();
predator.processor = new Processor.coreI7();

Console.WriteLine("Jawaban untuk nomor 1:");
laptop2.LaptopDinyalakan();
laptop2.LaptopDimatikan();

Console.WriteLine("Jawaban untuk nomor 2:");
//laptop1.Ngoding();
Console.WriteLine("Error mas");

Console.WriteLine("Jawaban untuk nomor 3:");
Console.WriteLine(laptop1.vga.merk);
Console.WriteLine(laptop1.processor.merk);
Console.WriteLine(laptop1.processor.tipe);

Console.WriteLine("Jawaban untuk nomor 4:");
predator.BermainGame();

Console.WriteLine("Jawaban untuk nomor 5:");
Laptop.Acer acer = new Laptop.Acer();
acer = new Laptop.Predator();
//acer.BermainGame();
Console.WriteLine("Error mas");

class vga
{
    public string merk;

    public vga(string merk)
    {
        this.merk = merk;
    }
}

class nvidia : vga
{
    public nvidia() :base("nvidia")
    {

    }
}

class AMD : vga
{
    public AMD() :base("AMD")
    {

    }
}

namespace Processor
{
    class processor
    {
        public string merk;
        public string tipe;

        public processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }

    class intel : processor
    {
        public intel(string tipe) :base("intel", tipe)
        {

        }
    }

    class AMD : processor
    {
        public AMD(string tipe) :base("AMD", tipe)
        {

        }
    }

    class coreI3 : intel
    {
        public coreI3() :base("Core i3")
        {

        }
    }

    class coreI5 : intel
    {
        public coreI5() : base("Core i5")
        {

        }
    }

    class coreI7 : intel
    {
        public coreI7() : base("Core i7")
        {

        }
    }

    class ryzen : AMD
    {
        public ryzen() : base("RAYZEN")
        {

        } 
    }

    class athlon : AMD
    {
        public athlon() : base("ATHLON")
        {

        }
    }
}

namespace Laptop
{
    class laptop
    {
        public string merk;
        public string tipe;
        public vga vga;
        public Processor.processor processor;
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    class Asus : laptop
    {
        public Asus() :base()
        {
            merk = "ASUS";
        }
    }
    class Acer : laptop
    {
        public Acer() :base()
        {
            merk = "ACER";
        }
    }

    class Lenovo : laptop
    {
        public Lenovo() : base()
        {
            merk = "LENOVO";
        }
    }

    class ROG : Asus
    {
        public ROG() :base()
        {
            tipe = "ROG";
        }
    }

    class Vivobook : Asus
    {
        public Vivobook() :base()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Swift : Acer
    {
        public Swift() :base()
        {
            tipe = "Swift";
        }
    }

    class Predator : Acer
    {
        public Predator() : base()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang bermain game");
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad() : base()
        {
            tipe = "IdeaPad";
        }
    }
    
    class Legion : Lenovo
    {
        public Legion() : base()
        {
            tipe = "Legion";
        }
    }
}
