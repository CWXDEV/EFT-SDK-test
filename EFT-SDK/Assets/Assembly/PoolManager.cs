using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.AssetsManager;
using EFT.CameraControl;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using NLog;
using UnityEngine;

// Token: 0x02001677 RID: 5751
public sealed class PoolManager
{
	// Token: 0x170013A4 RID: 5028
	// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x00002050 File Offset: 0x00000250
	private int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170013A5 RID: 5029
	// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x00002050 File Offset: 0x00000250
	public static CancellationToken DefaultCancellationToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170013A6 RID: 5030
	// (get) Token: 0x06007CB4 RID: 31924 RVA: 0x00002050 File Offset: 0x00000250
	public CancellationToken PoolsCancellationToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007CB5 RID: 31925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterPools(PoolManager.PoolsCategory poolsCategory, Transform parentTransform, GClass1797 config, PoolManager.AssemblyType defaultAssemblyType = PoolManager.AssemblyType.Nevermind)
	{
		throw null;
	}

	// Token: 0x06007CB6 RID: 31926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetPoolDontDestroy(ResourceType type)
	{
		throw null;
	}

	// Token: 0x06007CB7 RID: 31927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPoolReady(PoolManager.PoolsCategory category)
	{
		throw null;
	}

	// Token: 0x06007CB8 RID: 31928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private PoolManager.Class1184 method_0(PoolManager.PoolsCategory category)
	{
		throw null;
	}

	// Token: 0x06007CB9 RID: 31929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1(PoolManager.Class1184 pools, List<PoolManager.GStruct228> resources, PoolManager.AssemblyType assemblyType, GDelegate77 yield, IProgress<GStruct117> progress = null, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x06007CBA RID: 31930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task LoadBundlesAndCreatePools(PoolManager.PoolsCategory poolsCategory, PoolManager.AssemblyType assemblyType, ResourceKey[] resources, GDelegate77 yield, IProgress<GStruct117> progress = null, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x06007CBB RID: 31931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RegisterLoadBundlesAndCreatePools(PoolManager.PoolsCategory poolsCategory, Transform parentTransform, GClass1797 config, PoolManager.AssemblyType assemblyType, ResourceKey[] resources, GDelegate77 yield, IProgress<GStruct117> progress = null, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x06007CBC RID: 31932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadBundles()
	{
		throw null;
	}

	// Token: 0x06007CBD RID: 31933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadTemporaryPools(bool cleanUselessPools)
	{
		throw null;
	}

	// Token: 0x06007CBE RID: 31934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPools(PoolManager.PoolsCategory poolsCategory, bool quick)
	{
		throw null;
	}

	// Token: 0x06007CBF RID: 31935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreatePlayerObject(ResourceKey assetName)
	{
		throw null;
	}

	// Token: 0x06007CC0 RID: 31936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected GameObject method_2(ResourceKey resourceKey, PoolManager.PoolsCategory poolCategory)
	{
		throw null;
	}

	// Token: 0x06007CC1 RID: 31937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GameObject smethod_0(IEasyAssets easyAssets, ResourceKey resourceKey, GStruct105 resourceType)
	{
		throw null;
	}

	// Token: 0x06007CC2 RID: 31938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupGameObjectWithoutPool(GStruct105 resourceType, GameObject gameObject)
	{
		throw null;
	}

	// Token: 0x06007CC3 RID: 31939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GameObject smethod_1(IEasyAssets easyAssets, GClass1203 itemTemplates, ResourceKey resourceKey)
	{
		throw null;
	}

	// Token: 0x06007CC4 RID: 31940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_3(ContainerCollection containerCollection, GClass671 collectionView, ECameraType cameraType, IPlayer player, bool isAnimated, CancellationToken ct, GDelegate77 yield)
	{
		throw null;
	}

	// Token: 0x06007CC5 RID: 31941 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T CreateFromPool<T>(ResourceKey resourceKey)
	{
		throw null;
	}

