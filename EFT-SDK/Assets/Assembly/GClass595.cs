using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.Interactive;
using EFT.MovingPlatforms;
using EFT.PrefabSettings;
using UnityEngine;

// Token: 0x0200062F RID: 1583
public class GClass595 : Singleton<GClass595>
{
	// Token: 0x14000057 RID: 87
	// (add) Token: 0x06002438 RID: 9272 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002439 RID: 9273 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate19 OnSoundPlayed
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

	// Token: 0x14000058 RID: 88
	// (add) Token: 0x0600243A RID: 9274 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600243B RID: 9275 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate16 OnKill
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

	// Token: 0x14000059 RID: 89
	// (add) Token: 0x0600243C RID: 9276 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600243D RID: 9277 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate11 OnHardAimDelegate
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

	// Token: 0x1400005A RID: 90
	// (add) Token: 0x0600243E RID: 9278 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600243F RID: 9279 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate15 OnGrenadeThrow
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

	// Token: 0x1400005B RID: 91
	// (add) Token: 0x06002440 RID: 9280 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate10 OnQETilt
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

	// Token: 0x1400005C RID: 92
	// (add) Token: 0x06002442 RID: 9282 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate14 OnGrenadeExplosive
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

	// Token: 0x1400005D RID: 93
	// (add) Token: 0x06002444 RID: 9284 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Vector3> OnBodyBotDead
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

	// Token: 0x1400005E RID: 94
	// (add) Token: 0x06002446 RID: 9286 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002447 RID: 9287 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Locomotive.ETravelState> OnTrainCome
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

	// Token: 0x1400005F RID: 95
	// (add) Token: 0x06002448 RID: 9288 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002449 RID: 9289 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate17 OnPhraseSay
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

	// Token: 0x14000060 RID: 96
	// (add) Token: 0x0600244A RID: 9290 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600244B RID: 9291 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate20 OnFlareDelegate
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

	// Token: 0x14000061 RID: 97
	// (add) Token: 0x0600244C RID: 9292 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate18 OnBeingHit
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

	// Token: 0x14000062 RID: 98
	// (add) Token: 0x0600244E RID: 9294 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600244F RID: 9295 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate9 OnGestusShow
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

	// Token: 0x14000063 RID: 99
	// (add) Token: 0x06002450 RID: 9296 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002451 RID: 9297 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate21 OnInteractObject
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

	// Token: 0x14000064 RID: 100
	// (add) Token: 0x06002452 RID: 9298 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002453 RID: 9299 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass595.GDelegate8 OnArtilleryStart
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

	// Token: 0x14000065 RID: 101
	// (add) Token: 0x06002454 RID: 9300 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002455 RID: 9301 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<string> OnPlayerComeToPlace
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

	// Token: 0x14000066 RID: 102
	// (add) Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002457 RID: 9303 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<string> OnEvent
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

	// Token: 0x14000067 RID: 103
	// (add) Token: 0x06002458 RID: 9304 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002459 RID: 9305 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int> OnExitActivated
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

	// Token: 0x14000068 RID: 104
	// (add) Token: 0x0600245A RID: 9306 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600245B RID: 9307 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int, WorldInteractiveObject> OnDoorInteracted
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

	// Token: 0x14000069 RID: 105
	// (add) Token: 0x0600245C RID: 9308 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600245D RID: 9309 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnStopBotSpawn
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

	// Token: 0x1400006A RID: 106
	// (add) Token: 0x0600245E RID: 9310 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600245F RID: 9311 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> OnApplyLighthouseKeeperFriendlyUsecs
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

	// Token: 0x1400006B RID: 107
	// (add) Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002461 RID: 9313 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> OnApplyLighthouseKeeperFriendlyZryachiy
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

	// Token: 0x1400006C RID: 108
	// (add) Token: 0x06002462 RID: 9314 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002463 RID: 9315 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<List<Player>> OnApplyTraderServiceBtrSupport
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

	// Token: 0x1400006D RID: 109
	// (add) Token: 0x06002464 RID: 9316 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnStopTraderServiceBtrSupport
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

	// Token: 0x1400006E RID: 110
	// (add) Token: 0x06002466 RID: 9318 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> OnInterruptTraderServiceBtrSupportByBetrayer
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

	// Token: 0x06002468 RID: 9320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyLighthouseKeeperFriendlyUsecs(Player player)
	{
		throw null;
	}

	// Token: 0x06002469 RID: 9321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyLighthouseKeeperFriendlyZryachiy(Player player)
	{
		throw null;
	}

