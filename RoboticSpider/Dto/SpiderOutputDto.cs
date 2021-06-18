using Newtonsoft.Json.Converters;
using RoboticSpider.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RoboticSpider.Dto
{
    public class SpiderOutputDto
    {
        public int CurrX { get; set; }
        public int CurrY { get; set; }
        public SpiderDirection Direction { get; set; }
    }
}
