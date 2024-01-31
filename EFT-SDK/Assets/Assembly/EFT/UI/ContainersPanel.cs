using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.UI
{
	// Token: 0x0200291D RID: 10525
	[UsedImplicitly]
	public sealed class ContainersPanel : UIElement
	{
		// Token: 0x0600D22F RID: 53807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2809 parentContext, EquipmentClass equipment, InventoryControllerClass inventoryController, SkillManager skills, InsuranceCompanyClass insurance, bool inRaid)
		{
			throw null;
		}

		// Token: 0x0600D230 RID: 53808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private SlotView method_0(EquipmentSlot slotName)
		{
			throw null;
		}

		// Token: 0x0600D231 RID: 53809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D383 RID: 54147
		private const int int_0 = 10;

		// Token: 0x0400D384 RID: 54148
		[SerializeField]
		private Transform _slotViewsContainer;

		// Token: 0x0400D385 RID: 54149
		[SerializeField]
		private SlotView _dogtagTemplate;

		// Token: 0x0400D386 RID: 54150
		[SerializeField]
		[FormerlySerializedAs("SlotTemplate")]
		private SlotView _defaultSlotTemplate;

		// Token: 0x0400D387 RID: 54151
		private readonly Dictionary<EquipmentSlot, SlotView> dictionary_0;

		// Token: 0x0400D388 RID: 54152
		private SlotView slotView_0;

		// Token: 0x0400D389 RID: 54153
		private static readonly EquipmentSlot[] equipmentSlot_0;
	}
}
