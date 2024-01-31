using System;
using System.Collections.Generic;

namespace ChartAndGraph
{
	// Token: 0x0200317B RID: 12667
	internal interface IInternalGraphData
	{
		// Token: 0x0600F978 RID: 63864
		double GetMinValue(int axis, bool dataValue);

		// Token: 0x0600F979 RID: 63865
		double GetMaxValue(int axis, bool dataValue);

		// Token: 0x0600F97A RID: 63866
		void OnBeforeSerialize();

		// Token: 0x0600F97B RID: 63867
		void OnAfterDeserialize();

		// Token: 0x0600F97C RID: 63868
		void Update();

		// Token: 0x140003AC RID: 940
		// (add) Token: 0x0600F97D RID: 63869
		// (remove) Token: 0x0600F97E RID: 63870
		event EventHandler InternalDataChanged;

		// Token: 0x140003AD RID: 941
		// (add) Token: 0x0600F97F RID: 63871
		// (remove) Token: 0x0600F980 RID: 63872
		event EventHandler InternalRealTimeDataChanged;

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x0600F981 RID: 63873
		int TotalCategories { get; }

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600F982 RID: 63874
		IEnumerable<GraphData.CategoryData> Categories { get; }
	}
}
