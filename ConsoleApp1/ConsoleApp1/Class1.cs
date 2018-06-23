using System;
using static System.Math;

namespace TeleprompterConsole
{
    internal class TelePrompterConfig
    {
        private object lockHandle = new object();
        public int DelayInMilliseconds { get; private set; } = 200;

        public void UpdateDelay(int increment) // negative to speed up
        {
            var newDelay = Min(DelayInMilliseconds + increment, 1000);
            newDelay = Max(newDelay, 20);
            lock (lockHandle)
            {
                DelayInMilliseconds = (int)newDelay;
            }
        }

        private object Max(object newDelay, int v)
        {
            throw new NotImplementedException();
        }

        private object Min(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public bool Done { get; private set; }

        public void SetDone()
        {
            Done = true;
        }
    }
}