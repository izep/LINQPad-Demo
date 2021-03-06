﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiled_Library_Demo.Model
{
    public interface IPrimate : IAnimal
    {
        
    }

    public class Primate : IPrimate
    {
        public Primate(bool tail)
        {
            this.type = AnimalType.primate;
            this.arms = 2; 
            this.legs = 2;
            this.tail = tail;
        }
        public AnimalType type { get; }
        public int? arms { get; }
        public int? legs { get; }
        public bool tail { get; }
    }
}
