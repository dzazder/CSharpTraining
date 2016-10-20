using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Builder director
    /// </summary>
    public class ComputerBuilderDirector
    {
        public Computer Construct()
        {
            ComputerBuilder builder = new ComputerBuilder();
            builder.SetCpu(2000);
            builder.SetHardDisk(500);
            builder.SetRam(4096);

            return builder.GetResult();
        }
    }
}
