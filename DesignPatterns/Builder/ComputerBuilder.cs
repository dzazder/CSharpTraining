using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Builder implementation
    /// </summary>
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer computer;

        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        public void SetRam(int ram)
        {
            computer.RAM = ram;
        }

        public void SetCpu(int cpu)
        {
            computer.CPU = cpu;
        }

        public void SetHardDisk(int hd)
        {
            computer.HardDisk = hd;
        }

        public Computer GetResult()
        {
            return computer;
        }
    }
}
