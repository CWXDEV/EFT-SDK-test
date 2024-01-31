using System;
using System.Runtime.InteropServices;

// Token: 0x020014D5 RID: 5333
public static class GClass1646
{
	// Token: 0x040078BB RID: 30907
	public static GClass1646.GStruct135 DefaultOptions;

	// Token: 0x040078BC RID: 30908
	public static readonly int DefaultRemoteFramerate;

	// Token: 0x020014D6 RID: 5334
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct135
	{
		// Token: 0x040078BD RID: 30909
		public float DynamicAdjustmentTolerance;

		// Token: 0x040078BE RID: 30910
		public int DeliveryTimeEmaDuration;

		// Token: 0x040078BF RID: 30911
		public float CatchupNegativeThreshold;

		// Token: 0x040078C0 RID: 30912
		public float CatchupPositiveThreshold;

		// Token: 0x040078C1 RID: 30913
		public double CatchupSpeed;

		// Token: 0x040078C2 RID: 30914
		public double SlowdownSpeed;
	}
}
