using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;

// Token: 0x02002742 RID: 10050
public class GClass2959 : ExfiltrationRequirement
{
	// Token: 0x0600C91A RID: 51482 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddOperationAffectRequirement(GEventArgs2 args)
	{
		throw null;
	}

	// Token: 0x0600C91B RID: 51483 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveOperationAffectRequirement(GEventArgs3 args)
	{
		throw null;
	}

	// Token: 0x0600C91C RID: 51484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Enter(Player player, ExfiltrationPoint point)
	{
		throw null;
	}

	// Token: 0x0600C91D RID: 51485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Exit(Player player, ExfiltrationPoint point)
	{
		throw null;
	}

	// Token: 0x0600C91E RID: 51486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroy()
	{
		throw null;
	}

	// Token: 0x0400C92F RID: 51503
	private readonly Dictionary<Player, Action> dictionary_0;

	// Token: 0x02002743 RID: 10051
	[CompilerGenerated]
	private sealed class Class2262
	{
		// Token: 0x0600C91F RID: 51487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GEventArgs2 args)
		{
			throw null;
		}

		// Token: 0x0600C920 RID: 51488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x0400C930 RID: 51504
		public GClass2959 gclass2959_0;

		// Token: 0x0400C931 RID: 51505
		public ExfiltrationPoint point;

		// Token: 0x0400C932 RID: 51506
		public Player player;

		// Token: 0x0400C933 RID: 51507
		public Action<GEventArgs2> addHandler;

		// Token: 0x0400C934 RID: 51508
		public Action<GEventArgs3> removeHandler;
	}
}
