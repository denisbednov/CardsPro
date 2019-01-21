using System;
using System.Linq;

namespace CardsPro.Core
{
    public static class Extensions
    {
        public static void ThrowIfNullOrWhiteSpace(this string value, string name, string nullMessage = null, string emptyMessage = "Argument must not be the empty string.")
        {
            if (value == null)
            {
                if (nullMessage == null)
                {
                    throw new ArgumentNullException(name);
                }

                throw new ArgumentNullException(name, nullMessage);
            }

            if (value.All(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException(emptyMessage, name);
            }
        }

        public static void ThrowIfNull(this object value, string name, string message = null)
        {
            if (value == null)
            {
                if (message == null)
                {
                    throw new ArgumentNullException(name);
                }

                throw new ArgumentNullException(name, message);
            }
        }
    }
}
