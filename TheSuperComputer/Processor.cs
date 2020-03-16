﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Processor
    {
        private String series;
        private int core;
        private int cache;

        public Processor()
        {

        }
        public void setSeries(string series)
        {
            this.series = series;
        }
        public String getSeries()
        {
            return this.series;
        }
        public void setCore(int core)
        {
            this.core = core;
        }
        public int getCore()
        {
            return this.core;
        }
        public void setCache(int cache)
        {
            this.cache = cache;
        }
        public int getCache()
        {
            return this.cache;
        }
        public override string ToString()
        {
            return $"Processor series:{this.series};Processor core:{this.core};Processor:{this.cache}";
        }
    }
}
