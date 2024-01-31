using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x020008FF RID: 2303
public class BaseSoundPlayer : MonoBehaviour, GInterface24
{
	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x060033F4 RID: 13300 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060033F5 RID: 13301 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool IsSilenced
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060033F6 RID: 13302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GInterface123 handsController, BifacialTransform weaponHierarchy, Player player)
	{
		throw null;
	}

	// Token: 0x060033F7 RID: 13303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BifacialTransform weaponHierarchy, ObservedPlayerView player)
	{
		throw null;
	}

	// Token: 0x060033F8 RID: 13304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Init(BifacialTransform weaponHierarchy)
	{
		throw null;
	}

	// Token: 0x060033F9 RID: 13305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SoundEventHandler(string soundName)
	{
		throw null;
	}

	// Token: 0x060033FA RID: 13306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SoundAtPointEventHandler(string soundName)
	{
		throw null;
	}

	// Token: 0x060033FB RID: 13307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EventReceiver(string eventName)
	{
		throw null;
	}

	// Token: 0x060033FC RID: 13308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayRandomClip(BaseSoundPlayer.SoundElement soundElement)
	{
		throw null;
	}

	// Token: 0x060033FD RID: 13309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		throw null;
	}

	// Token: 0x060033FE RID: 13310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060033FF RID: 13311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseClipsSource()
	{
		throw null;
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnUseProp(bool boolParam)
	{
		throw null;
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnAddAmmoInChamber()
	{
		throw null;
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnAddAmmoInMag()
	{
		throw null;
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnArm()
	{
		throw null;
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnCook()
	{
		throw null;
	}

	// Token: 0x06003406 RID: 13318 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnDelAmmoChamber()
	{
		throw null;
	}

	// Token: 0x06003407 RID: 13319 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnDelAmmoFromMag()
	{
		throw null;
	}

	// Token: 0x06003408 RID: 13320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnDisarm()
	{
		throw null;
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnFireEnd()
	{
		throw null;
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnFiringBullet()
	{
		throw null;
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnFoldOff()
	{
		throw null;
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnFoldOn()
	{
		throw null;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnIdleStart()
	{
		throw null;
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnMalfunctionOff()
	{
		throw null;
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnMagHide()
	{
		throw null;
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnMagIn()
	{
		throw null;
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnMagOut()
	{
		throw null;
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnMagShow()
	{
		throw null;
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnMessageName()
	{
		throw null;
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnModChanged()
	{
		throw null;
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnOffBoltCatch()
	{
		throw null;
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnOnBoltCatch()
	{
		throw null;
	}

	// Token: 0x06003417 RID: 13335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnPutMagToRig()
	{
		throw null;
	}

	// Token: 0x06003418 RID: 13336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnRemoveShell()
	{
		throw null;
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnReplaceSecondMag()
	{
		throw null;
	}

	// Token: 0x0600341A RID: 13338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnShellEject()
	{
		throw null;
	}

	// Token: 0x0600341B RID: 13339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnShowAmmo(bool BoolParam)
	{
		throw null;
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSliderOut()
	{
		throw null;
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnSound(string StringParam)
	{
		throw null;
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnSoundAtPoint(string StringParam)
	{
		throw null;
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnStartUtilityOperation()
	{
		throw null;
	}

	// Token: 0x06003420 RID: 13344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnThirdAction(int IntParam)
	{
		throw null;
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnUseSecondMagForReload()
	{
		throw null;
	}

	// Token: 0x06003422 RID: 13346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnWeapIn()
	{
		throw null;
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnWeapOut()
	{
		throw null;
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnBackpackDrop()
	{
		throw null;
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnComboPlanning()
	{
		throw null;
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnLauncherAppeared()
	{
		throw null;
	}

	// Token: 0x06003427 RID: 13351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnLauncherDisappeared()
	{
		throw null;
	}

	// Token: 0x06003428 RID: 13352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnShowMag()
	{
		throw null;
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnCurrentAnimStateEnded()
	{
		throw null;
	}

	// Token: 0x0600342A RID: 13354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnSetActiveObject(int objectID)
	{
		throw null;
	}

	// Token: 0x0600342B RID: 13355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface24.OnDeactivateObject(int objectID)
	{
		throw null;
	}

	// Token: 0x040034B0 RID: 13488
	protected BaseSoundPlayer.IObserverToPlayerBridge playersBridge;

	// Token: 0x040034B1 RID: 13489
	private BetterSource _clipsSource;

	// Token: 0x040034B2 RID: 13490
	protected BifacialTransform _weaponHierarchy;

	// Token: 0x040034B3 RID: 13491
	private const string UberviewPattern = "EventName 150;SoundClips 180;";

	// Token: 0x040034B4 RID: 13492
	[SerializeField]
	public List<BaseSoundPlayer.SoundElement> AdditionalSounds;

	// Token: 0x040034B5 RID: 13493
	[SerializeField]
	public BaseSoundPlayer.SoundElement[] MainSounds;

	// Token: 0x040034B6 RID: 13494
	protected readonly GClass763 CompositeDisposable;

	// Token: 0x040034B7 RID: 13495
	private FirearmsAnimator _firearmsAnimator;

	// Token: 0x02000900 RID: 2304
	[Serializable]
	public class SoundElement
	{
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x00002050 File Offset: 0x00000250
		public AudioClip RandomSoundClip
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040034B9 RID: 13497
		public string EventName;

		// Token: 0x040034BA RID: 13498
		public int RollOff;

		// Token: 0x040034BB RID: 13499
		public float Volume;

		// Token: 0x040034BC RID: 13500
		public AudioClip[] SoundClips;
	}

	// Token: 0x02000901 RID: 2305
	protected interface IObserverToPlayerBridge
	{
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600342D RID: 13357
		IPlayer iPlayer { get; }

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600342E RID: 13358
		EPointOfView PointOfView { get; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600342F RID: 13359
		BaseSoundPlayer.SoundElement PropIn { get; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06003430 RID: 13360
		BaseSoundPlayer.SoundElement PropOut { get; }

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x06003431 RID: 13361
		// (remove) Token: 0x06003432 RID: 13362
		event Action BreakLoop;

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06003433 RID: 13363
		EnvironmentType Environment { get; }

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003434 RID: 13364
		bool isWeaponTriggerPressed { get; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003435 RID: 13365
		FirearmsAnimator FirearmsAnimator { get; }
	}

	// Token: 0x02000902 RID: 2306
	protected class ObserverBridge : BaseSoundPlayer.IObserverToPlayerBridge
	{
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer iPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00002050 File Offset: 0x00000250
		public EPointOfView PointOfView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x00002050 File Offset: 0x00000250
		public BaseSoundPlayer.SoundElement PropIn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x00002050 File Offset: 0x00000250
		public BaseSoundPlayer.SoundElement PropOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x0600343A RID: 13370 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600343B RID: 13371 RVA: 0x00002050 File Offset: 0x00000250
		public event Action BreakLoop
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

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x00002050 File Offset: 0x00000250
		public EnvironmentType Environment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x00002050 File Offset: 0x00000250
		public bool isWeaponTriggerPressed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x00002050 File Offset: 0x00000250
		public FirearmsAnimator FirearmsAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallBreakLoop()
		{
			throw null;
		}

		// Token: 0x040034BE RID: 13502
		private ObservedPlayerView _observedPlayer;
	}

	// Token: 0x02000903 RID: 2307
	protected class PlayerBridge : BaseSoundPlayer.IObserverToPlayerBridge
	{
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer iPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x00002050 File Offset: 0x00000250
		public EPointOfView PointOfView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x00002050 File Offset: 0x00000250
		public BaseSoundPlayer.SoundElement PropIn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00002050 File Offset: 0x00000250
		public BaseSoundPlayer.SoundElement PropOut
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140000AC RID: 172
		// (add) Token: 0x06003444 RID: 13380 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003445 RID: 13381 RVA: 0x00002050 File Offset: 0x00000250
		public event Action BreakLoop
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

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x00002050 File Offset: 0x00000250
		public EnvironmentType Environment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x00002050 File Offset: 0x00000250
		public bool isWeaponTriggerPressed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x00002050 File Offset: 0x00000250
		public FirearmsAnimator FirearmsAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CallBreakLoop()
		{
			throw null;
		}

		// Token: 0x040034C0 RID: 13504
		private Player _player;

		// Token: 0x040034C1 RID: 13505
		private GInterface123 _handsController;

		// Token: 0x040034C2 RID: 13506
		private Player.FirearmController _firearm;
	}

	// Token: 0x02000904 RID: 2308
	[CompilerGenerated]
	private sealed class Class480
	{
		// Token: 0x040034C3 RID: 13507
		public string soundName;
	}

	// Token: 0x02000905 RID: 2309
	[CompilerGenerated]
	private sealed class Class481
	{
		// Token: 0x040034C4 RID: 13508
		public string soundName;
	}

	// Token: 0x02000906 RID: 2310
	[CompilerGenerated]
	private sealed class Class482
	{
		// Token: 0x040034C5 RID: 13509
		public string eventName;
	}
}
