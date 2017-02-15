/*
 *  Using GeeksForGeeks.org for algorithm examples and coding them out in C#
 */

using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = "y";
            //Get all available Algorithms in an array
            var types = Enum.GetValues(typeof(AlgorithmTypes)).Cast<AlgorithmTypes>().ToArray();

            try
            {
                while (run == "y")
                {
                    Console.WriteLine("Choose an alogrithm");

                    for (int i = 0; i < types.Count(); i++)
                    {
                        Console.WriteLine(types[i]);
                    }

                    Console.Write("Please enter one:");
                    var algorithmTypeString = Console.ReadLine();

                    AlgorithmTypes algorithmType;

                    //If it doesn't parse then rerun the loop
                    if (!Enum.TryParse(algorithmTypeString, out algorithmType))
                        continue;

                    var factory = GetFactory(algorithmType);

                    if (factory == null)
                        throw new NullReferenceException("An algorithm type has not been setup");

                    var algorithmSetup = factory.GetSetup();
                    algorithmSetup.SetupAlgorithm();
                    algorithmSetup.Run();

                    Console.WriteLine("Would you like to continue?(y/n)");
                    run = Console.ReadLine().ToLower();
                }
            }
            catch(NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
                Console.Write("Press the any key to exit....");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Instantiates an instance of a class that implements IAlgorithmFactory
        /// </summary>
        /// <param name="algorithmType"></param>
        /// <returns></returns>
        public static AlgorithmFactory GetFactory(AlgorithmTypes algorithmType)
        {
            switch (algorithmType)
            {
                case AlgorithmTypes.Graph:
                    return new GraphFactory();
                case AlgorithmTypes.LinkedList:
                    return new LinkedListFactory();
            }

            return null;
        }

    }
}
