using System;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x0200317A RID: 12666
	public interface IInternalUse
	{
		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600F95B RID: 63835
		// (set) Token: 0x0600F95C RID: 63836
		CategoryLabels CategoryLabels { get; set; }

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600F95D RID: 63837
		// (set) Token: 0x0600F95E RID: 63838
		ItemLabels ItemLabels { get; set; }

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600F95F RID: 63839
		// (set) Token: 0x0600F960 RID: 63840
		GroupLabels GroupLabels { get; set; }

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600F961 RID: 63841
		// (set) Token: 0x0600F962 RID: 63842
		HorizontalAxis HorizontalAxis { get; set; }

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600F963 RID: 63843
		// (set) Token: 0x0600F964 RID: 63844
		VerticalAxis VerticalAxis { get; set; }

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600F965 RID: 63845
		Camera InternalTextCamera { get; }

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600F966 RID: 63846
		float InternalTextIdleDistance { get; }

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x0600F967 RID: 63847
		TextController InternalTextController { get; }

		// Token: 0x0600F968 RID: 63848
		bool InternalHasValues(AxisBase axis);

		// Token: 0x0600F969 RID: 63849
		double InternalMaxValue(AxisBase axis);

		// Token: 0x0600F96A RID: 63850
		double InternalMinValue(AxisBase axis);

		// Token: 0x0600F96B RID: 63851
		void InternalItemSelected(object userData);

		// Token: 0x0600F96C RID: 63852
		void InternalItemLeave(object userData);

		// Token: 0x0600F96D RID: 63853
		void InternalItemHovered(object userData);

		// Token: 0x0600F96E RID: 63854
		void CallOnValidate();

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x0600F96F RID: 63855
		float InternalTotalWidth { get; }

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x0600F970 RID: 63856
		float InternalTotalDepth { get; }

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600F971 RID: 63857
		float InternalTotalHeight { get; }

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600F972 RID: 63858
		bool InternalSupportsItemLabels { get; }

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600F973 RID: 63859
		bool InternalSupportsCategoryLables { get; }

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600F974 RID: 63860
		bool InternalSupportsGroupLabels { get; }

		// Token: 0x140003AB RID: 939
		// (add) Token: 0x0600F975 RID: 63861
		// (remove) Token: 0x0600F976 RID: 63862
		event Action Generated;

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x0600F977 RID: 63863
		bool HideHierarchy { get; }
	}
}
