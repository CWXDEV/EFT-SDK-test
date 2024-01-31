using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Microsoft.Extensions.ObjectPool;
using UnityEngine;

namespace EFT.AssetsManager
{
	// Token: 0x02002868 RID: 10344
	[DisallowMultipleComponent]
	public class AssetPoolObject : MonoBehaviour
	{
		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x0600CE8E RID: 52878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CE8F RID: 52879 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsStub
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

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x0600CE90 RID: 52880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CE91 RID: 52881 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsInPool
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

		// Token: 0x0600CE92 RID: 52882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReturnToPool(GameObject gameObject, bool immediate = true)
		{
			throw null;
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ReturnToPool(AssetPoolObject assetPoolObject, bool immediate = true)
		{
			throw null;
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(GameObject gameObject, AssetPoolObject parentAssetPoolObject, bool immediate)
		{
			throw null;
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(AssetPoolObject assetPoolObject)
		{
			throw null;
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2(GameObject gameObject, bool immediate)
		{
			throw null;
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x0600CE97 RID: 52887 RVA: 0x00002050 File Offset: 0x00000250
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StoreCollider(Collider coll)
		{
			throw null;
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnGetFromPool()
		{
			throw null;
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ReturnToPool()
		{
			throw null;
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterComponent(GInterface358 component)
		{
			throw null;
		}

		// Token: 0x0600CE9D RID: 52893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnregisterComponent(GInterface358 component)
		{
			throw null;
		}

		// Token: 0x0600CE9E RID: 52894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(GStruct105 resourceType, bool isStub = false)
		{
			throw null;
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCreatePoolRoleModel()
		{
			throw null;
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InheritRoleModelData<TAssetPoolObject>(TAssetPoolObject roleModel) where TAssetPoolObject : AssetPoolObject
		{
			throw null;
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCreatePoolObject<TAssetPoolObject>([CanBeNull] GClass3001<TAssetPoolObject> assetsPoolParent) where TAssetPoolObject : AssetPoolObject
		{
			throw null;
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy<TAssetPoolObject>(GClass3001<TAssetPoolObject> ownerAssetsPool) where TAssetPoolObject : AssetPoolObject
		{
			throw null;
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Collider> GetColliders(bool includeNestedAssetPoolObjects)
		{
			throw null;
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisposeContainerCollectionView()
		{
			throw null;
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CollectOriginallyEnabledComponents()
		{
			throw null;
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOriginalComponentsEnabled(bool enabled)
		{
			throw null;
		}

		// Token: 0x0400CF49 RID: 53065
		private static readonly ObjectPool<List<AssetPoolObject>> objectPool_0;

		// Token: 0x0400CF4A RID: 53066
		public List<string> PoolHistory;

		// Token: 0x0400CF4B RID: 53067
		public List<Collider> Colliders;

		// Token: 0x0400CF4C RID: 53068
		public List<GInterface358> Components;

		// Token: 0x0400CF4D RID: 53069
		public List<Renderer> Renderers;

		// Token: 0x0400CF4E RID: 53070
		[SerializeField]
		private List<Component> _originallyEnabledComponents;

		// Token: 0x0400CF4F RID: 53071
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400CF50 RID: 53072
		[CanBeNull]
		public GClass671 ContainerCollectionView;

		// Token: 0x0400CF51 RID: 53073
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400CF52 RID: 53074
		protected GStruct105 ResourceType;

		// Token: 0x0400CF53 RID: 53075
		private GInterface357 ginterface357_0;

		// Token: 0x0400CF54 RID: 53076
		private bool bool_2;

		// Token: 0x0400CF55 RID: 53077
		public List<Component> RegisteredComponentsToClean;

		// Token: 0x0400CF56 RID: 53078
		public List<AssetPoolObject.GClass3000> RegisteredCollidersToDisable;

		// Token: 0x02002869 RID: 10345
		private sealed class Class2347 : PooledObjectPolicy<List<AssetPoolObject>>
		{
			// Token: 0x0600CEA8 RID: 52904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override List<AssetPoolObject> Create()
			{
				throw null;
			}

			// Token: 0x0600CEA9 RID: 52905 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool Return(List<AssetPoolObject> obj)
			{
				throw null;
			}
		}

		// Token: 0x0200286A RID: 10346
		public class GClass3000
		{
			// Token: 0x0600CEAA RID: 52906 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0400CF57 RID: 53079
			public Collider Collider;

			// Token: 0x0400CF58 RID: 53080
			public int Layer;

			// Token: 0x0400CF59 RID: 53081
			public bool WasEnabled;
		}
	}
}
