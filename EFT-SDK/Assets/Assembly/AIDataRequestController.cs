using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020004B1 RID: 1201
public class AIDataRequestController
{
	// Token: 0x17000548 RID: 1352
	// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
	public int RequestsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000549 RID: 1353
	// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00002050 File Offset: 0x00000250
	public BotRequest ActivatedRequest
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

	// Token: 0x06001D5E RID: 7518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAdd(BotRequest request, BotGroupRequestController groupRequestController)
	{
		throw null;
	}

	// Token: 0x06001D5F RID: 7519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanAddByCount(BotRequestType type)
	{
		throw null;
	}

	// Token: 0x06001D60 RID: 7520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MyRequestTaken(BotRequest request)
	{
		throw null;
	}

	// Token: 0x06001D61 RID: 7521 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckOnEndByRequester()
	{
		throw null;
	}

	// Token: 0x06001D62 RID: 7522 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose(BotRequest request)
	{
		throw null;
	}

	// Token: 0x06001D63 RID: 7523 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisposeAll(BotRequest exeptThis = null)
	{
		throw null;
	}

	// Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040018D8 RID: 6360
	private readonly List<BotRequest> _currentRequests;

	// Token: 0x040018D9 RID: 6361
	private float _nextCheckRequestsToEnd;

	// Token: 0x040018DA RID: 6362
	private readonly AIData _aiData;

	// Token: 0x020004B2 RID: 1202
	[CompilerGenerated]
	private sealed class Class240
	{
		// Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotRequest x)
		{
			throw null;
		}

		// Token: 0x040018DC RID: 6364
		public BotRequestType type;
	}

	// Token: 0x020004B3 RID: 1203
	[CompilerGenerated]
	private sealed class Class241
	{
		// Token: 0x06001D66 RID: 7526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotRequest x)
		{
			throw null;
		}

		// Token: 0x040018DD RID: 6365
		public BotRequest exeptThis;
	}
}