	// Token: 0x06007CC6 RID: 31942 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreateItem(Item item, bool isAnimated)
	{
		throw null;
	}

	// Token: 0x06007CC7 RID: 31943 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreateItem(Item item, ECameraType cameraType, [CanBeNull] IPlayer player, bool isAnimated)
	{
		throw null;
	}

	// Token: 0x06007CC8 RID: 31944 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreateItemUsablePrefab(Item item, IPlayer player)
	{
		throw null;
	}

	// Token: 0x06007CC9 RID: 31945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GameObject> CreateItemUsablePrefabAsync(Item item, IPlayer player)
	{
		throw null;
	}

	// Token: 0x06007CCA RID: 31946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GameObject> CreateItemAsync(Item item, ECameraType cameraType, [CanBeNull] IPlayer player, bool isAnimated, GDelegate77 yield, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_4(ContainerCollection collection, bool isHandsItem, ECameraType cameraType, IPlayer player, bool isAnimated, GameObject itemGameObject, AssetPoolObject poolObject, Transform weaponHierarchy, CancellationToken ct, GDelegate77 yield)
	{
		throw null;
	}

	// Token: 0x06007CCC RID: 31948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreateCleanLootPrefab(Item item, ECameraType cameraType, [CanBeNull] IPlayer player = null)
	{
		throw null;
	}

	// Token: 0x06007CCD RID: 31949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GameObject> CreateCleanLootPrefabAsync(Item item, [CanBeNull] IPlayer player = null)
	{
		throw null;
	}

	// Token: 0x06007CCE RID: 31950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GameObject CreateLootPrefab(Item item, ECameraType cameraType, [CanBeNull] IPlayer player = null)
	{
		throw null;
	}

	// Token: 0x06007CCF RID: 31951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Collider collider, AssetPoolObject asset)
	{
		throw null;
	}

	// Token: 0x06007CD0 RID: 31952 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_2(List<PoolManager.GStruct228> bundlesList, Dictionary<ResourceKey, List<DependencyGraph<IEasyBundle>.GClass3388>> loadedBundles, DependencyGraph<IEasyBundle>.GClass3387 container)
	{
		throw null;
	}

	// Token: 0x04008328 RID: 33576
	public static readonly PoolManager.GClass627 Logger;

	// Token: 0x04008329 RID: 33577
	private Dictionary<ResourceType, bool> dictionary_0;

	// Token: 0x0400832A RID: 33578
	public bool IgnorePools;

	// Token: 0x0400832B RID: 33579
	public readonly IEasyAssets EasyAssets;

	// Token: 0x0400832C RID: 33580
	private readonly GClass1203 gclass1203_0;

	// Token: 0x0400832D RID: 33581
	private readonly GInterface185 ginterface185_0;

	// Token: 0x0400832E RID: 33582
	private readonly Dictionary<PoolManager.PoolsCategory, PoolManager.Class1184> dictionary_1;

	// Token: 0x0400832F RID: 33583
	private readonly Dictionary<PoolManager.PoolsCategory, CancellationToken> dictionary_2;

	// Token: 0x04008330 RID: 33584
	private static CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04008331 RID: 33585
	private Dictionary<ResourceKey, List<DependencyGraph<IEasyBundle>.GClass3388>> dictionary_3;

	// Token: 0x04008332 RID: 33586
	private Dictionary<ResourceKey, string> dictionary_4;

