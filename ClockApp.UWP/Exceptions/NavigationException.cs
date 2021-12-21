using System;

namespace ClockApp.UWP.Exceptions
{
    internal class NavigationException : Exception
    {
        public NavigationException(string msg) : base(msg)
        {

        }
    }
}
