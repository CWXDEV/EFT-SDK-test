using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT;
using UnityEngine.SceneManagement;

// Token: 0x020016A0 RID: 5792
public static class GClass1802
{
	// Token: 0x06007D3F RID: 32063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<GClass1802.GClass1803> Load(ResourceKey preset)
	{
		throw null;
	}

	// Token: 0x06007D40 RID: 32064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task Unload(GClass1802.GClass1803 sceneToken)
	{
		throw null;
	}

	// Token: 0x06007D41 RID: 32065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task smethod_0(string sceneName, LoadSceneMode loadSceneMode, Action<float> progressCallback = null)
	{
		throw null;
	}

	// Token: 0x06007D42 RID: 32066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task UnloadScene(string sceneName, Action<float> progressCallback = null)
	{
		throw null;
	}

	// Token: 0x020016A1 RID: 5793
	public class GClass1803
	{
		// Token: 0x04008417 RID: 33815
		public ScenesPreset ScenesPreset;

		// Token: 0x04008418 RID: 33816
		public DependencyGraph<IEasyBundle>.GClass3388 Resources;
	}
}
