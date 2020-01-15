using System;

namespace CompositeYT.Exceptions
{
    public class UnsupportedMethodException: Exception
    {
        public UnsupportedMethodException():base("Unsupported method")
        {
            
        }
    }
}
