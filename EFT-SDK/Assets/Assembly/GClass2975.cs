using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using JetBrains.Annotations;

// Token: 0x020027CB RID: 10187
public class GClass2975 : GClass2973
{
	// Token: 0x17002474 RID: 9332
	// (get) Token: 0x0600CC34 RID: 52276 RVA: 0x00002050 File Offset: 0x00000250
	public override ENodeStatus CurrentStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CC35 RID: 52277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSelected(bool value)
	{
		throw null;
	}

	// Token: 0x0600CC36 RID: 52278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetFilter([CanBeNull] IEnumerable<string> filters)
	{
		throw null;
	}

	// Token: 0x0600CC37 RID: 52279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IEnumerable<GClass2973> GetSelected()
	{
		throw null;
	}

	// Token: 0x0600CC38 RID: 52280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void GetSelectedLeavesNonAlloc(List<GClass2973> list)
	{
		throw null;
	}

	// Token: 0x0400CC44 RID: 52292
	public bool Open;

	// Token: 0x0400CC45 RID: 52293
	public GClass2973[] Children;

	// Token: 0x020027CC RID: 10188
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2304
	{
		// Token: 0x0600CC39 RID: 52281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2973 x)
		{
			throw null;
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass2973 x)
		{
			throw null;
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass2973> method_2(GClass2973 x)
		{
			throw null;
		}

		// Token: 0x0400CC46 RID: 52294
		public static readonly GClass2975.Class2304 class2304_0;

		// Token: 0x0400CC47 RID: 52295
		public static Func<GClass2973, bool> func_0;

		// Token: 0x0400CC48 RID: 52296
		public static Func<GClass2973, bool> func_1;

		// Token: 0x0400CC49 RID: 52297
		public static Func<GClass2973, IEnumerable<GClass2973>> func_2;
	}
}
