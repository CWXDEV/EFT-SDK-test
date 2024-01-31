using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B72 RID: 7026
	public sealed class BonusesPanel : AbstractPanel<List<GClass1404>>
	{
		// Token: 0x06009400 RID: 37888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task Show(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x06009401 RID: 37889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x04009AB0 RID: 39600
		private const string string_0 = "CURRENT BONUSES:";

		// Token: 0x04009AB1 RID: 39601
		private const string string_1 = "FUTURE BONUSES:";

		// Token: 0x04009AB2 RID: 39602
		private const string string_2 = "CURRENT NEGATIV BONUSES:";

		// Token: 0x04009AB3 RID: 39603
		private const string string_3 = "FUTURE NEGATIV BONUSES:";

		// Token: 0x04009AB4 RID: 39604
		private static readonly IReadOnlyDictionary<ELevelType, string> ireadOnlyDictionary_0;

		// Token: 0x04009AB5 RID: 39605
		private static readonly IReadOnlyDictionary<ELevelType, string> ireadOnlyDictionary_1;

		// Token: 0x04009AB6 RID: 39606
		[SerializeField]
		private GroupBonusPanel _positiveBonusesPanel;

		// Token: 0x04009AB7 RID: 39607
		[SerializeField]
		private GroupBonusPanel _negativeBonusesPanel;

		// Token: 0x02001B74 RID: 7028
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1663
		{
			// Token: 0x06009407 RID: 37895 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1404 b)
			{
				throw null;
			}

			// Token: 0x06009408 RID: 37896 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass1908 v)
			{
				throw null;
			}

			// Token: 0x06009409 RID: 37897 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1404[] method_2(GClass1908 v)
			{
				throw null;
			}

			// Token: 0x0600940A RID: 37898 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(GClass1404 b)
			{
				throw null;
			}

			// Token: 0x0600940B RID: 37899 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(GClass1404 v)
			{
				throw null;
			}

			// Token: 0x0600940C RID: 37900 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(GClass1404 x)
			{
				throw null;
			}

			// Token: 0x0600940D RID: 37901 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(GClass1404 x)
			{
				throw null;
			}

			// Token: 0x04009AC2 RID: 39618
			public static readonly BonusesPanel.Class1663 class1663_0;

			// Token: 0x04009AC3 RID: 39619
			public static Func<GClass1404, bool> func_0;

			// Token: 0x04009AC4 RID: 39620
			public static Func<GClass1908, bool> func_1;

			// Token: 0x04009AC5 RID: 39621
			public static Func<GClass1908, GClass1404[]> func_2;

			// Token: 0x04009AC6 RID: 39622
			public static Func<GClass1404, bool> func_3;

			// Token: 0x04009AC7 RID: 39623
			public static Func<GClass1404, bool> func_4;

			// Token: 0x04009AC8 RID: 39624
			public static Func<GClass1404, bool> func_5;

			// Token: 0x04009AC9 RID: 39625
			public static Func<GClass1404, bool> func_6;
		}
	}
}
