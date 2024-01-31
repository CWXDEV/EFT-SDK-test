using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001D0C RID: 7436
public abstract class GClass2030 : NotificationClass
{
	// Token: 0x170017E8 RID: 6120
	// (get) Token: 0x06009A03 RID: 39427 RVA: 0x00002050 File Offset: 0x00000250
	public override string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400A13F RID: 41279
	[JsonProperty("text")]
	public string Text;
}
