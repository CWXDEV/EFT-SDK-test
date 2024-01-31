using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020009D1 RID: 2513
public class TabFont : Tab
{
	// Token: 0x060037FD RID: 14333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnPointerEnter(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x060037FE RID: 14334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnPointerExit(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x060037FF RID: 14335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void vmethod_0(bool active)
	{
		throw null;
	}

	// Token: 0x040039B7 RID: 14775
	[SerializeField]
	private CustomTextMeshProUGUI _label;

	// Token: 0x040039B8 RID: 14776
	[SerializeField]
	private Color _defaultColor;

	// Token: 0x040039B9 RID: 14777
	[SerializeField]
	private Color _hoverColor;

	// Token: 0x040039BA RID: 14778
	[SerializeField]
	private FontStyle _defaultFont;

	// Token: 0x040039BB RID: 14779
	[SerializeField]
	private FontStyle _hoverFont;
}
