using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200283E RID: 10302
public sealed class AssetsManagerClass : IAssetsManager
{
	// Token: 0x170024DE RID: 9438
	// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CDF5 RID: 52725 RVA: 0x00002050 File Offset: 0x00000250
	public BundlesManagerClass BundlesManager
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

	// Token: 0x0600CDF6 RID: 52726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetAssetName(ResourceKey resourceKey)
	{
		throw null;
	}

	// Token: 0x0600CDF7 RID: 52727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private UnityEngine.Object method_0(string assetName)
	{
		throw null;
	}

	// Token: 0x0600CDF8 RID: 52728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private UnityEngine.Object method_1(string assetName, out string mask)
	{
		throw null;
	}

	// Token: 0x170024DF RID: 9439
	// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CDFA RID: 52730 RVA: 0x00002050 File Offset: 0x00000250
	public string[] Variants
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

	// Token: 0x0600CDFB RID: 52731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnityEngine.Object GetAsset(string assetName)
	{
		throw null;
	}

	// Token: 0x0600CDFC RID: 52732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetAsset<T>(string assetName) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x0600CDFD RID: 52733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IOperation<object> LoadAssetAsync(ResourceKey resourceKey)
	{
		throw null;
	}

	// Token: 0x0600CDFE RID: 52734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IOperation<object> LoadAssetAsync(string bundleName, string assetName)
	{
		throw null;
	}

	// Token: 0x0600CDFF RID: 52735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IOperation<object> LoadMainAssetAsync(string bundleName)
	{
		throw null;
	}

	// Token: 0x0600CE00 RID: 52736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IOperation LoadAssetsAsync(string bundleName)
	{
		throw null;
	}

	// Token: 0x0600CE01 RID: 52737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IOperation LoadBundlesAsync(string[] bundleNames)
	{
		throw null;
	}

	// Token: 0x0600CE02 RID: 52738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2999 LoadScene(string bundleName, string sceneName, LoadSceneMode loadSceneMode, bool allowSceneActivation, Action<float> progressCallback)
	{
		throw null;
	}

	// Token: 0x0600CE03 RID: 52739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadUnusedResources()
	{
		throw null;
	}

	// Token: 0x0600CE04 RID: 52740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadBundle(string bundleName, bool unloadAllLoadedObjects)
	{
		throw null;
	}

	// Token: 0x0600CE05 RID: 52741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadBundleWithDependences(string bundleName, bool unloadAllLoadedObjects)
	{
		throw null;
	}

	// Token: 0x0600CE06 RID: 52742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(string bundleName)
	{
		throw null;
	}

	// Token: 0x0400CEA3 RID: 52899
	private readonly Dictionary<string, UnityEngine.Object> dictionary_0;

	// Token: 0x0400CEA4 RID: 52900
	private readonly Dictionary<string, AssetsManagerClass.Class2335> dictionary_1;

	// Token: 0x0400CEA5 RID: 52901
	private readonly AssetsManagerClass.GClass631 gclass631_0;

	// Token: 0x0400CEA6 RID: 52902
	private const string string_0 = "{0}:";

	// Token: 0x0400CEA7 RID: 52903
	private const string string_1 = "{0}:Asset:{1}";

	// Token: 0x0400CEA8 RID: 52904
	private const string string_2 = "{0}:MainAsset";

	// Token: 0x0400CEA9 RID: 52905
	private const string string_3 = "{0}:AllAssets";

	// Token: 0x0400CEAA RID: 52906
	[CompilerGenerated]
	private BundlesManagerClass gclass2997_0;

	// Token: 0x0200283F RID: 10303
	public sealed class GClass631 : LoggerClass
	{
		// Token: 0x0600CE07 RID: 52743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BundleNotFound(ResourceKey resourceKey)
		{
			throw null;
		}

		// Token: 0x0600CE08 RID: 52744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CantGetAsset(string assetName)
		{
			throw null;
		}

		// Token: 0x0600CE09 RID: 52745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CantGetAssetOfType(string assetName, Type type)
		{
			throw null;
		}

		// Token: 0x0600CE0A RID: 52746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnloadingUnusedResources()
		{
			throw null;
		}

		// Token: 0x0600CE0B RID: 52747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartLoadBundlesListOperation(string[] bundleNames)
		{
			throw null;
		}

		// Token: 0x0600CE0C RID: 52748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FinishLoadBundlesListOperation(string[] bundleNames)
		{
			throw null;
		}

		// Token: 0x0600CE0D RID: 52749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAllAssetOperationStarted(AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE0E RID: 52750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadAllAssetOperationFinished(AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE0F RID: 52751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CantLoadAssetFromBundle(string bundleName)
		{
			throw null;
		}

		// Token: 0x0600CE10 RID: 52752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssetLoadFromBundleFinished(string name, string bundleName)
		{
			throw null;
		}

		// Token: 0x0600CE11 RID: 52753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(string assetName, string bundleName)
		{
			throw null;
		}

		// Token: 0x0600CE12 RID: 52754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssetLoadedFromBundle(string assetName, string bundleName)
		{
			throw null;
		}
	}

