using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;

// Token: 0x02000CF6 RID: 3318
public sealed class GClass949<T, U> : GameSetting<U>
{
	// Token: 0x060046DF RID: 18143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override U GetValue()
	{
		throw null;
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task SetValue(U value)
	{
		throw null;
	}

	// Token: 0x060046E1 RID: 18145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TakeValueFrom(GameSetting<U> other)
	{
		throw null;
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Action Bind(Action<U> handler)
	{
		throw null;
	}

	// Token: 0x060046E3 RID: 18147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Action Subscribe(Action<U> handler)
	{
		throw null;
	}

	// Token: 0x060046E4 RID: 18148 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Action BindWithoutValue(GInterface389 handler)
	{
		throw null;
	}

	// Token: 0x060046E5 RID: 18149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetToDefault()
	{
		throw null;
	}

	// Token: 0x060046E6 RID: 18150 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ForceApply()
	{
		throw null;
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool HasSameValue(GameSetting<U> other)
	{
		throw null;
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Action<T> method_0(Action<U> handler)
	{
		throw null;
	}

	// Token: 0x040051CC RID: 20940
	private readonly Func<T, U> func_0;

	// Token: 0x040051CD RID: 20941
	private readonly Func<U, Task> func_1;

	// Token: 0x040051CE RID: 20942
	private readonly GameSetting<T> gameSetting_0;

	// Token: 0x02000CF7 RID: 3319
	[CompilerGenerated]
	private sealed class Class671
	{
		// Token: 0x060046E9 RID: 18153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(T baseValue)
		{
			throw null;
		}

		// Token: 0x040051CF RID: 20943
		public GClass949<T, U> gclass949_0;

		// Token: 0x040051D0 RID: 20944
		public Action<U> handler;
	}
}
