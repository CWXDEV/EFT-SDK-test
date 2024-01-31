using System;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.AssetsManager;
using UnityEngine;

// Token: 0x0200286B RID: 10347
public interface GInterface357 : IDisposable
{
	// Token: 0x0600CEAB RID: 52907
	void Push(AssetPoolObject poolObject);

	// Token: 0x170024EE RID: 9454
	// (get) Token: 0x0600CEAC RID: 52908
	ResourceKey ResourceKey { get; }

	// Token: 0x0600CEAD RID: 52909
	GameObject PopOrCreate(bool poolShouldNotBeEmpty = false);

	// Token: 0x170024EF RID: 9455
	// (get) Token: 0x0600CEAE RID: 52910
	bool IsDisposed { get; }

	// Token: 0x170024F0 RID: 9456
	// (get) Token: 0x0600CEAF RID: 52911
	PoolContainerObject ParentObject { get; }

	// Token: 0x0600CEB0 RID: 52912
	Task ExpandPool(int objectsCoun, GDelegate77 yield, CancellationToken cancellationToken = default(CancellationToken), string reason = "");

	// Token: 0x170024F1 RID: 9457
	// (get) Token: 0x0600CEB1 RID: 52913
	int CurrentPoolSize { get; }

	// Token: 0x170024F2 RID: 9458
	// (get) Token: 0x0600CEB2 RID: 52914
	int FuturePoolSize { get; }

	// Token: 0x170024F3 RID: 9459
	// (get) Token: 0x0600CEB3 RID: 52915
	int TotalCreatedObjectsCount { get; }

	// Token: 0x170024F4 RID: 9460
	// (get) Token: 0x0600CEB4 RID: 52916
	string PoolShortName { get; }

	// Token: 0x170024F5 RID: 9461
	// (get) Token: 0x0600CEB5 RID: 52917
	GStruct105 ResourceType { get; }

	// Token: 0x0600CEB6 RID: 52918
	void QuickDispose();

	// Token: 0x0600CEB7 RID: 52919
	void ReturnPoolObjects();

	// Token: 0x170024F6 RID: 9462
	// (get) Token: 0x0600CEB8 RID: 52920
	bool IsWillBeDestroyedByParent { get; }
}