	// Token: 0x0600246A RID: 9322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTraderServiceBtrSupport(List<Player> players)
	{
		throw null;
	}

	// Token: 0x0600246B RID: 9323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopTraderServiceBtrSupport()
	{
		throw null;
	}

	// Token: 0x0600246C RID: 9324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InterruptTraderServiceBtrSupportByBetrayer(Player player)
	{
		throw null;
	}

	// Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopBotSpawn()
	{
		throw null;
	}

	// Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayerComeToPlace(string zone)
	{
		throw null;
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AnyEvent(string eventId)
	{
		throw null;
	}

	// Token: 0x06002470 RID: 9328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExitActivated(int eventId)
	{
		throw null;
	}

	// Token: 0x06002471 RID: 9329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ArtilleryStart(Vector3 position, float radius, float delay)
	{
		throw null;
	}

	// Token: 0x06002472 RID: 9330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySound(IPlayer person, Vector3 position, float power, AISoundType type)
	{
		throw null;
	}

	// Token: 0x06002473 RID: 9331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SayPhrase(IPlayer player, EPhraseTrigger @event)
	{
		throw null;
	}

	// Token: 0x06002474 RID: 9332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrainCome(Locomotive.ETravelState val)
	{
		throw null;
	}

	// Token: 0x06002475 RID: 9333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeadBodySound(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002476 RID: 9334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InteractObject(string id, Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002477 RID: 9335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GrenadeExplosion(Vector3 position, string playerProfileID, bool isSmoke, float smokeRadius, float smokeLifeTime)
	{
		throw null;
	}

	// Token: 0x06002478 RID: 9336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Kill(IPlayer killer, IPlayer target)
	{
		throw null;
	}

	// Token: 0x06002479 RID: 9337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ThrowGrenade(Grenade grenade, Vector3 position, Vector3 force, float mass)
	{
		throw null;
	}

	// Token: 0x0600247A RID: 9338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowGesture(Player player, EGesture gesture)
	{
		throw null;
	}

	// Token: 0x0600247B RID: 9339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void QETilt(IPlayer player)
	{
		throw null;
	}

	// Token: 0x0600247C RID: 9340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HardAim(IPlayer player, bool val)
	{
		throw null;
	}

	// Token: 0x0600247D RID: 9341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x0600247E RID: 9342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeingHitAction(DamageInfo damageInfo, Player victim)
	{
		throw null;
	}

	// Token: 0x0600247F RID: 9343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SuccessFlare(Player player, Vector3 position, FlareEventType eventType)
	{
		throw null;
	}

	// Token: 0x04002381 RID: 9089
	[CompilerGenerated]
	private GClass595.GDelegate19 gdelegate19_0;

	// Token: 0x04002382 RID: 9090
	[CompilerGenerated]
	private GClass595.GDelegate16 gdelegate16_0;

	// Token: 0x04002383 RID: 9091
	[CompilerGenerated]
	private GClass595.GDelegate11 gdelegate11_0;

	// Token: 0x04002384 RID: 9092
	[CompilerGenerated]
	private GClass595.GDelegate15 gdelegate15_0;

	// Token: 0x04002385 RID: 9093
	[CompilerGenerated]
	private GClass595.GDelegate10 gdelegate10_0;

	// Token: 0x04002386 RID: 9094
	[CompilerGenerated]
	private GClass595.GDelegate14 gdelegate14_0;

	// Token: 0x04002387 RID: 9095
	[CompilerGenerated]
	private Action<Vector3> action_0;

	// Token: 0x04002388 RID: 9096
	[CompilerGenerated]
	private Action<Locomotive.ETravelState> action_1;

	// Token: 0x04002389 RID: 9097
	[CompilerGenerated]
	private GClass595.GDelegate17 gdelegate17_0;

	// Token: 0x0400238A RID: 9098
	[CompilerGenerated]
	private GClass595.GDelegate20 gdelegate20_0;

	// Token: 0x0400238B RID: 9099
	[CompilerGenerated]
	private GClass595.GDelegate18 gdelegate18_0;

	// Token: 0x0400238C RID: 9100
	[CompilerGenerated]
	private GClass595.GDelegate9 gdelegate9_0;

	// Token: 0x0400238D RID: 9101
	[CompilerGenerated]
	private GClass595.GDelegate21 gdelegate21_0;

	// Token: 0x0400238E RID: 9102
	[CompilerGenerated]
	private GClass595.GDelegate8 gdelegate8_0;

	// Token: 0x0400238F RID: 9103
	[CompilerGenerated]
	private Action<string> action_2;

	// Token: 0x04002390 RID: 9104
	[CompilerGenerated]
	private Action<string> action_3;

	// Token: 0x04002391 RID: 9105
	[CompilerGenerated]
	private Action<int> action_4;

	// Token: 0x04002392 RID: 9106
	[CompilerGenerated]
	private Action<int, WorldInteractiveObject> action_5;

	// Token: 0x04002393 RID: 9107
	[CompilerGenerated]
	private Action action_6;

	// Token: 0x04002394 RID: 9108
	[CompilerGenerated]
	private Action<Player> action_7;

	// Token: 0x04002395 RID: 9109
	[CompilerGenerated]
	private Action<Player> action_8;

	// Token: 0x04002396 RID: 9110
	[CompilerGenerated]
	private Action<List<Player>> action_9;

	// Token: 0x04002397 RID: 9111
	[CompilerGenerated]
	private Action action_10;

	// Token: 0x04002398 RID: 9112
	[CompilerGenerated]
	private Action<Player> action_11;

	// Token: 0x02000630 RID: 1584
	// (Invoke) Token: 0x06002480 RID: 9344
	public delegate void GDelegate8(Vector3 position, float radius, float delay);

	// Token: 0x02000631 RID: 1585
	// (Invoke) Token: 0x06002483 RID: 9347
	public delegate void GDelegate9(GClass454 data);

	// Token: 0x02000632 RID: 1586
	// (Invoke) Token: 0x06002486 RID: 9350
	public delegate void GDelegate10(IPlayer player);

	// Token: 0x02000633 RID: 1587
	// (Invoke) Token: 0x06002489 RID: 9353
	public delegate void GDelegate11(IPlayer player, bool status);

	// Token: 0x02000634 RID: 1588
	// (Invoke) Token: 0x0600248C RID: 9356
	public delegate void GDelegate12(LootItem item);

	// Token: 0x02000635 RID: 1589
	// (Invoke) Token: 0x0600248F RID: 9359
	public delegate void GDelegate13(LootItem item);

	// Token: 0x02000636 RID: 1590
	// (Invoke) Token: 0x06002492 RID: 9362
	public delegate void GDelegate14(Vector3 position, string playerProfileID, bool isSmoke, float smokeRadius, float smokeLifeTime);

	// Token: 0x02000637 RID: 1591
	// (Invoke) Token: 0x06002495 RID: 9365
	public delegate void GDelegate15(Grenade grenade, Vector3 position, Vector3 force, float mass);

	// Token: 0x02000638 RID: 1592
	// (Invoke) Token: 0x06002498 RID: 9368
	public delegate void GDelegate16(IPlayer killer, IPlayer target);

	// Token: 0x02000639 RID: 1593
	public class GClass596
	{
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanUse
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CalcChance()
		{
			throw null;
		}

		// Token: 0x04002399 RID: 9113
		public IPlayer PlayerRequester;

		// Token: 0x0400239A RID: 9114
		public EPhraseTrigger phrase;

		// Token: 0x0400239B RID: 9115
		private bool bool_0;

		// Token: 0x0400239C RID: 9116
		private bool bool_1;

		// Token: 0x0400239D RID: 9117
		public int UsedTimes;
	}

	// Token: 0x0200063A RID: 1594
	// (Invoke) Token: 0x0600249D RID: 9373
	public delegate void GDelegate17(GClass595.GClass596 info);

	// Token: 0x0200063B RID: 1595
	// (Invoke) Token: 0x060024A0 RID: 9376
	public delegate void GDelegate18(DamageInfo damageInfo, Player victim);

	// Token: 0x0200063C RID: 1596
	// (Invoke) Token: 0x060024A3 RID: 9379
	public delegate void GDelegate19(IPlayer player, Vector3 position, float power, AISoundType type);

	// Token: 0x0200063D RID: 1597
	// (Invoke) Token: 0x060024A6 RID: 9382
	public delegate void GDelegate20(IPlayer player, Vector3 position, FlareEventType flareEventType);

	// Token: 0x0200063E RID: 1598
	// (Invoke) Token: 0x060024A9 RID: 9385
	public delegate void GDelegate21(string doorId, Vector3 position);

	// Token: 0x0200063F RID: 1599
	[CompilerGenerated]
	[Serializable]
	private sealed class Class309
	{
		// Token: 0x060024AC RID: 9388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(int i, WorldInteractiveObject o)
		{
			throw null;
		}

		// Token: 0x0400239E RID: 9118
		public static readonly GClass595.Class309 class309_0;

		// Token: 0x0400239F RID: 9119
		public static Action<int, WorldInteractiveObject> action_0;
	}
}
