using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02001672 RID: 5746
public sealed class GClass1791
{
	// Token: 0x04008308 RID: 33544
	public MongoID TraderId;

	// Token: 0x04008309 RID: 33545
	public ETraderServiceType ServiceType;

	// Token: 0x0400830A RID: 33546
	public bool CanAfford;

	// Token: 0x0400830B RID: 33547
	public bool WasPurchasedInThisRaid;

	// Token: 0x0400830C RID: 33548
	public Dictionary<MongoID, int> ItemsToPay;

	// Token: 0x0400830D RID: 33549
	public MongoID[] UniqueItems;

	// Token: 0x0400830E RID: 33550
	public Dictionary<string, int> SubServices;

	// Token: 0x02001673 RID: 5747
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1183
	{
		// Token: 0x06007C9F RID: 31903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(BackendConfigSettingsClass.SubService subService)
		{
			throw null;
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(BackendConfigSettingsClass.SubService subService)
		{
			throw null;
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(BackendConfigSettingsClass.SubService subService)
		{
			throw null;
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_3(BackendConfigSettingsClass.SubService subService)
		{
			throw null;
		}

		// Token: 0x0400830F RID: 33551
		public static readonly GClass1791.Class1183 class1183_0;

		// Token: 0x04008310 RID: 33552
		public static Func<BackendConfigSettingsClass.SubService, string> func_0;

		// Token: 0x04008311 RID: 33553
		public static Func<BackendConfigSettingsClass.SubService, int> func_1;

		// Token: 0x04008312 RID: 33554
		public static Func<BackendConfigSettingsClass.SubService, string> func_2;

		// Token: 0x04008313 RID: 33555
		public static Func<BackendConfigSettingsClass.SubService, int> func_3;
	}
}
