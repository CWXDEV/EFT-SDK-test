using System;
using System.Runtime.CompilerServices;
using Diz.Binding;

namespace EFT.InventoryLogic
{
	// Token: 0x02002271 RID: 8817
	public class FireModeComponent : GClass2750
	{
		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x0600B3BC RID: 46012 RVA: 0x00002050 File Offset: 0x00000250
		public Weapon.EFireMode[] AvailableEFireModes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x0600B3BD RID: 46013 RVA: 0x00002050 File Offset: 0x00000250
		public int BurstShotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFireMode(Weapon.EFireMode fireMode)
		{
			throw null;
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Weapon.EFireMode GetNextFireMode()
		{
			throw null;
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Weapon.EFireMode GetForceAutoFireMode()
		{
			throw null;
		}

		// Token: 0x0400B7FC RID: 47100
		private readonly GInterface285 ginterface285_0;

		// Token: 0x0400B7FD RID: 47101
		[NonSerialized]
		public BindableEvent OnChanged;

		// Token: 0x0400B7FE RID: 47102
		public Weapon.EFireMode FireMode;

		// Token: 0x02002272 RID: 8818
		[CompilerGenerated]
		private sealed class Class1947
		{
			// Token: 0x0600B3C1 RID: 46017 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Weapon.EFireMode mode)
			{
				throw null;
			}

			// Token: 0x0400B7FF RID: 47103
			public Weapon.EFireMode fireMode;
		}
	}
}
