// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        /// <summary>
        /// WARNING: This method does not implicitly handle long paths. Use SetFileAttributes.
        /// </summary>
        [GeneratedDllImport(Libraries.Kernel32, EntryPoint = "SetFileAttributesW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        private static partial bool SetFileAttributesPrivate(
            string name,
            int attr);

        internal static bool SetFileAttributes(string name, int attr)
        {
            name = PathInternal.EnsureExtendedPrefixIfNeeded(name);
            return SetFileAttributesPrivate(name, attr);
        }
    }
}
