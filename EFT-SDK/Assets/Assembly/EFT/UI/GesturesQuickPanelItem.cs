using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028C5 RID: 10437
	public class GesturesQuickPanelItem : UIElement
	{
		// Token: 0x0600D073 RID: 53363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EPhraseTrigger trigger)
		{
			throw null;
		}

		// Token: 0x0600D074 RID: 53364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select()
		{
			throw null;
		}

		// Token: 0x0600D075 RID: 53365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deselect()
		{
			throw null;
		}

		// Token: 0x0600D076 RID: 53366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D143 RID: 53571
		[SerializeField]
		private CustomTextMeshProUGUI _label;

		// Token: 0x0400D144 RID: 53572
		[SerializeField]
		private Image _background;

		// Token: 0x0400D145 RID: 53573
		[SerializeField]
		private GameObject _yObject;

		// Token: 0x0400D146 RID: 53574
		[SerializeField]
		private Color _defaultBackground;

		// Token: 0x0400D147 RID: 53575
		[SerializeField]
		private Color _selectedBackground;

		// Token: 0x0400D148 RID: 53576
		[SerializeField]
		private Color _defaultText;

		// Token: 0x0400D149 RID: 53577
		[SerializeField]
		private Color _selectedText;
	}
}
