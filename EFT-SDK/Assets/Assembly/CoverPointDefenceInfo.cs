using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000133 RID: 307
[Serializable]
public class CoverPointDefenceInfo
{
	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
	public float DefenceLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
	public int DangerCoeff
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OverrideData(float defenceLevel, int dangerCoeff)
	{
		throw null;
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSafe()
	{
		throw null;
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefenceLevel(float deffCoeff)
	{
		throw null;
	}

	// Token: 0x04000759 RID: 1881
	[SerializeField]
	private float _defenceLevel;

	// Token: 0x0400075A RID: 1882
	[SerializeField]
	private int distanceCheckSum;
}
