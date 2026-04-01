using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FSOServer.Packets
{
    public class PacketFactory
    {
        public static ICommand GetCommand(PacketType packetType)
        {
            switch (packetType)
            {
                default:
                    return null;
            }
        }
    }
}
