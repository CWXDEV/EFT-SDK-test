using System;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FF0 RID: 12272
	public sealed class ConditionInZone : Condition
	{
		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x0600F1F2 RID: 61938 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GenerateFormattedDescription()
		{
			throw null;
		}

		// Token: 0x0400F813 RID: 63507
		public string[] zoneIds;

		// Token: 0x02002FF1 RID: 12273
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3067
		{
			// Token: 0x0400F814 RID: 63508
			public static readonly ConditionInZone.Class3067 class3067_0;

			// Token: 0x0400F815 RID: 63509
			public static Func<string, string> func_0;
		}
	}
}
