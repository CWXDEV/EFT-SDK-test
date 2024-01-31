using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020005FA RID: 1530
public class BotsForceAttackEvent : GClass574
{
	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x060022F6 RID: 8950 RVA: 0x00002050 File Offset: 0x00000250
	public override List<int> LayersToActivate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x060022F7 RID: 8951 RVA: 0x00002050 File Offset: 0x00000250
	public override List<int> LayersToDeActivate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060022F8 RID: 8952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool Start(string cause)
	{
		throw null;
	}

	// Token: 0x060022F9 RID: 8953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool CanActivate(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void BotEventActive(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExternalStart()
	{
		throw null;
	}

	// Token: 0x060022FC RID: 8956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060022FD RID: 8957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x060022FE RID: 8958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(HashSet<string> ids, string from)
	{
		throw null;
	}

	// Token: 0x060022FF RID: 8959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(string id)
	{
		throw null;
	}

	// Token: 0x06002300 RID: 8960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(string id)
	{
		throw null;
	}

	// Token: 0x06002301 RID: 8961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5(string doorId)
	{
		throw null;
	}

	// Token: 0x06002302 RID: 8962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugActivate()
	{
		throw null;
	}

	// Token: 0x06002303 RID: 8963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void Dispose()
	{
		throw null;
	}

	// Token: 0x06002304 RID: 8964 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06002305 RID: 8965 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(string id, Vector3 position)
	{
		throw null;
	}

	// Token: 0x06002306 RID: 8966 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(string id)
	{
		throw null;
	}

	// Token: 0x06002307 RID: 8967 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(string id)
	{
		throw null;
	}

	// Token: 0x040022B8 RID: 8888
	private readonly HashSet<string> _idsInteractableToActivate;

	// Token: 0x040022B9 RID: 8889
	private readonly HashSet<string> _idsZoneToActivate;

	// Token: 0x040022BA RID: 8890
	private HashSet<string> _idsEventsToActivate;

	// Token: 0x040022BB RID: 8891
	private GClass551.GInterface13 _timer;

	// Token: 0x040022BC RID: 8892
	private GameDateTime _gameTime;

	// Token: 0x040022BD RID: 8893
	private GClass595.GDelegate21 OnInteractObject;

	// Token: 0x040022BE RID: 8894
	private Action<string> OnPlayerComeToZone;

	// Token: 0x040022BF RID: 8895
	private Action<string> OnEvent;

	// Token: 0x040022C0 RID: 8896
	private ZoneLeaveControllerClass _botZonesLeaveController;
}
