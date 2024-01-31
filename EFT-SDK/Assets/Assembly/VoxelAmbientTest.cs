using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AB3 RID: 2739
[ExecuteInEditMode]
public class VoxelAmbientTest : MonoBehaviour
{
	// Token: 0x06003BF9 RID: 15353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06003BFC RID: 15356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool[] method_0()
	{
		throw null;
	}

	// Token: 0x06003BFD RID: 15357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(float lightRange, out int[][] axes, out float[] intensities, out Vector3[] vectors)
	{
		throw null;
	}

	// Token: 0x04004156 RID: 16726
	public int PixelsX;

	// Token: 0x04004157 RID: 16727
	public int PixelsY;

	// Token: 0x04004158 RID: 16728
	public int PixelsZ;

	// Token: 0x04004159 RID: 16729
	[Space]
	public int Upsample;

	// Token: 0x0400415A RID: 16730
	[Space]
	public float LightRange;

	// Token: 0x0400415B RID: 16731
	public float NormalsContrast;

	// Token: 0x0400415C RID: 16732
	public float WallLightness;

	// Token: 0x0400415D RID: 16733
	[Space]
	public Transform GridPosition;

	// Token: 0x0400415E RID: 16734
	public Material Material;

	// Token: 0x0400415F RID: 16735
	public Texture3D Tex;

	// Token: 0x04004160 RID: 16736
	public Vector4 DebugVec;

	// Token: 0x04004161 RID: 16737
	public bool DebugDrawGrid;

	// Token: 0x04004162 RID: 16738
	private static readonly int int_0;

	// Token: 0x02000AB4 RID: 2740
	private class Class551
	{
		// Token: 0x06003BFE RID: 15358 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool[] GetObstacles(Transform gridPosition)
		{
			throw null;
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LinkedList<int> GetSunLight(bool[] obstacles)
		{
			throw null;
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float[] GetLight(bool[] obstacles, LinkedList<int> lights, int[][] axes, float[] intensities)
		{
			throw null;
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color[] GetDirected(float[] array, int[][] axes, Vector3[] vectors, float NormalContrast)
		{
			throw null;
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color[] BlurImage(Color[] pixels, int size)
		{
			throw null;
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color[] Downsample(Color[] pixels, int samples, out VoxelAmbientTest.Class551 im)
		{
			throw null;
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0(int x, int y, int z)
		{
			throw null;
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(int id, out int x, out int y, out int z)
		{
			throw null;
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture3D GetTex(Color[] pixels)
		{
			throw null;
		}

		// Token: 0x04004163 RID: 16739
		private int int_0;

		// Token: 0x04004164 RID: 16740
		private int int_1;

		// Token: 0x04004165 RID: 16741
		private int int_2;

		// Token: 0x04004166 RID: 16742
		private int int_3;
	}
}
