using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using UnityEngine;

// Token: 0x0200288F RID: 10383
public sealed class GClass3010
{
	// Token: 0x0600CF3F RID: 53055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetIcon(string url, Action<Sprite> callback)
	{
		throw null;
	}

	// Token: 0x0600CF40 RID: 53056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Sprite> LoadAvatar(string avatar)
	{
		throw null;
	}

	// Token: 0x0600CF41 RID: 53057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(string url, Dictionary<string, Sprite> cache, bool cacheOnDisk, Action<Sprite> callback)
	{
		throw null;
	}

	// Token: 0x0400D029 RID: 53289
	private readonly Dictionary<string, Sprite> dictionary_0;

	// Token: 0x0400D02A RID: 53290
	private readonly Dictionary<string, Sprite> dictionary_1;

	// Token: 0x0400D02B RID: 53291
	private readonly ISession ginterface145_0;

	// Token: 0x02002890 RID: 10384
	[CompilerGenerated]
	private sealed class Class2353
	{
		// Token: 0x0600CF42 RID: 53058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Texture2D> result)
		{
			throw null;
		}

		// Token: 0x0400D02C RID: 53292
		public Action<Sprite> callback;

		// Token: 0x0400D02D RID: 53293
		public Dictionary<string, Sprite> cache;

		// Token: 0x0400D02E RID: 53294
		public string url;
	}
}
