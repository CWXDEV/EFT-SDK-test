using System;
using System.Runtime.CompilerServices;
using EFT.UI.DragAndDrop;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x0200296B RID: 10603
	public sealed class EquipmentBuildGear : EquipmentTab
	{
		// Token: 0x0600D31B RID: 54043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0400D4F8 RID: 54520
		[SerializeField]
		private SlotView _tacticalVestSlot;

		// Token: 0x0400D4F9 RID: 54521
		[SerializeField]
		private SlotView _backpackSlot;

		// Token: 0x0400D4FA RID: 54522
		[SerializeField]
		private SlotView _securedContainerSlot;
	}
}
