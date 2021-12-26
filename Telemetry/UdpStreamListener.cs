using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using ForzaHorizon5.DataModels;

namespace ForzaHorizon5.Telemetry
{
    public class UdpStreamListener : IDisposable
    {
        private Socket _socket;
        private EndPoint _ep;
        private byte[] _buffer_recv;
        private ArraySegment<byte> _buffer_recv_segment;
        private ForzaStruct fhstruct;
        public void Close()
        {
            _socket.Close();
        }
        public void Dispose()
        {
            _socket.Dispose();
        }

        public void Initialize(IPAddress address, int port)
        {
            _buffer_recv = new byte[324];
            _buffer_recv_segment = new(_buffer_recv);
            _ep = new IPEndPoint(IPAddress.Any, port);
            _socket = new(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.PacketInformation, true);
            _socket.Bind(_ep);
        }

        public void StartReceiveLoop()
        {
            _ = Task.Run(async () =>
            {
                SocketReceiveMessageFromResult res;
                while (true)
                {
                    res = await _socket.ReceiveMessageFromAsync(_buffer_recv_segment, SocketFlags.None, _ep);
                    fhstruct = ForzaHorizon5Module.dataReader.Read(_buffer_recv_segment);
                    ForzaHorizon5Module.model.Apply(fhstruct);
                }
            });
        }
    }
}
