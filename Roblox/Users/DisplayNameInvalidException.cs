using System;

namespace Roblox.Users
{
    public class DisplayNameInvalidException : Exception
    {
        public DisplayNameInvalidException(string message) : base(message) { }
    }
}