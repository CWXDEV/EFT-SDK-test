using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using Newtonsoft.Json;

// Token: 0x02001614 RID: 5652
public sealed class GClass1756
{
	// Token: 0x14000168 RID: 360
	// (add) Token: 0x06007B0A RID: 31498 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007B0B RID: 31499 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnBanExpired
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

	// Token: 0x17001360 RID: 4960
	// (get) Token: 0x06007B0C RID: 31500 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B0D RID: 31501 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("banType")]
	public EBanType Type
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001361 RID: 4961
	// (get) Token: 0x06007B0E RID: 31502 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007B0F RID: 31503 RVA: 0x00002050 File Offset: 0x00000250
	[JsonProperty("dateTime")]
	public long ExpirationTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001362 RID: 4962
	// (get) Token: 0x06007B10 RID: 31504 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public bool Expired
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001363 RID: 4963
	// (get) Token: 0x06007B11 RID: 31505 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public DateTime BanUntil
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001364 RID: 4964
	// (get) Token: 0x06007B12 RID: 31506 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public TimeSpan TimeLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06007B13 RID: 31507 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x06007B14 RID: 31508 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06007B15 RID: 31509 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_2()
	{
		throw null;
	}

	// Token: 0x06007B16 RID: 31510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06007B17 RID: 31511 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x04008006 RID: 32774
	public const string EXHIBITION_BLOCKED_MESSAGE = "Exhibition/BlockedMessage";

	// Token: 0x04008007 RID: 32775
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x04008008 RID: 32776
	[CompilerGenerated]
	private EBanType ebanType_0;

	// Token: 0x04008009 RID: 32777
	[CompilerGenerated]
	private long long_0;

	// Token: 0x0400800A RID: 32778
	private readonly CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400800B RID: 32779
	private Task task_0;
}
