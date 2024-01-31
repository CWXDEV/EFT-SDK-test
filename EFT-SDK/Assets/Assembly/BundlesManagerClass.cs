using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using UnityEngine;
using UnityEngine.Build.Pipeline;

// Token: 0x02002858 RID: 10328
public class BundlesManagerClass
{
	// Token: 0x170024E3 RID: 9443
	// (get) Token: 0x0600CE4C RID: 52812 RVA: 0x00002050 File Offset: 0x00000250
	public string DownloadingUrl
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024E4 RID: 9444
	// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x00002050 File Offset: 0x00000250
	public string LoadingUrl
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024E5 RID: 9445
	// (get) Token: 0x0600CE4E RID: 52814 RVA: 0x00002050 File Offset: 0x00000250
	public CompatibilityAssetBundleManifest Manifest
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024E6 RID: 9446
	// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600CE50 RID: 52816 RVA: 0x00002050 File Offset: 0x00000250
	public string[] Variants
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

	// Token: 0x0600CE51 RID: 52817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IOperation<AssetBundle> LoadBundleAsync(string bundleName, bool logErrors = true)
	{
		throw null;
	}

	// Token: 0x0600CE52 RID: 52818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnloadBundle(string bundleName, bool unloadAllLoadedObjects)
	{
		throw null;
	}

	// Token: 0x0600CE53 RID: 52819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AssetBundle FindBundle(string bundleName)
	{
		throw null;
	}

	// Token: 0x0600CE54 RID: 52820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<string> FindDependences(string bundleName)
	{
		throw null;
	}

	// Token: 0x0600CE55 RID: 52821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_0(string bundleName)
	{
		throw null;
	}

	// Token: 0x0600CE56 RID: 52822 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(string dependency)
	{
		throw null;
	}

	// Token: 0x0400CF0C RID: 53004
	private readonly Dictionary<string, BundlesManagerClass.Class2342> dictionary_0;

	// Token: 0x0400CF0D RID: 53005
	private readonly Dictionary<string, BundlesManagerClass.Class2343> dictionary_1;

	// Token: 0x0400CF0E RID: 53006
	private readonly List<string> list_0;

	// Token: 0x0400CF0F RID: 53007
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x0400CF10 RID: 53008
	[CompilerGenerated]
	private readonly string string_1;

	// Token: 0x0400CF11 RID: 53009
	[CompilerGenerated]
	private readonly CompatibilityAssetBundleManifest compatibilityAssetBundleManifest_0;

	// Token: 0x0400CF12 RID: 53010
	[CompilerGenerated]
	private string[] string_2;

	// Token: 0x02002859 RID: 10329
	private class Class2342
	{
		// Token: 0x0400CF13 RID: 53011
		public readonly AssetBundle AssetBundle;

		// Token: 0x0400CF14 RID: 53012
		public int Counter;
	}

	// Token: 0x0200285A RID: 10330
	public class GClass2998 : Operation<byte[]>
	{
		// Token: 0x0600CE57 RID: 52823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BundlesManagerClass.GClass2998 smethod_0(string url, string bundleName)
		{
			throw null;
		}

		// Token: 0x0600CE58 RID: 52824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string url, string bundleName)
		{
			throw null;
		}
	}

	// Token: 0x0200285C RID: 10332
	private class Class2343 : Operation<AssetBundle>
	{
		// Token: 0x0600CE5B RID: 52827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static BundlesManagerClass.Class2343 smethod_0(BundlesManagerClass manager, string bundleName, bool logErrors)
		{
			throw null;
		}

		// Token: 0x0600CE5C RID: 52828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BundlesManagerClass manager, string bundleName, bool logErrors)
		{
			throw null;
		}

		// Token: 0x0200285D RID: 10333
		[CompilerGenerated]
		private sealed class Class2344
		{
			// Token: 0x0600CE5D RID: 52829 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IOperation<AssetBundle> method_0(string dependency)
			{
				throw null;
			}

			// Token: 0x0400CF1C RID: 53020
			public BundlesManagerClass manager;
		}
	}
}
