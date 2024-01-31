using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020003EC RID: 1004
public class BotTurnAwayLight : GClass362
{
	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06001826 RID: 6182 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(Func<Vector3?> posToTurnAway, float delay = 0f)
	{
		throw null;
	}

	// Token: 0x040014F7 RID: 5367
	private const float MAX_TURN_AWAY_TIME = 4f;

	// Token: 0x040014F8 RID: 5368
	private bool _isActive;

	// Token: 0x040014F9 RID: 5369
	private float _startTime;

	// Token: 0x040014FA RID: 5370
	private Func<Vector3?> _posToTurnAway;

	// Token: 0x040014FB RID: 5371
	private GClass551.GInterface13 _timer;

	// Token: 0x020003ED RID: 1005
	[CompilerGenerated]
	private sealed class Class210
	{
		// Token: 0x06001829 RID: 6185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040014FC RID: 5372
		public BotTurnAwayLight botTurnAwayLight_0;

		// Token: 0x040014FD RID: 5373
		public Func<Vector3?> posToTurnAway;
	}
}
