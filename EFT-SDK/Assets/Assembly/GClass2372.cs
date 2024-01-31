using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.InventoryLogic;
using EFT.NextObservedPlayer;
using UnityEngine;

// Token: 0x0200200A RID: 8202
public class GClass2372 : GInterface127, GInterface217
{
	// Token: 0x17001BC9 RID: 7113
	// (get) Token: 0x0600A9C6 RID: 43462 RVA: 0x00002050 File Offset: 0x00000250
	private static Item Item_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1400022A RID: 554
	// (add) Token: 0x0600A9C7 RID: 43463 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600A9C8 RID: 43464 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<ValueTuple<Item, WeaponPrefab>, ValueTuple<Item, WeaponPrefab>> OnChangeInHandItem
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

	// Token: 0x1400022B RID: 555
	// (add) Token: 0x0600A9C9 RID: 43465 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600A9CA RID: 43466 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnUnequipWeaponFromDeadBody
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

	// Token: 0x1400022C RID: 556
	// (add) Token: 0x0600A9CB RID: 43467 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600A9CC RID: 43468 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> OnWeaponOut
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

	// Token: 0x17001BCA RID: 7114
	// (get) Token: 0x0600A9CD RID: 43469 RVA: 0x00002050 File Offset: 0x00000250
	public WeaponPrefab CurrentWeaponPrefab
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BCB RID: 7115
	// (get) Token: 0x0600A9CE RID: 43470 RVA: 0x00002050 File Offset: 0x00000250
	public Item ItemInHands
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BCC RID: 7116
	// (get) Token: 0x0600A9CF RID: 43471 RVA: 0x00002050 File Offset: 0x00000250
	public EHandsControllerType CurrentHandsControllerType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BCD RID: 7117
	// (get) Token: 0x0600A9D0 RID: 43472 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsWeaponTriggerPressing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BCE RID: 7118
	// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2355 BundleAnimationBones
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1400022D RID: 557
	// (add) Token: 0x0600A9D2 RID: 43474 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600A9D3 RID: 43475 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17001BCF RID: 7119
	// (get) Token: 0x0600A9D4 RID: 43476 RVA: 0x00002050 File Offset: 0x00000250
	public Weapon Weapon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD0 RID: 7120
	// (get) Token: 0x0600A9D5 RID: 43477 RVA: 0x00002050 File Offset: 0x00000250
	public WeaponSoundPlayer WeaponSoundPlayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD1 RID: 7121
	// (get) Token: 0x0600A9D6 RID: 43478 RVA: 0x00002050 File Offset: 0x00000250
	public float ErgonomicWeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD2 RID: 7122
	// (get) Token: 0x0600A9D7 RID: 43479 RVA: 0x00002050 File Offset: 0x00000250
	public float TotalErgonomics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD3 RID: 7123
	// (get) Token: 0x0600A9D8 RID: 43480 RVA: 0x00002050 File Offset: 0x00000250
	public BifacialTransform CurrentFireport
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD4 RID: 7124
	// (get) Token: 0x0600A9D9 RID: 43481 RVA: 0x00002050 File Offset: 0x00000250
	public bool MouseLookControl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD5 RID: 7125
	// (get) Token: 0x0600A9DA RID: 43482 RVA: 0x00002050 File Offset: 0x00000250
	public GameObject ItemGameObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD6 RID: 7126
	// (get) Token: 0x0600A9DB RID: 43483 RVA: 0x00002050 File Offset: 0x00000250
	public ObservedPlayerView PlayerView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD7 RID: 7127
	// (get) Token: 0x0600A9DC RID: 43484 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInventoryOpen
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BD8 RID: 7128
	// (get) Token: 0x0600A9DD RID: 43485 RVA: 0x00002050 File Offset: 0x00000250
	public bool InReloadOperation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A9DE RID: 43486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool FirearmInHands()
	{
		throw null;
	}

	// Token: 0x17001BD9 RID: 7129
	// (get) Token: 0x0600A9DF RID: 43487 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 KnifeGlobalSwingDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001BDA RID: 7130
	// (get) Token: 0x0600A9E0 RID: 43488 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600A9E1 RID: 43489 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17001BDB RID: 7131
	// (get) Token: 0x0600A9E2 RID: 43490 RVA: 0x00002050 File Offset: 0x00000250
	private FirearmsAnimator FirearmsAnimator_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A9E3 RID: 43491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dipose()
	{
		throw null;
	}

	// Token: 0x0600A9E4 RID: 43492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int smethod_0(Item item)
	{
		throw null;
	}

