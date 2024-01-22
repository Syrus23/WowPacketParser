﻿using System;
using System.Text.Json;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649
{
    public static class BattlenetProtoHandler
    {
        public static MethodCall ReadMethodCall(Packet packet, params object[] idx)
        {
            var method = new MethodCall();

            method.Type = packet.ReadUInt64("Type", idx);
            method.ObjectId = packet.ReadUInt64("ObjectId", idx);
            method.Token = packet.ReadUInt32("Token", idx);

            return method;
        }

        public static void ReadProtoData(Packet packet, int length, MethodCall method, params object[] indexes)
        {
            var val = packet.ReadBytes(length);

            var parser = ProtobufParser.GetParser(method.GetServiceHash(), method.GetMethodId(), packet.Opcode);

            if (parser == null)
            {
                packet.AddValue("MethodCall", "ServiceHash: 0x" + method.GetServiceHash().ToString("X") + " MethodID: " + method.GetMethodId(), indexes);
                packet.AddValue("Message", Convert.ToHexString(val), indexes);
                return;
            }

            packet.AddValue("Type", ProtobufParser.GetParserName(parser), indexes);

            var msg = parser.ParseFrom(val).ToString();
            var formattedMsg = JsonSerializer.Serialize(JsonDocument.Parse(msg), new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            });

            packet.AddValue("Message", System.Environment.NewLine + formattedMsg, indexes);
        }

        [Parser(Opcode.CMSG_BATTLENET_REQUEST)]
        public static void HandleBattlenetRequest(Packet packet)
        {
            var method = ReadMethodCall(packet, "Method");

            int protoSize = packet.ReadInt32();
            ReadProtoData(packet, protoSize, method, "Data");
        }

        [Parser(Opcode.SMSG_BATTLENET_NOTIFICATION)]
        public static void HandleBattlenetNotification(Packet packet)
        {
            var method = ReadMethodCall(packet, "Method");

            int protoSize = packet.ReadInt32();
            ReadProtoData(packet, protoSize, method, "Data");
        }

        [Parser(Opcode.SMSG_BATTLENET_RESPONSE)]
        public static void HandleBattlenetResponse(Packet packet)
        {
            packet.ReadInt32E<BattlenetRpcErrorCode>("BnetStatus");
            var method = ReadMethodCall(packet, "Method");

            int protoSize = packet.ReadInt32();
            ReadProtoData(packet, protoSize, method, "Data");
        }
    }
}
