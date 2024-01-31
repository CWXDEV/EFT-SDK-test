using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000AC4 RID: 2756
[ExecuteInEditMode]
public sealed class MultiFlare : MonoBehaviour
{
	// Token: 0x170009DF RID: 2527
	// (get) Token: 0x06003C3A RID: 15418 RVA: 0x00002050 File Offset: 0x00000250
	public int RegisteredLightsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170009E0 RID: 2528
	// (get) Token: 0x06003C3B RID: 15419 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyList<MultiFlareLight> Lights
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170009E1 RID: 2529
	// (get) Token: 0x06003C3C RID: 15420 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GenerateMesh()
	{
		throw null;
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterLight(MultiFlareLight flareLight)
	{
		throw null;
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveLight(MultiFlareLight flareLight)
	{
		throw null;
	}

	// Token: 0x06003C43 RID: 15427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveLight(int index)
	{
		throw null;
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllLights()
	{
		throw null;
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private MultiFlare.GClass859 method_0(in MultiFlare.EFlareType type, Material material)
	{
		throw null;
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int capacity)
	{
		throw null;
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<int> method_2(in int count)
	{
		throw null;
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_3(in MultiFlare.EFlareType type)
	{
		throw null;
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(in Vector3 position, ref Bounds bounds)
	{
		throw null;
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x040041CB RID: 16843
	public ProFlareAtlas Atlas;

	// Token: 0x040041CC RID: 16844
	public Material NormalMat;

	// Token: 0x040041CD RID: 16845
	public Material ShitMat;

	// Token: 0x040041CE RID: 16846
	public LayerMask LayerMask;

	// Token: 0x040041CF RID: 16847
	public Space Space;

	// Token: 0x040041D0 RID: 16848
	public int StartCapacity;

	// Token: 0x040041D1 RID: 16849
	private static readonly MultiFlare.GClass859 gclass859_0;

	// Token: 0x040041D2 RID: 16850
	private readonly List<MultiFlareLight> list_0;

	// Token: 0x040041D3 RID: 16851
	private List<Vector4> list_1;

	// Token: 0x040041D4 RID: 16852
	private List<Vector3> list_2;

	// Token: 0x040041D5 RID: 16853
	private List<Vector2> list_3;

	// Token: 0x040041D6 RID: 16854
	private List<Vector2> list_4;

	// Token: 0x040041D7 RID: 16855
	private List<Vector2> list_5;

	// Token: 0x040041D8 RID: 16856
	private List<Vector2> list_6;

	// Token: 0x040041D9 RID: 16857
	private List<int> list_7;

	// Token: 0x040041DA RID: 16858
	private MultiFlare.GClass859 gclass859_1;

	// Token: 0x040041DB RID: 16859
	private MultiFlare.GClass859 gclass859_2;

	// Token: 0x040041DC RID: 16860
	private int int_0;

	// Token: 0x040041DD RID: 16861
	private Bounds bounds_0;

	// Token: 0x02000AC5 RID: 2757
	public enum EFlareType
	{
		// Token: 0x040041DF RID: 16863
		Normal,
		// Token: 0x040041E0 RID: 16864
		OffScreen,
		// Token: 0x040041E1 RID: 16865
		Shit
	}

	// Token: 0x02000AC6 RID: 2758
	public enum ERotationType
	{
		// Token: 0x040041E3 RID: 16867
		None,
		// Token: 0x040041E4 RID: 16868
		Normal,
		// Token: 0x040041E5 RID: 16869
		Inverse
	}

	// Token: 0x02000AC7 RID: 2759
	public sealed class GClass859 : IDisposable
	{
		// Token: 0x06003C4B RID: 15435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(in Matrix4x4 matrix, in int layer)
		{
			throw null;
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x040041E6 RID: 16870
		[CanBeNull]
		public readonly Color32[] Colors;

		// Token: 0x040041E7 RID: 16871
		[CanBeNull]
		public readonly Vector3[] Positions;

		// Token: 0x040041E8 RID: 16872
		public bool ColorsWasChanged;

		// Token: 0x040041E9 RID: 16873
		public bool PositionsWasChanged;

		// Token: 0x040041EA RID: 16874
		private readonly Material material_0;

		// Token: 0x040041EB RID: 16875
		private readonly Mesh mesh_0;

		// Token: 0x040041EC RID: 16876
		private readonly bool bool_0;
	}
}
