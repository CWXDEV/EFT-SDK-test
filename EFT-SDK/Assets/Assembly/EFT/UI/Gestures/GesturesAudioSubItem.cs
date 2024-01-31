using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EA5 RID: 11941
	public sealed class GesturesAudioSubItem : GestureBaseItem
	{
		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600EBA4 RID: 60324 RVA: 0x00002050 File Offset: 0x00000250
		public override int ItemIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EBA5 RID: 60325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Sprite defaultBackground, Sprite selectedBackground, Color defaultAudioColor, Color selectedAudioColor, GClass3175 binds)
		{
			throw null;
		}

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void BindUpdatedHandler(GesturesMenu.GStruct400 bind)
		{
			throw null;
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UnderPointerChanged(bool isUnderPointer)
		{
			throw null;
		}

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(KeyValuePair<ECommand, int> x)
		{
			throw null;
		}

		// Token: 0x0400F0BB RID: 61627
		public EPhraseTrigger PhraseTrigger;

		// Token: 0x0400F0BC RID: 61628
		public bool IsSituational;

		// Token: 0x0400F0BD RID: 61629
		[SerializeField]
		private Image _background;

		// Token: 0x0400F0BE RID: 61630
		[SerializeField]
		private GameObject _situationalMarker;

		// Token: 0x0400F0BF RID: 61631
		[SerializeField]
		private CustomTextMeshProUGUI _textField;

		// Token: 0x0400F0C0 RID: 61632
		[Space]
		[SerializeField]
		private GameObject _bindObject;

		// Token: 0x0400F0C1 RID: 61633
		[SerializeField]
		private CustomTextMeshProUGUI _bindLabel;

		// Token: 0x0400F0C2 RID: 61634
		private Sprite sprite_0;

		// Token: 0x0400F0C3 RID: 61635
		private Sprite sprite_1;

		// Token: 0x0400F0C4 RID: 61636
		private Color color_0;

		// Token: 0x0400F0C5 RID: 61637
		private Color color_1;

		// Token: 0x0400F0C6 RID: 61638
		private ECommand ecommand_0;
	}
}
