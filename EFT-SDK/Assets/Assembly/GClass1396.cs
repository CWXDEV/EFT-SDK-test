using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Comfort.Common;
using EFT;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200126E RID: 4718
public static class GClass1396
{
	// Token: 0x060062AD RID: 25261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Instantiate<T>(this IAssetsManager assetsManager, string assetName) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x060062AE RID: 25262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Instantiate<T>(this IAssetsManager assetsManager, string assetName, Vector3 position, Quaternion rotation) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x060062AF RID: 25263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Instantiate<T>(this IAssetsManager assetsManager, ResourceKey resourceKey) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x060062B0 RID: 25264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Instantiate<T>(this IAssetsManager assetsManager, ResourceKey resourceKey, Vector3 position, Quaternion rotation) where T : UnityEngine.Object
	{
		throw null;
	}

	// Token: 0x060062B1 RID: 25265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1801 LoadScenesFromPreset(this IAssetsManager assetsManager, GStruct229 preset, bool loadFirstAsSingle, bool loadInParallelMode, bool allowSceneActivation, CancellationToken cancellationToken = default(CancellationToken), IProgress<float> progress = null)
	{
		throw null;
	}

	// Token: 0x060062B2 RID: 25266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1801 LoadScenesFromPreset(this IAssetsManager assetsManager, ScenesPreset preset, bool loadFirstAsSingle, bool loadInParallelMode, bool allowSceneActivation, CancellationToken cancellationToken = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x060062B3 RID: 25267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2999 LoadScene(this IAssetsManager manager, ResourceKey resourceKey, LoadSceneMode loadSceneMode = LoadSceneMode.Single, bool allowSceneActivation = true, Action<float> progressCallback = null)
	{
		throw null;
	}

	// Token: 0x060062B4 RID: 25268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IOperation LoadSceneByReference(this IAssetsManager manager, string reference, LoadSceneMode loadSceneMode = LoadSceneMode.Single, bool allowSceneActivation = true, Action<float> progressCallback = null)
	{
		throw null;
	}

	// Token: 0x060062B5 RID: 25269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ResourceKey smethod_0(string reference)
	{
		throw null;
	}
}
