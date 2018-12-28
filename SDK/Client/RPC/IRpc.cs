﻿using System;
using System.Threading.Tasks;

namespace FGMM.SDK.Client.RPC
{
    public interface IRpc
    {
        void Trigger(params object[] payloads);

        /// <summary>
        /// Attaches a RPC event handler to the event.
        /// </summary>
        /// <param name="callback">The callback to run when the event fires.</param>
        void On(Action<IRpcEvent> callback);

        /// <summary>
        /// Attaches a RPC event handler to the event.
        /// </summary>
        /// <typeparam name="T">The type of the first callback argument.</typeparam>
        /// <param name="callback">The callback to run when the event fires.</param>
        void On<T>(Action<IRpcEvent, T> callback);

        /// <summary>
        /// Attaches a RPC event handler to the event.
        /// </summary>
        /// <typeparam name="T1">The type of the first callback argument.</typeparam>
        /// <typeparam name="T2">The type of the second callback argument.</typeparam>
        /// <param name="callback">The callback to run when the event fires.</param>
        void On<T1, T2>(Action<IRpcEvent, T1, T2> callback);

        /// <summary>
        /// Attaches a RPC event handler to the event.
        /// </summary>
        /// <typeparam name="T1">The type of the first callback argument.</typeparam>
        /// <typeparam name="T2">The type of the second callback argument.</typeparam>
        /// <typeparam name="T3">The type of the third callback argument.</typeparam>
        /// <param name="callback">The callback to run when the event fires.</param>
        void On<T1, T2, T3>(Action<IRpcEvent, T1, T2, T3> callback);

        /// <summary>
        /// Attaches a RPC event handler to the event.
        /// </summary>
        /// <typeparam name="T1">The type of the first callback argument.</typeparam>
        /// <typeparam name="T2">The type of the second callback argument.</typeparam>
        /// <typeparam name="T3">The type of the third callback argument.</typeparam>
        /// <typeparam name="T4">The type of the forth callback argument.</typeparam>
        /// <param name="callback">The callback to run when the event fires.</param>
        void On<T1, T2, T3, T4>(Action<IRpcEvent, T1, T2, T3, T4> callback);

        /// <summary>
        /// Attaches a RPC event handler to the event.
        /// </summary>
        /// <typeparam name="T1">The type of the first callback argument.</typeparam>
        /// <typeparam name="T2">The type of the second callback argument.</typeparam>
        /// <typeparam name="T3">The type of the third callback argument.</typeparam>
        /// <typeparam name="T4">The type of the forth callback argument.</typeparam>
        /// <typeparam name="T5">The type of the fifth callback argument.</typeparam>
        /// <param name="callback">The callback to run when the event fires.</param>
        void On<T1, T2, T3, T4, T5>(Action<IRpcEvent, T1, T2, T3, T4, T5> callback);

        Task Request(params object[] payloads);

        Task<T> Request<T>(params object[] payloads);

        Task<Tuple<T1, T2>> Request<T1, T2>(params object[] payloads);

        Task<Tuple<T1, T2, T3>> Request<T1, T2, T3>(params object[] payloads);

        Task<Tuple<T1, T2, T3, T4>> Request<T1, T2, T3, T4>(params object[] payloads);

        Task<Tuple<T1, T2, T3, T4, T5>> Request<T1, T2, T3, T4, T5>(params object[] payloads);
    }
}
