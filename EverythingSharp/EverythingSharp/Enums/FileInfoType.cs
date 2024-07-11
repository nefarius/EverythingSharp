using System.Diagnostics.CodeAnalysis;

namespace EverythingSharp.Enums
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    internal enum FileInfoType : uint
    {
        FileSize = 1,
        FFolderSize = 2,
        DateCreated = 3,
        DateModified = 4,
        DateAccessed = 5,
        Attributes = 6
    }
}