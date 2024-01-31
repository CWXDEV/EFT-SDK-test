using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000E85 RID: 3717
public class GClass1061
{
	// Token: 0x06004D80 RID: 19840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeData()
	{
		throw null;
	}

	// Token: 0x06004D81 RID: 19841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ReleaseBuffers()
	{
		throw null;
	}

	// Token: 0x06004D82 RID: 19842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddLodAndRenderer(Mesh mesh, List<Material> materials, MaterialPropertyBlock mpb, bool castShadows, float lodSize = -1f, MaterialPropertyBlock shadowMPB = null, bool excludeBounds = false, int layer = 0)
	{
		throw null;
	}

	// Token: 0x06004D83 RID: 19843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddLod(float screenRelativeTransitionHeight = -1f, bool excludeBounds = false)
	{
		throw null;
	}

	// Token: 0x06004D84 RID: 19844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddRenderer(int lod, Mesh mesh, List<Material> materials, Matrix4x4 transformOffset, MaterialPropertyBlock mpb, bool castShadows, int layer = 0, MaterialPropertyBlock shadowMPB = null, Renderer rendererRef = null)
	{
		throw null;
	}

	// Token: 0x06004D85 RID: 19845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CalculateBounds()
	{
		throw null;
	}

	// Token: 0x06004D86 RID: 19846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CreateRenderersFromGameObject(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GenerateLODsFromLODGroup(GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CreateRenderersFromMeshRenderers(int lod, GPUInstancerPrototype prototype)
	{
		throw null;
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetMeshRenderersOfTransform(Transform objectTransform, List<MeshRenderer> meshRenderers)
	{
		throw null;
	}

	// Token: 0x04005A17 RID: 23063
	public GPUInstancerPrototype prototype;

	// Token: 0x04005A18 RID: 23064
	public List<GClass1062> instanceLODs;

	// Token: 0x04005A19 RID: 23065
	public Bounds instanceBounds;

	// Token: 0x04005A1A RID: 23066
	public float[] lodSizes;

	// Token: 0x04005A1B RID: 23067
	public float lodBiasApplied;

	// Token: 0x04005A1C RID: 23068
	[HideInInspector]
	public Matrix4x4[] instanceDataArray;

	// Token: 0x04005A1D RID: 23069
	public int instanceCount;

	// Token: 0x04005A1E RID: 23070
	public int bufferSize;

	// Token: 0x04005A1F RID: 23071
	public ComputeBuffer transformationMatrixVisibilityBuffer;

	// Token: 0x04005A20 RID: 23072
	public ComputeBuffer argsBuffer;

	// Token: 0x04005A21 RID: 23073
	public ComputeBuffer instanceLODDataBuffer;

	// Token: 0x04005A22 RID: 23074
	public uint[] args;

	// Token: 0x04005A23 RID: 23075
	public bool hasShadowCasterBuffer;

	// Token: 0x04005A24 RID: 23076
	public Material shadowCasterMaterial;

	// Token: 0x04005A25 RID: 23077
	public ComputeBuffer shadowArgsBuffer;

	// Token: 0x04005A26 RID: 23078
	public uint[] shadowArgs;

	// Token: 0x04005A27 RID: 23079
	public bool transformDataModified;
}
