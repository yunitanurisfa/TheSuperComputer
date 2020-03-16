using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1200x600", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102", 50);
            Vga nvdiaVga = new Vga("Nvidia", 2070, 2080);
            Ram samsungRam = new Ram("DDR4", 2666, 4000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(2000);
            intelProcessor.setCore(12);
            intelProcessor.setSeries("CORE i9 9th Gen");

            Computer computer = new Computer.Builder(samsungRam, nvdiaVga, intelProcessor)
                .withMonitor(lgMonitor).withPrinter(hpPrinter).build();

            Console.WriteLine(computer.ToString());
        }
    }
}
