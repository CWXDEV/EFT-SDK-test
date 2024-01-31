using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.UI.Ragfair;

// Token: 0x0200195C RID: 6492
public sealed class GClass1859 : ISerializer<Offer>
{
	// Token: 0x06008B69 RID: 35689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Offer Deserialize()
	{
		throw null;
	}

	// Token: 0x06008B6A RID: 35690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(Offer t)
	{
		throw null;
	}

	// Token: 0x040090E0 RID: 37088
	public string _id;

	// Token: 0x040090E1 RID: 37089
	public long intId;

	// Token: 0x040090E2 RID: 37090
	public Offer.GClass3191 user;

	// Token: 0x040090E3 RID: 37091
	public GClass1186[] items;

	// Token: 0x040090E4 RID: 37092
	public string root;

	// Token: 0x040090E5 RID: 37093
	public int itemsCost;

	// Token: 0x040090E6 RID: 37094
	public int requirementsCost;

	// Token: 0x040090E7 RID: 37095
	public HandoverRequirement[] requirements;

	// Token: 0x040090E8 RID: 37096
	public double startTime;

	// Token: 0x040090E9 RID: 37097
	public double endTime;

	// Token: 0x040090EA RID: 37098
	public bool wasEdit;

	// Token: 0x040090EB RID: 37099
	public bool exchange;

	// Token: 0x040090EC RID: 37100
	public int loyaltyLevel;

	// Token: 0x040090ED RID: 37101
	public bool locked;

	// Token: 0x040090EE RID: 37102
	public bool unlimitedCount;

	// Token: 0x040090EF RID: 37103
	public int buyRestrictionMax;

	// Token: 0x040090F0 RID: 37104
	public int buyRestrictionCurrent;

	// Token: 0x040090F1 RID: 37105
	public bool sellInOnePiece;

	// Token: 0x040090F2 RID: 37106
	public int summaryCost;
}
