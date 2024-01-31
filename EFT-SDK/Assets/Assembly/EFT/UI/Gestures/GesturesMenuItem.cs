using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EB2 RID: 11954
	public sealed class GesturesMenuItem : GestureBaseItem
	{
		// Token: 0x17002895 RID: 10389
		// (set) Token: 0x0600EBFF RID: 60415 RVA: 0x00002050 File Offset: 0x00000250
		public Sprite Icon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0600EC00 RID: 60416 RVA: 0x00002050 File Offset: 0x00000250
		public override int ItemIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EC01 RID: 60417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Sprite defaultSubColor, Sprite selectedSubColor, GClass3175 binds)
		{
			throw null;
		}

		// Token: 0x0600EC02 RID: 60418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void BindUpdatedHandler(GesturesMenu.GStruct400 bind)
		{
			throw null;
		}

		// Token: 0x0600EC03 RID: 60419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UnderPointerChanged(bool isUnderPointer)
		{
			throw null;
		}

		// Token: 0x0600EC04 RID: 60420 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(KeyValuePair<ECommand, int> x)
		{
			throw null;
		}

		// Token: 0x0400F10F RID: 61711
		public EGesture Gesture;

		// Token: 0x0400F110 RID: 61712
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0400F111 RID: 61713
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400F112 RID: 61714
		[SerializeField]
		[Space]
		private GameObject _bindObject;

		// Token: 0x0400F113 RID: 61715
		[SerializeField]
		private CustomTextMeshProUGUI _bindLabel;

		// Token: 0x0400F114 RID: 61716
		[SerializeField]
		private CustomTextMeshProUGUI _commandLabel;

		// Token: 0x0400F115 RID: 61717
		private Sprite sprite_0;

		// Token: 0x0400F116 RID: 61718
		private Sprite sprite_1;

		// Token: 0x0400F117 RID: 61719
		private ECommand ecommand_0;
	}
}
