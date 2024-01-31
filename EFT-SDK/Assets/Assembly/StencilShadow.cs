using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AB2 RID: 2738
public class StencilShadow : MonoBehaviour
{
	// Token: 0x170009DC RID: 2524
	// (get) Token: 0x06003BEF RID: 15343 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x00002050 File Offset: 0x00000250
	public Renderer Renderer
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170009DD RID: 2525
	// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Bounds Bounds
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x170009DE RID: 2526
	// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00002050 File Offset: 0x00000250
	public int ActualDrawPriority
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003BF4 RID: 15348 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Awake")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003BF6 RID: 15350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06003BF8 RID: 15352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0400414E RID: 16718
	public Color Ambient;

	// Token: 0x0400414F RID: 16719
	public AmbientLight.CullingSettings Culling;

	// Token: 0x04004150 RID: 16720
	[CompilerGenerated]
	private Renderer renderer_0;

	// Token: 0x04004151 RID: 16721
	[CompilerGenerated]
	private Bounds bounds_0;

	// Token: 0x04004152 RID: 16722
	public int DesiredDrawPriority;

	// Token: 0x04004153 RID: 16723
	[Range(0f, 1f)]
	public float FogAttenuation;

	// Token: 0x04004154 RID: 16724
	[SerializeField]
	[HideInInspector]
	private int _drawPriority;

	// Token: 0x04004155 RID: 16725
	private Mesh mesh_0;
}
