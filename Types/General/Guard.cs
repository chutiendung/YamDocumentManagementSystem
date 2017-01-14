using System;

namespace YamDocumentManagementSystem.Types.General
{
    public static class Guard
    {
        private const string DefaultParameterName = @"value";

        public static void ThrowIfNullOrWhitespace(string value, string parameterName = DefaultParameterName)
        {
            ThrowIfNull(value, parameterName);

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(@"Parameter cannot be whitespace", parameterName);
            }
        }

        public static void ThrowIfNull<T>(T value, string parameterName = DefaultParameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}