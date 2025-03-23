using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Otus_Arrays
{
    static internal class WatchTimer
    {
        static Stopwatch watch = new Stopwatch();
        const long TicksPerMillisecond = 10000;

        static internal void StartWatchTimer()
        {
            watch.Start();
        }

        static internal void StopWatchTimer()
        {
            watch.Stop();
        }

        static internal void ResetWatchTimer()
        {
            watch.Reset();
        }

        static internal TimeSpan ElapsedTimer()
        {          
            return watch.Elapsed;
        }
    }
}
