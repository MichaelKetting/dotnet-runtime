// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [GeneratedDllImport(Libraries.Kernel32,  SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
        internal static partial bool GetProcessPriorityBoost(SafeProcessHandle handle, out bool disabled);
    }
}
