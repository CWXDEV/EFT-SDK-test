using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000BA6 RID: 2982
public class HairRenderer : MonoBehaviour
{
	// Token: 0x060040AC RID: 16556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060040AD RID: 16557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x060040AF RID: 16559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x060040B0 RID: 16560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x060040B1 RID: 16561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_4(Material m)
	{
		throw null;
	}

	// Token: 0x060040B2 RID: 16562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x060040B3 RID: 16563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x060040B4 RID: 16564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x040049CB RID: 18891
	public Renderer sourceRenderer;

	// Token: 0x040049CC RID: 18892
	public HairRenderer.Mode mode;

	// Token: 0x040049CD RID: 18893
	public bool useOpaquePass;

	// Token: 0x040049CE RID: 18894
	public float opaqueAlphaRef;

	// Token: 0x040049CF RID: 18895
	public bool frontWriteDepth;

	// Token: 0x040049D0 RID: 18896
	public float frontBackAlphaRef;

	// Token: 0x040049D1 RID: 18897
	public HairRenderer.DebugMode debugMode;

	// Token: 0x040049D2 RID: 18898
	[HideInInspector]
	public Transform[] headSpheres;

	// Token: 0x040049D3 RID: 18899
	[HideInInspector]
	public Transform headShell;

	// Token: 0x040049D4 RID: 18900
	[HideInInspector]
	public float sortDistanceScale;

	// Token: 0x040049D5 RID: 18901
	private Mesh mesh_0;

	// Token: 0x040049D6 RID: 18902
	private Mesh mesh_1;

	// Token: 0x040049D7 RID: 18903
	private int[] int_0;

	// Token: 0x040049D8 RID: 18904
	private MeshFilter meshFilter_0;

	// Token: 0x040049D9 RID: 18905
	private HairRenderer.Class611 class611_0;

	// Token: 0x040049DA RID: 18906
	private Material material_0;

	// Token: 0x040049DB RID: 18907
	private Material material_1;

	// Token: 0x040049DC RID: 18908
	private Material material_2;

	// Token: 0x040049DD RID: 18909
	private static readonly int int_1;

	// Token: 0x040049DE RID: 18910
	private static readonly int int_2;

	// Token: 0x040049DF RID: 18911
	private static readonly int int_3;

	// Token: 0x040049E0 RID: 18912
	private static readonly int int_4;

	// Token: 0x040049E1 RID: 18913
	private static readonly int int_5;

	// Token: 0x040049E2 RID: 18914
	private static readonly int int_6;

	// Token: 0x02000BA7 RID: 2983
	public enum DebugMode
	{
		// Token: 0x040049E4 RID: 18916
		DBG_NONE,
		// Token: 0x040049E5 RID: 18917
		DBG_OCCLUSION,
		// Token: 0x040049E6 RID: 18918
		DBG_GRAYMASK,
		// Token: 0x040049E7 RID: 18919
		DBG_MASKEDALBEDO,
		// Token: 0x040049E8 RID: 18920
		DBG_SPECULAR,
		// Token: 0x040049E9 RID: 18921
		DBG_LIGHTING,
		// Token: 0x040049EA RID: 18922
		DBG_FLOW
	}

	// Token: 0x02000BA8 RID: 2984
	public enum Mode
	{
		// Token: 0x040049EC RID: 18924
		Original,
		// Token: 0x040049ED RID: 18925
		StaticHeightBased,
		// Token: 0x040049EE RID: 18926
		DynamicRadialDistance
	}

	// Token: 0x02000BA9 RID: 2985
	private class Class611
	{
		// Token: 0x060040B5 RID: 16565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int patchCount, int patchIdx, int offset, int[] indices)
		{
			throw null;
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BuildNormalizedPatches()
		{
			throw null;
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SortIndices(Vector3 eye, int[] indices, float distScale)
		{
			throw null;
		}

		// Token: 0x040049EF RID: 18927
		private Vector3[] vector3_0;

		// Token: 0x040049F0 RID: 18928
		private Vector2[] vector2_0;

		// Token: 0x040049F1 RID: 18929
		private Color[] color_0;

		// Token: 0x040049F2 RID: 18930
		private HairRenderer.Class611.Struct121[] struct121_0;

		// Token: 0x040049F3 RID: 18931
		private uint[] uint_0;

		// Token: 0x040049F4 RID: 18932
		public Color[] staticPatchColors;

		// Token: 0x040049F5 RID: 18933
		public int[] staticPatchIndices;

		// Token: 0x02000BAA RID: 2986
		private class Class612
		{
			// Token: 0x040049F6 RID: 18934
			public int i0;

			// Token: 0x040049F7 RID: 18935
			public int i1;

			// Token: 0x040049F8 RID: 18936
			public int i2;
		}

		// Token: 0x02000BAB RID: 2987
		private class Class613
		{
			// Token: 0x060040B8 RID: 16568 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool AddTriangle(HairRenderer.Class611.Class612 t)
			{
				throw null;
			}

			// Token: 0x060040B9 RID: 16569 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Merge(HairRenderer.Class611.Class613 p)
			{
				throw null;
			}

			// Token: 0x040049F9 RID: 18937
			public HairRenderer.Class611 owner;

			// Token: 0x040049FA RID: 18938
			public HashSet<int> indices;

			// Token: 0x040049FB RID: 18939
			public HashSet<HairRenderer.Class611.Class612> triangles;
		}

		// Token: 0x02000BAC RID: 2988
		[StructLayout(LayoutKind.Auto)]
		public struct Struct121
		{
			// Token: 0x040049FC RID: 18940
			public Vector3 centroid;

			// Token: 0x040049FD RID: 18941
			public float layer;

			// Token: 0x040049FE RID: 18942
			public int[] indices;
		}
	}
}
