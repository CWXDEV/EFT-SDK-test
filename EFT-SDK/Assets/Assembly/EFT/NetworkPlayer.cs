using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using Diz.LanguageExtensions;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001526 RID: 5414
	public abstract class NetworkPlayer : Player
	{
		// Token: 0x06007428 RID: 29736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T smethod_2<T>(ResourceKey assetName, int playerId, Vector3 position, string prefix, GInterface101 frameIndexer, EUpdateQueue updateQueue, Player.EUpdateMode armsUpdateMode, Player.EUpdateMode bodyUpdateMode, CharacterControllerSpawner.Mode characterControllerMode, Func<float> getSensitivity, Func<float> getAimingSensitivity, bool isThirdPerson) where T : NetworkPlayer
		{
			throw null;
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06007429 RID: 29737 RVA: 0x00002050 File Offset: 0x00000250
		protected GClass2413 NetworkHealthController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600742A RID: 29738 RVA: 0x00002050 File Offset: 0x00000250
		public override byte ChannelIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600742B RID: 29739 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600742C RID: 29740 RVA: 0x00002050 File Offset: 0x00000250
		public override bool IsVisible
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

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600742E RID: 29742 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0600742F RID: 29743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserializeFromServer(byte channelId, GInterface76 reader)
		{
			throw null;
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007431 RID: 29745 RVA: 0x00002050 File Offset: 0x00000250
		private GInterface101 FrameIndexer
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

		// Token: 0x06007432 RID: 29746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessCommonPacket(GClass1762 commonPacket)
		{
			throw null;
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ApplyTeleportPacket(GStruct336 packet)
		{
			throw null;
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessStartSearchingAction(string itemId)
		{
			throw null;
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_128(string itemId)
		{
			throw null;
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_129(string itemId, SearchedState state)
		{
			throw null;
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_130(string itemId, GStruct366 gridId, bool silent)
		{
			throw null;
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct415<bool> method_131(string itemId, GStruct366 gridId, bool silent)
		{
			throw null;
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessStopSearching(string itemId)
		{
			throw null;
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessInteractWithBtr(PlayerInteractPacket interactionBtrPacket)
		{
			throw null;
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessNetworkDeath(string aggressorName, string aggressorMainCharacterName, EPlayerSide aggressorSide, EBodyPartColliderType colliderType, string weaponName, EMemberCategory memberCategory)
		{
			throw null;
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessPoisonResourceChange(string id, float value)
		{
			throw null;
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessArmorPointsChange(string id, float value)
		{
			throw null;
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SearchOperationsOnItemRemoved(GClass2865 obj)
		{
			throw null;
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessChangeSkillExperience(GStruct207? packet, bool silent)
		{
			throw null;
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ProcessChangeMasteringExperience(GStruct208? packet, bool silent)
		{
			throw null;
		}

		// Token: 0x04007A65 RID: 31333
		protected readonly Dictionary<uint, Tuple<GClass2833, Action>> CurrentOperations;

		// Token: 0x04007A66 RID: 31334
		protected readonly Dictionary<uint, Callback<int, bool, EOperationStatus>> OperationCallbacks;

		// Token: 0x04007A67 RID: 31335
		protected ushort LastStationaryWeaponOperationId;

		// Token: 0x04007A68 RID: 31336
		[CompilerGenerated]
		private readonly byte byte_0;

		// Token: 0x04007A69 RID: 31337
		public static readonly EPhraseTrigger[] LocalPhrases;

		// Token: 0x04007A6A RID: 31338
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04007A6B RID: 31339
		[CompilerGenerated]
		private GInterface101 ginterface101_0;

		// Token: 0x04007A6C RID: 31340
		private GClass619 gclass619_0;

		// Token: 0x02001527 RID: 5415
		[Flags]
		public enum EMovementCommand : byte
		{
			// Token: 0x04007A6E RID: 31342
			MoveStart = 1,
			// Token: 0x04007A6F RID: 31343
			MoveEnd = 2,
			// Token: 0x04007A70 RID: 31344
			SprintStart = 4,
			// Token: 0x04007A71 RID: 31345
			SprintEnd = 8,
			// Token: 0x04007A72 RID: 31346
			StartProne = 16,
			// Token: 0x04007A73 RID: 31347
			StopProne = 32,
			// Token: 0x04007A74 RID: 31348
			JumpStart = 64,
			// Token: 0x04007A75 RID: 31349
			JumpEnd = 128
		}

		// Token: 0x02001528 RID: 5416
		public class GClass3282 : Error
		{
			// Token: 0x06007442 RID: 29762 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04007A76 RID: 31350
			public readonly GStruct366 ContainerId;
		}

		// Token: 0x02001529 RID: 5417
		[Serializable]
		public struct ClientShot
		{
			// Token: 0x06007443 RID: 29763 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04007A77 RID: 31351
			public bool Approved;

			// Token: 0x04007A78 RID: 31352
			public int BodyPart;

			// Token: 0x04007A79 RID: 31353
			public float Damage;

			// Token: 0x04007A7A RID: 31354
			public float LeftBodyPartHealth;

			// Token: 0x04007A7B RID: 31355
			public string TargetName;
		}

		// Token: 0x0200152A RID: 5418
		[CompilerGenerated]
		private sealed class Class1124
		{
			// Token: 0x06007444 RID: 29764 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x06007445 RID: 29765 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Item item)
			{
				throw null;
			}

			// Token: 0x04007A7C RID: 31356
			public string id;
		}

		// Token: 0x0200152B RID: 5419
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1125
		{
			// Token: 0x06007446 RID: 29766 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(Slot slot)
			{
				throw null;
			}

			// Token: 0x04007A7D RID: 31357
			public static readonly NetworkPlayer.Class1125 class1125_0;

			// Token: 0x04007A7E RID: 31358
			public static Func<Slot, Item> func_0;
		}
	}
}
