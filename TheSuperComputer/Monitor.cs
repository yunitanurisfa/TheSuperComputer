﻿using System;

namespace TheSuperComputer
{
    class Monitor
    {
        private String resolution;
        private Boolean supportHdmi;
        private double size;

        public Monitor(String resolution, Boolean supportHdmi, double size)
        {
            this.resolution = resolution;
            this.supportHdmi = supportHdmi;
            this.size = size;
        }

        private String getResolution()
        {
            return this.resolution;
        }
        private Boolean isSupportHdmi()
        {
            return this.supportHdmi;
        }
        private double getSize()
        {
            return this.size;
        }
        public override string ToString()
        {
            return $"Monitor resolution: {this.resolution}  ;Monitor support hdmi : {this.supportHdmi} ; Monitor dimensi: {this.size} inch";
        }

    }
}
