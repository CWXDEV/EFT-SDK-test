using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000C07 RID: 3079
[CreateAssetMenu]
[Serializable]
public sealed class WinterMaterialSpeedTreeEft : ScriptableObject, GInterface44
{
	// Token: 0x17000AD4 RID: 2772
	// (get) Token: 0x060042C1 RID: 17089 RVA: 0x00002050 File Offset: 0x00000250
	private static LoggerClass WinterLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060042C2 RID: 17090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fix()
	{
		throw null;
	}

	// Token: 0x04004C59 RID: 19545
	private static readonly int _base;

	// Token: 0x04004C5A RID: 19546
	private static readonly int _normalMap;

	// Token: 0x04004C5B RID: 19547
	private static readonly int _detail;

	// Token: 0x04004C5C RID: 19548
	private static readonly int _hueVariation;

	// Token: 0x04004C5D RID: 19549
	private static readonly int _color;

	// Token: 0x04004C5E RID: 19550
	public Material Material;

	// Token: 0x04004C5F RID: 19551
	public Texture Base;

	// Token: 0x04004C60 RID: 19552
	public Texture NormalMap;

	// Token: 0x04004C61 RID: 19553
	public Texture Detail;

	// Token: 0x04004C62 RID: 19554
	public Color HueVariation;

	// Token: 0x04004C63 RID: 19555
	public Color Color;
}
