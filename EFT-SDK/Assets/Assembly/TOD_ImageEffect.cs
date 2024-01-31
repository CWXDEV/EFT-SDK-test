using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000AC RID: 172
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public abstract class TOD_ImageEffect : MonoBehaviour
{
	// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Material CreateMaterial(Shader shader)
	{
		throw null;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Awake()
	{
		throw null;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool CheckSupport(bool needDepth = false, bool needHdr = false)
	{
		throw null;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
		throw null;
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CustomBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr = 0)
	{
		throw null;
	}

	// Token: 0x040003A9 RID: 937
	public TOD_Sky sky;

	// Token: 0x040003AA RID: 938
	protected Camera cam;

	// Token: 0x040003AB RID: 939
	private static readonly int int_0;

	// Token: 0x040003AC RID: 940
	private bool bool_0;

	// Token: 0x040003AD RID: 941
	private bool bool_1;
}
