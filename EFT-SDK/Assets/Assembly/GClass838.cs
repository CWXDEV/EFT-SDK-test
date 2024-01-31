using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A1D RID: 2589
public class GClass838
{
	// Token: 0x06003901 RID: 14593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D LoadLUT(GClass838.LUTType type)
	{
		throw null;
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D smethod_0(TextureFormat format, Color[] pixels)
	{
		throw null;
	}

	// Token: 0x06003903 RID: 14595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D smethod_1(double[,] LUTTransformInv)
	{
		throw null;
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D smethod_2(float[] LUTScalar0, float[] LUTScalar1, float[] LUTScalar2)
	{
		throw null;
	}

	// Token: 0x04003AFF RID: 15103
	private static double[,] double_0;

	// Token: 0x04003B00 RID: 15104
	private static float[] float_0;

	// Token: 0x04003B01 RID: 15105
	private static double[,] double_1;

	// Token: 0x04003B02 RID: 15106
	private static float[] float_1;

	// Token: 0x04003B03 RID: 15107
	private static float[] float_2;

	// Token: 0x04003B04 RID: 15108
	private const int int_0 = 64;

	// Token: 0x04003B05 RID: 15109
	private const int int_1 = 3;

	// Token: 0x02000A1E RID: 2590
	public enum LUTType
	{
		// Token: 0x04003B07 RID: 15111
		TransformInv_DisneyDiffuse,
		// Token: 0x04003B08 RID: 15112
		TransformInv_GGX,
		// Token: 0x04003B09 RID: 15113
		AmpDiffAmpSpecFresnel
	}
}
