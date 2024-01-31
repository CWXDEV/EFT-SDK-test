using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020012B1 RID: 4785
public static class GClass1444
{
	// Token: 0x06006372 RID: 25458 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T InstantiateAsset<T>(this IEasyAssets easyAssets, string key) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T InstantiateAsset<T>(this IEasyAssets easyAssets, ResourceKey key, Transform parent = null) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x06006374 RID: 25460 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetAsset<T>(this IEasyAssets easyAssets, ResourceKey key) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x06006375 RID: 25461 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityEngine.Object GetDefaultAsset(this IEasyAssets easyAssets)
	{
		throw null;
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T GetAsset<T>(this IEasyAssets easyAssets, string key, string assetName = null) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DependencyGraph<IEasyBundle>.GClass3388 Retain(this IEasyAssets easyAssets, string key, [CanBeNull] Func<string, bool> dependencyPredicate, IProgress<float> progress)
	{
		throw null;
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DependencyGraph<IEasyBundle>.GClass3388 Retain(this IEasyAssets easyAssets, IEnumerable<string> keys, IProgress<float> progress = null, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static DependencyGraph<IEasyBundle>.GClass3387 RetainSeparate(this IEasyAssets easyAssets, IEnumerable<string> keys, IProgress<float> progress = null, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<DependencyGraph<IEasyBundle>.GClass3387> RetainSeparateTask(this IEasyAssets easyAssets, IEnumerable<string> keys, IProgress<float> progress = null, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WaitForAllBundles(DependencyGraph<IEasyBundle>.GClass3388[] bundles, Action onFinished, CancellationToken cancellationToken = default(CancellationToken), IProgress<float> progress = null)
	{
		throw null;
	}

	// Token: 0x0600637C RID: 25468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WaitForAllBundles(DependencyGraph<IEasyBundle>.GClass3388 bundles, Action onFinished, CancellationToken cancellationToken = default(CancellationToken), IProgress<float> progress = null)
	{
		throw null;
	}

	// Token: 0x0600637D RID: 25469 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task smethod_0(DependencyGraph<IEasyBundle>.GClass3388[] bundles, Action onFinished, CancellationToken cancellationToken = default(CancellationToken), IProgress<float> progress = null)
	{
		throw null;
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task WaitForAllBundlesJob(DependencyGraph<IEasyBundle>.GClass3388 bundles, Action onFinished, CancellationToken cancellationToken = default(CancellationToken), IProgress<float> progress = null)
	{
		throw null;
	}

	// Token: 0x0600637F RID: 25471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task LoadBundles(DependencyGraph<IEasyBundle>.GClass3388[] bundles)
	{
		throw null;
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task LoadBundles(DependencyGraph<IEasyBundle>.GClass3388 bundles)
	{
		throw null;
	}

	// Token: 0x020012B2 RID: 4786
	[CompilerGenerated]
	private sealed class Class915<T> where T : UnityEngine.Object
	{
		// Token: 0x06006381 RID: 25473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(UnityEngine.Object x)
		{
			throw null;
		}

		// Token: 0x04007003 RID: 28675
		public string assetName;
	}

	// Token: 0x020012B3 RID: 4787
	[CompilerGenerated]
	[Serializable]
	private sealed class Class916<T> where T : UnityEngine.Object
	{
		// Token: 0x06006382 RID: 25474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(UnityEngine.Object a)
		{
			throw null;
		}

		// Token: 0x04007004 RID: 28676
		public static readonly GClass1444.Class916<T> class916_0;

		// Token: 0x04007005 RID: 28677
		public static Func<UnityEngine.Object, bool> func_0;
	}

	// Token: 0x020012B8 RID: 4792
	[CompilerGenerated]
	[Serializable]
	private sealed class Class917
	{
		// Token: 0x0600638B RID: 25483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_0(DependencyGraph<IEasyBundle>.GClass3388 x)
		{
			throw null;
		}

		// Token: 0x04007020 RID: 28704
		public static readonly GClass1444.Class917 class917_0;

		// Token: 0x04007021 RID: 28705
		public static Func<DependencyGraph<IEasyBundle>.GClass3388, Task> func_0;
	}
}
