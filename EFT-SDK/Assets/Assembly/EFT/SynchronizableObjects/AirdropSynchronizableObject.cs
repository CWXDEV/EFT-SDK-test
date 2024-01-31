using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Airdrop;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT.SynchronizableObjects
{
	// Token: 0x02001E39 RID: 7737
	public class AirdropSynchronizableObject : SynchronizableObject
	{
		// Token: 0x06009EB7 RID: 40631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Serialize(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Deserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Item method_0(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x0400A742 RID: 42818
		private const int int_0 = 65536;

		// Token: 0x0400A743 RID: 42819
		public EAirdropType AirdropType;

		// Token: 0x0400A744 RID: 42820
		public TaggedClip SqueakClip;

		// Token: 0x0400A745 RID: 42821
		public GameObject AirdropFlare;

		// Token: 0x0400A746 RID: 42822
		public GameObject AirdropDust;

		// Token: 0x0400A747 RID: 42823
		public GameObject Parachute;

		// Token: 0x0400A748 RID: 42824
		public GameObject ParachuteJoint;

		// Token: 0x0400A749 RID: 42825
		public BoxCollider CollisionCollider;

		// Token: 0x0400A74A RID: 42826
		public MeshRenderer[] DecalRenderers;

		// Token: 0x0400A74B RID: 42827
		public Material GunDecal;

		// Token: 0x0400A74C RID: 42828
		public Material MedicineDecal;

		// Token: 0x0400A74D RID: 42829
		public Material SupplyDecal;

		// Token: 0x02001E3A RID: 7738
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1803
		{
			// Token: 0x06009EBA RID: 40634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x06009EBB RID: 40635 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_1(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x06009EBC RID: 40636 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Item x)
			{
				throw null;
			}

			// Token: 0x06009EBD RID: 40637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<ResourceKey> method_3(Item x)
			{
				throw null;
			}

			// Token: 0x0400A74E RID: 42830
			public static readonly AirdropSynchronizableObject.Class1803 class1803_0;

			// Token: 0x0400A74F RID: 42831
			public static Func<LootItemPositionClass, Item> func_0;

			// Token: 0x0400A750 RID: 42832
			public static Func<LootItemPositionClass, Item> func_1;

			// Token: 0x0400A751 RID: 42833
			public static Func<Item, bool> func_2;

			// Token: 0x0400A752 RID: 42834
			public static Func<Item, IEnumerable<ResourceKey>> func_3;
		}
	}
}
