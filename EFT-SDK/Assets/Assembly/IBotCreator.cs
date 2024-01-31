using System;
using System.Threading;
using System.Threading.Tasks;
using EFT;

// Token: 0x02000623 RID: 1571
public interface IBotCreator
{
	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x060023E8 RID: 9192
	int BotsLoading { get; }

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x060023E9 RID: 9193
	bool StartProfilesLoaded { get; }

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x060023EA RID: 9194
	int BundlesLoading { get; }

	// Token: 0x060023EB RID: 9195
	Task<Profile> GenerateProfile(GClass588 data, CancellationToken cancellationToken, bool withDelete);

	// Token: 0x060023EC RID: 9196
	void ActivateBot(GClass588 data, BotZone zone, bool shallBeGroup, Func<BotOwner, BotZone, BotsGroup> groupAction, Action<BotOwner> callback, CancellationToken cancellationToken);

	// Token: 0x060023ED RID: 9197
	Task ActivateBot(Profile profile, GClass587 position, BotZone zone, bool shallBeGroup, Func<BotOwner, BotZone, BotsGroup> groupAction, Action<BotOwner> callback, CancellationToken cancellationToken);

	// Token: 0x060023EE RID: 9198
	void FillBackupProfilesData(GClass340 resultCache);
}
