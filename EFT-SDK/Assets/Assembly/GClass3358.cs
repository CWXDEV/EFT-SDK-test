using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x02001040 RID: 4160
public abstract class GClass3358<T> : GClass3357<T> where T : GInterface381
{
	// Token: 0x060056ED RID: 22253
	public abstract void LoadAll();

	// Token: 0x060056EE RID: 22254
	public abstract void RemoveConditionalsWithoutTemplate();

	// Token: 0x060056EF RID: 22255 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface381 GetConditional(string id)
	{
		throw null;
	}

	// Token: 0x060056F0 RID: 22256 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface381 GetConditional(int id)
	{
		throw null;
	}

	// Token: 0x060056F1 RID: 22257 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetNullableConditions()
	{
		throw null;
	}

	// Token: 0x060056F2 RID: 22258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TestConditions(int valueToAdd, params GStruct403[] checks)
	{
		throw null;
	}

	// Token: 0x040062D3 RID: 25299
	protected readonly string string_0;

	// Token: 0x040062D4 RID: 25300
	protected readonly EPlayerSide eplayerSide_0;

	// Token: 0x040062D5 RID: 25301
	protected readonly Dictionary<string, GClass3218> dictionary_0;

	// Token: 0x02001041 RID: 4161
	[CompilerGenerated]
	private sealed class Class797
	{
		// Token: 0x060056F3 RID: 22259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T conditional)
		{
			throw null;
		}

		// Token: 0x040062D6 RID: 25302
		public string id;
	}

	// Token: 0x02001042 RID: 4162
	[CompilerGenerated]
	private sealed class Class798
	{
		// Token: 0x060056F4 RID: 22260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T conditional)
		{
			throw null;
		}

		// Token: 0x040062D7 RID: 25303
		public int id;
	}
}
