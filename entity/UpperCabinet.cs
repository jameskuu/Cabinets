using System;
using System.Collections.Generic;
using System.Text;

namespace Cabinets
{
    class UpperCabinet
    {
        public double length { get; set; }
        public double height { get; set; }
        public double header { get; set; }
        public double bottom { get; set; }
        public double leftStyle { get; set; }
        public double rightStyle { get; set; }
        public double centerStyle { get; set; }
        public int numCenterStyles { get; set; }
        

        public UpperCabinet(double length, double height, double header, double bottom, double leftStyle, double rightStyle, double centerStyle, int numCenterStyles )
        {
            this.length = length;
            this.height = height;
            this.header = header;
            this.bottom = bottom;
            this.leftStyle = leftStyle;
            this.rightStyle = rightStyle;
            this.centerStyle = centerStyle;
            this.numCenterStyles = numCenterStyles;
        }

    }
}
