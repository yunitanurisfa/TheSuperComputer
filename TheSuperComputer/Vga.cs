﻿using System;

namespace TheSuperComputer
{
    class Vga
    {
        private String brand;
        private int graphicsClock;
        private int memoryClock;

        public Vga( String brand, int graphicsClock, int memoryClock)
        {
            this.brand = brand;
            this.graphicsClock = graphicsClock;
            this.memoryClock = memoryClock;

        }
        public String getBrand()
        {
            return this.brand;
        }
        public int getGraphicsClock()
        {
            return this.graphicsClock;
        }
        public int getMemoryClock()
        {
            return this.memoryClock;
        }
        public override string ToString()
        {
            return $"Vga Brand : {this.brand};Vga Graphics Clock:{this.graphicsClock};Vga Clock Memory : {this.memoryClock}";
        }
    }
}
