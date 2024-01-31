using System;
using JetBrains.Annotations;

// Token: 0x02000560 RID: 1376
public interface GInterface14 : IDisposable
{
	// Token: 0x0600211C RID: 8476
	bool Exists(string url);

	// Token: 0x0600211D RID: 8477
	[CanBeNull]
	string Load(string url);

	// Token: 0x0600211E RID: 8478
	void Save(string url, string data);
}
