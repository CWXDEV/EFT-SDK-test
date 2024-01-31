using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020009D9 RID: 2521
public class TwoValueBar : MonoBehaviour
{
	// Token: 0x06003818 RID: 14360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBase(float value)
	{
		throw null;
	}

	// Token: 0x06003819 RID: 14361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNew(float value)
	{
		throw null;
	}

	// Token: 0x040039D7 RID: 14807
	[SerializeField]
	private RectTransform _baseFill;

	// Token: 0x040039D8 RID: 14808
	[SerializeField]
	private RectTransform _newFill;

	// Token: 0x040039D9 RID: 14809
	[SerializeField]
	private RectTransform _newGlow;

	// Token: 0x040039DA RID: 14810
	[SerializeField]
	private float _spacing;

	// Token: 0x040039DB RID: 14811
	private float float_0;
}
