using Algorithms.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public abstract class AlgorithmFactory
    {
        private readonly string _name;
        private readonly Type _enumType;
        private readonly string[] _algorithms;


        public AlgorithmFactory(string name, Type enumType)
        {
            _name = name;
            _enumType = enumType;
            _algorithms = Enum.GetNames(enumType);
        }

        /// <summary>
        /// Gets the setup based on user input
        /// </summary>
        /// <returns></returns>
        public ISetup GetSetup()
        {
            while (true)
            {
                Console.WriteLine($"Select {_name} Algorithm:");

                for (int i = 0; i < _algorithms.Count(); i++)
                {
                    Console.WriteLine(_algorithms[i]);
                }

                Console.Write("Please Select One:");
                var algorithmName = Console.ReadLine();

                var setup = GetSetup(algorithmName);

                if (setup == null)
                    continue;

                return setup;
            }
        }

        /// <summary>
        /// Gets the setup based on supplied name
        /// </summary>
        /// <param name="algorithmName"></param>
        /// <returns></returns>
        public abstract ISetup GetSetup(string algorithmName);
    }
}
