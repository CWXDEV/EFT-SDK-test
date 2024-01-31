using System;
using System.Runtime.CompilerServices;

namespace Diz.Binding
{
	// Token: 0x020030E4 RID: 12516
	public sealed class BindableEvent : GInterface386
	{
		// Token: 0x1400037A RID: 890
		// (add) Token: 0x0600F577 RID: 62839 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F578 RID: 62840 RVA: 0x00002050 File Offset: 0x00000250
		private event Action Event_0
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

		// Token: 0x0600F579 RID: 62841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Action Subscribe(Action handler)
		{
			throw null;
		}

		// Token: 0x0600F57A RID: 62842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Action Bind(Action handler)
		{
			throw null;
		}

		// Token: 0x0600F57B RID: 62843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Invoke()
		{
			throw null;
		}

		// Token: 0x0400FB3E RID: 64318
		[CompilerGenerated]
		private Action _onChange;

		// Token: 0x020030E5 RID: 12517
		[CompilerGenerated]
		private sealed class Class3158
		{
			// Token: 0x0600F57C RID: 62844 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400FB3F RID: 64319
			public BindableEvent bindableEvent_0;

			// Token: 0x0400FB40 RID: 64320
			public Action handler;
		}
	}
}
