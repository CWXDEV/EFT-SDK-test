using System;

namespace ChartAndGraph
{
	// Token: 0x0200317C RID: 12668
	public interface IInternalSettings
	{
		// Token: 0x140003AE RID: 942
		// (add) Token: 0x0600F983 RID: 63875
		// (remove) Token: 0x0600F984 RID: 63876
		event EventHandler InternalOnDataUpdate;

		// Token: 0x140003AF RID: 943
		// (add) Token: 0x0600F985 RID: 63877
		// (remove) Token: 0x0600F986 RID: 63878
		event EventHandler InternalOnDataChanged;
	}
}
