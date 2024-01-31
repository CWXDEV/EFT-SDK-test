using System;
using UnityEngine;

// Token: 0x02000FA9 RID: 4009
public interface GInterface76 : GInterface77
{
	// Token: 0x17000D40 RID: 3392
	// (get) Token: 0x060054B0 RID: 21680
	int BitsRead { get; }

	// Token: 0x17000D41 RID: 3393
	// (get) Token: 0x060054B1 RID: 21681
	int BytesRead { get; }

	// Token: 0x060054B2 RID: 21682
	int ReadLimitedInt32(int min, int max);

	// Token: 0x060054B3 RID: 21683
	uint ReadUInt32UsingBitRange(int[] rangeBits);

	// Token: 0x060054B4 RID: 21684
	float ReadLimitedFloat(float min, float max, float res);

	// Token: 0x060054B5 RID: 21685
	string ReadLimitedString(char min, char max, uint? maxSize = 1200);

	// Token: 0x060054B6 RID: 21686
	uint ReadBits(int bits);

	// Token: 0x060054B7 RID: 21687
	void ReadBytes(byte[] destinationBytes, int destinationStartIndex, int length);

	// Token: 0x060054B8 RID: 21688
	byte[] ReadBytesAlloc(uint? maxSize = 1200);

	// Token: 0x060054B9 RID: 21689
	char ReadChar();

	// Token: 0x060054BA RID: 21690
	byte ReadByte();

	// Token: 0x060054BB RID: 21691
	short ReadInt16();

	// Token: 0x060054BC RID: 21692
	ushort ReadUInt16();

	// Token: 0x060054BD RID: 21693
	int ReadInt32();

	// Token: 0x060054BE RID: 21694
	uint ReadUInt32();

	// Token: 0x060054BF RID: 21695
	long ReadInt64();

	// Token: 0x060054C0 RID: 21696
	ulong ReadUInt64();

	// Token: 0x060054C1 RID: 21697
	float ReadFloat();

	// Token: 0x060054C2 RID: 21698
	double ReadDouble();

	// Token: 0x060054C3 RID: 21699
	string ReadString(uint? maxSize = 1200);

	// Token: 0x060054C4 RID: 21700
	Vector3 ReadVector3();

	// Token: 0x060054C5 RID: 21701
	Vector2 ReadVector2();

	// Token: 0x060054C6 RID: 21702
	Quaternion ReadQuaternion();

	// Token: 0x060054C7 RID: 21703
	bool ReadBool();

	// Token: 0x060054C9 RID: 21705
	bool ReadCheck(uint magic, string message = null);

	// Token: 0x060054CA RID: 21706
	void ReadAlign();
}
