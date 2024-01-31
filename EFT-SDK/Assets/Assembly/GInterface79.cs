using System;
using BitPacking;
using UnityEngine;

// Token: 0x02000FAE RID: 4014
public interface GInterface79 : GInterface77
{
	// Token: 0x17000D4D RID: 3405
	// (get) Token: 0x060054F7 RID: 21751
	int BitsWritten { get; }

	// Token: 0x17000D4E RID: 3406
	// (get) Token: 0x060054F8 RID: 21752
	int BytesWritten { get; }

	// Token: 0x060054F9 RID: 21753
	void WriteLimitedInt32(int value, int min, int max, BitPackingTag tag);

	// Token: 0x060054FA RID: 21754
	void WriteUInt32UsingBitRange(uint value, int[] rangeBits, BitPackingTag tag);

	// Token: 0x060054FB RID: 21755
	void WriteLimitedFloat(float value, float min, float max, float res, BitPackingTag tag);

	// Token: 0x060054FC RID: 21756
	void WriteLimitedString(string value, char min, char max, BitPackingTag tag, uint? maxSize);

	// Token: 0x060054FD RID: 21757
	void WriteBits(uint value, int bits);

	// Token: 0x060054FE RID: 21758
	void WriteBytes(byte[] data, int startIndex, int length);

	// Token: 0x060054FF RID: 21759
	void WriteBytesAndSize(byte[] data);

	// Token: 0x06005500 RID: 21760
	void Write(char value);

	// Token: 0x06005501 RID: 21761
	void Write(byte value);

	// Token: 0x06005502 RID: 21762
	void Write(short value);

	// Token: 0x06005503 RID: 21763
	void Write(ushort value);

	// Token: 0x06005504 RID: 21764
	void Write(int value);

	// Token: 0x06005505 RID: 21765
	void Write(uint value);

	// Token: 0x06005506 RID: 21766
	void Write(long value);

	// Token: 0x06005507 RID: 21767
	void Write(ulong value);

	// Token: 0x06005508 RID: 21768
	void Write(float value);

	// Token: 0x06005509 RID: 21769
	void Write(double value);

	// Token: 0x0600550A RID: 21770
	void Write(string value);

	// Token: 0x0600550B RID: 21771
	void Write(Vector3 value);

	// Token: 0x0600550C RID: 21772
	void Write(Vector2 value);

	// Token: 0x0600550D RID: 21773
	void Write(Quaternion value);

	// Token: 0x0600550E RID: 21774
	void Write(bool value);

	// Token: 0x06005510 RID: 21776
	void Write(GInterface79 value);

	// Token: 0x06005511 RID: 21777
	void WriteCheck(uint checkNumber);

	// Token: 0x06005512 RID: 21778
	void WriteAlign();

	// Token: 0x06005513 RID: 21779
	void Flush();
}
