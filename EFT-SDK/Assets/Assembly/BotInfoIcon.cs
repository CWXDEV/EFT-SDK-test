using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009A8 RID: 2472
public class BotInfoIcon : MonoBehaviour
{
	// Token: 0x06003767 RID: 14183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBool(bool value)
	{
		throw null;
	}

	// Token: 0x06003768 RID: 14184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInt(int value)
	{
		throw null;
	}

	// Token: 0x06003769 RID: 14185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColor(Color color)
	{
		throw null;
	}

	// Token: 0x040038BD RID: 14525
	[SerializeField]
	private Image _icon;

	// Token: 0x040038BE RID: 14526
	[SerializeField]
	private Color _trueColor;

	// Token: 0x040038BF RID: 14527
	[SerializeField]
	private Color _falseColor;

	// Token: 0x040038C0 RID: 14528
	[SerializeField]
	private List<Color> _additionalColors;

	// Token: 0x040038C1 RID: 14529
	private bool bool_0;

	// Token: 0x040038C2 RID: 14530
	private int int_0;
}
