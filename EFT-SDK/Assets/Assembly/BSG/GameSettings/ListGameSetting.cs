using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Bsg.GameSettings
{
	// Token: 0x02000CF8 RID: 3320
	[Serializable]
	public sealed class ListGameSetting<TType> : GameSetting<List<TType>>
	{
		// Token: 0x060046EA RID: 18154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override List<TType> GetValue()
		{
			throw null;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task SetValue(List<TType> value)
		{
			throw null;
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool HasSameValue(GameSetting<List<TType>> other)
		{
			throw null;
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void TakeValueFrom(GameSetting<List<TType>> other)
		{
			throw null;
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action Bind(Action<List<TType>> handler)
		{
			throw null;
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action Subscribe(Action<List<TType>> handler)
		{
			throw null;
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Action BindWithoutValue(GInterface389 handler)
		{
			throw null;
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ResetToDefault()
		{
			throw null;
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ForceApply()
		{
			throw null;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TType[] ToArray()
		{
			throw null;
		}

		// Token: 0x040051D1 RID: 20945
		private readonly GClass3355<List<TType>> _onListChanged;

		// Token: 0x040051D2 RID: 20946
		private readonly ListGameSetting<TType>.GDelegate27 _equalityCheck;

		// Token: 0x040051D3 RID: 20947
		private readonly ListGameSetting<TType>.GDelegate28 _copyItem;

		// Token: 0x040051D4 RID: 20948
		private List<TType> _value;

		// Token: 0x02000CF9 RID: 3321
		// (Invoke) Token: 0x060046F4 RID: 18164
		public delegate bool GDelegate27(TType x, TType y);

		// Token: 0x02000CFA RID: 3322
		// (Invoke) Token: 0x060046F7 RID: 18167
		public delegate TType GDelegate28(TType item);

		// Token: 0x02000CFB RID: 3323
		[CompilerGenerated]
		[Serializable]
		private sealed class Class672
		{
			// Token: 0x060046FA RID: 18170 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TType method_0(TType item)
			{
				throw null;
			}

			// Token: 0x040051D5 RID: 20949
			public static readonly ListGameSetting<TType>.Class672 class672_0;

			// Token: 0x040051D6 RID: 20950
			public static ListGameSetting<TType>.GDelegate28 gdelegate28_0;
		}
	}
}
