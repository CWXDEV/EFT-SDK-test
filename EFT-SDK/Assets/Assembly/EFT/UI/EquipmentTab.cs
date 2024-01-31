using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B05 RID: 11013
	public class EquipmentTab : UIElement
	{
		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600DA8B RID: 55947 RVA: 0x00002050 File Offset: 0x00000250
		public bool AnyItemViews
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DA8C RID: 55948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600DA8D RID: 55949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2809 equipmentContext, EquipmentClass equipment, InventoryControllerClass inventoryController, SkillManager skills, InsuranceCompanyClass insurance, bool inRaid)
		{
			throw null;
		}

		// Token: 0x0600DA8E RID: 55950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SlotView GetSlotView(EquipmentSlot slotType)
		{
			throw null;
		}

		// Token: 0x0600DA8F RID: 55951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0400DD97 RID: 56727
		[SerializeField]
		private SlotView _earpieceSlot;

		// Token: 0x0400DD98 RID: 56728
		[SerializeField]
		private SlotView _headwearSlot;

		// Token: 0x0400DD99 RID: 56729
		[SerializeField]
		private SlotView _faceCoverSlot;

		// Token: 0x0400DD9A RID: 56730
		[SerializeField]
		private SlotView _armbandSlot;

		// Token: 0x0400DD9B RID: 56731
		[SerializeField]
		private SlotView _armorSlot;

		// Token: 0x0400DD9C RID: 56732
		[SerializeField]
		private SlotView _eyewearSlot;

		// Token: 0x0400DD9D RID: 56733
		[SerializeField]
		private SlotView _primaryWeaponSlot;

		// Token: 0x0400DD9E RID: 56734
		[SerializeField]
		private SlotView _holsterSlot;

		// Token: 0x0400DD9F RID: 56735
		[SerializeField]
		private SlotView _seconaryWeaponSlot;

		// Token: 0x0400DDA0 RID: 56736
		[SerializeField]
		private SlotView _scabbardSlot;

		// Token: 0x0400DDA1 RID: 56737
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400DDA2 RID: 56738
		private EquipmentClass gclass2697_0;

		// Token: 0x0400DDA3 RID: 56739
		protected Dictionary<EquipmentSlot, SlotView> _slotViews;
	}
}
