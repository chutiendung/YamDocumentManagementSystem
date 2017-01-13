using System;

namespace YamDocumentManagementSystem.Types.General
{
    public static class Guard
    {
        public static void ThrowIfNull<T>(T value, string parameterName = @"value")
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}