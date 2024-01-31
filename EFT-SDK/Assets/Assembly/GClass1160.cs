using System;
using System.Runtime.CompilerServices;
using BitPacking;
using UnityEngine;

// Token: 0x02000F93 RID: 3987
public class GClass1160 : GInterface76, GInterface77
{
	// Token: 0x17000D16 RID: 3350
	// (get) Token: 0x060053E8 RID: 21480 RVA: 0x00002050 File Offset: 0x00000250
	public byte[] Buffer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D17 RID: 3351
	// (get) Token: 0x060053E9 RID: 21481 RVA: 0x00002050 File Offset: 0x00000250
	public int BitsRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D18 RID: 3352
	// (get) Token: 0x060053EA RID: 21482 RVA: 0x00002050 File Offset: 0x00000250
	public int BitsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D19 RID: 3353
	// (get) Token: 0x060053EB RID: 21483 RVA: 0x00002050 File Offset: 0x00000250
	public int BitsRemain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D1A RID: 3354
	// (get) Token: 0x060053EC RID: 21484 RVA: 0x00002050 File Offset: 0x00000250
	public int BytesRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D1B RID: 3355
	// (get) Token: 0x060053ED RID: 21485 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsOverflow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000D1C RID: 3356
	// (get) Token: 0x060053EE RID: 21486 RVA: 0x00002050 File Offset: 0x00000250
	public EBitStreamMode StreamMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ReadLimitedInt32(int min, int max)
	{
		throw null;
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint ReadUInt32UsingBitRange(int[] rangeBits)
	{
		throw null;
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ReadLimitedFloat(float min, float max, float res)
	{
		throw null;
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReadLimitedString(char min, char max, uint? maxSize = 1200)
	{
		throw null;
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint ReadBits(int bits)
	{
		throw null;
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadBytes(byte[] destinationBytes, int destinationStartIndex, int length)
	{
		throw null;
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] ReadBytesAlloc(uint? maxSize)
	{
		throw null;
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public char ReadChar()
	{
		throw null;
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte ReadByte()
	{
		throw null;
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public short ReadInt16()
	{
		throw null;
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ushort ReadUInt16()
	{
		throw null;
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ReadInt32()
	{
		throw null;
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public uint ReadUInt32()
	{
		throw null;
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public long ReadInt64()
	{
		throw null;
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ulong ReadUInt64()
	{
		throw null;
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float ReadFloat()
	{
		throw null;
	}

	// Token: 0x060053FF RID: 21503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ReadDouble()
	{
		throw null;
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReadString(uint? maxSize)
	{
		throw null;
	}

	public Vector3 ReadVector3()
	{
		throw new NotImplementedException();
	}

	public Vector2 ReadVector2()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06005401 RID: 21505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Quaternion ReadQuaternion()
	{
		throw null;
	}

	// Token: 0x06005402 RID: 21506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadBool()
	{
		throw null;
	}

	// Token: 0x06005403 RID: 21507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TEnum ReadEnum<[Attribute1] TEnum>() where TEnum : struct
	{
		throw null;
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadCheck(uint magic, string message = null)
	{
		throw null;
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadAlign()
	{
		throw null;
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeLimitedInt32(ref int value, int min, int max, BitPackingTag tag)
	{
		throw null;
	}

	// Token: 0x06005408 RID: 21512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeUInt32UsingBitRange(ref uint value, int[] rangeBits, BitPackingTag tag)
	{
		throw null;
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeLimitedFloat(ref float value, float min, float max, float res, BitPackingTag tag)
	{
		throw null;
	}

	// Token: 0x0600540A RID: 21514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeLimitedString(ref string value, char min, char max, BitPackingTag tag, uint? maxSize = 1200)
	{
		throw null;
	}

	// Token: 0x0600540B RID: 21515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeBits(ref uint value, int bits)
	{
		throw null;
	}

	// Token: 0x0600540C RID: 21516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeBytes(ref byte[] data, int startIndex, int length)
	{
		throw null;
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeBytesAndSize(ref byte[] data, uint? maxSize)
	{
		throw null;
	}

	// Token: 0x0600540E RID: 21518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref char value)
	{
		throw null;
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref byte value)
	{
		throw null;
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref short value)
	{
		throw null;
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref ushort value)
	{
		throw null;
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref int value)
	{
		throw null;
	}

	// Token: 0x06005413 RID: 21523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref uint value)
	{
		throw null;
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref long value)
	{
		throw null;
	}

	// Token: 0x06005415 RID: 21525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref ulong value)
	{
		throw null;
	}

	// Token: 0x06005416 RID: 21526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref float value)
	{
		throw null;
	}

	// Token: 0x06005417 RID: 21527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref double value)
	{
		throw null;
	}

	// Token: 0x06005418 RID: 21528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref string value, uint? maxSize)
	{
		throw null;
	}

	// Token: 0x06005419 RID: 21529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref Vector3 value)
	{
		throw null;
	}

	// Token: 0x0600541A RID: 21530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref Vector2 value)
	{
		throw null;
	}

	// Token: 0x0600541B RID: 21531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref Quaternion value)
	{
		throw null;
	}

	// Token: 0x0600541C RID: 21532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(ref bool value)
	{
		throw null;
	}

	// Token: 0x0600541D RID: 21533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize<[Attribute1] TEnum>(ref TEnum value) where TEnum : struct
	{
		throw null;
	}

	// Token: 0x0600541E RID: 21534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SerializeCheck(uint checkNumber, string message = null)
	{
		throw null;
	}

	// Token: 0x0600541F RID: 21535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerializeAlign()
	{
		throw null;
	}

	// Token: 0x04006017 RID: 24599
	private readonly GInterface75 ginterface75_0;
}
