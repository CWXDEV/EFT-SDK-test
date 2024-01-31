using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Quests;
using JetBrains.Annotations;

// Token: 0x02002FCE RID: 12238
public sealed class GClass3365 : GClass3364<Condition>
{
	// Token: 0x17002971 RID: 10609
	// (get) Token: 0x0600F1B8 RID: 61880 RVA: 0x00002050 File Offset: 0x00000250
	private IEnumerable<Condition> IEnumerable_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F1B9 RID: 61881 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Condition method_7(int identity)
	{
		throw null;
	}

	// Token: 0x0600F1BA RID: 61882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TestAll(GInterface381 conditional, params GStruct403[] checks)
	{
		throw null;
	}

	// Token: 0x0600F1BB RID: 61883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TestAll(GInterface381 conditional)
	{
		throw null;
	}

	// Token: 0x0600F1BC RID: 61884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TestAny(GInterface381 conditional)
	{
		throw null;
	}

	// Token: 0x0600F1BD RID: 61885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetIdentity()
	{
		throw null;
	}

	// Token: 0x0600F1BE RID: 61886 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Condition GetCondition(GStruct403 check)
	{
		throw null;
	}

	// Token: 0x0600F1BF RID: 61887 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<Condition> GetCompletedConditionTemplates(GInterface381 conditional)
	{
		throw null;
	}

	// Token: 0x0400F7C0 RID: 63424
	private int int_0;

	// Token: 0x02002FCF RID: 12239
	public class GClass3215 : IEqualityComparer<Condition>
	{
		// Token: 0x0600F1C0 RID: 61888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(Condition obj)
		{
			throw null;
		}

		// Token: 0x0600F1C1 RID: 61889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Condition obj1, Condition obj2)
		{
			throw null;
		}
	}

	// Token: 0x02002FD0 RID: 12240
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3055
	{
		// Token: 0x0600F1C2 RID: 61890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition x)
		{
			throw null;
		}

		// Token: 0x0400F7C1 RID: 63425
		public static readonly GClass3365.Class3055 class3055_0;

		// Token: 0x0400F7C2 RID: 63426
		public static Func<Condition, bool> func_0;
	}

	// Token: 0x02002FD1 RID: 12241
	[CompilerGenerated]
	private sealed class Class3056
	{
		// Token: 0x0600F1C3 RID: 61891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F7C3 RID: 63427
		public int identity;
	}

	// Token: 0x02002FD2 RID: 12242
	[CompilerGenerated]
	private sealed class Class3057
	{
		// Token: 0x0600F1C4 RID: 61892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F7C4 RID: 63428
		public GInterface381 conditional;
	}

	// Token: 0x02002FD3 RID: 12243
	[CompilerGenerated]
	private sealed class Class3058
	{
		// Token: 0x0600F1C5 RID: 61893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F7C5 RID: 63429
		public GInterface381 conditional;
	}

	// Token: 0x02002FD4 RID: 12244
	[CompilerGenerated]
	private sealed class Class3059
	{
		// Token: 0x0600F1C6 RID: 61894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Condition condition)
		{
			throw null;
		}

		// Token: 0x0400F7C6 RID: 63430
		public GInterface381 conditional;

		// Token: 0x0400F7C7 RID: 63431
		public Func<Condition, bool> func_0;
	}
}
