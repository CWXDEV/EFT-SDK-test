using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x020025DE RID: 9694
public sealed class GClass2868 : GClass2833, GInterface336, GInterface337
{
	// Token: 0x17002265 RID: 8805
	// (get) Token: 0x0600C0C1 RID: 49345 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface337.Item1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002266 RID: 8806
	// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x00002050 File Offset: 0x00000250
	ItemAddress GInterface337.From1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002267 RID: 8807
	// (get) Token: 0x0600C0C3 RID: 49347 RVA: 0x00002050 File Offset: 0x00000250
	ItemAddress GInterface337.To1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C0C4 RID: 49348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0600C0C5 RID: 49349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal override void vmethod_0(Callback callback, bool requiresExternalFinalization = false)
	{
		throw null;
	}

	// Token: 0x0600C0C6 RID: 49350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C2CC RID: 49868
	public readonly Item Item;

	// Token: 0x0400C2CD RID: 49869
	public readonly ItemAddress From;

	// Token: 0x0400C2CE RID: 49870
	public readonly ItemAddress To;

	// Token: 0x0400C2CF RID: 49871
	public readonly int Count;

	// Token: 0x0400C2D0 RID: 49872
	public readonly string CloneId;

	// Token: 0x0400C2D1 RID: 49873
	public GInterface319 IdGenerator;

	// Token: 0x0400C2D2 RID: 49874
	private Item item_0;

	// Token: 0x0400C2D3 RID: 49875
	private GClass2773 gclass2773_0;

	// Token: 0x0400C2D4 RID: 49876
	private GClass2772 gclass2772_0;

	// Token: 0x020025DF RID: 9695
	[CompilerGenerated]
	private sealed class Class2168
	{
		// Token: 0x0600C0C7 RID: 49351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult outProcessResult)
		{
			throw null;
		}

		// Token: 0x0400C2D5 RID: 49877
		public GClass2868 gclass2868_0;

		// Token: 0x0400C2D6 RID: 49878
		public bool requiresExternalFinalization;

		// Token: 0x0400C2D7 RID: 49879
		public Callback callback;
	}

	// Token: 0x020025E0 RID: 9696
	[CompilerGenerated]
	private sealed class Class2169
	{
		// Token: 0x0600C0C8 RID: 49352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult inProcessResult)
		{
			throw null;
		}

		// Token: 0x0400C2D8 RID: 49880
		public bool succeed;

		// Token: 0x0400C2D9 RID: 49881
		public GStruct413<GClass2791> splitResult;

		// Token: 0x0400C2DA RID: 49882
		public GClass2868.Class2168 class2168_0;
	}
}
