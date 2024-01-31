using System;
using System.Runtime.CompilerServices;
using EFT.Hideout;
using Newtonsoft.Json;

// Token: 0x02001ADB RID: 6875
public class GClass1908
{
	// Token: 0x170015EC RID: 5612
	// (get) Token: 0x060090A2 RID: 37026 RVA: 0x00002050 File Offset: 0x00000250
	public bool Processing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170015ED RID: 5613
	// (get) Token: 0x060090A3 RID: 37027 RVA: 0x00002050 File Offset: 0x00000250
	public bool Waiting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060090A4 RID: 37028 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int TimeLeft()
	{
		throw null;
	}

	// Token: 0x060090A5 RID: 37029 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int TimePassed()
	{
		throw null;
	}

	// Token: 0x060090A6 RID: 37030 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateData(GClass1910 value)
	{
		throw null;
	}

	// Token: 0x060090A7 RID: 37031 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearData()
	{
		throw null;
	}

	// Token: 0x040097DE RID: 38878
	[JsonProperty("id")]
	public string Id;

	// Token: 0x040097DF RID: 38879
	[JsonProperty("requirements")]
	public Requirement[] Requirements;

	// Token: 0x040097E0 RID: 38880
	[JsonProperty("bonuses")]
	public GClass1404[] Bonuses;

	// Token: 0x040097E1 RID: 38881
	[JsonProperty("improvementTime")]
	public int ImprovementTime;

	// Token: 0x040097E2 RID: 38882
	[JsonIgnore]
	public bool Completed;

	// Token: 0x040097E3 RID: 38883
	[JsonIgnore]
	public int CompleteTimestamp;
}
