using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B12 RID: 2834
public class ColorDetailInstancing : MonoBehaviour
{
	// Token: 0x06003D90 RID: 15760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(ColorDetailInstancing.MaterialControlls[] controlls)
	{
		throw null;
	}

	// Token: 0x06003D91 RID: 15761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x040043E1 RID: 17377
	private static Shader shader_0;

	// Token: 0x040043E2 RID: 17378
	private static readonly int int_0;

	// Token: 0x040043E3 RID: 17379
	private static readonly int int_1;

	// Token: 0x040043E4 RID: 17380
	private static readonly int int_2;

	// Token: 0x040043E5 RID: 17381
	private static MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x040043E6 RID: 17382
	[SerializeField]
	private ColorDetailInstancing.MaterialControlls[] _materials;

	// Token: 0x02000B13 RID: 2835
	[Serializable]
	public struct MaterialLink
	{
		// Token: 0x040043E7 RID: 17383
		public MeshRenderer MeshRenderer;

		// Token: 0x040043E8 RID: 17384
		public int MaterialIndex;
	}

	// Token: 0x02000B14 RID: 2836
	[Serializable]
	public struct MaterialControlls
	{
		// Token: 0x040043E9 RID: 17385
		public Material material;

		// Token: 0x040043EA RID: 17386
		public Color Color;

		// Token: 0x040043EB RID: 17387
		public int DetailTexIndex;

		// Token: 0x040043EC RID: 17388
		public float DetailScale;

		// Token: 0x040043ED RID: 17389
		[HideInInspector]
		public ColorDetailInstancing.MaterialLink[] Links;
	}
}
