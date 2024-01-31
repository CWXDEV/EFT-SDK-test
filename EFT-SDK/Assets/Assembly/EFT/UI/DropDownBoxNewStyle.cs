using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C38 RID: 11320
	[UsedImplicitly]
	public class DropDownBoxNewStyle : BaseDropDownBox
	{
		// Token: 0x0600DF16 RID: 57110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(IEnumerable<string> values, Func<int, bool> validator = null)
		{
			throw null;
		}

		// Token: 0x0600DF17 RID: 57111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetPanelState(bool open)
		{
			throw null;
		}

		// Token: 0x0600DF18 RID: 57112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetTextInternal(string text)
		{
			throw null;
		}

		// Token: 0x0600DF19 RID: 57113 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400E3F2 RID: 58354
		[SerializeField]
		private List<TMP_Text> _labels;

		// Token: 0x0400E3F3 RID: 58355
		[SerializeField]
		private RectTransform _listContainer;

		// Token: 0x0400E3F4 RID: 58356
		[SerializeField]
		private DefaultUiButtonNewStyle _mainButton;

		// Token: 0x0400E3F5 RID: 58357
		[SerializeField]
		private GameObject _upArrows;

		// Token: 0x0400E3F6 RID: 58358
		[SerializeField]
		private GameObject _downArrows;
	}
}
