using System;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000C03 RID: 3075
[CreateAssetMenu]
[Serializable]
public sealed class WinterMaterialGrassInstancer : ScriptableObject, GInterface44
{
	// Token: 0x17000AD0 RID: 2768
	// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00002050 File Offset: 0x00000250
	private static LoggerClass WinterLogger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060042B6 RID: 17078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fix()
	{
		throw null;
	}

	// Token: 0x04004C49 RID: 19529
	public GPUInstancerDetailPrototype Prototype;

	// Token: 0x04004C4A RID: 19530
	public Texture2D Texture;

	// Token: 0x04004C4B RID: 19531
	public Texture2D BumpMap;
}