	// Token: 0x0600A9E5 RID: 43493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Func<Item, GameObject> smethod_1(EHandsControllerType controllerType, ObservedPlayerView player)
	{
		throw null;
	}

	// Token: 0x0600A9E6 RID: 43494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Item smethod_2(EHandsControllerType controllerType, string rootItem, GClass1186[] items)
	{
		throw null;
	}

	// Token: 0x0600A9E7 RID: 43495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BulletClass CreateAmmo(string ammoTemplate)
	{
		throw null;
	}

	// Token: 0x0600A9E8 RID: 43496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SetStationaryWeaponOnSpawn()
	{
		throw null;
	}

	// Token: 0x0600A9E9 RID: 43497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	// Token: 0x0600A9EA RID: 43498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task CreateHandsController(EHandsControllerType controllerType, string rootItem, GClass1186[] items, Weapon.EMalfunctionState malfunctionState = Weapon.EMalfunctionState.None, string malfunctionedAmmo = "", bool armed = true, int ammoInChamber = 0, float drawSpeedMultiplier = 1f)
	{
		throw null;
	}

	// Token: 0x0600A9EB RID: 43499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Item item, EHandsControllerType controllerType, Weapon.EMalfunctionState malfunctionState, string malfunctionedAmmo, bool armed, int ammoInChamber, float drawAnimSpeed)
	{
		throw null;
	}

	// Token: 0x0600A9EC RID: 43500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetAnimatorOnUnspawnHands()
	{
		throw null;
	}

	// Token: 0x0600A9ED RID: 43501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(EPlayerState prevState, EPlayerState nextState)
	{
		throw null;
	}

	// Token: 0x0600A9EE RID: 43502 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyHandsController()
	{
		throw null;
	}

	// Token: 0x0600A9EF RID: 43503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject method_2(Item item, Func<Item, GameObject> createItem)
	{
		throw null;
	}

	// Token: 0x0600A9F0 RID: 43504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WeaponHitReaction(Vector3 direction, float strength = 1f, float hands = 1f, float camera = 1f)
	{
		throw null;
	}

	// Token: 0x0600A9F1 RID: 43505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0600A9F2 RID: 43506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyMovementModel(GStruct287 nextModel)
	{
		throw null;
	}

	// Token: 0x0600A9F3 RID: 43507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x0600A9F4 RID: 43508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_3()
	{
		throw null;
	}

	// Token: 0x0600A9F5 RID: 43509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600A9F6 RID: 43510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x0600A9F7 RID: 43511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GClass2220 equipCommand)
	{
		throw null;
	}

	// Token: 0x0600A9F8 RID: 43512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x0600A9F9 RID: 43513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_8(GClass2241 command)
	{
		throw null;
	}

	// Token: 0x0600A9FA RID: 43514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_9(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x0600A9FB RID: 43515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(GClass2246 command)
	{
		throw null;
	}

	// Token: 0x0600A9FC RID: 43516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(GClass2256 command)
	{
		throw null;
	}

	// Token: 0x0600A9FD RID: 43517 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(GClass2228 command)
	{
		throw null;
	}

	// Token: 0x0600A9FE RID: 43518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection)
	{
		throw null;
	}

	// Token: 0x0600A9FF RID: 43519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14(BulletClass ammo, Vector3 shotPosition, Vector3 shotDirection)
	{
		throw null;
	}

	// Token: 0x0600AA00 RID: 43520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15(BulletClass flareItem, Vector3 shotPosition, Vector3 forward)
	{
		throw null;
	}

	// Token: 0x0600AA01 RID: 43521 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_16(GClass2259 command)
	{
		throw null;
	}

	// Token: 0x0600AA02 RID: 43522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_17(GClass2270 command)
	{
		throw null;
	}

	// Token: 0x0600AA03 RID: 43523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_18(GClass2232 commandMessage)
	{
		throw null;
	}

	// Token: 0x0600AA04 RID: 43524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_19(GClass2222 commandMessage)
	{
		throw null;
	}

	// Token: 0x0600AA05 RID: 43525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_20(GClass2238 commandMessage)
	{
		throw null;
	}

	// Token: 0x0600AA06 RID: 43526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(float overlap)
	{
		throw null;
	}

	// Token: 0x0600AA07 RID: 43527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22(GClass2223 command)
	{
		throw null;
	}

	// Token: 0x0600AA08 RID: 43528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_23(GClass2252 command)
	{
		throw null;
	}

	// Token: 0x0600AA09 RID: 43529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_24(GClass2239 command)
	{
		throw null;
	}

	// Token: 0x0600AA0A RID: 43530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_25(GClass2221 command)
	{
		throw null;
	}

