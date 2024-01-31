using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EAA RID: 11946
	public class GesturesDropdownPanel : UIInputNode
	{
		// Token: 0x0600EBCF RID: 60367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EBD0 RID: 60368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x00002050 File Offset: 0x00000250
		public bool DropdownPanelActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EBD2 RID: 60370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCommand(EPhraseTrigger trigger)
		{
			throw null;
		}

		// Token: 0x0600EBD3 RID: 60371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GesturesQuickPanelItem method_1(EPhraseTrigger trigger)
		{
			throw null;
		}

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCommand(EPhraseTrigger trigger)
		{
			throw null;
		}

		// Token: 0x0600EBD5 RID: 60373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDropdown()
		{
			throw null;
		}

		// Token: 0x0600EBD6 RID: 60374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EBD7 RID: 60375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseDropdown()
		{
			throw null;
		}

		// Token: 0x0600EBD8 RID: 60376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600EBD9 RID: 60377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600EBDA RID: 60378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0400F0E2 RID: 61666
		[SerializeField]
		private GesturesQuickPanelItem _quickTemplate;

		// Token: 0x0400F0E3 RID: 61667
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400F0E4 RID: 61668
		[SerializeField]
		private GameObject _dropdownObject;

		// Token: 0x0400F0E5 RID: 61669
		private readonly SortedDictionary<EPhraseTrigger, GesturesQuickPanelItem> sortedDictionary_0;

		// Token: 0x0400F0E6 RID: 61670
		private readonly SortedDictionary<EPhraseTrigger, GesturesQuickPanelItem> sortedDictionary_1;

		// Token: 0x0400F0E7 RID: 61671
		internal EPhraseTrigger ephraseTrigger_0;

		// Token: 0x0400F0E8 RID: 61672
		private int int_0;
	}
}
