using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.Quests
{
	// Token: 0x02002FDB RID: 12251
	[Serializable]
	public sealed class ConditionCounterManager
	{
		// Token: 0x0600F1D8 RID: 61912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadConditionCounters()
		{
			throw null;
		}

		// Token: 0x0600F1D9 RID: 61913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(IEnumerable<ConditionCounterCreator> templates)
		{
			throw null;
		}

		// Token: 0x0600F1DA RID: 61914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600F1DB RID: 61915 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3218 GetCounter(string id)
		{
			throw null;
		}

		// Token: 0x0600F1DC RID: 61916 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3218 method_1(GStruct403[] checks)
		{
			throw null;
		}

		// Token: 0x0600F1DD RID: 61917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Test(int valueToAdd, params GStruct403[] checks)
		{
			throw null;
		}

		// Token: 0x0600F1DE RID: 61918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(int valueToAdd, GClass3218 counter, GStruct403[] checks)
		{
			throw null;
		}

		// Token: 0x0600F1DF RID: 61919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetNullableConditions()
		{
			throw null;
		}

		// Token: 0x0400F7D9 RID: 63449
		private readonly GInterface381 _conditional;

		// Token: 0x0400F7DA RID: 63450
		private readonly Dictionary<string, GClass3218> _profileCounters;

		// Token: 0x0400F7DB RID: 63451
		private readonly List<GClass3218> _counters;

		// Token: 0x02002FDC RID: 12252
		[CompilerGenerated]
		private sealed class Class3060
		{
			// Token: 0x0600F1E0 RID: 61920 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass3218 x)
			{
				throw null;
			}

			// Token: 0x0400F7DC RID: 63452
			public GClass3218 counter;
		}

		// Token: 0x02002FDD RID: 12253
		[CompilerGenerated]
		private sealed class Class3061
		{
			// Token: 0x0600F1E1 RID: 61921 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass3218 counter)
			{
				throw null;
			}

			// Token: 0x0400F7DD RID: 63453
			public string id;
		}

		// Token: 0x02002FDE RID: 12254
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3062
		{
			// Token: 0x0600F1E2 RID: 61922 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass3218 x)
			{
				throw null;
			}

			// Token: 0x0400F7DE RID: 63454
			public static readonly ConditionCounterManager.Class3062 class3062_0;

			// Token: 0x0400F7DF RID: 63455
			public static Func<GClass3218, bool> func_0;
		}
	}
}
