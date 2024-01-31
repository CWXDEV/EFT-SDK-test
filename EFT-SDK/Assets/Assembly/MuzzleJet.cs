using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AD0 RID: 2768
public class MuzzleJet : MuzzleEffect
{
	// Token: 0x06003C6E RID: 15470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RandomizeMaterial(Material material, Vector2 cellSize)
	{
		throw null;
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(ref int quadNum, MuzzleJet.Particle particle, Vector3 axis, Vector3 position, Vector2 cellSize, Vector2 posNorm, byte commonRnd, float addLengthRnd, Vector3[] vertices, Vector3[] normals, Vector2[] uv0, Vector2[] uv1, Color32[] colors, Vector4[] tangents)
	{
		throw null;
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(ref int quadNum, Transform patent, Vector2 cellSize, Vector3[] vertices, Vector3[] normals, Vector2[] uv0, Vector2[] uv1, Color32[] colors, Vector4[] tangents)
	{
		throw null;
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform UpdateOrCreateMesh(MuzzleJet[] muzzleJets, Transform patent, Material material, Vector2 cellSize)
	{
		throw null;
	}

	// Token: 0x0400422B RID: 16939
	public const string MeshName = "MuzzleJetCombinedMesh";

	// Token: 0x0400422C RID: 16940
	public MuzzleJet.Particle[] Particles;

	// Token: 0x0400422D RID: 16941
	public MuzzleJet.EditorType Type;

	// Token: 0x0400422E RID: 16942
	public int ParticlesCount;

	// Token: 0x0400422F RID: 16943
	public Vector3 JetBounds;

	// Token: 0x04004230 RID: 16944
	public AnimationCurve PositionDensity;

	// Token: 0x04004231 RID: 16945
	public AnimationCurve Sizes;

	// Token: 0x04004232 RID: 16946
	public AnimationCurve RandomShiftsX;

	// Token: 0x04004233 RID: 16947
	public AnimationCurve RandomShiftsY;

	// Token: 0x04004234 RID: 16948
	public AnimationCurve AxisShift;

	// Token: 0x04004235 RID: 16949
	public float SizesMult;

	// Token: 0x04004236 RID: 16950
	public float AxisShiftMult;

	// Token: 0x04004237 RID: 16951
	public float Chance;

	// Token: 0x04004238 RID: 16952
	public Vector2 RandomShiftsMult;

	// Token: 0x04004239 RID: 16953
	private static readonly int int_0;

	// Token: 0x0400423A RID: 16954
	private static readonly int int_1;

	// Token: 0x0400423B RID: 16955
	private static readonly int int_2;

	// Token: 0x02000AD1 RID: 2769
	public enum EditorType
	{
		// Token: 0x0400423D RID: 16957
		CurveDriven,
		// Token: 0x0400423E RID: 16958
		Manually
	}

	// Token: 0x02000AD2 RID: 2770
	[Serializable]
	public class Particle
	{
		// Token: 0x0400423F RID: 16959
		public float Position;

		// Token: 0x04004240 RID: 16960
		public float Size;

		// Token: 0x04004241 RID: 16961
		public Vector2 RandomShift;

		// Token: 0x04004242 RID: 16962
		public float AxisShift;
	}
}
