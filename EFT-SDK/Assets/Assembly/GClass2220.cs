using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;

// Token: 0x02001F2C RID: 7980
public class GClass2220 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x0600A513 RID: 42259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2220 CreateInstance()
	{
		throw null;
	}

	// Token: 0x17001B25 RID: 6949
	// (get) Token: 0x0600A514 RID: 42260 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A515 RID: 42261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A516 RID: 42262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A517 RID: 42263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A518 RID: 42264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD08 RID: 44296
	public EquipmentSlot SlotType;

	// Token: 0x0400AD09 RID: 44297
	public GClass2220.EOperationType OperationType;

	// Token: 0x0400AD0A RID: 44298
	public GStruct103 ItemsForEquip;

	// Token: 0x0400AD0B RID: 44299
	public bool IsInInventory;

	// Token: 0x02001F2D RID: 7981
	public enum EOperationType
	{
		// Token: 0x0400AD0D RID: 44301
		Equip,
		// Token: 0x0400AD0E RID: 44302
		UnEquip,
		// Token: 0x0400AD0F RID: 44303
		Toggle,
		// Token: 0x0400AD10 RID: 44304
		ToggleFold
	}
}
