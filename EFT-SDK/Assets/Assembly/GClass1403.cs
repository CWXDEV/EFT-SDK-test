using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001281 RID: 4737
public sealed class GClass1403
{
	// Token: 0x17000FB1 RID: 4017
	// (get) Token: 0x060062D3 RID: 25299 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass1403 Current
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1403 Create(string major = "0.14.0.1.28476", string minor = "", string backend = "6", string taxonomy = "341")
	{
		throw null;
	}

	// Token: 0x04006FB6 RID: 28598
	[JsonProperty("major")]
	public string Major;

	// Token: 0x04006FB7 RID: 28599
	[JsonProperty("minor")]
	public string Minor;

	// Token: 0x04006FB8 RID: 28600
	[JsonProperty("game")]
	public string Game;

	// Token: 0x04006FB9 RID: 28601
	[JsonProperty("backend")]
	public string Backend;

	// Token: 0x04006FBA RID: 28602
	[JsonProperty("taxonomy")]
	public string Taxonomy;
}
