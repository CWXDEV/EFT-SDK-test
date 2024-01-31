using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020003F8 RID: 1016
public class BotMedecine : GClass362
{
	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06001875 RID: 6261 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001876 RID: 6262 RVA: 0x00002050 File Offset: 0x00000250
	public bool Using
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshCurMeds()
	{
		throw null;
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetDamaged()
	{
		throw null;
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool obj)
	{
		throw null;
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400153C RID: 5436
	public static readonly EquipmentSlot[] secureSlots;

	// Token: 0x0400153D RID: 5437
	public static readonly EquipmentSlot[] anySlots;

	// Token: 0x0400153E RID: 5438
	public static readonly EquipmentSlot[] pockets;

	// Token: 0x0400153F RID: 5439
	public static readonly EquipmentSlot[] allVisible;

	// Token: 0x04001540 RID: 5440
	public GClass412 FirstAid;

	// Token: 0x04001541 RID: 5441
	public GClass417 Stimulators;

	// Token: 0x04001542 RID: 5442
	public GClass415 SurgicalKit;

	// Token: 0x04001543 RID: 5443
	private float _recheckPeriod;
}
