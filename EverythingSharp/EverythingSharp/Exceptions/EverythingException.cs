using System;
using System.Diagnostics.CodeAnalysis;

using EverythingSharp.Enums;

namespace EverythingSharp.Exceptions
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class EverythingException : Exception
    {
        public EverythingException(Error errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public Error ErrorCode { get; }
    }
}