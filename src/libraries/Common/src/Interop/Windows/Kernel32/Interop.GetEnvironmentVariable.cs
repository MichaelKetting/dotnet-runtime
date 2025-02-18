// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [GeneratedDllImport(Libraries.Kernel32, EntryPoint = "GetEnvironmentVariableW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        internal static partial uint GetEnvironmentVariable(string lpName, ref char lpBuffer, uint nSize);
    }
}
