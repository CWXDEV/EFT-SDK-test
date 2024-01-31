using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Diz.LanguageExtensions;
using EFT.AssetsManager;
using EFT.Ballistics;
using EFT.Game.Spawning;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.MovingPlatforms;
using EFT.NextObservedPlayer;
using JetBrains.Annotations;
using Systems.Effects;
using UnityEngine;

namespace EFT
{
	// Token: 0x020011AE RID: 4526
	public class GameWorld : MonoBehaviour, IDisposable, IEnumerable, IEnumerable<IPlayer>, GInterface96, IPlayersCollection
	{
		// Token: 0x06006069 RID: 24681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TGameWorld Create<TGameWorld>(GameObject gameObject, PoolManager objectsFactory, EUpdateQueue updateQueue, string currentProfileId) where TGameWorld : GameWorld
		{
			throw null;
		}

		// Token: 0x1400010D RID: 269
		// (add) Token: 0x0600606A RID: 24682 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600606B RID: 24683 RVA: 0x00002050 File Offset: 0x00000250
		public static event Action OnDispose
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

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x00002050 File Offset: 0x00000250
		public ExfiltrationControllerClass ExfiltrationController
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

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600606F RID: 24687 RVA: 0x00002050 File Offset: 0x00000250
		public BufferZoneControllerClass BufferZoneController
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

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006071 RID: 24689 RVA: 0x00002050 File Offset: 0x00000250
		public HalloweenEventControllerClass HalloweenEventController
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

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006073 RID: 24691 RVA: 0x00002050 File Offset: 0x00000250
		internal Class419 Class419_0
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

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006075 RID: 24693 RVA: 0x00002050 File Offset: 0x00000250
		public BTRControllerClass BtrController
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

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06006076 RID: 24694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006077 RID: 24695 RVA: 0x00002050 File Offset: 0x00000250
		public string LocationId
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

		// Token: 0x1400010E RID: 270
		// (add) Token: 0x06006078 RID: 24696 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006079 RID: 24697 RVA: 0x00002050 File Offset: 0x00000250
		public event Action AfterGameStarted
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

		// Token: 0x1400010F RID: 271
		// (add) Token: 0x0600607A RID: 24698 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600607B RID: 24699 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IPlayer> OnPersonAdd
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

		// Token: 0x14000110 RID: 272
		// (add) Token: 0x0600607C RID: 24700 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600607D RID: 24701 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float> OnBeforeWorldTick
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

