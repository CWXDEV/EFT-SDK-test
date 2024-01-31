using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000710 RID: 1808
public class TransformLinks : MonoBehaviour
{
	// Token: 0x06002A1D RID: 10781 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetTransform(ECharacterWeaponBones bone)
	{
		throw null;
	}

	// Token: 0x06002A1E RID: 10782 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetTransformOutOfRangeSafe(ECharacterWeaponBones bone)
	{
		throw null;
	}

	// Token: 0x06002A1F RID: 10783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetCachedTransform(int index)
	{
		throw null;
	}

	// Token: 0x06002A20 RID: 10784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GatherIK(Transform[] markers, Transform[] gripReferences, Transform[] elbowBends)
	{
		throw null;
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GatherUnderbarrelWeaponIK(Transform launcherRoot, Transform[] elbowBends)
	{
		throw null;
	}

	// Token: 0x06002A22 RID: 10786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CacheTransforms(Transform parent, IEnumerable<string> cachedBoneNames)
	{
		throw null;
	}

	// Token: 0x06002A23 RID: 10787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetPositions()
	{
		throw null;
	}

	// Token: 0x04002851 RID: 10321
	public Transform[] Transforms;

	// Token: 0x04002852 RID: 10322
	public Transform Self;

	// Token: 0x04002853 RID: 10323
	[SerializeField]
	private TransformLinks.CachedTransform[] _cachedTransforms;

	// Token: 0x02000711 RID: 1809
	[Serializable]
	public struct CachedTransform
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x04002854 RID: 10324
		public Vector3 Position;

		// Token: 0x04002855 RID: 10325
		public Quaternion Rotation;

		// Token: 0x04002856 RID: 10326
		public Transform Transform;
	}

	// Token: 0x02000712 RID: 1810
	[CompilerGenerated]
	private sealed class Class377
	{
		// Token: 0x06002A25 RID: 10789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Transform method_0(string x)
		{
			throw null;
		}

		// Token: 0x04002857 RID: 10327
		public Transform parent;
	}

	// Token: 0x02000713 RID: 1811
	[CompilerGenerated]
	[Serializable]
	private sealed class Class378
	{
		// Token: 0x06002A26 RID: 10790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Transform x)
		{
			throw null;
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TransformLinks.CachedTransform method_1(Transform t)
		{
			throw null;
		}

		// Token: 0x04002858 RID: 10328
		public static readonly TransformLinks.Class378 class378_0;

		// Token: 0x04002859 RID: 10329
		public static Func<Transform, bool> func_0;

		// Token: 0x0400285A RID: 10330
		public static Func<Transform, TransformLinks.CachedTransform> func_1;
	}
}
