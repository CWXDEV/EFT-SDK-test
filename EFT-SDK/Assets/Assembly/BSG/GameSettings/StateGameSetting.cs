using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Bsg.GameSettings
{
	// Token: 0x02000CF3 RID: 3315
	[Serializable]
	public class StateGameSetting<T> : GameSetting<T>
	{
		// Token: 0x060046D2 RID: 18130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override T GetValue()
		{
			throw null;
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task SetValue(T value)
		{
			throw null;
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(T defaultValue)
		{
			throw null;
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool HasSameValue(GameSetting<T> other)
		{
			throw null;
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TakeValueFrom(GameSetting<T> other)
		{
			throw null;
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action Bind(Action<T> handler)
		{
			throw null;
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action Subscribe(Action<T> handler)
		{
			throw null;
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action BindWithoutValue(GInterface389 handler)
		{
			throw null;
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public sealed override void ResetToDefault()
		{
			throw null;
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ForceApply()
		{
			throw null;
		}

		// Token: 0x040051C4 RID: 20932
		private readonly BindableState<T> _internalState;

		// Token: 0x040051C5 RID: 20933
		private T _defaultValue;
	}
}
