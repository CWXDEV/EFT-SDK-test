using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Token: 0x02001F1E RID: 7966
public class GClass2211
{
	// Token: 0x14000227 RID: 551
	// (add) Token: 0x0600A4D0 RID: 42192 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600A4D1 RID: 42193 RVA: 0x00002050 File Offset: 0x00000250
	private event Func<bool> Event_0
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

	// Token: 0x14000228 RID: 552
	// (add) Token: 0x0600A4D2 RID: 42194 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600A4D3 RID: 42195 RVA: 0x00002050 File Offset: 0x00000250
	private event Action Event_1
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

	// Token: 0x0600A4D4 RID: 42196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RunTaskChecker()
	{
		throw null;
	}

	// Token: 0x0600A4D5 RID: 42197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceCreateCommand()
	{
		throw null;
	}

	// Token: 0x0600A4D6 RID: 42198 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600A4D7 RID: 42199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChecker<T>(Func<T> floatGetter) where T : IComparable
	{
		throw null;
	}

	// Token: 0x0600A4D8 RID: 42200 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddFloatChecker(Func<float> floatGetter)
	{
		throw null;
	}

	// Token: 0x0600A4D9 RID: 42201 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBoolChecker(Func<bool> boolGetter)
	{
		throw null;
	}

	// Token: 0x0600A4DA RID: 42202 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEnumChecker<T>(Func<T> boolGetter) where T : struct, Enum
	{
		throw null;
	}

	// Token: 0x0600A4DB RID: 42203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualCheck()
	{
		throw null;
	}

	// Token: 0x0600A4DC RID: 42204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0()
	{
		throw null;
	}

	// Token: 0x0600A4DD RID: 42205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator StartCommandCheckerCoroutine()
	{
		throw null;
	}

	// Token: 0x0600A4DE RID: 42206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x0400AC90 RID: 44176
	[CompilerGenerated]
	private Func<bool> func_0;

	// Token: 0x0400AC91 RID: 44177
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400AC92 RID: 44178
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400AC93 RID: 44179
	private List<GClass2211.GInterface216> list_0;

	// Token: 0x02001F1F RID: 7967
	public interface GInterface216
	{
		// Token: 0x0600A4DF RID: 42207
		bool IsChanged();
	}

	// Token: 0x02001F20 RID: 7968
	public class GClass2212<T> : GClass2211.GInterface216 where T : IComparable
	{
		// Token: 0x0600A4E0 RID: 42208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChanged()
		{
			throw null;
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool CompareValues()
		{
			throw null;
		}

		// Token: 0x0400AC94 RID: 44180
		private T gparam_0;

		// Token: 0x0400AC95 RID: 44181
		private T gparam_1;

		// Token: 0x0400AC96 RID: 44182
		private Func<T> func_0;
	}

	// Token: 0x02001F21 RID: 7969
	public class GClass2213 : GClass2211.GInterface216
	{
		// Token: 0x0600A4E2 RID: 42210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChanged()
		{
			throw null;
		}

		// Token: 0x0400AC97 RID: 44183
		private float float_0;

		// Token: 0x0400AC98 RID: 44184
		private float float_1;

		// Token: 0x0400AC99 RID: 44185
		private Func<float> func_0;
	}

	// Token: 0x02001F22 RID: 7970
	public class GClass2214 : GClass2211.GInterface216
	{
		// Token: 0x0600A4E3 RID: 42211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChanged()
		{
			throw null;
		}

		// Token: 0x0400AC9A RID: 44186
		private bool bool_0;

		// Token: 0x0400AC9B RID: 44187
		private bool bool_1;

		// Token: 0x0400AC9C RID: 44188
		private Func<bool> func_0;
	}

	// Token: 0x02001F23 RID: 7971
	public class GClass2215<T> : GClass2211.GInterface216 where T : struct, Enum
	{
		// Token: 0x0600A4E4 RID: 42212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChanged()
		{
			throw null;
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool CompareValues()
		{
			throw null;
		}

		// Token: 0x0400AC9D RID: 44189
		private T gparam_0;

		// Token: 0x0400AC9E RID: 44190
		private T gparam_1;

		// Token: 0x0400AC9F RID: 44191
		private Func<T> func_0;
	}
}
