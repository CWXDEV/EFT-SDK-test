using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000C01 RID: 3073
[CreateAssetMenu]
[Serializable]
public class WinterMaterialBD2S : ScriptableObject, GInterface44
{
	// Token: 0x17000ACE RID: 2766
	// (get) Token: 0x060042B1 RID: 17073 RVA: 0x00002050 File Offset: 0x00000250
	private static LoggerClass WinterLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fix()
	{
		throw null;
	}

	// Token: 0x04004C37 RID: 19511
	private static readonly int _mainTex;

	// Token: 0x04004C38 RID: 19512
	private static readonly int _bumpMap;

	// Token: 0x04004C39 RID: 19513
	private static readonly int _color;

	// Token: 0x04004C3A RID: 19514
	public Material Material;

	// Token: 0x04004C3B RID: 19515
	public Texture MainTex;

	// Token: 0x04004C3C RID: 19516
	public Texture BumpMap;

	// Token: 0x04004C3D RID: 19517
	public Color Color;
}
