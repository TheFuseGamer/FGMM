﻿namespace FGMM.SDK.Server.RPC
{
    /// <inheritdoc cref="IRpcTrigger" />
    /// <inheritdoc cref="IRpcAttach" />
    /// <summary>
    /// Represents the ability send and receive RPC events.
    /// </summary>
    /// <seealso cref="IRpcTrigger" />
    /// <seealso cref="IRpcAttach" />
    public interface IRpc : IRpcTrigger, IRpcAttach { }
}
