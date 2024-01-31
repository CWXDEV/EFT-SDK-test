using System;
using System.Collections.Generic;

// Token: 0x02001CA6 RID: 7334
public interface IConnectionHandler
{
	// Token: 0x1700176A RID: 5994
	// (get) Token: 0x0600990A RID: 39178
	ENotificationTransportType TransportType { get; }

	// Token: 0x1700176B RID: 5995
	// (get) Token: 0x0600990B RID: 39179
	IReadOnlyDictionary<string, string> UriParams { get; }

	// Token: 0x1700176C RID: 5996
	// (get) Token: 0x0600990C RID: 39180
	IReadOnlyDictionary<string, string> RequestHeaders { get; }

	// Token: 0x0600990D RID: 39181
	void SetUri(string uri);

	// Token: 0x0600990E RID: 39182
	void SetUriParam(string key, string value);

	// Token: 0x0600990F RID: 39183
	void SetRequestHeader(string key, string value);

	// Token: 0x06009910 RID: 39184
	void Open(Action<long, byte[]> onMessage, Action<long, string> onError);

	// Token: 0x06009911 RID: 39185
	void Close();

	// Token: 0x1700176D RID: 5997
	// (get) Token: 0x06009912 RID: 39186
	bool Closed { get; }
}
