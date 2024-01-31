using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.Quests;

// Token: 0x0200303A RID: 12346
public sealed class GClass1247 : GClass1246
{
	// Token: 0x1400036B RID: 875
	// (add) Token: 0x0600F29E RID: 62110 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F29F RID: 62111 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnExpired
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

	// Token: 0x17002995 RID: 10645
	// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x00002050 File Offset: 0x00000250
	public override EQuestIconType IconType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002996 RID: 10646
	// (get) Token: 0x0600F2A1 RID: 62113 RVA: 0x00002050 File Offset: 0x00000250
	public override string QuestTypeName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002997 RID: 10647
	// (get) Token: 0x0600F2A2 RID: 62114 RVA: 0x00002050 File Offset: 0x00000250
	public bool NeedCountdown
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F2A3 RID: 62115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_11()
	{
		throw null;
	}

	// Token: 0x0600F2A4 RID: 62116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetExpired()
	{
		throw null;
	}

	// Token: 0x0600F2A5 RID: 62117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void Dispose()
	{
		throw null;
	}

	// Token: 0x0400F8D1 RID: 63697
	private const string string_2 = "Daily";

	// Token: 0x0400F8D2 RID: 63698
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400F8D3 RID: 63699
	public readonly int ExpirationDate;

	// Token: 0x0400F8D4 RID: 63700
	private CancellationTokenSource cancellationTokenSource_0;
}
