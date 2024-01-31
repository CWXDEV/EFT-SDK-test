using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x0200249B RID: 9371
	[Serializable]
	public class AmmoBox : ContainerCollection, IAmmoContainer
	{
		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x0600BBC5 RID: 48069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BBC6 RID: 48070 RVA: 0x00002050 File Offset: 0x00000250
		public StackSlot Cartridges
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x0600BBC7 RID: 48071 RVA: 0x00002050 File Offset: 0x00000250
		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x00002050 File Offset: 0x00000250
		public int MaxCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x0600BBC9 RID: 48073 RVA: 0x00002050 File Offset: 0x00000250
		public override bool CanSellOnRagfair
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x00002050 File Offset: 0x00000250
		public override bool MergesWithChildren
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x0600BBCB RID: 48075 RVA: 0x00002050 File Offset: 0x00000250
		public override IEnumerable<IContainer> Containers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Item FindItem(string itemId)
		{
			throw null;
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600BBCD RID: 48077 RVA: 0x00002050 File Offset: 0x00000250
		public override IEnumerable<EItemInfoButton> ItemInteractionButtons
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IContainer GetContainer(string containerId)
		{
			throw null;
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BulletClass GetBulletAtPosition(int index)
		{
			throw null;
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashSum()
		{
			throw null;
		}
	}
}
