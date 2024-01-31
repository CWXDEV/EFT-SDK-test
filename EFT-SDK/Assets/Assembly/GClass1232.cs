using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

// Token: 0x02001001 RID: 4097
public sealed class GClass1232 : GInterface80
{
	// Token: 0x17000D63 RID: 3427
	// (get) Token: 0x06005561 RID: 21857 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005562 RID: 21858 RVA: 0x00002050 File Offset: 0x00000250
	public float Value
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06005563 RID: 21859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetStringValue(string postfix = "")
	{
		throw null;
	}

	// Token: 0x06005564 RID: 21860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFullStringValue(string displayName)
	{
		throw null;
	}

	// Token: 0x040061E0 RID: 25056
	[JsonProperty("delay")]
	public float Delay;

	// Token: 0x040061E1 RID: 25057
	[JsonProperty("duration")]
	public float Duration;

	// Token: 0x040061E2 RID: 25058
	[JsonProperty("fadeOut")]
	public float FadeOut;

	// Token: 0x040061E3 RID: 25059
	[JsonProperty("cost")]
	public int Cost;

	// Token: 0x040061E4 RID: 25060
	[JsonProperty("healthPenaltyMin")]
	public int HealthPenaltyMin;

	// Token: 0x040061E5 RID: 25061
	[JsonProperty("healthPenaltyMax")]
	public int HealthPenaltyMax;
}
