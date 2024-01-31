using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020002F8 RID: 760
public class GClass395 : BotReload
{
	// Token: 0x06001008 RID: 4104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(MagazineClass foundMag, List<BulletClass> ammoList)
	{
		throw null;
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanReload(bool withCheckByPeriod, out MagazineClass foundMag, out List<BulletClass> ammoForInternalReload)
	{
		throw null;
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void AddAmmoToPockets(string templateId, int targetCount)
	{
		throw null;
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_5(string templateId, int targetCount)
	{
		throw null;
	}

	// Token: 0x04000F3F RID: 3903
	private int int_0;

	// Token: 0x04000F40 RID: 3904
	private bool bool_0;

	// Token: 0x04000F41 RID: 3905
	private List<ItemAddress> list_0;

	// Token: 0x04000F42 RID: 3906
	private const float float_0 = 1.3f;

	// Token: 0x04000F43 RID: 3907
	private float float_1;

	// Token: 0x020002F9 RID: 761
	[CompilerGenerated]
	private sealed class Class175
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x04000F44 RID: 3908
		public GClass395 gclass395_0;

		// Token: 0x04000F45 RID: 3909
		public MagazineClass currentMagazine;
	}

	// Token: 0x020002FA RID: 762
	[CompilerGenerated]
	private sealed class Class176
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x04000F46 RID: 3910
		public string templateId;

		// Token: 0x04000F47 RID: 3911
		public Func<Item, bool> func_0;
	}
}
