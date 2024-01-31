using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Token: 0x020009A5 RID: 2469
public class BotDebugMenuItemTemplate : MonoBehaviour
{
	// Token: 0x06003758 RID: 14168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeSelection(bool selected)
	{
		throw null;
	}

	// Token: 0x06003759 RID: 14169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetArrowsVisible(bool left, bool right)
	{
		throw null;
	}

	// Token: 0x0600375A RID: 14170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHitActive(bool active)
	{
		throw null;
	}

	// Token: 0x040038B0 RID: 14512
	public TMP_Text ItemLabel;

	// Token: 0x040038B1 RID: 14513
	public TMP_Text HintText;

	// Token: 0x040038B2 RID: 14514
	[SerializeField]
	private GameObject _selector;

	// Token: 0x040038B3 RID: 14515
	[SerializeField]
	private GameObject _leftArrow;

	// Token: 0x040038B4 RID: 14516
	[SerializeField]
	private GameObject _rightArrow;

	// Token: 0x040038B5 RID: 14517
	[SerializeField]
	private GameObject _hintRoot;
}
