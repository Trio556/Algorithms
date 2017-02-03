using Algorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface IAlgorithmFactory
    {
        ISetup GetSetup();
    }
}
