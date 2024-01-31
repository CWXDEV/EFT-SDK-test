using System;
using EFT.AssetsManager;

// Token: 0x0200287A RID: 10362
public interface GInterface358
{
	// Token: 0x0600CEFC RID: 52988
	void OnCreatePoolRoleModel(AssetPoolObject assetPoolObject);

	// Token: 0x0600CEFD RID: 52989
	void OnCreatePoolObject(AssetPoolObject assetPoolObject);

	// Token: 0x0600CEFE RID: 52990
	void OnGetFromPool(AssetPoolObject assetPoolObject);

	// Token: 0x0600CEFF RID: 52991
	void OnReturnToPool(AssetPoolObject assetPoolObject);

	// Token: 0x0600CF00 RID: 52992
	void InheritRoleModelData(GInterface358 roleModel);

	// Token: 0x17002509 RID: 9481
	// (get) Token: 0x0600CF01 RID: 52993
	// (set) Token: 0x0600CF02 RID: 52994
	bool enabled { get; set; }
}
