using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020004AD RID: 1197
public class LastSoundsController
{
	// Token: 0x17000526 RID: 1318
	// (get) Token: 0x06001CFB RID: 7419 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001CFC RID: 7420 RVA: 0x00002050 File Offset: 0x00000250
	public ZeroGoalTarget ZeroGoalTarget
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

	// Token: 0x06001CFD RID: 7421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNeutralSound(IPlayer player, Vector3 position)
	{
		throw null;
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass499 GetLastSound()
	{
		throw null;
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IPlayer PossibleKiller(Vector3 pos, float time)
	{
		throw null;
	}

	// Token: 0x040018A2 RID: 6306
	private const float DIST_IS_KILLER_SQR = 25f;

	// Token: 0x040018A3 RID: 6307
	private const int neutralSoundsCount = 100;

	// Token: 0x040018A4 RID: 6308
	private const int neutralSoundsCountHalf = 50;

	// Token: 0x040018A5 RID: 6309
	private const float OlD_TIME = 5f;

	// Token: 0x040018A6 RID: 6310
	public GClass499[] NeutralSounds;

	// Token: 0x040018A7 RID: 6311
	private int _lastNeutralSoundIndex;

	// Token: 0x040018A8 RID: 6312
	private bool isCycle;

	// Token: 0x040018A9 RID: 6313
	private BotsGroup _group;
}
