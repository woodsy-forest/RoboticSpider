using RoboticSpider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboticSpider.Dto
{
    public class SpiderInputDto
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public int CurrX { get; set; }
        public int CurrY { get; set; }

        public SpiderMove[] Commands { get; set; }

        public SpiderDirection Direction { get; set; }
    }
}
