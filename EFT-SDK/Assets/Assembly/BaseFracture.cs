using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B41 RID: 2881
public abstract class BaseFracture : MonoBehaviour
{
	// Token: 0x17000A0F RID: 2575
	// (get) Token: 0x06003E7C RID: 15996 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003E7D RID: 15997 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
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

	// Token: 0x17000A10 RID: 2576
	// (get) Token: 0x06003E7E RID: 15998 RVA: 0x00002050 File Offset: 0x00000250
	internal List<Shard> List_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003E7F RID: 15999
	protected abstract IEnumerator SpreadFracture(Vector3[] points);

	// Token: 0x06003E80 RID: 16000
	protected abstract void ImmediateFracture(Vector3[] points);

	// Token: 0x06003E81 RID: 16001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void BeginFracture(Vector3 point, float size = 0.5f)
	{
		throw null;
	}

	// Token: 0x06003E82 RID: 16002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Destroy(Vector3 point, float force)
	{
		throw null;
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void InitializeDestruction()
	{
		throw null;
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void FinalizeDestruction()
	{
		throw null;
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void GetVerticesInPlane()
	{
		throw null;
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CreateShardMesh(Vector3 point)
	{
		throw null;
	}

	// Token: 0x040045FC RID: 17916
	protected static readonly Vector4[] InitPlanes;

	// Token: 0x040045FD RID: 17917
	[SerializeField]
	private bool _immediate;

	// Token: 0x040045FE RID: 17918
	[SerializeField]
	protected RangedInt Shards;

	// Token: 0x040045FF RID: 17919
	[SerializeField]
	protected int ShardsPerFrame;

	// Token: 0x04004600 RID: 17920
	protected List<Shard> FinishedShards;

	// Token: 0x04004601 RID: 17921
	protected Vector3 MaxBounds;

	// Token: 0x04004602 RID: 17922
	protected Vector3 MinBounds;

	// Token: 0x04004603 RID: 17923
	protected Vector3[] NewVertices;

	// Token: 0x04004604 RID: 17924
	protected Vector2[] NewUVs;

	// Token: 0x04004605 RID: 17925
	protected int[] NewTriangles;

	// Token: 0x04004606 RID: 17926
	protected List<Vector3> Vertices;

	// Token: 0x04004607 RID: 17927
	protected List<int> PlaneIndices;

	// Token: 0x04004608 RID: 17928
	protected readonly List<Vector4> Planes;

	// Token: 0x04004609 RID: 17929
	[CompilerGenerated]
	private bool bool_0;
}
