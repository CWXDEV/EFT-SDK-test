using System;
using System.Threading;
using System.Threading.Tasks;
using EFT;

// Token: 0x02000613 RID: 1555
public interface GInterface18
{
	// Token: 0x0600238B RID: 9099
	Task<Profile> CreateProfile(GClass588 data, CancellationToken cancellationToken, bool withDelete);

	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x0600238C RID: 9100
	bool StartProfilesLoaded { get; }

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x0600238D RID: 9101
	int BundlesLoading { get; }

	// Token: 0x0600238E RID: 9102
	void FillBackupProfilesData(GClass340 resultCache);
}
