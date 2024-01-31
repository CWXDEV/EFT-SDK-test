using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comfort.Common;

// Token: 0x020008D0 RID: 2256
public interface IBackendInterface<T> : IBackendStatus where T : GInterface144
{
	// Token: 0x170008B6 RID: 2230
	// (get) Token: 0x060032EA RID: 13034
	T Session { get; }

	// Token: 0x060032EB RID: 13035
	Task<T> CreateClientSession();

	// Token: 0x060032EC RID: 13036
	void RegisterDevice(string email, string activateCode, Callback onFinished);

	// Token: 0x060032ED RID: 13037
	Task RegenerateToken();

	// Token: 0x060032EE RID: 13038
	Task ValidateVersion();

	// Token: 0x060032EF RID: 13039
	Task<Result<GClass798>> Login(string login, string password);

	// Token: 0x060032F0 RID: 13040
	Task<GClass1397> GetMainMenuLocalization(string locale);

	// Token: 0x060032F1 RID: 13041
	Task<Dictionary<string, string>> GetAvailableLanguages();

	// Token: 0x060032F2 RID: 13042
	Task Logout();

	// Token: 0x060032F3 RID: 13043
	Task Destroy();

	// Token: 0x060032F4 RID: 13044
	void EnableDiagnostics(bool webDiagnosticsEnabled);
}
