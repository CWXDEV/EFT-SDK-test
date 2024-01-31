using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E44 RID: 11844
	public class SlotItemView : GridItemView
	{
		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600E9E1 RID: 59873 RVA: 0x00002050 File Offset: 0x00000250
		protected override string ValueFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnBeingExaminedChanged(bool isBeingExamined)
		{
			throw null;
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SlotItemView Create(Item item, GClass2809 sourceContext, TraderControllerClass inventoryController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SlotItemView NewSlotItemView(Item item, GClass2809 sourceContext, ItemRotation rotation, TraderControllerClass inventoryController, IItemOwner itemOwner, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupAddress()
		{
			throw null;
		}

		// Token: 0x0600E9E6 RID: 59878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateStaticInfo()
		{
			throw null;
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateInfo()
		{
			throw null;
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateInfoVisibility(bool visible)
		{
			throw null;
		}

		// Token: 0x0600E9E9 RID: 59881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_34()
		{
			throw null;
		}

		// Token: 0x0600E9EA RID: 59882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_3(RectTransform rectTransform)
		{
			throw null;
		}

		// Token: 0x0400EE5D RID: 61021
		[SerializeField]
		protected Image BackgroundPattern;

		// Token: 0x0400EE5E RID: 61022
		[SerializeField]
		protected Image BackgroundShadow;

		// Token: 0x0400EE5F RID: 61023
		[SerializeField]
		private Slider _masteringSlider;

		// Token: 0x0400EE60 RID: 61024
		[SerializeField]
		private Image _masteringIcon;

		// Token: 0x0400EE61 RID: 61025
		[SerializeField]
		private DurabilitySlider _durabilitySlider;

		// Token: 0x0400EE62 RID: 61026
		[SerializeField]
		private TextMeshProUGUI _masteringLabel;

		// Token: 0x0400EE63 RID: 61027
		private const float float_4 = 10f;

		// Token: 0x0400EE64 RID: 61028
		private ItemAttributeClass gclass2745_0;

		// Token: 0x0400EE65 RID: 61029
		private bool bool_8;

		// Token: 0x0400EE66 RID: 61030
		private bool bool_9;

		// Token: 0x0400EE67 RID: 61031
		private SkillManager skillManager_0;

		// Token: 0x02002E45 RID: 11845
		[CompilerGenerated]
		private sealed class Class2892
		{
			// Token: 0x0600E9EB RID: 59883 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x0400EE68 RID: 61032
			public GClass1764 mastered;
		}

		// Token: 0x02002E46 RID: 11846
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2893
		{
			// Token: 0x0600E9EC RID: 59884 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass x)
			{
				throw null;
			}

			// Token: 0x0400EE69 RID: 61033
			public static readonly SlotItemView.Class2893 class2893_0;

			// Token: 0x0400EE6A RID: 61034
			public static Predicate<ItemAttributeClass> predicate_0;
		}
	}
}
