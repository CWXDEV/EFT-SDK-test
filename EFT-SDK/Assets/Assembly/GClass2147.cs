using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02001E62 RID: 7778
public abstract class GClass2147 : GInterface189
{
	// Token: 0x1700195E RID: 6494
	// (get) Token: 0x06009F6B RID: 40811 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual float maxHoleHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009F6C RID: 40812
	public abstract bool CanMove();

	// Token: 0x06009F6D RID: 40813
	public abstract bool CanMoveAutomaticly();

	// Token: 0x06009F6E RID: 40814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_0()
	{
		throw null;
	}

	// Token: 0x0400A7E3 RID: 42979
	protected const float float_0 = 1.8f;

	// Token: 0x0400A7E4 RID: 42980
	protected readonly Transform transform_0;

	// Token: 0x0400A7E5 RID: 42981
	protected readonly GInterface211 ginterface211_0;
}
