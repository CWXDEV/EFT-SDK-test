using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E00 RID: 7680
public abstract class GClass2108 : GInterface184
{
	// Token: 0x170018F6 RID: 6390
	// (get) Token: 0x06009E1E RID: 40478 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009E1F RID: 40479 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2106.GClass2107[] Timings
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

	// Token: 0x170018F7 RID: 6391
	// (get) Token: 0x06009E20 RID: 40480 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009E21 RID: 40481 RVA: 0x00002050 File Offset: 0x00000250
	public bool Stopped
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

	// Token: 0x170018F8 RID: 6392
	// (get) Token: 0x06009E22 RID: 40482 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009E23 RID: 40483 RVA: 0x00002050 File Offset: 0x00000250
	public bool Paused
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06009E24 RID: 40484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06009E25 RID: 40485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x06009E26 RID: 40486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06009E27 RID: 40487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(uint value)
	{
		throw null;
	}

	// Token: 0x06009E28 RID: 40488
	protected abstract uint GetCurrentValue();

	// Token: 0x170018F9 RID: 6393
	// (get) Token: 0x06009E29 RID: 40489
	public abstract string Name { get; }

	// Token: 0x06009E2A RID: 40490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int smethod_0(uint[] keys, uint value)
	{
		throw null;
	}

	// Token: 0x06009E2B RID: 40491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GClass2106.GClass2107[] GetTimings()
	{
		throw null;
	}

	// Token: 0x0400A667 RID: 42599
	private readonly uint[] uint_0;

	// Token: 0x0400A668 RID: 42600
	protected ulong[] ulong_0;

	// Token: 0x0400A669 RID: 42601
	[CompilerGenerated]
	private GClass2106.GClass2107[] gclass2107_0;

	// Token: 0x0400A66A RID: 42602
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400A66B RID: 42603
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x02001E01 RID: 7681
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1800
	{
		// Token: 0x06009E2C RID: 40492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(uint value)
		{
			throw null;
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal uint method_1(uint key)
		{
			throw null;
		}

		// Token: 0x0400A66C RID: 42604
		public static readonly GClass2108.Class1800 class1800_0;

		// Token: 0x0400A66D RID: 42605
		public static Func<uint, bool> func_0;

		// Token: 0x0400A66E RID: 42606
		public static Func<uint, uint> func_1;
	}
}
