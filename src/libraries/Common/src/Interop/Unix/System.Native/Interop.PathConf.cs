// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        internal enum PathConfName : int
        {
            PC_LINK_MAX         = 1,
            PC_MAX_CANON        = 2,
            PC_MAX_INPUT        = 3,
            PC_NAME_MAX         = 4,
            PC_PATH_MAX         = 5,
            PC_PIPE_BUF         = 6,
            PC_CHOWN_RESTRICTED = 7,
            PC_NO_TRUNC         = 8,
            PC_VDISABLE         = 9,
        }

        [GeneratedDllImport(Libraries.SystemNative, EntryPoint = "SystemNative_PathConf", StringMarshalling = StringMarshalling.Utf8, SetLastError = true)]
        private static partial int PathConf(string path, PathConfName name);
    }
}
