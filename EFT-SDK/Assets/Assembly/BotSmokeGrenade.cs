using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020002DE RID: 734
public class BotSmokeGrenade : GClass362
{
	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInSmoke
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

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PlaceToShoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmokeEnter(SmokeGrenadePlace smokeGrenadePlace)
	{
		throw null;
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SmokeExit(SmokeGrenadePlace smokeGrenadePlace)
	{
		throw null;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallShoot()
	{
		throw null;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSmokeGrenadeData(GClass495 place)
	{
		throw null;
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x04000ECD RID: 3789
	private readonly List<SmokeGrenadePlace> affectedSmokes;

	// Token: 0x04000ECE RID: 3790
	private GClass527 _smokeModif;

	// Token: 0x04000ECF RID: 3791
	private GClass495 _lastPlace;

	// Token: 0x04000ED0 RID: 3792
	private bool _willShootToSmoke;

	// Token: 0x04000ED1 RID: 3793
	private float _nextCheckTime;

	// Token: 0x04000ED2 RID: 3794
	private float _smokeEndTime;
}