	// Token: 0x02002840 RID: 10304
	private class Class2334 : Operation<object>
	{
		// Token: 0x0600CE13 RID: 52755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AssetsManagerClass.Class2334 smethod_0(AssetsManagerClass manager, string[] bundleNames, string keyFormat)
		{
			throw null;
		}

		// Token: 0x0600CE14 RID: 52756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(AssetsManagerClass manager, string[] bundleNames)
		{
			throw null;
		}
	}

	// Token: 0x02002842 RID: 10306
	private abstract class Class2335 : Operation<object>
	{
		// Token: 0x0600CE17 RID: 52759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AssetsManagerClass.Class2335 smethod_0<T>(AssetsManagerClass manager, string bundleName, string keyFormat, string assetName, bool loadAssetAsync) where T : AssetsManagerClass.Class2335, new()
		{
			throw null;
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x0600CE18 RID: 52760 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CE19 RID: 52761 RVA: 0x00002050 File Offset: 0x00000250
		public string BundleName
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

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600CE1A RID: 52762 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CE1B RID: 52763 RVA: 0x00002050 File Offset: 0x00000250
		public string AssetName
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

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x0600CE1C RID: 52764 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CE1D RID: 52765 RVA: 0x00002050 File Offset: 0x00000250
		public string Key
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

		// Token: 0x0600CE1E RID: 52766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(AssetsManagerClass manager, bool loadAssetAsync)
		{
			throw null;
		}

		// Token: 0x0600CE1F RID: 52767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(AssetsManagerClass manager, IOperation<AssetBundle> loadBundleOperation, bool loadAssetAsync)
		{
			throw null;
		}

		// Token: 0x0600CE20 RID: 52768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(AssetsManagerClass manager, IOperation<AssetBundle> loadBundleOperation, bool loadAssetAsync)
		{
			throw null;
		}

		// Token: 0x0600CE21 RID: 52769
		protected abstract void vmethod_0(AssetsManagerClass manager, AssetBundle bundle);

		// Token: 0x0600CE22 RID: 52770
		protected abstract Task vmethod_1(AssetsManagerClass manager, AssetBundle bundle);

		// Token: 0x0400CEB4 RID: 52916
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400CEB5 RID: 52917
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400CEB6 RID: 52918
		[CompilerGenerated]
		private string string_2;
	}

	// Token: 0x02002844 RID: 10308
	private sealed class Class2336 : AssetsManagerClass.Class2335
	{
		// Token: 0x0600CE25 RID: 52773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task vmethod_1(AssetsManagerClass manager, AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE26 RID: 52774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0(AssetsManagerClass manager, AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(AssetsManagerClass manager, string bundleName, UnityEngine.Object asset)
		{
			throw null;
		}
	}

	// Token: 0x02002846 RID: 10310
	private sealed class Class2337 : AssetsManagerClass.Class2335
	{
		// Token: 0x0600CE2A RID: 52778 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task vmethod_1(AssetsManagerClass manager, AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE2B RID: 52779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0(AssetsManagerClass manager, AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE2C RID: 52780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(AssetsManagerClass manager, string bundleName, UnityEngine.Object asset)
		{
			throw null;
		}
	}

	// Token: 0x02002847 RID: 10311
	private sealed class Class2338 : AssetsManagerClass.Class2335
	{
		// Token: 0x0600CE2D RID: 52781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task vmethod_1(AssetsManagerClass manager, AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE2E RID: 52782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0(AssetsManagerClass manager, AssetBundle bundle)
		{
			throw null;
		}

		// Token: 0x0600CE2F RID: 52783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(AssetsManagerClass manager, AssetBundle bundle, UnityEngine.Object[] assets)
		{
			throw null;
		}
	}

	// Token: 0x02002849 RID: 10313
	private sealed class Class2345 : GClass2999
	{
		// Token: 0x0600CE32 RID: 52786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AssetsManagerClass.Class2345 smethod_0(AssetsManagerClass manager, string bundleName, string sceneName, LoadSceneMode loadSceneMode, bool allowSceneActivation, Action<float> progressCallback)
		{
			throw null;
		}

		// Token: 0x0600CE33 RID: 52787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(AssetsManagerClass manager, string bundleName, string sceneName, LoadSceneMode loadSceneMode, bool allowSceneActivation, Action<float> progressCallback)
		{
			throw null;
		}

		// Token: 0x0400CECD RID: 52941
		private static readonly AssetsManagerClass.Class2345.Class355 class355_0;

		// Token: 0x0200284A RID: 10314
		private sealed class Class355 : LoggerClass
		{
		}
	}

	// Token: 0x0200284C RID: 10316
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2339
	{
		// Token: 0x0600CE36 RID: 52790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(string name)
		{
			throw null;
		}

		// Token: 0x0400CEDB RID: 52955
		public static readonly AssetsManagerClass.Class2339 class2339_0;

		// Token: 0x0400CEDC RID: 52956
		public static Func<string, string> func_0;
	}
}
