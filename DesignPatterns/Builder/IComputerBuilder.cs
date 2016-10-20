using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Builder abstraction
    /// </summary>
    public interface IComputerBuilder
    {
        void SetRam(int ram);
        void SetCpu(int cpu);
        void SetHardDisk(int hd);
        Computer GetResult();
    }
}
