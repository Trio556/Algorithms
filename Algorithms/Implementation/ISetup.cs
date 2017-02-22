namespace Algorithms.Implementation
{
    public interface ISetup
    {
        /// <summary>
        /// Method called to setup a certain algorithm
        /// </summary>
        /// <returns></returns>
        bool SetupAlgorithm();

        /// <summary>
        /// Runs the Algorithm
        /// </summary>
        /// <exception cref="NullReferenceException">If SetupAlgorithm failed NullReferenceException will be thrown</exception>
        void Run();
    }
}
