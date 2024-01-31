using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.UI;
using EFT.UI.Ragfair;

// Token: 0x02002F97 RID: 12183
public sealed class GClass3197 : GClass3196
{
	// Token: 0x17002937 RID: 10551
	// (get) Token: 0x0600F05F RID: 61535 RVA: 0x00002050 File Offset: 0x00000250
	public override ERagFairOfferDataType DataType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400F5F3 RID: 62963
	public GClass2881 Handbook;

	// Token: 0x0400F5F4 RID: 62964
	public string ProfileId;

	// Token: 0x0400F5F5 RID: 62965
	public Offer Offer;

	// Token: 0x0400F5F6 RID: 62966
	public Profile.TraderInfo TraderInfo;

	// Token: 0x0400F5F7 RID: 62967
	public ItemUiContext ItemUiContext;

	// Token: 0x0400F5F8 RID: 62968
	public RagFairClass Ragfair;

	// Token: 0x0400F5F9 RID: 62969
	public InventoryControllerClass InventoryController;

	// Token: 0x0400F5FA RID: 62970
	public InsuranceCompanyClass InsuranceCompany;

	// Token: 0x0400F5FB RID: 62971
	public GClass1839 SocialNetwork;

	// Token: 0x0400F5FC RID: 62972
	public Action<Offer, Action> OnRenew;

	// Token: 0x0400F5FD RID: 62973
	public Action<bool, Dictionary<GInterface151, int>> OnPurchase;

	// Token: 0x0400F5FE RID: 62974
	public Action<Offer> OnExpired;

	// Token: 0x0400F5FF RID: 62975
	public Action<Offer, Action> OnRemove;
}
