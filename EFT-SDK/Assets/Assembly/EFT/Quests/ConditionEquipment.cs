using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FDF RID: 12255
	public sealed class ConditionEquipment : Condition
	{
		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600F1E3 RID: 61923 RVA: 0x00002050 File Offset: 0x00000250
		public bool TargetIsCategory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600F1E4 RID: 61924 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400F7E0 RID: 63456
		public bool IncludeNotEquippedItems;

		// Token: 0x0400F7E1 RID: 63457
		public string[][] equipmentInclusive;

		// Token: 0x0400F7E2 RID: 63458
		public string[][] equipmentExclusive;

		// Token: 0x0400F7E3 RID: 63459
		private bool? _targetIsCategory;

		// Token: 0x02002FE0 RID: 12256
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3063
		{
			// Token: 0x0400F7E4 RID: 63460
			public static readonly ConditionEquipment.Class3063 class3063_0;

			// Token: 0x0400F7E5 RID: 63461
			public static Func<string, bool> func_0;

			// Token: 0x0400F7E6 RID: 63462
			public static Func<string[], bool> func_1;

			// Token: 0x0400F7E7 RID: 63463
			public static Func<string[], IEnumerable<string>> func_2;

			// Token: 0x0400F7E8 RID: 63464
			public static Func<string, string> func_3;
		}
	}
}
