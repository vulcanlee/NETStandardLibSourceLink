using System;

namespace NETStandardLib
{

    public class SayHello
    {
        public string Hello()
        {
#if NET40
            return "Hi NET40";
#elif NET45
            return "Hi NET45";
#elif NETCOREAPP1_0
            return "Hi NETCOREAPP1_0";
#elif NETCOREAPP2_0
            return "Hi NETCOREAPP2_0";
#elif NETSTANDARD2_0
            return "Hi NETSTANDARD2_0";
#endif
        }
    }
}
