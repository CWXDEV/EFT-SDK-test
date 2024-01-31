using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001534 RID: 5428
[StructLayout(LayoutKind.Auto)]
public struct GStruct177
{
	// Token: 0x06007453 RID: 29779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface77 stream, ref GStruct177 handsChangePacket, GStruct177 prevFrame)
	{
		throw null;
	}

	// Token: 0x06007454 RID: 29780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(GStruct177 other)
	{
		throw null;
	}

	// Token: 0x06007455 RID: 29781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	// Token: 0x06007456 RID: 29782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	// Token: 0x04007A9E RID: 31390
	private const int int_0 = 2047;

	// Token: 0x04007A9F RID: 31391
	public GStruct177.EOperationType OperationType;

	// Token: 0x04007AA0 RID: 31392
	public uint CallbackId;

	// Token: 0x04007AA1 RID: 31393
	public string ItemId;

	// Token: 0x04007AA2 RID: 31394
	public EBodyPart MedsBodyPart;

	// Token: 0x04007AA3 RID: 31395
	public float MedsAmount;

	// Token: 0x04007AA4 RID: 31396
	public int AnimationVariant;

	// Token: 0x02001535 RID: 5429
	public enum EOperationType
	{
		// Token: 0x04007AA6 RID: 31398
		None,
		// Token: 0x04007AA7 RID: 31399
		Drop,
		// Token: 0x04007AA8 RID: 31400
		FastDrop,
		// Token: 0x04007AA9 RID: 31401
		CreateEmptyHands,
		// Token: 0x04007AAA RID: 31402
		CreateFirearm,
		// Token: 0x04007AAB RID: 31403
		CreateGrenade,
		// Token: 0x04007AAC RID: 31404
		CreateMeds,
		// Token: 0x04007AAD RID: 31405
		CreateKnife,
		// Token: 0x04007AAE RID: 31406
		CreateQuickGrenadeThrow,
		// Token: 0x04007AAF RID: 31407
		CreateQuickKnifeKick,
		// Token: 0x04007AB0 RID: 31408
		CreateQuickUseItem,
		// Token: 0x04007AB1 RID: 31409
		CreateUsableItem,
		// Token: 0x04007AB2 RID: 31410
		DropAndCreateEmptyHands,
		// Token: 0x04007AB3 RID: 31411
		DropAndCreateFirearm,
		// Token: 0x04007AB4 RID: 31412
		DropAndCreateGrenade,
		// Token: 0x04007AB5 RID: 31413
		DropAndCreateMeds,
		// Token: 0x04007AB6 RID: 31414
		DropAndCreateKnife,
		// Token: 0x04007AB7 RID: 31415
		DropAndCreateQuickGrenadeThrow,
		// Token: 0x04007AB8 RID: 31416
		DropAndCreateQuickKnifeKick,
		// Token: 0x04007AB9 RID: 31417
		DropAndCreateQuickUseItem,
		// Token: 0x04007ABA RID: 31418
		DropAndCreateUsableItem
	}
}
