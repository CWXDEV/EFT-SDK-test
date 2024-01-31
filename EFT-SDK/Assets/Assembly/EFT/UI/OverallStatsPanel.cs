using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B2E RID: 11054
	public class OverallStatsPanel : UIElement
	{
		// Token: 0x0600DB17 RID: 56087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ISession session)
		{
			throw null;
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(SessionCountersClass pmcStats, SessionCountersClass scavStats, SessionCountersClass overallStats, int regDate, long totalTime)
		{
			throw null;
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleChangedHandler(OverallStatsPanel.EStatType statType, bool value)
		{
			throw null;
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(SessionCountersClass counters)
		{
			throw null;
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(long seconds)
		{
			throw null;
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400DE8A RID: 56970
		[SerializeField]
		private CustomTextMeshProUGUI _raidsLabel;

		// Token: 0x0400DE8B RID: 56971
		[SerializeField]
		private CustomTextMeshProUGUI _runsLabel;

		// Token: 0x0400DE8C RID: 56972
		[SerializeField]
		private CustomTextMeshProUGUI _survivedLabel;

		// Token: 0x0400DE8D RID: 56973
		[SerializeField]
		private CustomTextMeshProUGUI _survivalRate;

		// Token: 0x0400DE8E RID: 56974
		[SerializeField]
		private CustomTextMeshProUGUI _kiaLabel;

		// Token: 0x0400DE8F RID: 56975
		[SerializeField]
		private CustomTextMeshProUGUI _averageLifetimeLabel;

		// Token: 0x0400DE90 RID: 56976
		[SerializeField]
		private CustomTextMeshProUGUI _miaLabel;

		// Token: 0x0400DE91 RID: 56977
		[SerializeField]
		private CustomTextMeshProUGUI _rowSLabel;

		// Token: 0x0400DE92 RID: 56978
		[SerializeField]
		private CustomTextMeshProUGUI _awolLabel;

		// Token: 0x0400DE93 RID: 56979
		[SerializeField]
		private CustomTextMeshProUGUI _leaveRateLabel;

		// Token: 0x0400DE94 RID: 56980
		[SerializeField]
		private CustomTextMeshProUGUI _killsLabel;

		// Token: 0x0400DE95 RID: 56981
		[SerializeField]
		private CustomTextMeshProUGUI _kdRatioLabel;

		// Token: 0x0400DE96 RID: 56982
		[SerializeField]
		private LocalizedText _onlineTimeLabel;

		// Token: 0x0400DE97 RID: 56983
		[SerializeField]
		private LocalizedText _overallLifetimeLabel;

		// Token: 0x0400DE98 RID: 56984
		private SessionCountersClass gclass2198_0;

		// Token: 0x0400DE99 RID: 56985
		private SessionCountersClass gclass2198_1;

		// Token: 0x0400DE9A RID: 56986
		private SessionCountersClass gclass2198_2;

		// Token: 0x0400DE9B RID: 56987
		private int int_0;

		// Token: 0x0400DE9C RID: 56988
		private long long_0;

		// Token: 0x02002B2F RID: 11055
		public enum EStatType
		{
			// Token: 0x0400DE9E RID: 56990
			Overall,
			// Token: 0x0400DE9F RID: 56991
			Pmc,
			// Token: 0x0400DEA0 RID: 56992
			Scav,
			// Token: 0x0400DEA1 RID: 56993
			Arena
		}

		// Token: 0x02002B30 RID: 11056
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2601
		{
			// Token: 0x0600DB1D RID: 56093 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Profile p)
			{
				throw null;
			}

			// Token: 0x0600DB1E RID: 56094 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Profile p)
			{
				throw null;
			}

			// Token: 0x0400DEA2 RID: 56994
			public static readonly OverallStatsPanel.Class2601 class2601_0;

			// Token: 0x0400DEA3 RID: 56995
			public static Func<Profile, bool> func_0;

			// Token: 0x0400DEA4 RID: 56996
			public static Func<Profile, bool> func_1;
		}
	}
}
