// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V4_4_0_54481.UpdateFields.V4_4_0_54481
{
    //[GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class ConversationLine : IConversationLine
    {
        public int ConversationLineID { get; set; }
        public uint StartTime { get; set; }
        public int UiCameraID { get; set; }
        public byte ActorIndex { get; set; }
        public byte Flags { get; set; }

        // dummies required by interface
        public byte ChatType { get; }
    }
}

