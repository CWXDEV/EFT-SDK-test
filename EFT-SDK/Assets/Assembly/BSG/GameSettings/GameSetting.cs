using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Diz.Binding;

namespace Bsg.GameSettings
{
	// Token: 0x02000CF1 RID: 3313
	[Serializable]
	public abstract class GameSetting<T> : IBindable<T>, IGameSetting
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x00002050 File Offset: 0x00000250
		public string Key
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060046BE RID: 18110 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAvailableToEdit
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

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060046C0 RID: 18112 RVA: 0x00002050 File Offset: 0x00000250
		public T Value
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

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060046C2 RID: 18114 RVA: 0x00002050 File Offset: 0x00000250
		object IGameSetting.ObjectValue
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

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x00002050 File Offset: 0x00000250
		Type IGameSetting.ObjectType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060046C4 RID: 18116
		public abstract T GetValue();

		// Token: 0x060046C5 RID: 18117
		public abstract Task SetValue(T value);

		// Token: 0x060046C6 RID: 18118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IGameSetting.HasSameValue(IGameSetting other)
		{
			throw null;
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IGameSetting.TakeValueFrom(IGameSetting other)
		{
			throw null;
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task<T> PreProcessValue(T value)
		{
			throw null;
		}

		// Token: 0x060046C9 RID: 18121
		public abstract bool HasSameValue(GameSetting<T> other);

		// Token: 0x060046CA RID: 18122
		public abstract void TakeValueFrom(GameSetting<T> other);

		// Token: 0x060046CB RID: 18123
		public abstract Action Bind(Action<T> handler);

		// Token: 0x060046CC RID: 18124
		public abstract Action Subscribe(Action<T> handler);

		// Token: 0x060046CD RID: 18125
		public abstract Action BindWithoutValue(GInterface389 handler);

		// Token: 0x060046CE RID: 18126
		public abstract void ResetToDefault();

		// Token: 0x060046CF RID: 18127
		public abstract void ForceApply();

		// Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040051BE RID: 20926
		protected static readonly Type SettingType;

		// Token: 0x040051BF RID: 20927
		protected static readonly bool IsNullable;

		// Token: 0x040051C2 RID: 20930
		private readonly Func<T, Task<T>> _asyncPreProcessor;

		// Token: 0x02000CF2 RID: 3314
		[CompilerGenerated]
		private sealed class Class670
		{
			// Token: 0x060046D1 RID: 18129 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task<T> method_0(T value)
			{
				throw null;
			}

			// Token: 0x040051C3 RID: 20931
			public Func<T, T> preProcessor;
		}
	}
}
