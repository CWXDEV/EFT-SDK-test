using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using Newtonsoft.Json;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F56 RID: 12118
	public sealed class Offer : GInterface151
	{
		// Token: 0x0600EF11 RID: 61201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Offer CreateUnavailableOffer(string templateId)
		{
			throw null;
		}

		// Token: 0x14000360 RID: 864
		// (add) Token: 0x0600EF12 RID: 61202 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600EF13 RID: 61203 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Offer, bool> OnSelectToPurchase
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600EF14 RID: 61204 RVA: 0x00002050 File Offset: 0x00000250
		public int TotalItemCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600EF15 RID: 61205 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool OnlyMoney
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600EF16 RID: 61206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF17 RID: 61207 RVA: 0x00002050 File Offset: 0x00000250
		public string Id
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x0600EF18 RID: 61208 RVA: 0x00002050 File Offset: 0x00000250
		public EMemberCategory MemberType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600EF19 RID: 61209 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF1A RID: 61210 RVA: 0x00002050 File Offset: 0x00000250
		public Item Item
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x0600EF1B RID: 61211 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF1C RID: 61212 RVA: 0x00002050 File Offset: 0x00000250
		public IExchangeRequirement[] Requirements
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x0600EF1D RID: 61213 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF1E RID: 61214 RVA: 0x00002050 File Offset: 0x00000250
		public bool SellInOnePiece
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600EF1F RID: 61215 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF20 RID: 61216 RVA: 0x00002050 File Offset: 0x00000250
		public DateTime EndTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600EF21 RID: 61217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF22 RID: 61218 RVA: 0x00002050 File Offset: 0x00000250
		public int BuyRestrictionMax
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600EF23 RID: 61219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF24 RID: 61220 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public int BuyRestrictionCurrent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x0600EF25 RID: 61221 RVA: 0x00002050 File Offset: 0x00000250
		public bool Expired
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x0600EF26 RID: 61222 RVA: 0x00002050 File Offset: 0x00000250
		public bool LimitsReached
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x0600EF27 RID: 61223 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanBeBought
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x0600EF28 RID: 61224 RVA: 0x00002050 File Offset: 0x00000250
		public int RenewPercent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002901 RID: 10497
		// (get) Token: 0x0600EF29 RID: 61225 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentItemCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002902 RID: 10498
		// (get) Token: 0x0600EF2A RID: 61226 RVA: 0x00002050 File Offset: 0x00000250
		public ECurrencyType MoneyType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600EF2B RID: 61227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EF2C RID: 61228 RVA: 0x00002050 File Offset: 0x00000250
		public bool AvailableTimePassed
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600EF2D RID: 61229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectToPurchase()
		{
			throw null;
		}

		// Token: 0x0600EF2E RID: 61230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectFromPurchase()
		{
			throw null;
		}

		// Token: 0x0600EF2F RID: 61231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400F452 RID: 62546
		private const int RENEW_MODIFIER = 25;

		// Token: 0x0400F454 RID: 62548
		public long IntId;

		// Token: 0x0400F455 RID: 62549
		public int ItemsCost;

		// Token: 0x0400F456 RID: 62550
		public int RequirementsCost;

		// Token: 0x0400F457 RID: 62551
		public DateTime StartTime;

		// Token: 0x0400F458 RID: 62552
		public string Name;

		// Token: 0x0400F459 RID: 62553
		public string ShortName;

		// Token: 0x0400F45A RID: 62554
		public int LoyaltyLevel;

		// Token: 0x0400F45B RID: 62555
		public bool Locked;

		// Token: 0x0400F45C RID: 62556
		public bool UnlimitedCount;

		// Token: 0x0400F45D RID: 62557
		public int SummaryCost;

		// Token: 0x0400F45E RID: 62558
		[JsonIgnore]
		public Offer.GClass3191 User;

		// Token: 0x0400F45F RID: 62559
		[JsonIgnore]
		public bool NotAvailable;

		// Token: 0x02002F57 RID: 12119
		public class GClass3191
		{
			// Token: 0x17002904 RID: 10500
			// (get) Token: 0x0600EF30 RID: 61232 RVA: 0x00002050 File Offset: 0x00000250
			public string CorrectedNickname
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400F468 RID: 62568
			public string Id;

			// Token: 0x0400F469 RID: 62569
			public string Nickname;

			// Token: 0x0400F46A RID: 62570
			public float Rating;

			// Token: 0x0400F46B RID: 62571
			public EMemberCategory MemberType;

			// Token: 0x0400F46C RID: 62572
			public string Avatar;

			// Token: 0x0400F46D RID: 62573
			public bool IsRatingGrowing;
		}
	}
}
