using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Computer
    {
        public Computer()
        {
            
        }

        public int RAM { get; set; }
        public int CPU { get; set; }
        public int HardDisk { get; set; }
    }
}
