using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

namespace EFT.Hideout
{
	// Token: 0x02001B27 RID: 6951
	public class AirFilteringUnitBehaviour : GClass1924, GInterface147, GInterface163, IInputTree, GInterface168, GInterface169
	{
		// Token: 0x140001B6 RID: 438
		// (add) Token: 0x060092B1 RID: 37553 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060092B2 RID: 37554 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Item, int> OnConsumableItemChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x060092B3 RID: 37555 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1900 ResourceConsumer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x060092B4 RID: 37556 RVA: 0x00002050 File Offset: 0x00000250
		public bool Changeable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x060092B5 RID: 37557 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2700[] UsingItems
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x060092B6 RID: 37558 RVA: 0x00002050 File Offset: 0x00000250
		public float Consumption
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x060092B7 RID: 37559 RVA: 0x00002050 File Offset: 0x00000250
		public float ConsumptionReduction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(AreaData area, AreaInfo profileInfo, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnergyGenerationChanged(bool isOn)
		{
			throw null;
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060092BB RID: 37563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(Item item, int index)
		{
			throw null;
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LevelUpdatedHandler()
		{
			throw null;
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InstallConsumableItems(GClass2700[] installedSupplies)
		{
			throw null;
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(float profileDecayTime)
		{
			throw null;
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0400996A RID: 39274
		[CompilerGenerated]
		private Action<Item, int> action_0;

		// Token: 0x0400996B RID: 39275
		private GClass1900 gclass1900_0;
	}
}
