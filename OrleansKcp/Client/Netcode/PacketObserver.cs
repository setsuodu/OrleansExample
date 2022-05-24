using System;
using System.Linq;
using GrainInterfaces;
using kcp2k;

namespace Client
{
    // 进程上的观察者，用来监听逻辑服。
    public class PacketObserver : IPacketObserver
    {
        private readonly KcpServer context;

        public PacketObserver(KcpServer context)
        {
            this.context = context;
        }

        // 处理从逻辑服过来的消息，（那么客户端消息呢？）
        public void OnReceivePacket(ArraySegment<byte> Packet)
        {
            Console.WriteLine($"Silo.OnReceivePacket，返回给Client:{context}");

            int firstclient = context.connections.Count > 0 ? context.connections.First().Key : -1;
            context.Send(firstclient, new ArraySegment<byte>(new byte[] { 0x03, 0x04 }), KcpChannel.Unreliable);
        }
    }
}