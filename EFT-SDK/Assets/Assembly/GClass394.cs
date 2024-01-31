using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x020002F4 RID: 756
public class GClass394 : BotReload
{
	// Token: 0x06001001 RID: 4097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanReload(bool withCheckByPeriod, out MagazineClass foundMag, out List<BulletClass> ammoForInternalReload)
	{
		throw null;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReloadAmmo(List<BulletClass> foundAmmo)
	{
		throw null;
	}

	// Token: 0x020002F5 RID: 757
	[CompilerGenerated]
	private sealed class Class172
	{
		// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x04000F38 RID: 3896
		public GClass394 gclass394_0;

		// Token: 0x04000F39 RID: 3897
		public MagazineClass currentMagazine;

		// Token: 0x04000F3A RID: 3898
		public Weapon weapon;
	}

	// Token: 0x020002F6 RID: 758
	[CompilerGenerated]
	private sealed class Class173
	{
		// Token: 0x04000F3B RID: 3899
		public GClass394 gclass394_0;

		// Token: 0x04000F3C RID: 3900
		public int stockCount;
	}

	// Token: 0x020002F7 RID: 759
	[CompilerGenerated]
	private sealed class Class174
	{
		// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult s)
		{
			throw null;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult s)
		{
			throw null;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(IResult s)
		{
			throw null;
		}

		// Token: 0x04000F3D RID: 3901
		public string ammoToAdd;

		// Token: 0x04000F3E RID: 3902
		public GClass394.Class173 class173_0;
	}
}
