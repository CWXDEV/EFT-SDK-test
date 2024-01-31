using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.AssetsManager;
using EFT.InventoryLogic;
using EFT.MovingPlatforms;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002755 RID: 10069
	public class Corpse : LootItem
	{
		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x0600C97E RID: 51582 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C97F RID: 51583 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1752 Customization
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

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600C980 RID: 51584 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C981 RID: 51585 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerSide Side
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

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600C982 RID: 51586 RVA: 0x00002050 File Offset: 0x00000250
		public GStruct104[] TransformSyncs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x0600C983 RID: 51587 RVA: 0x00002050 File Offset: 0x00000250
		public GStruct104[] TransformSyncsRelativeToPlatform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x0600C984 RID: 51588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C985 RID: 51589 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasRagdoll
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

		// Token: 0x0600C986 RID: 51590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateCorpse<T>(GameObject gameObject, string playerProfileID, EquipmentClass equipment, GClass1752 customization, bool reinitBody, GameWorld gameWorld, EPlayerSide side, Vector3 velocity, Transform pelvis, BindableState<Item> itemInHands, bool foreStillCorpse, GClass671 containerCollectionView, MongoID firstID = default(MongoID)) where T : Corpse
		{
			throw null;
		}

		// Token: 0x0600C987 RID: 51591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateStillCorpse<T>(GameWorld gameWorld, GClass1197 corpseJson, MovingPlatform platform) where T : Corpse
		{
			throw null;
		}

		// Token: 0x0600C988 RID: 51592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C989 RID: 51593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(bool forceStill = false)
		{
			throw null;
		}

		// Token: 0x0600C98A RID: 51594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(string playerProfileID, EquipmentClass equipment, GClass1752 customization, bool reinitBody, GameWorld gameWorld, EPlayerSide side, Vector3 velocity, Transform pelvis, bool ragdollEnabled, BindableState<Item> itemInHands, bool foreStillCorpse, GClass671 containerCollectionView = null, MongoID firstId = default(MongoID))
		{
			throw null;
		}

		// Token: 0x0600C98B RID: 51595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Kill()
		{
			throw null;
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600C98C RID: 51596 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual CollisionDetectionMode CollisionDetectionMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItemInHandsLootedCallback(Action itemInHandsLooted)
		{
			throw null;
		}

		// Token: 0x0600C98E RID: 51598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void RemoveLootItem(GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600C98F RID: 51599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x0600C990 RID: 51600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool CheckCorpseIsStill(bool sleeping, float timePass)
		{
			throw null;
		}

		// Token: 0x0600C991 RID: 51601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CacheComponents()
		{
			throw null;
		}

		// Token: 0x0600C992 RID: 51602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct104[] method_18()
		{
			throw null;
		}

		// Token: 0x0600C993 RID: 51603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ApplyTransformSync(GStruct104[] transformSyncs)
		{
			throw null;
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600C994 RID: 51604 RVA: 0x00002050 File Offset: 0x00000250
		public override Transform TrackableTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400C98C RID: 51596
		public const float MAX_TIME = 15f;

		// Token: 0x0400C98D RID: 51597
		private RigidbodySpawner[] rigidbodySpawner_0;

		// Token: 0x0400C98E RID: 51598
		private CharacterJointSpawner[] characterJointSpawner_0;

		// Token: 0x0400C98F RID: 51599
		private List<PlayerRigidbodySleepHierarchy> list_0;

		// Token: 0x0400C990 RID: 51600
		protected Action _itemInHandsLooted;

		// Token: 0x0400C991 RID: 51601
		[CompilerGenerated]
		private GClass1752 gclass1752_0;

		// Token: 0x0400C992 RID: 51602
		[CompilerGenerated]
		private EPlayerSide eplayerSide_0;

		// Token: 0x0400C993 RID: 51603
		private GStruct104[] gstruct104_0;

		// Token: 0x0400C994 RID: 51604
		protected Transform _pelvis;

		// Token: 0x0400C995 RID: 51605
		private Vector3 vector3_1;

		// Token: 0x0400C996 RID: 51606
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400C997 RID: 51607
		protected PlayerBody PlayerBody;

		// Token: 0x0400C998 RID: 51608
		public BindableState<Item> ItemInHands;

		// Token: 0x0400C999 RID: 51609
		public RagdollClass Ragdoll;

		// Token: 0x0400C99A RID: 51610
		public string PlayerProfileID;
	}
}
