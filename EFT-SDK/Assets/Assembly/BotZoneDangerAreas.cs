using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000235 RID: 565
public class BotZoneDangerAreas
{
	// Token: 0x1400000C RID: 12
	// (add) Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AIDangerArea> OnDangerAreaCreated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<AIDangerArea> OnDangerAreaRemoved
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BotZone zone)
	{
		throw null;
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDanger(Vector3 point, float rad, float period = -1f)
	{
		throw null;
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BotDied(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Complete(AIDangerArea area)
	{
		throw null;
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Vector3 p1, Vector3 p2)
	{
		throw null;
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000B6B RID: 2923
	private const float DANGER_AREA_RADIUS = 8f;

	// Token: 0x04000B6C RID: 2924
	private const float SDIST_TO_CREATE_AREA = 400f;

	// Token: 0x04000B6D RID: 2925
	private const float STANDART_DANGER_AREA_PERIOD_SEC = 600f;

	// Token: 0x04000B6E RID: 2926
	public BotZone ZoneOwner;

	// Token: 0x04000B6F RID: 2927
	public HashSet<AIDangerArea> ActiveAreas;

	// Token: 0x04000B70 RID: 2928
	private readonly HashSet<GClass551.GInterface13> _timers;

	// Token: 0x04000B71 RID: 2929
	private readonly List<Vector3> _deathPositions;

	// Token: 0x02000236 RID: 566
	[CompilerGenerated]
	private sealed class Class134
	{
		// Token: 0x04000B74 RID: 2932
		public BotZoneDangerAreas botZoneDangerAreas_0;

		// Token: 0x04000B75 RID: 2933
		public AIDangerArea area;
	}

	// Token: 0x02000237 RID: 567
	[CompilerGenerated]
	private sealed class Class135
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04000B76 RID: 2934
		public GClass551.GInterface13 timer;

		// Token: 0x04000B77 RID: 2935
		public BotZoneDangerAreas.Class134 class134_0;
	}
}
