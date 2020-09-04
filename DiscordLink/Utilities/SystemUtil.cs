﻿using System.Threading;

namespace Eco.Plugins.DiscordLink.Utilities
{
    public static class SystemUtil
    {
        public static void StopAndDestroyTimer(ref Timer timer)
        {
            if (timer != null)
            {
                timer.Change(Timeout.Infinite, Timeout.Infinite);
                timer = null;
            }
        }

        public delegate void SynchronousThreadFunction();
        public static void SynchronousThreadExecute(SynchronousThreadFunction func)
        {
            Thread thread = new Thread(new ThreadStart(func));
            thread.Start();
            thread.Join();
        }
    }
}
