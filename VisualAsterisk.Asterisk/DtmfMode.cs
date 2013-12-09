using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// DTMFMode: Set default dtmfmode for sending DTMF. Default: rfc2833
    /// Other options:
    /// info : SIP INFO messages
    /// inband : Inband audio (requires 64 kbit codec -alaw, ulaw)
    /// auto : Use rfc2833 if offered, inband otherwise
    /// </summary>
    enum DtmfMode
    {
        rfc2833, info, inband, auto
    }
}