	// Token: 0x0600AA0B RID: 43531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_26(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600AA0C RID: 43532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupItemInSlot(Slot slot, Item item)
	{
		throw null;
	}

	// Token: 0x0600AA0D RID: 43533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetupMod(Slot slot, Item item, IPlayer player)
	{
		throw null;
	}

	// Token: 0x0600AA0E RID: 43534 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveMode(Slot slot)
	{
		throw null;
	}

	// Token: 0x0600AA0F RID: 43535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action RemoveModeScheduled(Slot slot)
	{
		throw null;
	}

	// Token: 0x0600AA10 RID: 43536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAiming(bool isAiming, int aimIndex)
	{
		throw null;
	}

	// Token: 0x0600AA11 RID: 43537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_27(Vector3 shotPosition, Vector3 shotDirection, BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x0600AA12 RID: 43538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_28()
	{
		throw null;
	}

	// Token: 0x0600AA13 RID: 43539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_29(BulletClass ammo)
	{
		throw null;
	}

	// Token: 0x0600AA14 RID: 43540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_30(FirearmsEffects firearmsEffects)
	{
		throw null;
	}

	// Token: 0x0600AA15 RID: 43541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(Vector3 shotPosition, Vector3 shotDirection, BulletClass ammo, BaseSoundPlayer baseSoundPlayer)
	{
		throw null;
	}

	// Token: 0x0600AA16 RID: 43542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32()
	{
		throw null;
	}

	// Token: 0x0600AA17 RID: 43543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33()
	{
		throw null;
	}

	// Token: 0x0600AA18 RID: 43544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInteract(bool isInteract, int animationId)
	{
		throw null;
	}

	// Token: 0x0600AA19 RID: 43545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_34(bool isActive)
	{
		throw null;
	}

	// Token: 0x0600AA1A RID: 43546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_35(bool pickup)
	{
		throw null;
	}

	// Token: 0x0600AA1B RID: 43547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInventory(bool isOpen)
	{
		throw null;
	}

	// Token: 0x0600AA1C RID: 43548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_36()
	{
		throw null;
	}

	// Token: 0x0600AA1D RID: 43549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecalculateErgonomic()
	{
		throw null;
	}

	// Token: 0x0600AA1E RID: 43550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_37()
	{
		throw null;
	}

	// Token: 0x0600AA1F RID: 43551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_38()
	{
		throw null;
	}

	// Token: 0x0600AA20 RID: 43552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_39()
	{
		throw null;
	}

	// Token: 0x0600AA21 RID: 43553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private PlayerAnimator.EWeaponAnimationType method_40()
	{
		throw null;
	}

	// Token: 0x0600AA22 RID: 43554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_41(Weapon weapon, WeaponPrefab weaponPrefab)
	{
		throw null;
	}

	// Token: 0x0600AA23 RID: 43555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BlindFire(int value)
	{
		throw null;
	}

	// Token: 0x0600AA24 RID: 43556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetBlindFire()
	{
		throw null;
	}

	// Token: 0x0600AA25 RID: 43557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AfterWeaponOut()
	{
		throw null;
	}

	// Token: 0x0600AA26 RID: 43558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_42(GInterface218 command)
	{
		throw null;
	}

	// Token: 0x0600AA27 RID: 43559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFlagForInfoInReloadOperation(bool value)
	{
		throw null;
	}

	// Token: 0x0600AA28 RID: 43560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableLightsState()
	{
		throw null;
	}

	// Token: 0x0600AA29 RID: 43561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FastForward()
	{
		throw null;
	}

	// Token: 0x0600AA2A RID: 43562 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_43()
	{
		throw null;
	}

	// Token: 0x0600AA2B RID: 43563 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_44()
	{
		throw null;
	}

	// Token: 0x0400B0C7 RID: 45255
	[CompilerGenerated]
	private Action<ValueTuple<Item, WeaponPrefab>, ValueTuple<Item, WeaponPrefab>> action_0;

	// Token: 0x0400B0C8 RID: 45256
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400B0C9 RID: 45257
	[CompilerGenerated]
	private Action<Item> action_2;

	// Token: 0x0400B0CA RID: 45258
	[CompilerGenerated]
	private Action action_3;

	// Token: 0x0400B0CB RID: 45259
	private ObservedPlayerView observedPlayerView_0;

	// Token: 0x0400B0CC RID: 45260
	private PlayerBones playerBones_0;

	// Token: 0x0400B0CD RID: 45261
	private IAnimator ianimator_0;

	// Token: 0x0400B0CE RID: 45262
	private GClass2375 gclass2375_0;

	// Token: 0x0400B0CF RID: 45263
	private GClass2385 gclass2385_0;

