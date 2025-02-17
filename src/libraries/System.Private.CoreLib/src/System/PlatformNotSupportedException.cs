// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*=============================================================================
**
**
**
** Purpose: To handle features that don't run on particular platforms
**
**
=============================================================================*/

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class PlatformNotSupportedException : NotSupportedException
    {
        public PlatformNotSupportedException()
            : base(SR.Arg_PlatformNotSupported)
        {
            HResult = HResults.COR_E_PLATFORMNOTSUPPORTED;
        }

        public PlatformNotSupportedException(string? message)
            : base(message)
        {
            HResult = HResults.COR_E_PLATFORMNOTSUPPORTED;
        }

        public PlatformNotSupportedException(string? message, Exception? inner)
            : base(message, inner)
        {
            HResult = HResults.COR_E_PLATFORMNOTSUPPORTED;
        }

        [Obsolete(Obsoletions.LegacyFormatterImplMessage, DiagnosticId = Obsoletions.LegacyFormatterImplDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
