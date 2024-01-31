using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

// Token: 0x020005BB RID: 1467
public class TerrainBallistic : BaseBallistic
{
	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
	private static MaterialType[] MaterialType_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BaseBallistic.ESurfaceSound GetSurfaceSound(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override BallisticCollider Get(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_0(Vector3 worldPos)
	{
		throw null;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ApplyPresetValues(BallisticCollider bCollider)
	{
		throw null;
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsNoneDefault(BallisticCollider bCollider)
	{
		throw null;
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(BallisticCollider b)
	{
		throw null;
	}

	// Token: 0x0400216B RID: 8555
	public TerrainData TerrainData;

	// Token: 0x0400216C RID: 8556
	public TextAsset TextureMixDataAsset;

	// Token: 0x0400216D RID: 8557
	private static GameObject gameObject_0;

	// Token: 0x0400216E RID: 8558
	private int int_0;

	// Token: 0x0400216F RID: 8559
	private Vector3 vector3_0;

	// Token: 0x04002170 RID: 8560
	private BallisticCollider[] ballisticCollider_0;

	// Token: 0x04002171 RID: 8561
	private GClass697 gclass697_0;

	// Token: 0x04002172 RID: 8562
	public BaseBallistic.ESurfaceSound[] TerrainMaterials;

	// Token: 0x04002173 RID: 8563
	[CompilerGenerated]
	private static readonly MaterialType[] materialType_0;

	// Token: 0x020005BC RID: 1468
	[CompilerGenerated]
	private sealed class Class283
	{
		// Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BallisticCollider c)
		{
			throw null;
		}

		// Token: 0x04002174 RID: 8564
		public BaseBallistic.ESurfaceSound terrainMaterial;
	}

	// Token: 0x020005BD RID: 1469
	[CompilerGenerated]
	private sealed class Class284
	{
		// Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BallisticCollider c)
		{
			throw null;
		}

		// Token: 0x04002175 RID: 8565
		public int i;

		// Token: 0x04002176 RID: 8566
		public TerrainBallistic terrainBallistic_0;
	}
}
