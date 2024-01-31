using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A84 RID: 10884
	public sealed class CharacteristicsPanel : UIElement
	{
		// Token: 0x0600D842 RID: 55362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Item item, Item compareItem)
		{
			throw null;
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0([CanBeNull] Item item, Item compareItem)
		{
			throw null;
		}

		// Token: 0x0600D845 RID: 55365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCompare(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600D846 RID: 55366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCompareRequired(Item compareWith, Slot slot)
		{
			throw null;
		}

		// Token: 0x0600D847 RID: 55367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D848 RID: 55368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool expanded)
		{
			throw null;
		}

		// Token: 0x0600D84A RID: 55370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D84B RID: 55371 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ItemAttributeClass attribute, CharacteristicPanel full)
		{
			throw null;
		}

		// Token: 0x0600D84C RID: 55372 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(ItemAttributeClass attribute, CompactCharacteristicPanel compact)
		{
			throw null;
		}

		// Token: 0x0600D84D RID: 55373 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void smethod_0<T>(GClass3078<ItemAttributeClass, T> viewList, List<ItemAttributeClass> changedList) where T : CompactCharacteristicPanel
		{
			throw null;
		}

		// Token: 0x0400DB06 RID: 56070
		[SerializeField]
		private GameObject _infoButtonPanel;

		// Token: 0x0400DB07 RID: 56071
		[SerializeField]
		private GameObject _characteristics;

		// Token: 0x0400DB08 RID: 56072
		[SerializeField]
		private Button _infoButton;

		// Token: 0x0400DB09 RID: 56073
		[SerializeField]
		private Button _charPanelButton;

		// Token: 0x0400DB0A RID: 56074
		[SerializeField]
		private CharacteristicPanel _charPanelTemplate;

		// Token: 0x0400DB0B RID: 56075
		[SerializeField]
		private CharacteristicPanel _charDurability;

		// Token: 0x0400DB0C RID: 56076
		[SerializeField]
		private CharacteristicPanel _charWeight;

		// Token: 0x0400DB0D RID: 56077
		[SerializeField]
		private CompactCharacteristicPanel _compactCharTemplate;

		// Token: 0x0400DB0E RID: 56078
		[SerializeField]
		private Transform _charPanelContainer;

		// Token: 0x0400DB0F RID: 56079
		[SerializeField]
		private bool _expanded;

		// Token: 0x0400DB10 RID: 56080
		private Item item_0;

		// Token: 0x0400DB11 RID: 56081
		private Item item_1;

		// Token: 0x0400DB12 RID: 56082
		private GClass2748 gclass2748_0;

		// Token: 0x0400DB13 RID: 56083
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400DB14 RID: 56084
		private GClass3078<ItemAttributeClass, CharacteristicPanel> gclass3078_0;

		// Token: 0x0400DB15 RID: 56085
		private GClass3078<ItemAttributeClass, CompactCharacteristicPanel> gclass3078_1;

		// Token: 0x0400DB16 RID: 56086
		private GStruct55 gstruct55_0;

		// Token: 0x02002A85 RID: 10885
		[CompilerGenerated]
		private sealed class Class2533<T> where T : CompactCharacteristicPanel
		{
			// Token: 0x0600D84E RID: 55374 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass attr)
			{
				throw null;
			}

			// Token: 0x0400DB17 RID: 56087
			public ItemAttributeClass attribute;
		}

		// Token: 0x02002A86 RID: 10886
		[CompilerGenerated]
		private sealed class Class2534
		{
			// Token: 0x0600D84F RID: 55375 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0600D850 RID: 55376 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1()
			{
				throw null;
			}

			// Token: 0x0400DB18 RID: 56088
			public float allDurability;
		}

		// Token: 0x02002A87 RID: 10887
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2535
		{
			// Token: 0x0600D851 RID: 55377 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass x)
			{
				throw null;
			}

			// Token: 0x0600D852 RID: 55378 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemAttributeClass x)
			{
				throw null;
			}

			// Token: 0x0600D853 RID: 55379 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(ItemAttributeClass x)
			{
				throw null;
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal RepairableComponent method_3(ArmorComponent x)
			{
				throw null;
			}

			// Token: 0x0600D855 RID: 55381 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_4(RepairableComponent x)
			{
				throw null;
			}

			// Token: 0x0600D856 RID: 55382 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_5(RepairableComponent x)
			{
				throw null;
			}

			// Token: 0x0600D857 RID: 55383 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_6()
			{
				throw null;
			}

			// Token: 0x0400DB19 RID: 56089
			public static readonly CharacteristicsPanel.Class2535 class2535_0;

			// Token: 0x0400DB1A RID: 56090
			public static Func<ItemAttributeClass, bool> func_0;

			// Token: 0x0400DB1B RID: 56091
			public static Func<ItemAttributeClass, bool> func_1;

			// Token: 0x0400DB1C RID: 56092
			public static Predicate<ItemAttributeClass> predicate_0;

			// Token: 0x0400DB1D RID: 56093
			public static Func<ArmorComponent, RepairableComponent> func_2;

			// Token: 0x0400DB1E RID: 56094
			public static Func<RepairableComponent, float> func_3;

			// Token: 0x0400DB1F RID: 56095
			public static Func<RepairableComponent, float> func_4;

			// Token: 0x0400DB20 RID: 56096
			public static Func<EItemAttributeDisplayType> func_5;
		}

		// Token: 0x02002A88 RID: 10888
		[CompilerGenerated]
		private sealed class Class2536
		{
			// Token: 0x0600D858 RID: 55384 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass attribute)
			{
				throw null;
			}

			// Token: 0x0600D859 RID: 55385 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemAttributeClass attribute)
			{
				throw null;
			}

			// Token: 0x0400DB21 RID: 56097
			public CharacteristicsPanel characteristicsPanel_0;

			// Token: 0x0400DB22 RID: 56098
			public List<ItemAttributeClass> newAttributes;
		}

		// Token: 0x02002A89 RID: 10889
		[CompilerGenerated]
		private sealed class Class2537
		{
			// Token: 0x0600D85A RID: 55386 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass a)
			{
				throw null;
			}

			// Token: 0x0400DB23 RID: 56099
			public ItemAttributeClass attribute;
		}

		// Token: 0x02002A8A RID: 10890
		[CompilerGenerated]
		private sealed class Class2538
		{
			// Token: 0x0600D85B RID: 55387 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass a)
			{
				throw null;
			}

			// Token: 0x0600D85C RID: 55388 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemAttributeClass a)
			{
				throw null;
			}

			// Token: 0x0400DB24 RID: 56100
			public ItemAttributeClass attribute;
		}
	}
}
