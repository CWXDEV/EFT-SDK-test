using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

// Token: 0x02000A4A RID: 2634
public class DynamicDeferredDecalRenderer : MonoBehaviour
{
	// Token: 0x17000997 RID: 2455
	// (get) Token: 0x060039C3 RID: 14787 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039C4 RID: 14788 RVA: 0x00002050 File Offset: 0x00000250
	public Material DecalMaterial
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

	// Token: 0x17000998 RID: 2456
	// (get) Token: 0x060039C5 RID: 14789 RVA: 0x00002050 File Offset: 0x00000250
	public Matrix4x4 ModelMatrix
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000999 RID: 2457
	// (get) Token: 0x060039C6 RID: 14790 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700099A RID: 2458
	// (get) Token: 0x060039C7 RID: 14791 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039C8 RID: 14792 RVA: 0x00002050 File Offset: 0x00000250
	public Transform TransformHelper
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700099B RID: 2459
	// (get) Token: 0x060039C9 RID: 14793 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039CA RID: 14794 RVA: 0x00002050 File Offset: 0x00000250
	public GameObject GameObjectHelper
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700099C RID: 2460
	// (get) Token: 0x060039CB RID: 14795 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039CC RID: 14796 RVA: 0x00002050 File Offset: 0x00000250
	public int CullingGroupSphereIndex
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

	// Token: 0x060039CD RID: 14797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Material mat, Mesh mesh, Vector3 projectionDirection, Vector4 uvStartEnd, bool tiled, int cullingGroupIndex)
	{
		throw null;
	}

	// Token: 0x060039CE RID: 14798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ManualUpdate()
	{
		throw null;
	}

	// Token: 0x04003CF0 RID: 15600
	[CompilerGenerated]
	private Material material_0;

	// Token: 0x04003CF1 RID: 15601
	[CompilerGenerated]
	private Transform transform_0;

	// Token: 0x04003CF2 RID: 15602
	[CompilerGenerated]
	private GameObject gameObject_0;

	// Token: 0x04003CF3 RID: 15603
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04003CF4 RID: 15604
	private Action<BallisticCollider> action_0;

	// Token: 0x04003CF5 RID: 15605
	private static readonly int int_1;
}