	// Token: 0x0400B0D0 RID: 45264
	private Item item_0;

	// Token: 0x0400B0D1 RID: 45265
	private GameObject gameObject_0;

	// Token: 0x0400B0D2 RID: 45266
	private WeaponPrefab weaponPrefab_0;

	// Token: 0x0400B0D3 RID: 45267
	private BaseSoundPlayer baseSoundPlayer_0;

	// Token: 0x0400B0D4 RID: 45268
	private FirearmsEffects firearmsEffects_0;

	// Token: 0x0400B0D5 RID: 45269
	private EHandsControllerType ehandsControllerType_0;

	// Token: 0x0400B0D6 RID: 45270
	private WeaponPrefab weaponPrefab_1;

	// Token: 0x0400B0D7 RID: 45271
	private BaseSoundPlayer baseSoundPlayer_1;

	// Token: 0x0400B0D8 RID: 45272
	private GClass1665 gclass1665_0;

	// Token: 0x0400B0D9 RID: 45273
	private FirearmsEffects firearmsEffects_1;

	// Token: 0x0400B0DA RID: 45274
	private GClass2355 gclass2355_0;

	// Token: 0x0400B0DB RID: 45275
	private bool bool_0;

	// Token: 0x0400B0DC RID: 45276
	private float float_0;

	// Token: 0x0400B0DD RID: 45277
	private bool bool_1;

	// Token: 0x0400B0DE RID: 45278
	private bool bool_2;

	// Token: 0x0400B0DF RID: 45279
	private GClass751<float> gclass751_0;

	// Token: 0x0400B0E0 RID: 45280
	private GClass751<float> gclass751_1;

	// Token: 0x0400B0E1 RID: 45281
	private Action action_4;

	// Token: 0x0400B0E2 RID: 45282
	private bool bool_3;

	// Token: 0x0400B0E3 RID: 45283
	private bool bool_4;

	// Token: 0x0400B0E4 RID: 45284
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400B0E5 RID: 45285
	private bool bool_5;

	// Token: 0x0400B0E6 RID: 45286
	private bool bool_6;

	// Token: 0x0400B0E7 RID: 45287
	private float float_1;

	// Token: 0x0400B0E8 RID: 45288
	private bool bool_7;

	// Token: 0x0400B0E9 RID: 45289
	private GClass2364 gclass2364_0;

	// Token: 0x0400B0EA RID: 45290
	private bool bool_8;

	// Token: 0x0400B0EB RID: 45291
	private bool bool_9;

	// Token: 0x0400B0EC RID: 45292
	private bool bool_10;

	// Token: 0x0400B0ED RID: 45293
	private readonly Queue<GInterface218> queue_0;

	// Token: 0x0400B0EE RID: 45294
	private readonly Queue<GInterface218> queue_1;

	// Token: 0x0400B0EF RID: 45295
	private bool bool_11;

	// Token: 0x0200200B RID: 8203
	[CompilerGenerated]
	private sealed class Class1852
	{
		// Token: 0x0600AA2C RID: 43564 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GameObject method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GameObject method_1(Item item)
		{
			throw null;
		}

		// Token: 0x0400B0F0 RID: 45296
		public ObservedPlayerView player;
	}

	// Token: 0x0200200E RID: 8206
	[CompilerGenerated]
	private sealed class Class1853
	{
		// Token: 0x0600AA32 RID: 43570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400B101 RID: 45313
		public KnifeComponent knife;

		// Token: 0x0400B102 RID: 45314
		public GClass2372 gclass2372_0;
	}

	// Token: 0x0200201C RID: 8220
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1854
	{
		// Token: 0x0600AA4D RID: 43597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Mod method_1(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(Mod mod)
		{
			throw null;
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<IContainer> method_3(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4()
		{
			throw null;
		}

		// Token: 0x0400B141 RID: 45377
		public static readonly GClass2372.Class1854 class1854_0;

		// Token: 0x0400B142 RID: 45378
		public static Func<Slot, bool> func_0;

		// Token: 0x0400B143 RID: 45379
		public static Func<Slot, Mod> func_1;

		// Token: 0x0400B144 RID: 45380
		public static Func<Mod, int> func_2;

		// Token: 0x0400B145 RID: 45381
		public static Func<ContainerCollection, IEnumerable<IContainer>> func_3;

		// Token: 0x0400B146 RID: 45382
		public static Action action_0;
	}

	// Token: 0x0200201D RID: 8221
	[CompilerGenerated]
	private sealed class Class1855
	{
		// Token: 0x0600AA52 RID: 43602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400B147 RID: 45383
		public Transform objectToDelete;
	}
}
