using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.Hideout;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02001B87 RID: 7047
public sealed class GClass1928
{
	// Token: 0x170016B0 RID: 5808
	// (get) Token: 0x0600943E RID: 37950 RVA: 0x00002050 File Offset: 0x00000250
	private EAreaType EAreaType_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600943F RID: 37951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(HideoutArea hideoutArea, InventoryControllerClass inventoryController, float gridStep)
	{
		throw null;
	}

	// Token: 0x06009440 RID: 37952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06009441 RID: 37953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(EAreaType areaType)
	{
		throw null;
	}

	// Token: 0x06009442 RID: 37954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task UpdateStash(bool clearCache = false)
	{
		throw null;
	}

	// Token: 0x06009443 RID: 37955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GEventArgs2 addInfo)
	{
		throw null;
	}

	// Token: 0x06009444 RID: 37956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GEventArgs3 removeInfo)
	{
		throw null;
	}

	// Token: 0x06009445 RID: 37957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<GClass1928.ItemModel> method_4(Item item)
	{
		throw null;
	}

	// Token: 0x06009446 RID: 37958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(GClass1928.ItemModel model)
	{
		throw null;
	}

	// Token: 0x06009447 RID: 37959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GClass1928.ItemModel model, LocationInGrid locationInGrid, Transform spawnPoint)
	{
		throw null;
	}

	// Token: 0x06009448 RID: 37960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(GameObject itemGameObject)
	{
		throw null;
	}

	// Token: 0x06009449 RID: 37961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_8(IContainer container)
	{
		throw null;
	}

	// Token: 0x0600944A RID: 37962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private LocationInGrid method_9(Item item)
	{
		throw null;
	}

	// Token: 0x0600944B RID: 37963 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10(Item parent)
	{
		throw null;
	}

	// Token: 0x04009B15 RID: 39701
	private InventoryControllerClass gclass2757_0;

	// Token: 0x04009B16 RID: 39702
	private HideoutArea hideoutArea_0;

	// Token: 0x04009B17 RID: 39703
	private LootItemClass gclass2625_0;

	// Token: 0x04009B18 RID: 39704
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04009B19 RID: 39705
	private CancellationTokenSource cancellationTokenSource_1;

	// Token: 0x04009B1A RID: 39706
	private readonly Dictionary<Item, GClass1928.ItemModel> dictionary_0;

	// Token: 0x04009B1B RID: 39707
	private readonly Dictionary<Item, GClass1928.ItemModel> dictionary_1;

	// Token: 0x04009B1C RID: 39708
	private readonly Dictionary<int, GClass1928.ItemModel> dictionary_2;

	// Token: 0x04009B1D RID: 39709
	private float float_0;

	// Token: 0x02001B88 RID: 7048
	private class ItemModel : MonoBehaviour
	{
		// Token: 0x0600944C RID: 37964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GameObject prefab)
		{
			throw null;
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GameObject prefab)
		{
			throw null;
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Quaternion vmethod_0(GameObject prefab)
		{
			throw null;
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Vector3 vmethod_1(Vector3 localBoundsMin, Vector3 size)
		{
			throw null;
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Vector3 vmethod_2(Vector3 size)
		{
			throw null;
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetRotation(ItemRotation rotation)
		{
			throw null;
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Transform root, int layer)
		{
			throw null;
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04009B1E RID: 39710
		protected GameObject gameObject_0;

		// Token: 0x04009B1F RID: 39711
		protected Transform transform_0;

		// Token: 0x04009B20 RID: 39712
		private LODGroup lodgroup_0;
	}

	// Token: 0x02001B89 RID: 7049
	private sealed class WeaponItemModel : GClass1928.ItemModel
	{
		// Token: 0x06009454 RID: 37972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector3 vmethod_1(Vector3 localBoundsMin, Vector3 size)
		{
			throw null;
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Quaternion vmethod_0(GameObject prefab)
		{
			throw null;
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Vector3 vmethod_2(Vector3 size)
		{
			throw null;
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetRotation(ItemRotation rotation)
		{
			throw null;
		}
	}

	// Token: 0x02001B8A RID: 7050
	[CompilerGenerated]
	private sealed class Class1667
	{
		// Token: 0x06009458 RID: 37976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04009B21 RID: 39713
		public CancellationTokenSource updateCancellationToken;
	}

	// Token: 0x02001B8C RID: 7052
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1668
	{
		// Token: 0x0600945B RID: 37979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04009B2E RID: 39726
		public static readonly GClass1928.Class1668 class1668_0;

		// Token: 0x04009B2F RID: 39727
		public static Action action_0;
	}
}
