using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A44 RID: 2628
public class CirclePacker : MonoBehaviour
{
	// Token: 0x060039A8 RID: 14760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x060039A9 RID: 14761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(CirclePacker.GClass842[] circles, int iterationCount)
	{
		throw null;
	}

	// Token: 0x060039AA RID: 14762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 smethod_1(Vector2 v)
	{
		throw null;
	}

	// Token: 0x060039AB RID: 14763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 smethod_2(Vector2 v)
	{
		throw null;
	}

	// Token: 0x060039AC RID: 14764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_3(CirclePacker.GClass842[] circles, float randomness)
	{
		throw null;
	}

	// Token: 0x060039AD RID: 14765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(CirclePacker.GClass842[] circles, Material material, int pass, float tuneSize)
	{
		throw null;
	}

	// Token: 0x060039AE RID: 14766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_5(Vector2 center, float size)
	{
		throw null;
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Texture2D smethod_6(RenderTexture renderTexture, bool mipMaps)
	{
		throw null;
	}

	// Token: 0x060039B0 RID: 14768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_7(Texture2D texture, float a, float b)
	{
		throw null;
	}

	// Token: 0x060039B1 RID: 14769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_8(Texture2D texture, bool asAsset)
	{
		throw null;
	}

	// Token: 0x04003CA4 RID: 15524
	public bool Generate;

	// Token: 0x04003CA5 RID: 15525
	public int Seed;

	// Token: 0x04003CA6 RID: 15526
	public int Count;

	// Token: 0x04003CA7 RID: 15527
	public Vector2 Radius;

	// Token: 0x04003CA8 RID: 15528
	[Range(0.8f, 1.2f)]
	public float TuneSize;

	// Token: 0x04003CA9 RID: 15529
	[Range(1f, 255f)]
	public int Iterations;

	// Token: 0x04003CAA RID: 15530
	[Range(0f, 1f)]
	public float AlphaRandomness;

	// Token: 0x04003CAB RID: 15531
	public int TextureSize;

	// Token: 0x04003CAC RID: 15532
	public bool FadeMips;

	// Token: 0x04003CAD RID: 15533
	public Vector2 FadeMinMax;

	// Token: 0x04003CAE RID: 15534
	public Material Material;

	// Token: 0x04003CAF RID: 15535
	public Material ViewMaterial;

	// Token: 0x04003CB0 RID: 15536
	public bool ExportTexture;

	// Token: 0x04003CB1 RID: 15537
	private RenderTexture renderTexture_0;

	// Token: 0x04003CB2 RID: 15538
	private CirclePacker.GClass842[] gclass842_0;

	// Token: 0x04003CB3 RID: 15539
	private static readonly int int_0;

	// Token: 0x02000A45 RID: 2629
	public class GClass842
	{
		// Token: 0x04003CB4 RID: 15540
		public Vector2 Pos;

		// Token: 0x04003CB5 RID: 15541
		public float Radius;

		// Token: 0x04003CB6 RID: 15542
		public float Alpha;
	}
}
