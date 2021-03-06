using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DotBPE.Rpc.Codes;

namespace DotBPE.Rpc
{
    public interface ITransportFactory<in TMessage>:IDisposable where TMessage : InvokeMessage
    {
        ITransport<TMessage> CreateTransport(EndPoint endpoint);
        Task CloseTransportAsync(EndPoint serverAddress);
    }
}
