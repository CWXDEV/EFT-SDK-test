using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000C06 RID: 3078
[CreateAssetMenu]
[Serializable]
public sealed class WinterMaterialSpeedTree8 : ScriptableObject, GInterface44
{
	// Token: 0x17000AD3 RID: 2771
	// (get) Token: 0x060042BF RID: 17087 RVA: 0x00002050 File Offset: 0x00000250
	private static LoggerClass WinterLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060042C0 RID: 17088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fix()
	{
		throw null;
	}

	// Token: 0x04004C50 RID: 19536
	private static readonly int _mainTex;

	// Token: 0x04004C51 RID: 19537
	private static readonly int _normalMap;

	// Token: 0x04004C52 RID: 19538
	private static readonly int _hueVariationColor;

	// Token: 0x04004C53 RID: 19539
	private static readonly int _color;

	// Token: 0x04004C54 RID: 19540
	public Material Material;

	// Token: 0x04004C55 RID: 19541
	public Texture MainTex;

	// Token: 0x04004C56 RID: 19542
	public Texture NormalMap;

	// Token: 0x04004C57 RID: 19543
	public Color HueVariation;

	// Token: 0x04004C58 RID: 19544
	public Color Color;
}
