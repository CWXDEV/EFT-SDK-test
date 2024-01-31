using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;

// Token: 0x02000459 RID: 1113
public class BotEatDrinkData : GClass362
{
	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x00002050 File Offset: 0x00000250
	public bool Using
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartDo(GClass346 closest)
	{
		throw null;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveEat()
	{
		throw null;
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Apply(int? varianAnim = null, Action callback = null)
	{
		throw null;
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActions()
	{
		throw null;
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040016F7 RID: 5879
	private const float START_TIME_OFFSET = 90f;

	// Token: 0x040016F8 RID: 5880
	private Action<bool> _callback;

	// Token: 0x040016F9 RID: 5881
	private readonly List<FoodClass> _itemsToUse;

	// Token: 0x040016FA RID: 5882
	private float _nextPossibleUseTime;

	// Token: 0x040016FB RID: 5883
	private bool _using;

	// Token: 0x040016FC RID: 5884
	private bool _haveItems;

	// Token: 0x040016FD RID: 5885
	private FoodClass _foodToUse;

	// Token: 0x040016FE RID: 5886
	private IPlayer _lookTo;

	// Token: 0x040016FF RID: 5887
	private bool _shallStart;

	// Token: 0x0200045A RID: 1114
	[CompilerGenerated]
	private sealed class Class224
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GInterface130> hands)
		{
			throw null;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(Result<GInterface135> applyResult)
		{
			throw null;
		}

		// Token: 0x04001700 RID: 5888
		public Action callback;

		// Token: 0x04001701 RID: 5889
		public BotEatDrinkData botEatDrinkData_0;

		// Token: 0x04001702 RID: 5890
		public Callback<GInterface135> callback_0;
	}
}
