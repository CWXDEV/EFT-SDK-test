using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Comfort.Common;
using Dissonance;
using EFT.GlobalEvents;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.Quests;
using EFT.Vehicle;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x020018A8 RID: 6312
	public class ClientPlayer : NetworkPlayer
	{
		// Token: 0x060087A7 RID: 34727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Interact(IItemOwner loot, Callback callback)
		{
			throw null;
		}

		// Token: 0x060087A8 RID: 34728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DropCurrentController(Action callback, bool fastDrop, Item nextControllerItem = null)
		{
			throw null;
		}

		// Token: 0x060087A9 RID: 34729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(bool withNetwork, Callback<GInterface125> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087AA RID: 34730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(Weapon weapon, Callback<IFirearmHandsController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087AB RID: 34731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(GrenadeClass throwWeap, Callback<IHandsController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087AC RID: 34732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(MedsClass meds, EBodyPart bodyPart, Callback<GInterface130> callback, int animationVariant, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087AD RID: 34733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(FoodClass foodDrink, float amount, Callback<GInterface130> callback, int animationVariant, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087AE RID: 34734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(KnifeComponent knife, Callback<IKnifeController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087AF RID: 34735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void Proceed<T>(Item item, Callback<GInterface129> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087B0 RID: 34736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(GrenadeClass throwWeap, Callback<IGrenadeController> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087B1 RID: 34737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(KnifeComponent knife, Callback<GInterface134> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087B2 RID: 34738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Proceed(Item item, Callback<GInterface135> callback, bool scheduled = true)
		{
			throw null;
		}

		// Token: 0x060087B3 RID: 34739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_3(IResult result, Action confirmAction)
		{
			throw null;
		}

		// Token: 0x060087B4 RID: 34740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint method_132(Action<bool> confirmAction)
		{
			throw null;
		}

		// Token: 0x060087B5 RID: 34741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ProcessStopSearching(string itemId)
		{
			throw null;
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060087B6 RID: 34742 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060087B7 RID: 34743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060087B8 RID: 34744 RVA: 0x00002050 File Offset: 0x00000250
		public DateTime TalkDateTime
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

		// Token: 0x060087B9 RID: 34745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitVoip(Player.EVoipState voipState)
		{
			throw null;
		}

		// Token: 0x060087BA RID: 34746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void VoipAbuseNotification(string reporterId)
		{
			throw null;
		}

		// Token: 0x060087BB RID: 34747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T smethod_4<T>(int playerId, Vector3 position, GInterface101 frameIndexer, ClientPlayer.GDelegate66 sendDelegate, int sendRateFramesLimit, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, GInterface144 session, GClass1792 voipSettings, ERaidMode raidMode) where T : ClientPlayer
		{
			throw null;
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060087BC RID: 34748 RVA: 0x00002050 File Offset: 0x00000250
		public override byte ChannelIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060087BD RID: 34749 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060087BE RID: 34750 RVA: 0x00002050 File Offset: 0x00000250
		public float RTTDelay
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

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060087BF RID: 34751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060087C0 RID: 34752 RVA: 0x00002050 File Offset: 0x00000250
		public static bool RTTEnabled
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

		// Token: 0x060087C1 RID: 34753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientPlayer.GInterface148 GetDataSender()
		{
			throw null;
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060087C2 RID: 34754 RVA: 0x00002050 File Offset: 0x00000250
		public long UnprocessedCriticalPackets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060087C3 RID: 34755 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060087C4 RID: 34756 RVA: 0x00002050 File Offset: 0x00000250
		public int UnprocessedCriticalPacketsTimeMs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x060087C5 RID: 34757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060087C6 RID: 34758 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsVisible
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

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x060087C7 RID: 34759 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsWaitingForNetworkCallback
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint method_133()
		{
			throw null;
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FixedUpdateTick()
		{
			throw null;
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ComplexLateUpdate(EUpdateQueue queue, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060087CB RID: 34763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060087CD RID: 34765 RVA: 0x00002050 File Offset: 0x00000250
		public override Player.AbstractHandsController HandsController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x060087CE RID: 34766 RVA: 0x00002050 File Offset: 0x00000250
		private GStruct170 GStruct170_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060087CF RID: 34767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateMovementContext()
		{
			throw null;
		}

		// Token: 0x060087D0 RID: 34768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void KillMe(EBodyPartColliderType colliderType, float damage)
		{
			throw null;
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DevelopResetDiscardLimits()
		{
			throw null;
		}

		// Token: 0x060087D2 RID: 34770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DevelopSetEncodedRadioTransmitter(bool value)
		{
			throw null;
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void GetRadioTransmitterStatusFromServer()
		{
			throw null;
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetTraderServicesDataFromServer(string traderId)
		{
			throw null;
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReceiveTraderServicesDataFromServer(byte[] packet)
		{
			throw null;
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DevelopSetActiveLighthouseTraderZoneDebug(bool value)
		{
			throw null;
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void KillAIs()
		{
			throw null;
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetEventState(EEventState eventState)
		{
			throw null;
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SpawnAI(int count)
		{
			throw null;
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DevelopUnlockDoors(bool open)
		{
			throw null;
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PauseAllEffectsOnPlayer()
		{
			throw null;
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UnpauseAllEffectsOnPlayer()
		{
			throw null;
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TriggerPhraseCommand(EPhraseTrigger phrase, int netPhraseId)
		{
			throw null;
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPhraseTold(EPhraseTrigger @event, TaggedClip clip, TagBank bank, GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ManageAggressor(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType colliderType)
		{
			throw null;
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ShowStringNotification(string message)
		{
			throw null;
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_134(GClass2907 endCutsceneEvent)
		{
			throw null;
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_135(GClass2891 cutsceneEvent)
		{
			throw null;
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("DEBUG")]
		[Conditional("CONSOLE")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_136()
		{
			throw null;
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_137()
		{
			throw null;
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_138()
		{
			throw null;
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_139()
		{
			throw null;
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_140()
		{
			throw null;
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_141()
		{
			throw null;
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_142(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_143()
		{
			throw null;
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetHands()
		{
			throw null;
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, float absorbed)
		{
			throw null;
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass1673 ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, GStruct389 shotId)
		{
			throw null;
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void MouseLook(bool forceApplyToOriginalRibcage = false)
		{
			throw null;
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060087EF RID: 34799 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060087F0 RID: 34800 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsBot
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

		// Token: 0x060087F1 RID: 34801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeserializeInitialState(NetworkReader networkReader, GClass1650 deferredData, Callback callback)
		{
			throw null;
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_144(SyncClientEventState createPlayerEvent)
		{
			throw null;
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_145(WinterReconnectEvent winterReconnectEvent)
		{
			throw null;
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_146(BaseReconnectEvent baseReconnectEvent)
		{
			throw null;
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_147(Callback callback, NetworkReader reader, bool isAlive, Quaternion rotation, bool isInPronePose, float poseLevel, Player.EVoipState voipState, bool isInBufferZone, int bufferZoneUsageTimeLeft, bool leftStance)
		{
			throw null;
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_148(Profile profile, MongoID firstId, Quaternion rotation, bool isAlive, EHandsControllerType type, bool isInSpawnOperation, string itemId, byte[] healthState, bool isInPronePose, float poseLevel, bool isStationaryWeapon, Vector2 stationaryRotation, Quaternion playerStationaryRotation, int animationVariant, Player.EVoipState voipState, bool isInBufferZone, int bufferZoneUsageTimeLeft, bool leftStance, Callback callback)
		{
			throw null;
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserializeFromServer(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_149(GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateTick()
		{
			throw null;
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ushort? method_150()
		{
			throw null;
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_151(ushort rttKey, int singleFixedUpdate, int serverTime)
		{
			throw null;
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdatePhones()
		{
			throw null;
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TryInteractionCallback(LootableContainer container)
		{
			throw null;
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_0(WorldInteractiveObject door, InteractionResult interactionResult, Action callback)
		{
			throw null;
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_1(WorldInteractiveObject door, InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void BtrInteraction(BTRSide btr, byte placeId, EInteractionType interaction)
		{
			throw null;
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06008801 RID: 34817 RVA: 0x00002050 File Offset: 0x00000250
		public override bool OnHisWayToOperateStationaryWeapon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OperateStationaryWeapon(StationaryWeapon stationaryWeapon, GStruct168.EStationaryCommand command)
		{
			throw null;
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_2(string itemId, string zoneId, bool successful)
		{
			throw null;
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_152(uint operationId, EOperationStatus status, string error, int inventoryHashSum, bool badBeforeExecuting)
		{
			throw null;
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_153(uint callbackId, string error, int inventoryHashSum, byte badBeforeExecuting)
		{
			throw null;
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_154(string traderId, double standing)
		{
			throw null;
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_155(bool isEncoded, RadioTransmitterStatus status, bool isAgressor)
		{
			throw null;
		}

		// Token: 0x1400018D RID: 397
		// (add) Token: 0x06008808 RID: 34824 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06008809 RID: 34825 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> SetActiveLighthouseTraderZoneDebug
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

		// Token: 0x0600880A RID: 34826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_156(bool active)
		{
			throw null;
		}

		// Token: 0x1400018E RID: 398
		// (add) Token: 0x0600880B RID: 34827 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600880C RID: 34828 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GStruct131> OnSyncLighthouseTraderZoneData
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

		// Token: 0x0600880D RID: 34829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SyncLighthouseTraderZoneData(GStruct131 data)
		{
			throw null;
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_157(string weaponId, float lastOverheat, float lastShotTime, bool slideReached)
		{
			throw null;
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSkillLevelChanged(GClass1763 skill)
		{
			throw null;
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnWeaponMastered(GClass1764 masterSkill)
		{
			throw null;
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x00002050 File Offset: 0x00000250
		public override Vector3 LocalShotDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008812 RID: 34834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_158(NetworkPlayer.ClientShot[] clientShots)
		{
			throw null;
		}

		// Token: 0x06008814 RID: 34836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_159(int questId, EQuestStatus status, int conditionId, double value, bool notify)
		{
			throw null;
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_160(int questId, EQuestStatus status, int conditionId, double value, bool notify)
		{
			throw null;
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ProcessCompletedAchievementsData(GStruct218 data)
		{
			throw null;
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ulong OutgoingPacketsBytes()
		{
			throw null;
		}

		// Token: 0x1400018F RID: 399
		// (add) Token: 0x06008818 RID: 34840 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06008819 RID: 34841 RVA: 0x00002050 File Offset: 0x00000250
		public event ClientPlayer.GClass1853.GDelegate65 OnPacketSent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDead(EDamageType damageType)
		{
			throw null;
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ShouldVocalizeDeath(EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnGameSessionEnd(ExitStatus exitStatus, float pastTime, string locationId, string exitName)
		{
			throw null;
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteCancelApplyingItemPacket()
		{
			throw null;
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Teleport(Vector3 position, bool onServerToo = false)
		{
			throw null;
		}

		// Token: 0x0600881F RID: 34847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ApplyTeleportPacket(GStruct336 packet)
		{
			throw null;
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void StartInflictSelfDamageCoroutine()
		{
			throw null;
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void PlayToggleSound(ref bool previousState, bool isOn, AudioClip toggleOn, AudioClip toggleOff)
		{
			throw null;
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CreateNestedSource()
		{
			throw null;
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetAudioProtagonist()
		{
			throw null;
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x00002050 File Offset: 0x00000250
		protected override float Distance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateOcclusion()
		{
			throw null;
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SendVoiceMuffledState(bool isMuffled)
		{
			throw null;
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SendUnderRoofStatus(bool isUnderRoof)
		{
			throw null;
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SendHeadlightsPacket(bool isSilent)
		{
			throw null;
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SendWeaponLightPacket()
		{
			throw null;
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_161(float coeff)
		{
			throw null;
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_162(int command, string id)
		{
			throw null;
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_163(int val)
		{
			throw null;
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_164(int val)
		{
			throw null;
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_165(int accessLevel)
		{
			throw null;
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_166()
		{
			throw null;
		}

		// Token: 0x06008830 RID: 34864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void InitialProfileExamineAll()
		{
			throw null;
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_167()
		{
			throw null;
		}

		// Token: 0x06008832 RID: 34866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInventoryOpened(bool opened)
		{
			throw null;
		}

		// Token: 0x06008833 RID: 34867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_168(IResult result)
		{
			throw null;
		}

		// Token: 0x04008E0E RID: 36366
		protected GStruct177 _handsChangePacket;

		// Token: 0x04008E0F RID: 36367
		private GStruct166 gstruct166_0;

		// Token: 0x04008E10 RID: 36368
		private PlayerInteractPacket gstruct167_0;

		// Token: 0x04008E11 RID: 36369
		protected GStruct172 _lootInteractionPacket;

		// Token: 0x04008E12 RID: 36370
		private GStruct168 gstruct168_0;

		// Token: 0x04008E13 RID: 36371
		private GStruct169 gstruct169_0;

		// Token: 0x04008E14 RID: 36372
		private GStruct161 gstruct161_0;

		// Token: 0x04008E15 RID: 36373
		private GStruct161 gstruct161_1;

		// Token: 0x04008E16 RID: 36374
		private bool bool_1;

		// Token: 0x04008E17 RID: 36375
		private bool bool_2;

		// Token: 0x04008E18 RID: 36376
		private const int int_0 = 20;

		// Token: 0x04008E19 RID: 36377
		private static readonly TimeSpan timeSpan_0;

		// Token: 0x04008E1A RID: 36378
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04008E1B RID: 36379
		private const float float_0 = 2.17f;

		// Token: 0x04008E1C RID: 36380
		private byte byte_1;

		// Token: 0x04008E1D RID: 36381
		private static Queue<Tuple<ushort, DateTime>> queue_0;

		// Token: 0x04008E1E RID: 36382
		private float float_1;

		// Token: 0x04008E1F RID: 36383
		private float float_2;

		// Token: 0x04008E20 RID: 36384
		[CompilerGenerated]
		private float float_3;

		// Token: 0x04008E21 RID: 36385
		protected ClientPlayer.GInterface148 _dataSender;

		// Token: 0x04008E22 RID: 36386
		private readonly Dictionary<uint, Callback<int, bool>> dictionary_0;

		// Token: 0x04008E23 RID: 36387
		private uint uint_0;

		// Token: 0x04008E24 RID: 36388
		public int ScavExfilMask;

		// Token: 0x04008E25 RID: 36389
		private GClass1650 gclass1650_0;

		// Token: 0x04008E26 RID: 36390
		private long long_0;

		// Token: 0x04008E27 RID: 36391
		private long long_1;

		// Token: 0x04008E28 RID: 36392
		private GClass738 gclass738_0;

		// Token: 0x04008E29 RID: 36393
		private GClass1792 gclass1792_0;

		// Token: 0x04008E2A RID: 36394
		private ClientPlayer.Class1403 class1403_0;

		// Token: 0x04008E2B RID: 36395
		private ClientGameWorld clientGameWorld_0;

		// Token: 0x04008E2C RID: 36396
		private Action action_0;

		// Token: 0x04008E2D RID: 36397
		private Action action_1;

		// Token: 0x04008E2E RID: 36398
		private Action action_2;

		// Token: 0x04008E2F RID: 36399
		private Action action_3;

		// Token: 0x04008E30 RID: 36400
		private bool bool_3;

		// Token: 0x04008E31 RID: 36401
		private bool bool_4;

		// Token: 0x04008E32 RID: 36402
		private ClientPlayer.Struct420 struct420_0;

		// Token: 0x04008E33 RID: 36403
		private ERaidMode eraidMode_0;

		// Token: 0x04008E34 RID: 36404
		private GClass1682 gclass1682_0;

		// Token: 0x04008E35 RID: 36405
		public bool TranslateNetCommands;

		// Token: 0x04008E36 RID: 36406
		private Vector3 vector3_0;

		// Token: 0x04008E37 RID: 36407
		private GStruct164 gstruct164_0;

		// Token: 0x04008E38 RID: 36408
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x04008E39 RID: 36409
		[CompilerGenerated]
		private Action<bool> action_4;

		// Token: 0x04008E3A RID: 36410
		[CompilerGenerated]
		private Action<GStruct131> action_5;

		// Token: 0x04008E3B RID: 36411
		private readonly GClass728<NetworkPlayer.ClientShot> gclass728_0;

		// Token: 0x04008E3C RID: 36412
		private GInterface144 ginterface144_0;

		// Token: 0x04008E3D RID: 36413
		private bool bool_6;

		// Token: 0x04008E3E RID: 36414
		private bool bool_7;

		// Token: 0x04008E3F RID: 36415
		private float float_4;

		// Token: 0x020018A9 RID: 6313
		public interface GInterface148
		{
			// Token: 0x06008835 RID: 34869
			void Send(ref GStruct161 client2ServerPacket, float deltaTime, float time, float lastServerTime);

			// Token: 0x06008836 RID: 34870
			void Dispatch();

			// Token: 0x170014DE RID: 5342
			// (get) Token: 0x06008837 RID: 34871
			ulong BytesWritten { get; }

			// Token: 0x14000190 RID: 400
			// (add) Token: 0x06008838 RID: 34872
			// (remove) Token: 0x06008839 RID: 34873
			event ClientPlayer.GClass1853.GDelegate65 DataSentEvent;
		}

		// Token: 0x020018AA RID: 6314
		public sealed class GClass1853 : ClientPlayer.GInterface148
		{
			// Token: 0x14000191 RID: 401
			// (add) Token: 0x0600883A RID: 34874 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600883B RID: 34875 RVA: 0x00002050 File Offset: 0x00000250
			private event ClientPlayer.GClass1853.GDelegate65 Event_0
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

			// Token: 0x170014DF RID: 5343
			// (get) Token: 0x0600883C RID: 34876 RVA: 0x00002050 File Offset: 0x00000250
			ulong ClientPlayer.GInterface148.BytesWritten
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x14000192 RID: 402
			// (add) Token: 0x0600883D RID: 34877 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600883E RID: 34878 RVA: 0x00002050 File Offset: 0x00000250
			event ClientPlayer.GClass1853.GDelegate65 ClientPlayer.GInterface148.DataSentEvent
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				add
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				remove
				{
					throw null;
				}
			}

			// Token: 0x0600883F RID: 34879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void ClientPlayer.GInterface148.Send(ref GStruct161 client2ServerPacket, float deltaTime, float time, float lastServerTime)
			{
				throw null;
			}

			// Token: 0x06008840 RID: 34880 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void ClientPlayer.GInterface148.Dispatch()
			{
				throw null;
			}

			// Token: 0x06008841 RID: 34881 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x04008E40 RID: 36416
			private readonly ClientPlayer clientPlayer_0;

			// Token: 0x04008E41 RID: 36417
			private readonly ClientPlayer.GDelegate66 gdelegate66_0;

			// Token: 0x04008E42 RID: 36418
			private readonly GInterface79 ginterface79_0;

			// Token: 0x04008E43 RID: 36419
			private GStruct161 gstruct161_0;

			// Token: 0x04008E44 RID: 36420
			private readonly GClass728<GStruct161> gclass728_0;

			// Token: 0x04008E45 RID: 36421
			private ulong ulong_0;

			// Token: 0x04008E46 RID: 36422
			private readonly float float_0;

			// Token: 0x04008E47 RID: 36423
			private float float_1;

			// Token: 0x04008E48 RID: 36424
			private float float_2;

			// Token: 0x04008E49 RID: 36425
			private int int_0;

			// Token: 0x04008E4A RID: 36426
			[CompilerGenerated]
			private ClientPlayer.GClass1853.GDelegate65 gdelegate65_0;

			// Token: 0x04008E4B RID: 36427
			public bool PreventDispatch;

			// Token: 0x04008E4C RID: 36428
			private bool bool_0;

			// Token: 0x020018AB RID: 6315
			// (Invoke) Token: 0x06008842 RID: 34882
			public delegate void GDelegate65(ClientPlayer player, int bytes, ulong totalBytes);
		}

		// Token: 0x020018AC RID: 6316
		internal sealed class Control0 : Player.PlayerOwnerInventoryController
		{
			// Token: 0x170014E0 RID: 5344
			// (get) Token: 0x06008845 RID: 34885 RVA: 0x00002050 File Offset: 0x00000250
			private ClientPlayer ClientPlayer_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06008846 RID: 34886 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_45(int inventoryHashSum, bool badBeforeExecuting, GClass2833 operation)
			{
				throw null;
			}

			// Token: 0x06008847 RID: 34887 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private uint method_46<T>(T operation, Callback<int, bool, EOperationStatus> action) where T : GClass2833
			{
				throw null;
			}

			// Token: 0x06008848 RID: 34888 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void ExecuteStationaryOperation(StationaryWeapon stationaryWeapon, Callback callback = null)
			{
				throw null;
			}

			// Token: 0x06008849 RID: 34889 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal override void Execute(GClass2833 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x0600884A RID: 34890 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void NotifyMagazineChecked(string name)
			{
				throw null;
			}

			// Token: 0x0600884B RID: 34891 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void Execute(GClass2865 operation, Callback callback)
			{
				throw null;
			}

			// Token: 0x0600884C RID: 34892 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ExecuteStop(GClass2865 operation)
			{
				throw null;
			}

			// Token: 0x0600884D RID: 34893 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void GetTraderServicesDataFromServer(string traderId)
			{
				throw null;
			}

			// Token: 0x020018AD RID: 6317
			[CompilerGenerated]
			private sealed class Class1399
			{
				// Token: 0x0600884E RID: 34894 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Result<int, bool, EOperationStatus> result)
				{
					throw null;
				}

				// Token: 0x04008E4D RID: 36429
				public int finishedInventoryHash;

				// Token: 0x04008E4E RID: 36430
				public EOperationStatus? serverOperationStatus;

				// Token: 0x04008E4F RID: 36431
				public EOperationStatus? localOperationStatus;

				// Token: 0x04008E50 RID: 36432
				public GClass2833 operation;

				// Token: 0x04008E51 RID: 36433
				public Callback callback;

				// Token: 0x04008E52 RID: 36434
				public ClientPlayer.Control0 control0_0;
			}

			// Token: 0x020018AE RID: 6318
			[CompilerGenerated]
			private sealed class Class1400
			{
				// Token: 0x0600884F RID: 34895 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult executeResult)
				{
					throw null;
				}

				// Token: 0x04008E53 RID: 36435
				public Result<int, bool, EOperationStatus> result;

				// Token: 0x04008E54 RID: 36436
				public ClientPlayer.Control0.Class1399 class1399_0;
			}

			// Token: 0x020018AF RID: 6319
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1401
			{
				// Token: 0x06008850 RID: 34896 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult _)
				{
					throw null;
				}

				// Token: 0x04008E55 RID: 36437
				public static readonly ClientPlayer.Control0.Class1401 class1401_0;

				// Token: 0x04008E56 RID: 36438
				public static Callback callback_0;
			}

			// Token: 0x020018B0 RID: 6320
			[CompilerGenerated]
			private sealed class Class1402
			{
				// Token: 0x06008851 RID: 34897 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Result<int, bool, EOperationStatus> result)
				{
					throw null;
				}

				// Token: 0x04008E57 RID: 36439
				public GClass2865 operation;

				// Token: 0x04008E58 RID: 36440
				public Callback callback;
			}
		}

		// Token: 0x020018B1 RID: 6321
		private sealed class Class1403 : IDisposable, IPlayerVoipController
		{
			// Token: 0x170014E1 RID: 5345
			// (get) Token: 0x06008852 RID: 34898 RVA: 0x00002050 File Offset: 0x00000250
			private DissonanceComms DissonanceComms_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170014E2 RID: 5346
			// (get) Token: 0x06008853 RID: 34899 RVA: 0x00002050 File Offset: 0x00000250
			private TimeSpan TimeSpan_0
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170014E3 RID: 5347
			// (get) Token: 0x06008854 RID: 34900 RVA: 0x00002050 File Offset: 0x00000250
			private TimeSpan TimeSpan_1
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170014E4 RID: 5348
			// (get) Token: 0x06008855 RID: 34901 RVA: 0x00002050 File Offset: 0x00000250
			private TimeSpan TimeSpan_2
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170014E5 RID: 5349
			// (get) Token: 0x06008856 RID: 34902 RVA: 0x00002050 File Offset: 0x00000250
			private TimeSpan TimeSpan_3
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06008857 RID: 34903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x170014E6 RID: 5350
			// (get) Token: 0x06008858 RID: 34904 RVA: 0x00002050 File Offset: 0x00000250
			public BindableState<EVoipControllerStatus> Status
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170014E7 RID: 5351
			// (get) Token: 0x06008859 RID: 34905 RVA: 0x00002050 File Offset: 0x00000250
			public BindableState<bool> HasInteraction
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170014E8 RID: 5352
			// (get) Token: 0x0600885A RID: 34906 RVA: 0x00002050 File Offset: 0x00000250
			public BindableState<bool> TalkDetected
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x14000193 RID: 403
			// (add) Token: 0x0600885B RID: 34907 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600885C RID: 34908 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<string> AbuseNotification
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

			// Token: 0x0600885D RID: 34909 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(string reporterId)
			{
				throw null;
			}

			// Token: 0x0600885E RID: 34910 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void Update()
			{
				throw null;
			}

			// Token: 0x0600885F RID: 34911 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1()
			{
				throw null;
			}

			// Token: 0x06008860 RID: 34912 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x170014E9 RID: 5353
			// (get) Token: 0x06008861 RID: 34913 RVA: 0x00002050 File Offset: 0x00000250
			TimeSpan IPlayerVoipController.TimeToNextStatus
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06008862 RID: 34914 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			EVoipControllerStatus IPlayerVoipController.ToggleTalk()
			{
				throw null;
			}

			// Token: 0x06008863 RID: 34915 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			EVoipControllerStatus IPlayerVoipController.StopTalk()
			{
				throw null;
			}

			// Token: 0x06008864 RID: 34916 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IPlayerVoipController.ReportAbuse()
			{
				throw null;
			}

			// Token: 0x06008865 RID: 34917 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ForceMuteVoIP(bool enable)
			{
				throw null;
			}

			// Token: 0x06008866 RID: 34918 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private EVoipControllerStatus method_3(ClientPlayer.Class1403.Class1405 state)
			{
				throw null;
			}

			// Token: 0x06008867 RID: 34919 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4(EVoipControllerStatus status)
			{
				throw null;
			}

			// Token: 0x06008868 RID: 34920 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_5(bool enabled)
			{
				throw null;
			}

			// Token: 0x06008869 RID: 34921 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6(string device)
			{
				throw null;
			}

			// Token: 0x0600886A RID: 34922 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_7()
			{
				throw null;
			}

			// Token: 0x0600886B RID: 34923 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private ClientPlayer.Class1403.Struct418 method_8()
			{
				throw null;
			}

			// Token: 0x0600886C RID: 34924 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private ClientPlayer.Class1403.Struct418 method_9()
			{
				throw null;
			}

			// Token: 0x0600886D RID: 34925 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private ClientPlayer.Class1403.Struct418 method_10()
			{
				throw null;
			}

			// Token: 0x0600886E RID: 34926 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private ClientPlayer.Class1403.Struct418 method_11()
			{
				throw null;
			}

			// Token: 0x0600886F RID: 34927 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_12()
			{
				throw null;
			}

			// Token: 0x04008E59 RID: 36441
			private ClientPlayer clientPlayer_0;

			// Token: 0x04008E5A RID: 36442
			private readonly GClass763 gclass763_0;

			// Token: 0x04008E5B RID: 36443
			private readonly ClientPlayer.Class1403.Class1404 class1404_0;

			// Token: 0x04008E5C RID: 36444
			private readonly ClientPlayer.Class1403.Class1408 class1408_0;

			// Token: 0x04008E5D RID: 36445
			private readonly ClientPlayer.Class1403.Class1414 class1414_0;

			// Token: 0x04008E5E RID: 36446
			private readonly ClientPlayer.Class1403.Class1410 class1410_0;

			// Token: 0x04008E5F RID: 36447
			private readonly ClientPlayer.Class1403.Class1411 class1411_0;

			// Token: 0x04008E60 RID: 36448
			private readonly ClientPlayer.Class1403.Class1412 class1412_0;

			// Token: 0x04008E61 RID: 36449
			private readonly ClientPlayer.Class1403.Class1407 class1407_0;

			// Token: 0x04008E62 RID: 36450
			private ClientPlayer.Class1403.Class1405 class1405_0;

			// Token: 0x04008E63 RID: 36451
			[CompilerGenerated]
			private readonly TimeSpan timeSpan_0;

			// Token: 0x04008E64 RID: 36452
			[CompilerGenerated]
			private readonly TimeSpan timeSpan_1;

			// Token: 0x04008E65 RID: 36453
			[CompilerGenerated]
			private readonly TimeSpan timeSpan_2;

			// Token: 0x04008E66 RID: 36454
			[CompilerGenerated]
			private readonly TimeSpan timeSpan_3;

			// Token: 0x04008E67 RID: 36455
			private DateTime? nullable_0;

			// Token: 0x04008E68 RID: 36456
			private bool bool_0;

			// Token: 0x04008E69 RID: 36457
			private bool bool_1;

			// Token: 0x04008E6A RID: 36458
			[CompilerGenerated]
			private readonly BindableState<EVoipControllerStatus> gclass3370_0;

			// Token: 0x04008E6B RID: 36459
			[CompilerGenerated]
			private readonly BindableState<bool> gclass3370_1;

			// Token: 0x04008E6C RID: 36460
			[CompilerGenerated]
			private readonly BindableState<bool> gclass3370_2;

			// Token: 0x04008E6D RID: 36461
			[CompilerGenerated]
			private Action<string> action_0;

			// Token: 0x020018B2 RID: 6322
			[StructLayout(LayoutKind.Auto)]
			public readonly struct Struct418
			{
				// Token: 0x170014EA RID: 5354
				// (get) Token: 0x06008870 RID: 34928 RVA: 0x00002050 File Offset: 0x00000250
				internal DateTime DateTime_0
				{
					[CompilerGenerated]
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014EB RID: 5355
				// (get) Token: 0x06008871 RID: 34929 RVA: 0x00002050 File Offset: 0x00000250
				internal DateTime DateTime_1
				{
					[CompilerGenerated]
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014EC RID: 5356
				// (get) Token: 0x06008872 RID: 34930 RVA: 0x00002050 File Offset: 0x00000250
				internal bool Boolean_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014ED RID: 5357
				// (get) Token: 0x06008873 RID: 34931 RVA: 0x00002050 File Offset: 0x00000250
				internal TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06008874 RID: 34932 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x04008E6E RID: 36462
				[CompilerGenerated]
				private readonly DateTime dateTime_0;

				// Token: 0x04008E6F RID: 36463
				[CompilerGenerated]
				private readonly DateTime dateTime_1;
			}

			// Token: 0x020018B3 RID: 6323
			internal sealed class Class1404
			{
				// Token: 0x06008875 RID: 34933 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ClientPlayer.Class1403.Class1404 smethod_0(byte activationsLimit, float activationsInterval, float speakingInterval)
				{
					throw null;
				}

				// Token: 0x06008876 RID: 34934 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(DateTime from, DateTime to)
				{
					throw null;
				}

				// Token: 0x06008877 RID: 34935 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal TimeSpan method_1(DateTime dateTime)
				{
					throw null;
				}

				// Token: 0x06008878 RID: 34936 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2()
				{
					throw null;
				}

				// Token: 0x04008E70 RID: 36464
				private TimeSpan timeSpan_0;

				// Token: 0x04008E71 RID: 36465
				private List<ClientPlayer.Class1403.Class1404.Struct419> list_0;

				// Token: 0x04008E72 RID: 36466
				private byte byte_0;

				// Token: 0x04008E73 RID: 36467
				private TimeSpan timeSpan_1;

				// Token: 0x020018B4 RID: 6324
				[StructLayout(LayoutKind.Auto)]
				public struct Struct419
				{
					// Token: 0x170014EE RID: 5358
					// (get) Token: 0x06008879 RID: 34937 RVA: 0x00002050 File Offset: 0x00000250
					public TimeSpan Duration
					{
						[MethodImpl(MethodImplOptions.NoInlining)]
						get
						{
							throw null;
						}
					}

					// Token: 0x04008E74 RID: 36468
					public DateTime From;

					// Token: 0x04008E75 RID: 36469
					public DateTime To;
				}
			}

			// Token: 0x020018B5 RID: 6325
			private abstract class Class1405
			{
				// Token: 0x170014EF RID: 5359
				// (get) Token: 0x0600887A RID: 34938
				internal abstract EVoipControllerStatus EVoipControllerStatus_0 { get; }

				// Token: 0x170014F0 RID: 5360
				// (get) Token: 0x0600887B RID: 34939 RVA: 0x00002050 File Offset: 0x00000250
				// (set) Token: 0x0600887C RID: 34940 RVA: 0x00002050 File Offset: 0x00000250
				internal ClientPlayer.Class1403 Class1403_0
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

				// Token: 0x170014F1 RID: 5361
				// (get) Token: 0x0600887D RID: 34941 RVA: 0x00002050 File Offset: 0x00000250
				internal ClientPlayer.Class1403.Class1404 Class1404_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014F2 RID: 5362
				// (get) Token: 0x0600887E RID: 34942 RVA: 0x00002050 File Offset: 0x00000250
				internal bool Boolean_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014F3 RID: 5363
				// (get) Token: 0x0600887F RID: 34943 RVA: 0x00002050 File Offset: 0x00000250
				protected DissonanceComms DissonanceComms_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014F4 RID: 5364
				// (get) Token: 0x06008880 RID: 34944
				internal abstract TimeSpan TimeSpan_0 { get; }

				// Token: 0x06008881 RID: 34945 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual EVoipControllerStatus vmethod_0()
				{
					throw null;
				}

				// Token: 0x06008882 RID: 34946 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual EVoipControllerStatus vmethod_1()
				{
					throw null;
				}

				// Token: 0x06008883 RID: 34947 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual EVoipControllerStatus vmethod_2()
				{
					throw null;
				}

				// Token: 0x06008884 RID: 34948 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual void vmethod_3()
				{
					throw null;
				}

				// Token: 0x06008885 RID: 34949 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual void vmethod_4()
				{
					throw null;
				}

				// Token: 0x06008886 RID: 34950 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal virtual void Update()
				{
					throw null;
				}

				// Token: 0x04008E76 RID: 36470
				[CompilerGenerated]
				private ClientPlayer.Class1403 class1403_0;
			}

			// Token: 0x020018B6 RID: 6326
			private abstract class Class1406 : ClientPlayer.Class1403.Class1405
			{
				// Token: 0x06008887 RID: 34951 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}
			}

			// Token: 0x020018B7 RID: 6327
			private sealed class Class1407 : ClientPlayer.Class1403.Class1406
			{
				// Token: 0x170014F5 RID: 5365
				// (get) Token: 0x06008888 RID: 34952 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06008889 RID: 34953 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}

				// Token: 0x170014F6 RID: 5366
				// (get) Token: 0x0600888A RID: 34954 RVA: 0x00002050 File Offset: 0x00000250
				internal override TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600888B RID: 34955 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override void vmethod_3()
				{
					throw null;
				}

				// Token: 0x0600888C RID: 34956 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override void Update()
				{
					throw null;
				}
			}

			// Token: 0x020018B8 RID: 6328
			private sealed class Class1408 : ClientPlayer.Class1403.Class1406
			{
				// Token: 0x170014F7 RID: 5367
				// (get) Token: 0x0600888D RID: 34957 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014F8 RID: 5368
				// (get) Token: 0x0600888E RID: 34958 RVA: 0x00002050 File Offset: 0x00000250
				internal override TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600888F RID: 34959 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}

				// Token: 0x06008890 RID: 34960 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_1()
				{
					throw null;
				}

				// Token: 0x06008891 RID: 34961 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private EVoipControllerStatus method_0()
				{
					throw null;
				}
			}

			// Token: 0x020018B9 RID: 6329
			private sealed class Class1414 : ClientPlayer.Class1403.Class1405
			{
				// Token: 0x170014F9 RID: 5369
				// (get) Token: 0x06008892 RID: 34962 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x170014FA RID: 5370
				// (get) Token: 0x06008893 RID: 34963 RVA: 0x00002050 File Offset: 0x00000250
				internal override TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06008894 RID: 34964 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}

				// Token: 0x06008895 RID: 34965 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_1()
				{
					throw null;
				}

				// Token: 0x06008896 RID: 34966 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_2()
				{
					throw null;
				}

				// Token: 0x06008897 RID: 34967 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override void Update()
				{
					throw null;
				}

				// Token: 0x06008898 RID: 34968 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				private void method_0()
				{
					throw null;
				}

				// Token: 0x04008E77 RID: 36471
				private ClientPlayer.Class1403.Struct418 struct418_0;
			}

			// Token: 0x020018BA RID: 6330
			private abstract class Class1409 : ClientPlayer.Class1403.Class1406
			{
				// Token: 0x170014FB RID: 5371
				// (get) Token: 0x06008899 RID: 34969 RVA: 0x00002050 File Offset: 0x00000250
				internal override TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600889A RID: 34970 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override void Update()
				{
					throw null;
				}

				// Token: 0x04008E78 RID: 36472
				protected ClientPlayer.Class1403.Struct418 struct418_0;
			}

			// Token: 0x020018BB RID: 6331
			private sealed class Class1410 : ClientPlayer.Class1403.Class1409
			{
				// Token: 0x170014FC RID: 5372
				// (get) Token: 0x0600889B RID: 34971 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600889C RID: 34972 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}
			}

			// Token: 0x020018BC RID: 6332
			private sealed class Class1411 : ClientPlayer.Class1403.Class1409
			{
				// Token: 0x170014FD RID: 5373
				// (get) Token: 0x0600889D RID: 34973 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600889E RID: 34974 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}
			}

			// Token: 0x020018BD RID: 6333
			private sealed class Class1412 : ClientPlayer.Class1403.Class1409
			{
				// Token: 0x0600889F RID: 34975 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal static ClientPlayer.Class1403.Class1412 smethod_0(ClientPlayer.Class1403 controller)
				{
					throw null;
				}

				// Token: 0x170014FE RID: 5374
				// (get) Token: 0x060088A0 RID: 34976 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x060088A1 RID: 34977 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}

				// Token: 0x170014FF RID: 5375
				// (get) Token: 0x060088A2 RID: 34978 RVA: 0x00002050 File Offset: 0x00000250
				internal bool Boolean_1
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x17001500 RID: 5376
				// (get) Token: 0x060088A3 RID: 34979 RVA: 0x00002050 File Offset: 0x00000250
				internal override TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}
			}

			// Token: 0x020018BE RID: 6334
			private sealed class Class1413 : ClientPlayer.Class1403.Class1409
			{
				// Token: 0x17001501 RID: 5377
				// (get) Token: 0x060088A4 RID: 34980 RVA: 0x00002050 File Offset: 0x00000250
				internal override EVoipControllerStatus EVoipControllerStatus_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x060088A5 RID: 34981 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override EVoipControllerStatus vmethod_0()
				{
					throw null;
				}

				// Token: 0x17001502 RID: 5378
				// (get) Token: 0x060088A6 RID: 34982 RVA: 0x00002050 File Offset: 0x00000250
				internal override TimeSpan TimeSpan_0
				{
					[MethodImpl(MethodImplOptions.NoInlining)]
					get
					{
						throw null;
					}
				}

				// Token: 0x060088A7 RID: 34983 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal override void Update()
				{
					throw null;
				}
			}
		}

		// Token: 0x020018BF RID: 6335
		// (Invoke) Token: 0x060088A8 RID: 34984
		public delegate void GDelegate66(byte channel, in ArraySegment<byte> segment);

		// Token: 0x020018C0 RID: 6336
		[StructLayout(LayoutKind.Auto)]
		public struct Struct420
		{
			// Token: 0x04008E79 RID: 36473
			public string calledOnSceneName;

			// Token: 0x04008E7A RID: 36474
			public int cutseneID;
		}

		// Token: 0x020018C1 RID: 6337
		[CompilerGenerated]
		private sealed class Class1415
		{
			// Token: 0x060088AB RID: 34987 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool succeed)
			{
				throw null;
			}

			// Token: 0x04008E7B RID: 36475
			public Callback callback;
		}

		// Token: 0x020018C2 RID: 6338
		[CompilerGenerated]
		private sealed class Class1416
		{
			// Token: 0x060088AC RID: 34988 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.EmptyHandsController method_0()
			{
				throw null;
			}

			// Token: 0x060088AD RID: 34989 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088AE RID: 34990 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E7C RID: 36476
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E7D RID: 36477
			public bool withNetwork;

			// Token: 0x04008E7E RID: 36478
			public Player.Process<Player.EmptyHandsController, GInterface125> process;

			// Token: 0x04008E7F RID: 36479
			public Action confirmCallback;
		}

		// Token: 0x020018C3 RID: 6339
		[CompilerGenerated]
		private sealed class Class1417
		{
			// Token: 0x060088AF RID: 34991 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.FirearmController method_0()
			{
				throw null;
			}

			// Token: 0x060088B0 RID: 34992 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088B1 RID: 34993 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E80 RID: 36480
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E81 RID: 36481
			public Weapon weapon;

			// Token: 0x04008E82 RID: 36482
			public Player.Process<Player.FirearmController, IFirearmHandsController> process;

			// Token: 0x04008E83 RID: 36483
			public Action confirmCallback;
		}

		// Token: 0x020018C4 RID: 6340
		[CompilerGenerated]
		private sealed class Class1418
		{
			// Token: 0x060088B2 RID: 34994 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.GrenadeController method_0()
			{
				throw null;
			}

			// Token: 0x060088B3 RID: 34995 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088B4 RID: 34996 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E84 RID: 36484
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E85 RID: 36485
			public GrenadeClass throwWeap;

			// Token: 0x04008E86 RID: 36486
			public Player.Process<Player.GrenadeController, IHandsController> process;

			// Token: 0x04008E87 RID: 36487
			public Action confirmCallback;
		}

		// Token: 0x020018C5 RID: 6341
		[CompilerGenerated]
		private sealed class Class1419
		{
			// Token: 0x060088B5 RID: 34997 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.MedsController method_0()
			{
				throw null;
			}

			// Token: 0x060088B6 RID: 34998 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088B7 RID: 34999 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E88 RID: 36488
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E89 RID: 36489
			public MedsClass meds;

			// Token: 0x04008E8A RID: 36490
			public EBodyPart bodyPart;

			// Token: 0x04008E8B RID: 36491
			public int animationVariant;

			// Token: 0x04008E8C RID: 36492
			public Player.Process<Player.MedsController, GInterface130> process;

			// Token: 0x04008E8D RID: 36493
			public Action confirmCallback;
		}

		// Token: 0x020018C6 RID: 6342
		[CompilerGenerated]
		private sealed class Class1420
		{
			// Token: 0x060088B8 RID: 35000 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.MedsController method_0()
			{
				throw null;
			}

			// Token: 0x060088B9 RID: 35001 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088BA RID: 35002 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E8E RID: 36494
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E8F RID: 36495
			public FoodClass foodDrink;

			// Token: 0x04008E90 RID: 36496
			public float amount;

			// Token: 0x04008E91 RID: 36497
			public int animationVariant;

			// Token: 0x04008E92 RID: 36498
			public Player.Process<Player.MedsController, GInterface130> process;

			// Token: 0x04008E93 RID: 36499
			public Action confirmCallback;
		}

		// Token: 0x020018C7 RID: 6343
		[CompilerGenerated]
		private sealed class Class1421
		{
			// Token: 0x060088BB RID: 35003 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.KnifeController method_0()
			{
				throw null;
			}

			// Token: 0x060088BC RID: 35004 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088BD RID: 35005 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E94 RID: 36500
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E95 RID: 36501
			public KnifeComponent knife;

			// Token: 0x04008E96 RID: 36502
			public Player.Process<Player.KnifeController, IKnifeController> process;

			// Token: 0x04008E97 RID: 36503
			public Action confirmCallback;
		}

		// Token: 0x020018C8 RID: 6344
		[CompilerGenerated]
		private sealed class Class1422<T> where T : Player.UsableItemController
		{
			// Token: 0x060088BE RID: 35006 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal T method_0()
			{
				throw null;
			}

			// Token: 0x060088BF RID: 35007 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088C0 RID: 35008 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E98 RID: 36504
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E99 RID: 36505
			public Item item;

			// Token: 0x04008E9A RID: 36506
			public Player.Process<T, GInterface129> process;

			// Token: 0x04008E9B RID: 36507
			public Action confirmCallback;
		}

		// Token: 0x020018C9 RID: 6345
		[CompilerGenerated]
		private sealed class Class1423
		{
			// Token: 0x060088C1 RID: 35009 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.QuickGrenadeThrowController method_0()
			{
				throw null;
			}

			// Token: 0x060088C2 RID: 35010 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088C3 RID: 35011 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008E9C RID: 36508
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008E9D RID: 36509
			public GrenadeClass throwWeap;

			// Token: 0x04008E9E RID: 36510
			public Player.Process<Player.QuickGrenadeThrowController, IGrenadeController> process;

			// Token: 0x04008E9F RID: 36511
			public Action confirmCallback;
		}

		// Token: 0x020018CA RID: 6346
		[CompilerGenerated]
		private sealed class Class1424
		{
			// Token: 0x060088C4 RID: 35012 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.QuickKnifeKickController method_0()
			{
				throw null;
			}

			// Token: 0x060088C5 RID: 35013 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088C6 RID: 35014 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008EA0 RID: 36512
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008EA1 RID: 36513
			public KnifeComponent knife;

			// Token: 0x04008EA2 RID: 36514
			public Player.Process<Player.QuickKnifeKickController, GInterface134> process;

			// Token: 0x04008EA3 RID: 36515
			public Action confirmCallback;
		}

		// Token: 0x020018CB RID: 6347
		[CompilerGenerated]
		private sealed class Class1425
		{
			// Token: 0x060088C7 RID: 35015 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Player.QuickUseItemController method_0()
			{
				throw null;
			}

			// Token: 0x060088C8 RID: 35016 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x060088C9 RID: 35017 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult result)
			{
				throw null;
			}

			// Token: 0x04008EA4 RID: 36516
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008EA5 RID: 36517
			public Item item;

			// Token: 0x04008EA6 RID: 36518
			public Player.Process<Player.QuickUseItemController, GInterface135> process;

			// Token: 0x04008EA7 RID: 36519
			public Action confirmCallback;
		}

		// Token: 0x020018CC RID: 6348
		[CompilerGenerated]
		private sealed class Class1426
		{
			// Token: 0x060088CA RID: 35018 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<int, bool> result)
			{
				throw null;
			}

			// Token: 0x04008EA8 RID: 36520
			public uint id;

			// Token: 0x04008EA9 RID: 36521
			public Action<bool> confirmAction;
		}

		// Token: 0x020018CD RID: 6349
		[CompilerGenerated]
		private sealed class Class1427<T> where T : ClientPlayer
		{
			// Token: 0x060088CB RID: 35019 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(BaseReconnectEvent reconnectEvent)
			{
				throw null;
			}

			// Token: 0x060088CC RID: 35020 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GClass2907 tpEvent)
			{
				throw null;
			}

			// Token: 0x060088CD RID: 35021 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass2891 tpEvent)
			{
				throw null;
			}

			// Token: 0x060088CE RID: 35022 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(SyncClientEventState createPlayerEvent)
			{
				throw null;
			}

			// Token: 0x060088CF RID: 35023 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(WinterReconnectEvent winterReconnectEvent)
			{
				throw null;
			}

			// Token: 0x04008EAA RID: 36522
			public T player;
		}

		// Token: 0x020018CE RID: 6350
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1428<TClientPlayer> where TClientPlayer : ClientPlayer
		{
			// Token: 0x060088D0 RID: 35024 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0()
			{
				throw null;
			}

			// Token: 0x060088D1 RID: 35025 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_1()
			{
				throw null;
			}

			// Token: 0x04008EAB RID: 36523
			public static readonly ClientPlayer.Class1428<TClientPlayer> class1428_0;

			// Token: 0x04008EAC RID: 36524
			public static Func<float> func_0;

			// Token: 0x04008EAD RID: 36525
			public static Func<float> func_1;
		}

		// Token: 0x020018CF RID: 6351
		[CompilerGenerated]
		private sealed class Class1429
		{
			// Token: 0x060088D2 RID: 35026 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008EAE RID: 36526
			public byte[] searchInfoSerializationBytes;

			// Token: 0x04008EAF RID: 36527
			public byte[] profileZip;

			// Token: 0x04008EB0 RID: 36528
			public Profile profile;

			// Token: 0x04008EB1 RID: 36529
			public byte[] inventoryZip;
		}

		// Token: 0x020018D2 RID: 6354
		[CompilerGenerated]
		private sealed class Class1430
		{
			// Token: 0x060088D7 RID: 35031 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008EEC RID: 36588
			public ClientPlayer clientPlayer_0;

			// Token: 0x04008EED RID: 36589
			public LootableContainer container;
		}

		// Token: 0x020018D3 RID: 6355
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1431
		{
			// Token: 0x060088D8 RID: 35032 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GStruct162 method_0(TacticalComboVisualController x)
			{
				throw null;
			}

			// Token: 0x060088D9 RID: 35033 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_1(Slot x)
			{
				throw null;
			}

			// Token: 0x060088DA RID: 35034 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GStruct162 method_2(LightComponent x)
			{
				throw null;
			}

			// Token: 0x04008EEE RID: 36590
			public static readonly ClientPlayer.Class1431 class1431_0;

			// Token: 0x04008EEF RID: 36591
			public static Func<TacticalComboVisualController, GStruct162> func_0;

			// Token: 0x04008EF0 RID: 36592
			public static Func<Slot, Item> func_1;

			// Token: 0x04008EF1 RID: 36593
			public static Func<LightComponent, GStruct162> func_2;
		}
	}
}
