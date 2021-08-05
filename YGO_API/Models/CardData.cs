using System;
using System.Collections.Generic;

#nullable disable

namespace YGO_API.Models
{
    public partial class CardData
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public string Attribute { get; set; }
        public string Race { get; set; }
        public string Atk { get; set; }
        public string Def { get; set; }
        public string Context { get; set; }
    }
}
