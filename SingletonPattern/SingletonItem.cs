using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class SingletonItem
    {
        private static SingletonItem _uniqueInstance;

        private SingletonItem() {}

        public static SingletonItem getInstance()
        {
            if(_uniqueInstance == null)
            {
                // Same as synchronize in Java
                lock (getInstance())
                {
                    if(_uniqueInstance == null)
                    {
                        _uniqueInstance = new SingletonItem();
                    }
                }
            }

            return _uniqueInstance;
        }
    }
}
