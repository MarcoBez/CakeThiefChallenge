using System;
using System.Collections.Generic;
using System.Text;
//Author - Marco Bezuidenhout 20200804
namespace CakeThief
{
    public class CakeType
    {
        public readonly int Weight;
        public readonly long Value;
        public readonly string Name;
        public CakeType(int weight, long value, string name)
        {
            Weight = weight;
            Value = value;
            Name = name;
        }
    }

}
