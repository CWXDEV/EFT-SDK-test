using System;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FE5 RID: 12261
	public sealed class ConditionFindItem : ConditionItem
	{
		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600F1E9 RID: 61929 RVA: 0x00002050 File Offset: 0x00000250
		public bool TargetIsCategory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600F1EA RID: 61930 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400F7EB RID: 63467
		public bool countInRaid;

		// Token: 0x0400F7EC RID: 63468
		private bool? _targetIsCategory;

		// Token: 0x02002FE6 RID: 12262
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3064
		{
			// Token: 0x0400F7ED RID: 63469
			public static readonly ConditionFindItem.Class3064 class3064_0;

			// Token: 0x0400F7EE RID: 63470
			public static Func<string, bool> func_0;

			// Token: 0x0400F7EF RID: 63471
			public static Func<string, string> func_1;
		}
	}
}
