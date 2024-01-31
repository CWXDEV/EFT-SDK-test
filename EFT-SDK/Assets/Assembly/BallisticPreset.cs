using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

// Token: 0x020005B3 RID: 1459
[Serializable]
public sealed class BallisticPreset
{
	// Token: 0x1700064B RID: 1611
	public float this[int i]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyScaleMult(BallisticCollider ballisticCollider, in Vector3 scale)
	{
		throw null;
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyPresetValues(BallisticCollider bCollider)
	{
		throw null;
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValid(BallisticCollider bCollider)
	{
		throw null;
	}

	// Token: 0x04002130 RID: 8496
	public string Name;

	// Token: 0x04002131 RID: 8497
	public MaterialType MaterialType;

	// Token: 0x04002132 RID: 8498
	public float[] values;

	// Token: 0x04002133 RID: 8499
	[Tooltip("PenetrationLevel зависит от скейла")]
	public bool DependOnScale;

	// Token: 0x04002134 RID: 8500
	[Tooltip("График множителя PenetrationLevel(value) от скейла(time)")]
	public AnimationCurve ScaleToPenetrationCurve;
}
