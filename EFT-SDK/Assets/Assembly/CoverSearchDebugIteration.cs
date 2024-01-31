using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200086D RID: 2157
[Serializable]
public class CoverSearchDebugIteration
{
	// Token: 0x1700086D RID: 2157
	// (get) Token: 0x060030EF RID: 12527 RVA: 0x00002050 File Offset: 0x00000250
	public CoverSearchDebugPointsGroup CoverPointGroups
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPointToIteration(Vector3 point, int level, float sqrRadius)
	{
		throw null;
	}

	// Token: 0x060030F1 RID: 12529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x040031C2 RID: 12738
	[SerializeField]
	private CoverSearchDebugPointsGroup _coverPointGroups;

	// Token: 0x040031C3 RID: 12739
	[SerializeField]
	public Vector3 CenterPoint;

	// Token: 0x040031C4 RID: 12740
	[SerializeField]
	public Vector3? ResultCover;

	// Token: 0x040031C5 RID: 12741
	public string timeMark;

	// Token: 0x040031C6 RID: 12742
	public string searchLabel;
}
