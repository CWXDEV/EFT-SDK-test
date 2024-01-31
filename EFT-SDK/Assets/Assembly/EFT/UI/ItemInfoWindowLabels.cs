using System;
using System.Runtime.CompilerServices;
using EFT.UI.WeaponModding;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x020029F9 RID: 10745
	public sealed class ItemInfoWindowLabels : UIElement
	{
		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x0600D585 RID: 54661 RVA: 0x00002050 File Offset: 0x00000250
		private DragTrigger DragTrigger_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x00002050 File Offset: 0x00000250
		private ScrollTrigger ScrollTrigger_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Show(WeaponPreview weaponPreview, bool canDrag = true)
		{
			throw null;
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string value)
		{
			throw null;
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string value, bool addToText = false)
		{
			throw null;
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(string value)
		{
			throw null;
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(string value)
		{
			throw null;
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600D58E RID: 54670 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0400D7A6 RID: 55206
		private const float float_0 = 0.12f;

		// Token: 0x0400D7A7 RID: 55207
		[SerializeField]
		private GameObject _previewPanel;

		// Token: 0x0400D7A8 RID: 55208
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x0400D7A9 RID: 55209
		[SerializeField]
		private CustomTextMeshProUGUI _itemType;

		// Token: 0x0400D7AA RID: 55210
		[SerializeField]
		private CustomTextMeshProUGUI _description;

		// Token: 0x0400D7AB RID: 55211
		[SerializeField]
		private CustomTextMeshProUGUI _weightText;

		// Token: 0x0400D7AC RID: 55212
		private DragTrigger dragTrigger_0;

		// Token: 0x0400D7AD RID: 55213
		private ScrollTrigger scrollTrigger_0;

		// Token: 0x0400D7AE RID: 55214
		private WeaponPreview weaponPreview_0;
	}
}
