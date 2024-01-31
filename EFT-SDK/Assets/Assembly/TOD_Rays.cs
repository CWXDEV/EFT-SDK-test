using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000BB RID: 187
[AddComponentMenu("Time of Day/Camera God Rays")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TOD_Rays : TOD_ImageEffect
{
	// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnEnable()
	{
		throw null;
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnDisable()
	{
		throw null;
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040003FD RID: 1021
	public Shader GodRayShader;

	// Token: 0x040003FE RID: 1022
	public Shader ScreenClearShader;

	// Token: 0x040003FF RID: 1023
	public TOD_Rays.ResolutionType Resolution;

	// Token: 0x04000400 RID: 1024
	public TOD_Rays.BlendModeType BlendMode;

	// Token: 0x04000401 RID: 1025
	public int BlurIterations;

	// Token: 0x04000402 RID: 1026
	public float BlurRadius;

	// Token: 0x04000403 RID: 1027
	public float Intensity;

	// Token: 0x04000404 RID: 1028
	public float MaxRadius;

	// Token: 0x04000405 RID: 1029
	public bool UseDepthTexture;

	// Token: 0x04000406 RID: 1030
	private Material material_0;

	// Token: 0x04000407 RID: 1031
	private Material material_1;

	// Token: 0x04000408 RID: 1032
	private static readonly int int_1;

	// Token: 0x04000409 RID: 1033
	private static readonly int int_2;

	// Token: 0x0400040A RID: 1034
	private static readonly int int_3;

	// Token: 0x0400040B RID: 1035
	private static readonly int int_4;

	// Token: 0x0400040C RID: 1036
	private const int int_5 = 2;

	// Token: 0x0400040D RID: 1037
	private const int int_6 = 3;

	// Token: 0x0400040E RID: 1038
	private const int int_7 = 1;

	// Token: 0x0400040F RID: 1039
	private const int int_8 = 0;

	// Token: 0x04000410 RID: 1040
	private const int int_9 = 4;

	// Token: 0x020000BC RID: 188
	public enum ResolutionType
	{
		// Token: 0x04000412 RID: 1042
		Low,
		// Token: 0x04000413 RID: 1043
		Normal,
		// Token: 0x04000414 RID: 1044
		High
	}

	// Token: 0x020000BD RID: 189
	public enum BlendModeType
	{
		// Token: 0x04000416 RID: 1046
		Screen,
		// Token: 0x04000417 RID: 1047
		Add
	}
}
