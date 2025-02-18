// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [GeneratedDllImport(Libraries.SystemNative, EntryPoint = "SystemNative_SearchPath", StringMarshalling = StringMarshalling.Utf8)]
        internal static partial string? SearchPath(NSSearchPathDirectory folderId);

        internal enum NSSearchPathDirectory
        {
            NSApplicationDirectory = 1,
            NSLibraryDirectory = 5,
            NSUserDirectory = 7,
            NSDocumentDirectory = 9,
            NSDesktopDirectory = 12,
            NSCachesDirectory = 13,
            NSMoviesDirectory = 17,
            NSMusicDirectory = 18,
            NSPicturesDirectory = 19
        }
    }
}