	// Token: 0x02001678 RID: 5752
	private class Class1184 : IDisposable
	{
		// Token: 0x06007CD1 RID: 31953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToken(ResourceKey key, DependencyGraph<IEasyBundle>.GClass3388 token)
		{
			throw null;
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task InitAndFillPools(IList<PoolManager.GStruct228> resourceInfo, PoolManager.AssemblyType assemblyType, GDelegate77 yield, IProgress<int> progress = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(PoolManager.GStruct228 resourceKey, PoolManager.AssemblyType assemblyType, GDelegate77 yield)
		{
			throw null;
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PoolManager.GStruct228> ConvertResourceInfo(ResourceKey[] resources)
		{
			throw null;
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PoolManager.GStruct228 method_1(ResourceKey resource)
		{
			throw null;
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameObject PopOrCreate(ResourceKey resourceKey, bool canInitializeAssetPool = false)
		{
			throw null;
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GInterface357 assetPool)
		{
			throw null;
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnloadUselessPools(int currentRaidNumber, int diff)
		{
			throw null;
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnloadPools()
		{
			throw null;
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GInterface357 pool, bool quickDispose)
		{
			throw null;
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ResourceKey key, bool quickDispose)
		{
			throw null;
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QuickDispose()
		{
			throw null;
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Action<GInterface357> disposeMethod)
		{
			throw null;
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(ResourceKey x)
		{
			throw null;
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(ResourceKey x)
		{
			throw null;
		}

		// Token: 0x04008333 RID: 33587
		private readonly GClass1203 gclass1203_0;

		// Token: 0x04008334 RID: 33588
		private readonly IEasyAssets ginterface394_0;

		// Token: 0x04008335 RID: 33589
		public readonly Transform ParentTransform;

		// Token: 0x04008336 RID: 33590
		private Transform transform_0;

		// Token: 0x04008337 RID: 33591
		public Transform UnloadableParent;

		// Token: 0x04008338 RID: 33592
		public readonly GClass1797 Config;

		// Token: 0x04008339 RID: 33593
		public readonly Dictionary<ResourceKey, PoolManager.Class1184.Class1185> PoolsDictionary;

		// Token: 0x0400833A RID: 33594
		private readonly PoolManager.AssemblyType assemblyType_0;

		// Token: 0x0400833B RID: 33595
		public GClass3002<PlayerPoolObject> PlayerAssetPool;

		// Token: 0x0400833C RID: 33596
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x02001679 RID: 5753
		public class Class1185
		{
			// Token: 0x06007CE1 RID: 31969 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RemovePool(bool quick)
			{
				throw null;
			}

			// Token: 0x0400833D RID: 33597
			public TaskCompletionSource<GInterface357> Source;

			// Token: 0x0400833E RID: 33598
			public int RequestCount;

			// Token: 0x0400833F RID: 33599
			public CancellationTokenSource CancellationSource;

			// Token: 0x04008340 RID: 33600
			public DependencyGraph<IEasyBundle>.GClass3388 BundleToken;

			// Token: 0x04008341 RID: 33601
			public bool DontDestroy;

			// Token: 0x04008342 RID: 33602
			public int LastRaidUseNumber;
		}

		// Token: 0x0200167C RID: 5756
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1186
		{
			// Token: 0x06007CE6 RID: 31974 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GInterface357 assetPool)
			{
				throw null;
			}

			// Token: 0x06007CE7 RID: 31975 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GInterface357 assetPool)
			{
				throw null;
			}

			// Token: 0x04008355 RID: 33621
			public static readonly PoolManager.Class1184.Class1186 class1186_0;

			// Token: 0x04008356 RID: 33622
			public static Action<GInterface357> action_0;

			// Token: 0x04008357 RID: 33623
			public static Action<GInterface357> action_1;
		}
	}

	// Token: 0x0200167D RID: 5757
	public class GClass627 : LoggerClass
	{
		// Token: 0x06007CE8 RID: 31976 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("UNITY_EDITOR")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TracePush<TAssetPoolObject>(TAssetPoolObject poolObject, GClass3001<TAssetPoolObject> abstractAssetsPool) where TAssetPoolObject : AssetPoolObject
		{
			throw null;
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("UNITY_EDITOR")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TracePop<TAssetPoolObject>(TAssetPoolObject poolObject, GClass3001<TAssetPoolObject> abstractAssetsPool) where TAssetPoolObject : AssetPoolObject
		{
			throw null;
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ErrorObjectIsAlreadyInPool<TAssetPoolObject>(TAssetPoolObject poolObject) where TAssetPoolObject : AssetPoolObject
		{
			throw null;
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Log(LogLevel logLevel, string format, params object[] args)
		{
			throw null;
		}
	}

	// Token: 0x0200167E RID: 5758
	public enum AssemblyType
	{
		// Token: 0x04008359 RID: 33625
		Local,
		// Token: 0x0400835A RID: 33626
		Online,
		// Token: 0x0400835B RID: 33627
		Nevermind
	}

	// Token: 0x0200167F RID: 5759
	public enum PoolsCategory
	{
		// Token: 0x0400835D RID: 33629
		Raid
	}

	// Token: 0x02001680 RID: 5760
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct228
	{
		// Token: 0x0400835E RID: 33630
		public ResourceKey ResourceKey;

		// Token: 0x0400835F RID: 33631
		public bool CreatePool;

		// Token: 0x04008360 RID: 33632
		public int PoolSize;

		// Token: 0x04008361 RID: 33633
		public GStruct105 ResourceType;
	}

	// Token: 0x02001681 RID: 5761
	public class GClass1796 : IEqualityComparer<ResourceType>
	{
		// Token: 0x06007CEC RID: 31980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ResourceType x, ResourceType y)
		{
			throw null;
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(ResourceType obj)
		{
			throw null;
		}
	}

	// Token: 0x02001682 RID: 5762
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1187
	{
		// Token: 0x06007CEE RID: 31982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal CancellationToken method_0(KeyValuePair<PoolManager.PoolsCategory, CancellationToken> kvp)
		{
			throw null;
		}

		// Token: 0x06007CEF RID: 31983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct117 method_1(float bp)
		{
			throw null;
		}

		// Token: 0x06007CF0 RID: 31984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(PoolManager.GStruct228 x)
		{
			throw null;
		}

		// Token: 0x04008362 RID: 33634
		public static readonly PoolManager.Class1187 class1187_0;

		// Token: 0x04008363 RID: 33635
		public static Func<KeyValuePair<PoolManager.PoolsCategory, CancellationToken>, CancellationToken> func_0;

		// Token: 0x04008364 RID: 33636
		public static Func<float, GStruct117> func_1;

		// Token: 0x04008365 RID: 33637
		public static Func<PoolManager.GStruct228, bool> func_2;
	}

	// Token: 0x02001683 RID: 5763
	[CompilerGenerated]
	private sealed class Class1188
	{
		// Token: 0x06007CF1 RID: 31985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(PoolManager.GStruct228 x)
		{
			throw null;
		}

		// Token: 0x06007CF2 RID: 31986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct117 method_1(int x)
		{
			throw null;
		}

		// Token: 0x06007CF3 RID: 31987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(PoolManager.GStruct228 x)
		{
			throw null;
		}

		// Token: 0x04008366 RID: 33638
		public List<PoolManager.GStruct228> poolsToCreate;

		// Token: 0x04008367 RID: 33639
		public PoolManager.Class1184 pools;

		// Token: 0x04008368 RID: 33640
		public PoolManager gclass1795_0;
	}

	// Token: 0x02001684 RID: 5764
	[CompilerGenerated]
	private sealed class Class1189
	{
		// Token: 0x06007CF4 RID: 31988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ResourceKey x)
		{
			throw null;
		}

		// Token: 0x04008369 RID: 33641
		public PoolManager.GStruct228 poolToCreate;
	}

	// Token: 0x02001687 RID: 5767
	[CompilerGenerated]
	private sealed class Class1190
	{
		// Token: 0x06007CF9 RID: 31993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04008386 RID: 33670
		public GameObject modPrefab;
	}

	// Token: 0x02001689 RID: 5769
	[CompilerGenerated]
	private sealed class Class1191
	{
		// Token: 0x06007CFC RID: 31996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04008396 RID: 33686
		public GameObject itemGameObject;
	}
}