		// Token: 0x14000111 RID: 273
		// (add) Token: 0x0600607E RID: 24702 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600607F RID: 24703 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float> OnLateUpdate
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

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06006080 RID: 24704 RVA: 0x00002050 File Offset: 0x00000250
		public float DeltaTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface355 ClientBallisticCalculator
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

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006084 RID: 24708 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface355 SharedBallisticsCalculator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<Player> AllPlayersEverExisted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetEverExistedPlayerByID(string profileID)
		{
			throw null;
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObservedPlayerView GetObservedPlayerByProfileID(string profileID)
		{
			throw null;
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GInterface94 GetEverExistedBridgeByProfileID(string profileID)
		{
			throw null;
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GInterface94 GetAlivePlayerBridgeByProfileID(string profileID)
		{
			throw null;
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GInterface94 GetAlivePlayerBridgeByCollider(Collider col)
		{
			throw null;
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetAlivePlayerByProfileID(string profileID)
		{
			throw null;
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x0600608C RID: 24716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600608D RID: 24717 RVA: 0x00002050 File Offset: 0x00000250
		public MovingPlatform[] Platforms
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

		// Token: 0x0600608E RID: 24718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<IPlayer> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x00002050 File Offset: 0x00000250
		protected Dictionary<Collider, IPlayer> PlayersColliders
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06006091 RID: 24721 RVA: 0x00002050 File Offset: 0x00000250
		public static int InteractiveLootMaskWPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06006092 RID: 24722 RVA: 0x00002050 File Offset: 0x00000250
		public static int LootMaskObstruction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06006093 RID: 24723 RVA: 0x00002050 File Offset: 0x00000250
		public EUpdateQueue UpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000112 RID: 274
		// (add) Token: 0x06006094 RID: 24724 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006095 RID: 24725 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GInterface12> OnLootItemDestroyed
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

		// Token: 0x06006096 RID: 24726 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MovingPlatform GetPlatformAtPosition(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BoardIfOnPlatform(MovingPlatform.GInterface347 transportee, Vector3 position)
		{
			throw null;
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AmmoPoolObject SpawnShellInTheWorld(ref AmmoPoolObject shell)
		{
			throw null;
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06006099 RID: 24729 RVA: 0x00002050 File Offset: 0x00000250
		public bool WorldSpawned
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x00002050 File Offset: 0x00000250
		private World World_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		GInterface355 GInterface96.CreateBallisticCalculator(int seed)
		{
			throw null;
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveBallisticCalculator(Item weapon)
		{
			throw null;
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GInterface355 CreateClientBallisticsCalculator()
		{
			throw null;
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveClientBallisticsCalculator()
		{
			throw null;
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterGrenade(Throwable grenade)
		{
			throw null;
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Throwable grenade)
		{
			throw null;
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterGrenade(string id)
		{
			throw null;
		}

		public GClass673 GrenadeFactory { get; }

		// Token: 0x060060A2 RID: 24738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Throwable grenade)
		{
			throw null;
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Throwable grenade)
		{
			throw null;
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_0(World world)
		{
			throw null;
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterInteractiveObject(Turnable t)
		{
			throw null;
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeLampState(Turnable turnable, Turnable.EState state)
		{
			throw null;
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterWindow(WindowBreaker window)
		{
			throw null;
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsLocalGame()
		{
			throw null;
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitAirdrop(bool takeNearbyPoint = false, Vector3 position = default(Vector3))
		{
			throw null;
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterWorldInteractionObject(WorldInteractiveObject worldInteractiveObject)
		{
			throw null;
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task InitLevel(ItemFactory itemFactory, GClass1797 config, bool loadBundlesAndCreatePools = true, List<ResourceKey> resources = null, IProgress<GStruct117> progress = null, CancellationToken ct = default(CancellationToken))
		{
			throw null;
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3()
		{
			throw null;
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsTempItem(Item item)
		{
			throw null;
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<Item> CreateTempItem(GClass1496 descriptor)
		{
			throw null;
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct412 RemoveTempItem(Item item)
		{
			throw null;
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterLoot<T>(T loot) where T : InteractableObject
		{
			throw null;
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyAllLoot()
		{
			throw null;
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyLoot(string id)
		{
			throw null;
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyLoot(GInterface12 loot)
		{
			throw null;
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1199 method_4(GClass1199 lootItems)
		{
			throw null;
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual LootItem CreateStaticLoot(GameObject lootObject, Item item, string lootName, GameWorld gameWorld, bool randomRotation, [CanBeNull] string[] validProfiles, string staticId = null, Vector3 shift = default(Vector3))
		{
			throw null;
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5(GClass1199 lootItems, bool initial)
		{
			throw null;
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SpawnLootCorpse(GClass1197 lootItem)
		{
			throw null;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SpawnLootCorpse<T>(GClass1197 corpseJson) where T : Corpse
		{
			throw null;
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GInterface26[] method_6(GClass1199 lootItems, GInterface26[] staticLootSpawns)
		{
			throw null;
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DevelopSetContainerVisibility(int command, string id)
		{
			throw null;
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass1199 lootItems, ref GInterface26[] staticLootSpawns)
		{
			throw null;
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IEnumerable<Transform> smethod_0(Transform transform)
		{
			throw null;
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_8(GClass1199 lootItems)
		{
			throw null;
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual LootItem CreateLootWithRigidbody(GameObject lootObject, Item item, string objectName, GameWorld gameWorld, bool randomRotation, [CanBeNull] string[] validProfiles, out BoxCollider objectCollider, bool forceLayerSetup = false, bool syncable = true, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0f)
		{
			throw null;
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_9(byte[] bytes)
		{
			throw null;
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11()
		{
			throw null;
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private LootItem method_12(LootItemPositionClass lootItem, bool initial, Player questPlayer = null, MovingPlatform platform = null)
		{
			throw null;
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task PreloadBundles()
		{
			throw null;
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task PreloadAdditionalData()
		{
			throw null;
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootItem ThrowItem(Item item, IPlayer player, Vector3? direction)
		{
			throw null;
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootItem ThrowItem(Item item, IPlayer player, Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, bool syncable = true, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0f)
		{
			throw null;
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootItem SetupItem(Item item, IPlayer player, Vector3 position, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ShotDelegate(GClass2988 shotResult)
		{
			throw null;
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void NetworkWorldOnGrenadeHit(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GClass1673 HackShot(DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoWorldTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DoOtherWorldTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void BeforeWorldTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void BallisticsTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void BeforePlayerTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PlayerTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void AfterPlayerTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OtherElseWorldTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void AfterWorldTick(float dt)
		{
			throw null;
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void LateUpdateWorld(float dt)
		{
			throw null;
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SafePlayerOperation(Action<Player> operation)
		{
			throw null;
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool InteractionSense(Vector3 origin, Vector3 direction, float radius, float distance)
		{
			throw null;
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GameObject FindInteractable(Ray ray, out RaycastHit hit)
		{
			throw null;
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Player FindInteractablePlayer(Ray ray, out RaycastHit hit)
		{
			throw null;
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<LootItemPositionClass> GetJsonLootItems()
		{
			throw null;
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<LootItemPositionClass> method_13()
		{
			throw null;
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LootItemPositionClass SerializeLootItem(LootItem lootItem)
		{
			throw null;
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static LootItem FindLootItem(string itemId, Vector3 position)
		{
			throw null;
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IItemOwner FindLootOrContainer(string itemId, Vector3 position)
		{
			throw null;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static LootItem DevelopFindLootItem(string itemId)
		{
			throw null;
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WorldInteractiveObject FindDoor(string doorId)
		{
			throw null;
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StationaryWeapon FindStationaryWeapon(string id)
		{
			throw null;
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public StationaryWeapon FindStationaryWeaponByItemId(string itemId)
		{
			throw null;
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RegisterPlayer(IPlayer iPlayer)
		{
			throw null;
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UnregisterPlayer(IPlayer iPlayer)
		{
			throw null;
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RegisterPlayerCollider(Player player, Collider playerCollider)
		{
			throw null;
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UnregisterPlayerCollider(Collider playerCollider)
		{
			throw null;
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_14(Player player)
		{
			throw null;
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Player GetPlayerByCollider(Collider col)
		{
			throw null;
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<ItemAddress> ToItemAddress(GClass1522 descriptor)
		{
			throw null;
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IItemOwner FindOwnerById(string ownerId)
		{
			throw null;
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyValuePair<IItemOwner, GameWorld.GStruct116> FindOwnerWithWorldData(string ownerId)
		{
			throw null;
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<Item> FindItemById(string itemId)
		{
			throw null;
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct415<ValueTuple<Item, GameWorld.GStruct116>> FindItemWithWorldData(string itemId)
		{
			throw null;
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_15(string itemId, IItemOwner inventoryController, out Item item)
		{
			throw null;
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TraderControllerClass FindControllerById(string id)
		{
			throw null;
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CulledPlayersCount()
		{
			throw null;
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int TotalPlayersCountToCull()
		{
			throw null;
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x00002050 File Offset: 0x00000250
		public virtual ulong TotalOutgoingBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060060F7 RID: 24823 RVA: 0x00002050 File Offset: 0x00000250
		public virtual ulong TotalIngoingBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSmokeGrenadesDeserialized(List<GStruct33> netGrenadeData)
		{
			throw null;
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(WorldInteractiveObject door, EDoorState stateBefore, EDoorState stateAfter)
		{
			throw null;
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CanPlayerSeepThrough(Collider collider)
		{
			throw null;
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterBorderZones()
		{
			throw null;
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterRestrictableZones()
		{
			throw null;
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnGameStarted()
		{
			throw null;
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_17()
		{
			throw null;
		}

		// Token: 0x04006A93 RID: 27283
		[CompilerGenerated]
		private static Action action_0;

		// Token: 0x04006A94 RID: 27284
		[CompilerGenerated]
		private ExfiltrationControllerClass gclass1254_0;

		// Token: 0x04006A95 RID: 27285
		[CompilerGenerated]
		private BufferZoneControllerClass gclass2950_0;

		// Token: 0x04006A96 RID: 27286
		[CompilerGenerated]
		private HalloweenEventControllerClass gclass1478_0;

		// Token: 0x04006A97 RID: 27287
		[CompilerGenerated]
		private Class419 class419_0;

		// Token: 0x04006A98 RID: 27288
		[CompilerGenerated]
		private BTRControllerClass gclass2913_0;

		// Token: 0x04006A99 RID: 27289
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04006A9A RID: 27290
		public GameDateTime GameDateTime;

		// Token: 0x04006A9B RID: 27291
		public GameWorldUnityTickListener UnityTickListener;

		// Token: 0x04006A9C RID: 27292
		public bool SpeedLimitsEnabled;

		// Token: 0x04006A9D RID: 27293
		public GClass1735.Config SpeedLimits;

		// Token: 0x04006A9E RID: 27294
		public string CurrentProfileId;

		// Token: 0x04006A9F RID: 27295
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x04006AA0 RID: 27296
		[CompilerGenerated]
		private Action<IPlayer> action_2;

		// Token: 0x04006AA1 RID: 27297
		[CompilerGenerated]
		private Action<float> action_3;

		// Token: 0x04006AA2 RID: 27298
		[CompilerGenerated]
		private Action<float> action_4;

		// Token: 0x04006AA3 RID: 27299
		private readonly GClass726 gclass726_0;

		// Token: 0x04006AA4 RID: 27300
		public AudioSourceCulling AudioSourceCulling;

		// Token: 0x04006AA5 RID: 27301
		public GClass737<GClass2989> TrajectoryCalculatorPool;

		// Token: 0x04006AA6 RID: 27302
		[CompilerGenerated]
		private GInterface355 ginterface355_0;

		// Token: 0x04006AA7 RID: 27303
		public BallisticsCalculator _sharedBallisticsCalculator;

		// Token: 0x04006AA8 RID: 27304
		private StashClass gclass2698_0;

		// Token: 0x04006AA9 RID: 27305
		private GClass2495 gclass2495_0;

		// Token: 0x04006AAA RID: 27306
		private TraderControllerClass gclass2754_0;

		// Token: 0x04006AAB RID: 27307
		public readonly List<GInterface12> LootList;

		// Token: 0x04006AAC RID: 27308
		public readonly Dictionary<IItemOwner, GameWorld.GStruct116> ItemOwners;

		// Token: 0x04006AAD RID: 27309
		public readonly GClass720<int, LootItem> LootItems;

		// Token: 0x04006AAE RID: 27310
		public readonly Dictionary<int, ObservedCorpse> ObservedPlayersCorpes;

		// Token: 0x04006AAF RID: 27311
		public readonly List<LootItemPositionClass> AllLoot;

		// Token: 0x04006AB0 RID: 27312
		public readonly List<IPlayer> RegisteredPlayers;

		// Token: 0x04006AB1 RID: 27313
		private Dictionary<string, Player> dictionary_0;

		// Token: 0x04006AB2 RID: 27314
		public Dictionary<string, Player> allAlivePlayersByID;

		// Token: 0x04006AB3 RID: 27315
		public List<Player> AllAlivePlayersList;

		// Token: 0x04006AB4 RID: 27316
		private Dictionary<string, GInterface94> dictionary_1;

		// Token: 0x04006AB5 RID: 27317
		private Dictionary<Collider, GInterface94> dictionary_2;

		// Token: 0x04006AB6 RID: 27318
		private Dictionary<string, GInterface94> dictionary_3;

		// Token: 0x04006AB7 RID: 27319
		public Dictionary<string, ObservedPlayerView> allObservedPlayersByID;

		// Token: 0x04006AB8 RID: 27320
		public MovingPlatform.GClass2927[] PlatformAdapters;

		// Token: 0x04006AB9 RID: 27321
		public BorderZone[] BorderZones;

		// Token: 0x04006ABA RID: 27322
		private MovingPlatform[] movingPlatform_0;

		// Token: 0x04006ABB RID: 27323
		public Player MainPlayer;

		// Token: 0x04006ABC RID: 27324
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x04006ABD RID: 27325
		[CompilerGenerated]
		private readonly Dictionary<Collider, IPlayer> dictionary_4;

		// Token: 0x04006ABE RID: 27326
		private readonly List<AmmoPoolObject> list_0;

		// Token: 0x04006ABF RID: 27327
		private readonly List<LootItemPositionClass> list_1;

		// Token: 0x04006AC0 RID: 27328
		private static int int_0;

		// Token: 0x04006AC1 RID: 27329
		private static int int_1;

		// Token: 0x04006AC2 RID: 27330
		private static int int_2;

		// Token: 0x04006AC3 RID: 27331
		private static int int_3;

		// Token: 0x04006AC4 RID: 27332
		public SpeakerManager SpeakerManager;

		// Token: 0x04006AC5 RID: 27333
		private static int int_4;

		// Token: 0x04006AC6 RID: 27334
		private EUpdateQueue eupdateQueue_0;

		// Token: 0x04006AC7 RID: 27335
		public SynchronizableObjectLogicProcessorClass SynchronizableObjectLogicProcessor;

		// Token: 0x04006AC8 RID: 27336
		public GClass608 MineManager;

		// Token: 0x04006AC9 RID: 27337
		[CompilerGenerated]
		private Action<GInterface12> action_5;

		// Token: 0x04006ACA RID: 27338
		protected readonly Dictionary<int, Turnable> Turnables;

		// Token: 0x04006ACB RID: 27339
		public readonly GClass720<int, WindowBreaker> Windows;

		// Token: 0x04006ACC RID: 27340
		public readonly GClass720<int, Throwable> Grenades;

		// Token: 0x04006ACD RID: 27341
		public List<GStruct126> GrenadesCriticalStates;

		// Token: 0x04006ACE RID: 27342
		private GClass673 gclass673_0;

		// Token: 0x04006ACF RID: 27343
		private bool bool_0;

		// Token: 0x04006AD0 RID: 27344
		private DependencyGraph<IEasyBundle>.GClass3388 gclass3388_0;

		// Token: 0x04006AD1 RID: 27345
		public GClass595.GDelegate12 OnThrowItem;

		// Token: 0x04006AD2 RID: 27346
		public GClass595.GDelegate13 OnTakeItem;

		// Token: 0x04006AD3 RID: 27347
		private readonly List<GameObject> list_2;

		// Token: 0x04006AD4 RID: 27348
		protected EffectsCommutator _effectsCommutator;

		// Token: 0x04006AD5 RID: 27349
		private BallisticCollider ballisticCollider_0;

		// Token: 0x04006AD6 RID: 27350
		internal World world_0;

		// Token: 0x04006AD7 RID: 27351
		private World world_1;

		// Token: 0x04006AD8 RID: 27352
		protected PoolManager ObjectsFactory;

		// Token: 0x04006AD9 RID: 27353
		private readonly Queue<byte[]> queue_0;

		// Token: 0x04006ADA RID: 27354
		private Task task_0;

		// Token: 0x04006ADB RID: 27355
		private List<WorldInteractiveObject> list_3;

		// Token: 0x020011AF RID: 4527
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct116
		{
			// Token: 0x04006ADC RID: 27356
			public Transform Transform;

			// Token: 0x04006ADD RID: 27357
			public bool DoNotPerformPickUpValidation;

			// Token: 0x04006ADE RID: 27358
			public IItemOwner ItemOwner;
		}

		// Token: 0x020011B0 RID: 4528
		public class GClass3264 : Error
		{
			// Token: 0x060060FF RID: 24831 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006ADF RID: 27359
			public readonly string ItemOwnerId;
		}

		// Token: 0x020011B1 RID: 4529
		public class GClass3265 : Error
		{
			// Token: 0x06006100 RID: 24832 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AE0 RID: 27360
			public readonly string ItemAddressId;
		}

		// Token: 0x020011B2 RID: 4530
		public class GClass3266 : Error
		{
			// Token: 0x06006101 RID: 24833 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AE1 RID: 27361
			public readonly string ItemId;
		}

		// Token: 0x020011B3 RID: 4531
		public sealed class GClass3267 : Error
		{
			// Token: 0x06006102 RID: 24834 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AE2 RID: 27362
			public readonly Item Item;

			// Token: 0x04006AE3 RID: 27363
			public readonly Vector3 PlayerPosition;

			// Token: 0x04006AE4 RID: 27364
			public readonly Vector3 ItemPosition;
		}

		// Token: 0x020011B4 RID: 4532
		public sealed class GClass3268 : Error
		{
			// Token: 0x06006103 RID: 24835 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x06006104 RID: 24836 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private string method_0(Player player)
			{
				throw null;
			}

			// Token: 0x04006AE5 RID: 27365
			public readonly Item Item;

			// Token: 0x04006AE6 RID: 27366
			public readonly Player CurrentPlayer;

			// Token: 0x04006AE7 RID: 27367
			[CanBeNull]
			public readonly Player FromPlayer;

			// Token: 0x04006AE8 RID: 27368
			[CanBeNull]
			public readonly Player ToPlayer;

			// Token: 0x04006AE9 RID: 27369
			public readonly bool KnownDirection;
		}

		// Token: 0x020011B5 RID: 4533
		public sealed class GClass3269 : Error
		{
			// Token: 0x06006105 RID: 24837 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AEA RID: 27370
			public readonly Player Player;
		}

		// Token: 0x020011B6 RID: 4534
		public sealed class GClass3270 : Error
		{
			// Token: 0x06006106 RID: 24838 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AEB RID: 27371
			public readonly Player Player;
		}

		// Token: 0x020011B7 RID: 4535
		public class GClass3271 : Error
		{
			// Token: 0x06006107 RID: 24839 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AEC RID: 27372
			public readonly IItemOwner ItemOwner;

			// Token: 0x04006AED RID: 27373
			public readonly Item Item;

			// Token: 0x04006AEE RID: 27374
			public readonly Vector3 OwnerPosition;

			// Token: 0x04006AEF RID: 27375
			public readonly Vector3 ItemPosition;
		}

		// Token: 0x020011B8 RID: 4536
		public class GClass3272 : Error
		{
			// Token: 0x06006108 RID: 24840 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AF0 RID: 27376
			public readonly IItemOwner ItemOwner;

			// Token: 0x04006AF1 RID: 27377
			public readonly Item Item;

			// Token: 0x04006AF2 RID: 27378
			public readonly Vector3 OwnerPosition;

			// Token: 0x04006AF3 RID: 27379
			public readonly Vector3 ItemPosition;

			// Token: 0x04006AF4 RID: 27380
			public string ColliderName;
		}

		// Token: 0x020011B9 RID: 4537
		public class GClass3273 : Error
		{
			// Token: 0x06006109 RID: 24841 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AF5 RID: 27381
			public readonly IItemOwner ItemOwner;

			// Token: 0x04006AF6 RID: 27382
			public readonly Item Item;

			// Token: 0x04006AF7 RID: 27383
			public readonly Vector3 OwnerPosition;

			// Token: 0x04006AF8 RID: 27384
			public readonly Vector3 ItemPosition;
		}

		// Token: 0x020011BA RID: 4538
		public class GClass3274 : Error
		{
			// Token: 0x0600610A RID: 24842 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04006AF9 RID: 27385
			public readonly Item Item;
		}

		// Token: 0x020011BB RID: 4539
		[CompilerGenerated]
		[Serializable]
		private sealed class Class884
		{
			// Token: 0x0600610B RID: 24843 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPlayer x)
			{
				throw null;
			}

			// Token: 0x0600610C RID: 24844 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_1(string x)
			{
				throw null;
			}

			// Token: 0x0600610D RID: 24845 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(GInterface26 x)
			{
				throw null;
			}

			// Token: 0x0600610E RID: 24846 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(Transform x)
			{
				throw null;
			}

			// Token: 0x0600610F RID: 24847 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(Player player)
			{
				throw null;
			}

			// Token: 0x06006110 RID: 24848 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5(Player player)
			{
				throw null;
			}

			// Token: 0x06006111 RID: 24849 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6(Player player)
			{
				throw null;
			}

			// Token: 0x06006112 RID: 24850 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_7(LootItemPositionClass a, LootItemPositionClass b)
			{
				throw null;
			}

			// Token: 0x06006113 RID: 24851 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_8(Item x)
			{
				throw null;
			}

			// Token: 0x06006114 RID: 24852 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_9(GClass1246 quest)
			{
				throw null;
			}

			// Token: 0x06006115 RID: 24853 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_10( ValueTuple<Item, GameWorld.GStruct116> e)
			{
				throw null;
			}

			// Token: 0x06006116 RID: 24854 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2989 method_11()
			{
				throw null;
			}

			// Token: 0x06006117 RID: 24855 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_12(GClass2989 calculator)
			{
				throw null;
			}

			// Token: 0x04006AFA RID: 27386
			public static readonly GameWorld.Class884 class884_0;

			// Token: 0x04006AFB RID: 27387
			public static Func<IPlayer, bool> func_0;

			// Token: 0x04006AFC RID: 27388
			public static Func<string, ResourceKey> func_1;

			// Token: 0x04006AFD RID: 27389
			public static Func<GInterface26, bool> func_2;

			// Token: 0x04006AFE RID: 27390
			public static Func<Transform, string> func_3;

			// Token: 0x04006AFF RID: 27391
			public static Comparison<LootItemPositionClass> comparison_0;

			// Token: 0x04006B00 RID: 27392
			public static Func<Item, string> func_4;

			// Token: 0x04006B01 RID: 27393
			public static Func<GClass1246, bool> func_5;

			// Token: 0x04006B02 RID: 27394
			public static Func<ValueTuple<Item, GameWorld.GStruct116>, Item> func_6;

			// Token: 0x04006B03 RID: 27395
			public static Func<GClass2989> func_7;

			// Token: 0x04006B04 RID: 27396
			public static Action<GClass2989> action_0;
		}

		// Token: 0x020011BE RID: 4542
		[CompilerGenerated]
		private sealed class Class885
		{
			// Token: 0x0600611C RID: 24860 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(LootItem x)
			{
				throw null;
			}

			// Token: 0x04006B13 RID: 27411
			public string id;
		}

		// Token: 0x020011BF RID: 4543
		[CompilerGenerated]
		private sealed class Class886
		{
			// Token: 0x0600611D RID: 24861 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GInterface26 x)
			{
				throw null;
			}

			// Token: 0x04006B14 RID: 27412
			public string lootId;
		}

		// Token: 0x020011C0 RID: 4544
		[CompilerGenerated]
		private sealed class Class887
		{
			// Token: 0x0600611E RID: 24862 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(LootableContainer container)
			{
				throw null;
			}

			// Token: 0x0600611F RID: 24863 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(LootableContainer x)
			{
				throw null;
			}

			// Token: 0x04006B15 RID: 27413
			public GameWorld gameWorld_0;

			// Token: 0x04006B16 RID: 27414
			public string id;
		}

		// Token: 0x020011C1 RID: 4545
		[CompilerGenerated]
		private sealed class Class888
		{
			// Token: 0x06006120 RID: 24864 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(LootItemPositionClass lootItem)
			{
				throw null;
			}

			// Token: 0x04006B17 RID: 27415
			public GInterface26 staticLootSpawn;
		}

		// Token: 0x020011C4 RID: 4548
		[CompilerGenerated]
		private sealed class Class890
		{
			// Token: 0x06006128 RID: 24872 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04006B21 RID: 27425
			public byte[] bytes;

			// Token: 0x04006B22 RID: 27426
			public LootItemPositionClass lootItem;
		}

		// Token: 0x020011C6 RID: 4550
		[CompilerGenerated]
		private sealed class Class891
		{
			// Token: 0x0600612B RID: 24875 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(StationaryWeapon x)
			{
				throw null;
			}

			// Token: 0x04006B29 RID: 27433
			public string id;
		}

		// Token: 0x020011C7 RID: 4551
		[CompilerGenerated]
		private sealed class Class892
		{
			// Token: 0x0600612C RID: 24876 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(StationaryWeapon x)
			{
				throw null;
			}

			// Token: 0x04006B2A RID: 27434
			public string itemId;
		}

		// Token: 0x020011C8 RID: 4552
		[CompilerGenerated]
		private sealed class Class893
		{
			// Token: 0x0600612D RID: 24877 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal byte[] method_0()
			{
				throw null;
			}

			// Token: 0x04006B2B RID: 27435
			public LootItemPositionClass jsonLootItem;
		}

		// Token: 0x020011CA RID: 4554
		[CompilerGenerated]
		private sealed class Class894
		{
			// Token: 0x06006130 RID: 24880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<IItemOwner, GameWorld.GStruct116> x)
			{
				throw null;
			}

			// Token: 0x04006B31 RID: 27441
			public string ownerId;
		}
	}
}
