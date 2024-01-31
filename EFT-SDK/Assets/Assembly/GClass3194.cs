using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI.Ragfair;
using JetBrains.Annotations;

// Token: 0x02002F73 RID: 12147
public sealed class GClass3194
{
	// Token: 0x14000361 RID: 865
	// (add) Token: 0x0600EF90 RID: 61328 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EF91 RID: 61329 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass3192> ItemAdded
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

	// Token: 0x14000362 RID: 866
	// (add) Token: 0x0600EF92 RID: 61330 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EF93 RID: 61331 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass3192> ItemRemoved
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

	// Token: 0x1700290D RID: 10509
	// (get) Token: 0x0600EF94 RID: 61332 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3362 HorizontalFilters
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700290E RID: 10510
	// (get) Token: 0x0600EF95 RID: 61333 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3362 VerticalFilters
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700290F RID: 10511
	// (get) Token: 0x0600EF96 RID: 61334 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3192[] AllFilters
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002910 RID: 10512
	// (get) Token: 0x0600EF97 RID: 61335 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002911 RID: 10513
	[CanBeNull]
	private GClass3192 this[EFilterType type]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600EF99 RID: 61337 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3192 FirstOrDefault(Func<GClass3192, bool> search)
	{
		throw null;
	}

	// Token: 0x0600EF9A RID: 61338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass3192 filter)
	{
		throw null;
	}

	// Token: 0x0600EF9B RID: 61339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass3192 filter)
	{
		throw null;
	}

	// Token: 0x0600EF9C RID: 61340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(IEnumerable<GClass3192> filters)
	{
		throw null;
	}

	// Token: 0x0600EF9D RID: 61341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(IEnumerable<GClass3192> filters)
	{
		throw null;
	}

	// Token: 0x0600EF9E RID: 61342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddFilter(GClass3192 filter)
	{
		throw null;
	}

	// Token: 0x0600EF9F RID: 61343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFilter(EFilterType filterType, bool sendCallback)
	{
		throw null;
	}

	// Token: 0x0600EFA0 RID: 61344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFilter(GClass3192 filter, bool sendCallback)
	{
		throw null;
	}

	// Token: 0x0600EFA1 RID: 61345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Store()
	{
		throw null;
	}

	// Token: 0x0600EFA2 RID: 61346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore()
	{
		throw null;
	}

	// Token: 0x0600EFA3 RID: 61347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x0600EFA4 RID: 61348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsActive(EFilterType type)
	{
		throw null;
	}

	// Token: 0x0600EFA5 RID: 61349 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass3192 method_4(EFilterType item)
	{
		throw null;
	}

	// Token: 0x0400F4EC RID: 62700
	private const int int_0 = 2;

	// Token: 0x0400F4ED RID: 62701
	[CompilerGenerated]
	private Action<GClass3192> action_0;

	// Token: 0x0400F4EE RID: 62702
	[CompilerGenerated]
	private Action<GClass3192> action_1;

	// Token: 0x0400F4EF RID: 62703
	private GClass3362 gclass3362_0;

	// Token: 0x0400F4F0 RID: 62704
	private List<GClass3192> list_0;

	// Token: 0x0400F4F1 RID: 62705
	[CompilerGenerated]
	private readonly GClass3362 gclass3362_1;

	// Token: 0x0400F4F2 RID: 62706
	[CompilerGenerated]
	private readonly GClass3362 gclass3362_2;

	// Token: 0x02002F74 RID: 12148
	[CompilerGenerated]
	private sealed class Class3023
	{
		// Token: 0x0600EFA6 RID: 61350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3192 x)
		{
			throw null;
		}

		// Token: 0x0400F4F3 RID: 62707
		public EFilterType type;
	}

	// Token: 0x02002F75 RID: 12149
	[CompilerGenerated]
	private sealed class Class3024
	{
		// Token: 0x0600EFA7 RID: 61351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3192 x)
		{
			throw null;
		}

		// Token: 0x0400F4F4 RID: 62708
		public EFilterType item;
	}

	// Token: 0x02002F76 RID: 12150
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3025
	{
		// Token: 0x0600EFA8 RID: 61352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3192 foundFilter)
		{
			throw null;
		}

		// Token: 0x0400F4F5 RID: 62709
		public static readonly GClass3194.Class3025 class3025_0;

		// Token: 0x0400F4F6 RID: 62710
		public static Func<GClass3192, bool> func_0;
	}
}
