using System;
using System.Runtime.CompilerServices;
using EFT.Quests;
using Newtonsoft.Json;

// Token: 0x02002FDA RID: 12250
public class GClass3218
{
	// Token: 0x14000367 RID: 871
	// (add) Token: 0x0600F1CF RID: 61903 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F1D0 RID: 61904 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass3218> OnValueChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x17002974 RID: 10612
	// (get) Token: 0x0600F1D1 RID: 61905 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("id")]
	public string Id
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002975 RID: 10613
	// (get) Token: 0x0600F1D2 RID: 61906 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F1D3 RID: 61907 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("value")]
	public int Value
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

	// Token: 0x17002976 RID: 10614
	// (get) Token: 0x0600F1D4 RID: 61908 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F1D5 RID: 61909 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("sourceId")]
	public string SourceId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17002977 RID: 10615
	// (get) Token: 0x0600F1D6 RID: 61910 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("type")]
	public string Type
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F1D7 RID: 61911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400F7D2 RID: 63442
	[CompilerGenerated]
	private Action<GClass3218> action_0;

	// Token: 0x0400F7D3 RID: 63443
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x0400F7D4 RID: 63444
	private int int_0;

	// Token: 0x0400F7D5 RID: 63445
	[JsonIgnore]
	public Condition Template;

	// Token: 0x0400F7D6 RID: 63446
	[JsonIgnore]
	public GInterface381 Conditional;

	// Token: 0x0400F7D7 RID: 63447
	[JsonIgnore]
	private string string_1;

	// Token: 0x0400F7D8 RID: 63448
	[CompilerGenerated]
	private readonly string string_2;
}
