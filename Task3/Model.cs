using System.Diagnostics;

namespace Task3
{
    internal class Model
    {
        readonly Stopwatch stopwatch = new Stopwatch();
        public Stopwatch Stopwatch { get { return stopwatch; } }

        public string GetTime()
        { return stopwatch.Elapsed.ToString(); }
    }
}