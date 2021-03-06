using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTNewPC
    {
        public void KoreaDecode(BitReader reader)
        {
            b_0 = reader.ReadByte();
            if (b_0 == 1)
                u32 = reader.ReadUInt32();
            b_1 = reader.ReadByte();
            if (b_1 == 1)
                bytearray_1 = reader.ReadBytes(12);
            pCStruct = reader.Read<PCStruct>();
            b_2 = reader.ReadByte();
            if (b_2 == 1)
                subPKTNewPC33 = reader.Read<subPKTNewPC33>();
            b_3 = reader.ReadByte();
            b_4 = reader.ReadByte();
            if (b_4 == 1)
                bytearray_0 = reader.ReadBytes(20);
            b_5 = reader.ReadByte();
        }
    }
}
