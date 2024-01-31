using System;
using BitPacking;
using UnityEngine;

// Token: 0x02000FAB RID: 4011
public interface GInterface77
{
	// Token: 0x17000D42 RID: 3394
	// (get) Token: 0x060054CB RID: 21707
	byte[] Buffer { get; }

	// Token: 0x17000D43 RID: 3395
	// (get) Token: 0x060054CC RID: 21708
	int BitsCount { get; }

	// Token: 0x17000D44 RID: 3396
	// (get) Token: 0x060054CD RID: 21709
	int BitsRemain { get; }

	// Token: 0x17000D45 RID: 3397
	// (get) Token: 0x060054CE RID: 21710
	bool IsOverflow { get; }

	// Token: 0x17000D46 RID: 3398
	// (get) Token: 0x060054CF RID: 21711
	EBitStreamMode StreamMode { get; }

	// Token: 0x060054D0 RID: 21712
	void SerializeLimitedInt32(ref int value, int min, int max, BitPackingTag tag);

	// Token: 0x060054D1 RID: 21713
	void SerializeUInt32UsingBitRange(ref uint value, int[] rangeBits, BitPackingTag tag);

	// Token: 0x060054D2 RID: 21714
	void SerializeLimitedFloat(ref float value, float min, float max, float res, BitPackingTag tag);

	// Token: 0x060054D3 RID: 21715
	void SerializeLimitedString(ref string value, char min, char max, BitPackingTag tag, uint? maxSize = 1200);

	// Token: 0x060054D4 RID: 21716
	void SerializeBits(ref uint value, int bits);

	// Token: 0x060054D5 RID: 21717
	void SerializeBytes(ref byte[] data, int startIndex, int length);

	// Token: 0x060054D6 RID: 21718
	void SerializeBytesAndSize(ref byte[] data, uint? maxSize = 1200);

	// Token: 0x060054D7 RID: 21719
	void Serialize(ref char value);

	// Token: 0x060054D8 RID: 21720
	void Serialize(ref byte value);

	// Token: 0x060054D9 RID: 21721
	void Serialize(ref short value);

	// Token: 0x060054DA RID: 21722
	void Serialize(ref ushort value);

	// Token: 0x060054DB RID: 21723
	void Serialize(ref int value);

	// Token: 0x060054DC RID: 21724
	void Serialize(ref uint value);

	// Token: 0x060054DD RID: 21725
	void Serialize(ref long value);

	// Token: 0x060054DE RID: 21726
	void Serialize(ref ulong value);

	// Token: 0x060054DF RID: 21727
	void Serialize(ref float value);

	// Token: 0x060054E0 RID: 21728
	void Serialize(ref double value);

	// Token: 0x060054E1 RID: 21729
	void Serialize(ref string value, uint? maxSize = 1200);

	// Token: 0x060054E2 RID: 21730
	void Serialize(ref Vector3 value);

	// Token: 0x060054E3 RID: 21731
	void Serialize(ref Vector2 value);

	// Token: 0x060054E4 RID: 21732
	void Serialize(ref Quaternion value);

	// Token: 0x060054E5 RID: 21733
	void Serialize(ref bool value);

	// Token: 0x060054E7 RID: 21735
	bool SerializeCheck(uint checkNumber, string message = null);

	// Token: 0x060054E8 RID: 21736
	void SerializeAlign();

	// Token: 0x060054E9 RID: 21737
	void Reset();
}
