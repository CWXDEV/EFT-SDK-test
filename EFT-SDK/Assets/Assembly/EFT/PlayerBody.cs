using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Diz.Skinning;
using EFT.InventoryLogic;
using EFT.Visual;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001941 RID: 6465
	public class PlayerBody : MonoBehaviour
	{
		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06008AC7 RID: 35527 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008AC8 RID: 35528 RVA: 0x00002050 File Offset: 0x00000250
		public bool HaveHolster
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

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06008AC9 RID: 35529 RVA: 0x00002050 File Offset: 0x00000250
		public Transform MeshTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06008ACA RID: 35530 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008ACB RID: 35531 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasIntergratedArmor
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

		// Token: 0x06008ACC RID: 35532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Init(GClass1752 customization, EquipmentClass equipment, [CanBeNull] BindableState<Item> itemInHands, int layer, EPlayerSide playerSide, string playerProfileID = "")
		{
			throw null;
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Init(GClass1752 customization, int layer, EPlayerSide playerSide)
		{
			throw null;
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GStruct380 watchBundleInfo, Skeleton handsSkeleton)
		{
			throw null;
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePlayerRenders(EPointOfView pointOfView, EPlayerSide side)
		{
			throw null;
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSlotViewChanged()
		{
			throw null;
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsVisible()
		{
			throw null;
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSkin(KeyValuePair<EBodyModelPart, ResourceKey> part, Skeleton skeleton)
		{
			throw null;
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetBodyRenderersNonAlloc(List<GStruct53> preAllocatedRenederersList)
		{
			throw null;
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetRenderersNonAlloc(List<Renderer> preAllocatedRenederersList)
		{
			throw null;
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetSlotBone(EquipmentSlot slotType)
		{
			throw null;
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetAlternativeHolsterBone(EquipmentSlot slotType)
		{
			throw null;
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTemperatureForBody(float tempCelsio)
		{
			throw null;
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerBody.GClass1857 GetSlotViewByItem(Item item)
		{
			throw null;
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSlotViewsDebugString()
		{
			throw null;
		}

		// Token: 0x04009062 RID: 36962
		[SerializeField]
		private Transform _meshTransform;

		// Token: 0x04009063 RID: 36963
		public PlayerBones PlayerBones;

		// Token: 0x04009064 RID: 36964
		public Skeleton SkeletonRootJoint;

		// Token: 0x04009065 RID: 36965
		public Skeleton SkeletonHands;

		// Token: 0x04009066 RID: 36966
		public GClass1752 BodyCustomization;

		// Token: 0x04009068 RID: 36968
		private int _layer;

		// Token: 0x04009069 RID: 36969
		private EPlayerSide _side;

		// Token: 0x0400906A RID: 36970
		private bool _active;

		// Token: 0x0400906B RID: 36971
		public readonly Dictionary<EBodyModelPart, LoddedSkin> BodySkins;

		// Token: 0x0400906C RID: 36972
		private PluggableBone _watches;

		// Token: 0x0400906D RID: 36973
		private GStruct53[] _bodyRenderers;

		// Token: 0x0400906E RID: 36974
		public bool IsRightLegPistolHolster;

		// Token: 0x0400906F RID: 36975
		private static readonly EquipmentSlot[] SlotNames;

		// Token: 0x04009070 RID: 36976
		public readonly GClass720<EquipmentSlot, PlayerBody.GClass1857> SlotViews;

		// Token: 0x04009072 RID: 36978
		private BindableState<Item> _itemInHands;

		// Token: 0x04009073 RID: 36979
		public BindableState<string> BodyCustomizationId;

		// Token: 0x04009074 RID: 36980
		public BindableState<EPlayerSide> PlayerSide;

		// Token: 0x04009075 RID: 36981
		public BindableState<EPointOfView> PointOfView;

		// Token: 0x04009076 RID: 36982
		private string _playerProfileID;

		// Token: 0x02001942 RID: 6466
		public class GClass1857
		{
			// Token: 0x17001530 RID: 5424
			// (get) Token: 0x06008ADD RID: 35549 RVA: 0x00002050 File Offset: 0x00000250
			public GameObject Model
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001531 RID: 5425
			// (get) Token: 0x06008ADE RID: 35550 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06008ADF RID: 35551 RVA: 0x00002050 File Offset: 0x00000250
			public EquipmentSlot EquipmentSlot
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

			// Token: 0x17001532 RID: 5426
			// (get) Token: 0x06008AE0 RID: 35552 RVA: 0x00002050 File Offset: 0x00000250
			public BindableState<Item> ContainedItem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17001533 RID: 5427
			// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x00002050 File Offset: 0x00000250
			public Renderer[] Renderers
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06008AE2 RID: 35554 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06008AE3 RID: 35555 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x06008AE4 RID: 35556 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_1(Item item)
			{
				throw null;
			}

			// Token: 0x06008AE5 RID: 35557 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2()
			{
				throw null;
			}

			// Token: 0x06008AE6 RID: 35558 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3()
			{
				throw null;
			}

			// Token: 0x06008AE7 RID: 35559 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void DestroyCurrentModel()
			{
				throw null;
			}

			// Token: 0x06008AE8 RID: 35560 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ChangePositionAfterBackpackChanged()
			{
				throw null;
			}

			// Token: 0x06008AE9 RID: 35561 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_4(PlayerBody playerBody, GameObject model)
			{
				throw null;
			}

			// Token: 0x04009077 RID: 36983
			private readonly Slot slot_0;

			// Token: 0x04009078 RID: 36984
			private readonly PlayerBody playerBody_0;

			// Token: 0x04009079 RID: 36985
			[CanBeNull]
			private readonly Transform transform_0;

			// Token: 0x0400907A RID: 36986
			[CanBeNull]
			private readonly Slot slot_1;

			// Token: 0x0400907B RID: 36987
			[CanBeNull]
			private readonly Transform transform_1;

			// Token: 0x0400907C RID: 36988
			public Task LoadingJob;

			// Token: 0x0400907D RID: 36989
			public Dress[] Dresses;

			// Token: 0x0400907E RID: 36990
			public readonly BindableState<Dress> MainDress;

			// Token: 0x0400907F RID: 36991
			public readonly BindableState<GameObject> ParentedModel;

			// Token: 0x04009080 RID: 36992
			private Item item_0;

			// Token: 0x04009081 RID: 36993
			private GameObject gameObject_0;

			// Token: 0x04009082 RID: 36994
			private CancellationTokenSource cancellationTokenSource_0;

			// Token: 0x04009083 RID: 36995
			private Action action_0;

			// Token: 0x04009084 RID: 36996
			private Action action_1;

			// Token: 0x04009085 RID: 36997
			private Action action_2;

			// Token: 0x04009086 RID: 36998
			private Renderer[] renderer_0;

			// Token: 0x04009087 RID: 36999
			[CompilerGenerated]
			private EquipmentSlot equipmentSlot_0;

			// Token: 0x02001943 RID: 6467
			[CompilerGenerated]
			private sealed class Class1503
			{
				// Token: 0x06008AEA RID: 35562 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Item item)
				{
					throw null;
				}

				// Token: 0x06008AEB RID: 35563 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1(Item child)
				{
					throw null;
				}

				// Token: 0x06008AEC RID: 35564 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_2(Item item)
				{
					throw null;
				}

				// Token: 0x04009088 RID: 37000
				public PlayerBody.GClass1857 gclass1857_0;

				// Token: 0x04009089 RID: 37001
				public EquipmentSlot equipmentSlot;

				// Token: 0x0400908A RID: 37002
				public Action<Item> action_0;
			}

			// Token: 0x02001944 RID: 6468
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1504
			{
				// Token: 0x06008AED RID: 35565 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Item method_0(Item item, Item itemInHands)
				{
					throw null;
				}

				// Token: 0x0400908B RID: 37003
				public static readonly PlayerBody.GClass1857.Class1504 class1504_0;

				// Token: 0x0400908C RID: 37004
				public static Func<Item, Item, Item> func_0;
			}

			// Token: 0x02001945 RID: 6469
			[CompilerGenerated]
			private sealed class Class1505
			{
				// Token: 0x06008AEE RID: 35566 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0400908D RID: 37005
				public GameObject result;
			}
		}

		// Token: 0x02001947 RID: 6471
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1506
		{
			// Token: 0x06008AF1 RID: 35569 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Renderer> method_0(LoddedSkin x)
			{
				throw null;
			}

			// Token: 0x06008AF2 RID: 35570 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(PlayerBody.GClass1857 x)
			{
				throw null;
			}

			// Token: 0x06008AF3 RID: 35571 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_2(PlayerBody.GClass1857 x)
			{
				throw null;
			}

			// Token: 0x06008AF4 RID: 35572 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Renderer> method_3(LoddedSkin x)
			{
				throw null;
			}

			// Token: 0x06008AF5 RID: 35573 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(PlayerBody.GClass1857 x)
			{
				throw null;
			}

			// Token: 0x06008AF6 RID: 35574 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_5(PlayerBody.GClass1857 x)
			{
				throw null;
			}

			// Token: 0x04009095 RID: 37013
			public static readonly PlayerBody.Class1506 class1506_0;

			// Token: 0x04009096 RID: 37014
			public static Func<LoddedSkin, IEnumerable<Renderer>> func_0;

			// Token: 0x04009097 RID: 37015
			public static Func<PlayerBody.GClass1857, bool> func_1;

			// Token: 0x04009098 RID: 37016
			public static Func<PlayerBody.GClass1857, Task> func_2;

			// Token: 0x04009099 RID: 37017
			public static Func<LoddedSkin, IEnumerable<Renderer>> func_3;

			// Token: 0x0400909A RID: 37018
			public static Func<PlayerBody.GClass1857, bool> func_4;

			// Token: 0x0400909B RID: 37019
			public static Func<PlayerBody.GClass1857, Task> func_5;
		}
	}
}
