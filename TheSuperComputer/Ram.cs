﻿using System;

namespace TheSuperComputer
{
    class Ram
    {
        private String type;
        private int speed;
        private int memorySize;

        public Ram(String type,int speed,int memorySize)
        {
            this.type = type;
            this.speed = speed;
            this.memorySize = memorySize;

        }
        public String getType()
        {
            return this.type;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public int getMemorySize()
        {
            return this.memorySize;
        }
        public override string ToString()
        {
            return $"Ram Type : {this.type};Ram Speed:{this.speed};Ram size : {this.memorySize}";
        }
    }
}
