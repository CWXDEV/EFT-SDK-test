using System;
using Comfort.Common;
using EFT;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200285F RID: 10335
public interface IAssetsManager
{
	// Token: 0x0600CE60 RID: 52832
	string GetAssetName(ResourceKey resourceKey);

	// Token: 0x0600CE61 RID: 52833
	UnityEngine.Object GetAsset(string assetName);

	// Token: 0x0600CE62 RID: 52834
	T GetAsset<T>(string assetName) where T : UnityEngine.Object;

	// Token: 0x170024E7 RID: 9447
	// (get) Token: 0x0600CE63 RID: 52835
	// (set) Token: 0x0600CE64 RID: 52836
	string[] Variants { get; set; }

	// Token: 0x0600CE65 RID: 52837
	IOperation<object> LoadAssetAsync(string bundleName, string assetName);

	// Token: 0x0600CE66 RID: 52838
	IOperation<object> LoadAssetAsync(ResourceKey resourceKey);

	// Token: 0x0600CE67 RID: 52839
	IOperation<object> LoadMainAssetAsync(string bundleName);

	// Token: 0x0600CE68 RID: 52840
	IOperation LoadAssetsAsync(string bundleName);

	// Token: 0x0600CE69 RID: 52841
	IOperation LoadBundlesAsync(string[] resourceKeys);

	// Token: 0x0600CE6A RID: 52842
	GClass2999 LoadScene(string bundleName, string sceneName, LoadSceneMode loadSceneMode = LoadSceneMode.Single, bool allowSceneActivation = true, Action<float> progressCallback = null);

	// Token: 0x0600CE6B RID: 52843
	void UnloadBundle(string prefubId, bool unloadAllLoadedObjects);

	// Token: 0x0600CE6C RID: 52844
	void UnloadBundleWithDependences(string assetName, bool unloadAllLoadedObjects);

	// Token: 0x0600CE6D RID: 52845
	void UnloadUnusedResources();
}
