using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.Hideout;
using EFT.Trading;
using EFT.UI.Ragfair;
using JsonType;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x020017A5 RID: 6053
internal sealed class Class262 : Class261, GInterface16, GInterface144, ISession, GInterface146, GInterface178, GInterface181
{
	// Token: 0x14000184 RID: 388
	// (add) Token: 0x060081EC RID: 33260 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060081ED RID: 33261 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int, string> InventoryErrorHappened
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

	// Token: 0x14000185 RID: 389
	// (add) Token: 0x060081EE RID: 33262 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060081EF RID: 33263 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IInventoryWarning> InventoryWarningHappened
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

	// Token: 0x14000186 RID: 390
	// (add) Token: 0x060081F0 RID: 33264 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060081F1 RID: 33265 RVA: 0x00002050 File Offset: 0x00000250
	private event Action Event_0
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

	// Token: 0x17001423 RID: 5155
	// (get) Token: 0x060081F2 RID: 33266 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060081F3 RID: 33267 RVA: 0x00002050 File Offset: 0x00000250
	public Action<string> ExamineRequestFailed
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

	// Token: 0x17001424 RID: 5156
	// (get) Token: 0x060081F4 RID: 33268 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060081F5 RID: 33269 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFlushing
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

	// Token: 0x17001425 RID: 5157
	// (get) Token: 0x060081F6 RID: 33270 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060081F7 RID: 33271 RVA: 0x00002050 File Offset: 0x00000250
	public EOperationQueueStatus QueueStatus
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

	// Token: 0x060081F8 RID: 33272 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearProfileUpdaters()
	{
		throw null;
	}

	// Token: 0x060081F9 RID: 33273 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterProfileUpdater(string profileId, GInterface142 profileUpdater)
	{
		throw null;
	}

	// Token: 0x060081FA RID: 33274 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterCaptchaHandler(GInterface143 captchaHandler)
	{
		throw null;
	}

	// Token: 0x060081FB RID: 33275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<ECaptchaResult>> RequestCaptcha()
	{
		throw null;
	}

	// Token: 0x060081FC RID: 33276 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendOperationRightNow(object operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x060081FD RID: 33277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_25()
	{
		throw null;
	}

	// Token: 0x060081FE RID: 33278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> FlushOperationQueue()
	{
		throw null;
	}

	// Token: 0x060081FF RID: 33279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_26(object operation, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008200 RID: 33280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendOperationQueued(object operation, Action<Callback> execute, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008201 RID: 33281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_27()
	{
		throw null;
	}

	// Token: 0x06008202 RID: 33282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_28(Result<Class262.QueueData> queueResult = default(Result<Class262.QueueData>))
	{
		throw null;
	}

	// Token: 0x06008203 RID: 33283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrySendCommands()
	{
		throw null;
	}

	// Token: 0x06008204 RID: 33284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_29()
	{
		throw null;
	}

	// Token: 0x06008205 RID: 33285 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_30(object[] commandsToSend, Result<Class262.QueueData> result)
	{
		throw null;
	}

	// Token: 0x06008206 RID: 33286 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(Result<Class262.QueueData> queueResult)
	{
		throw null;
	}

	// Token: 0x17001426 RID: 5158
	// (get) Token: 0x06008207 RID: 33287 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<TraderClass> Traders
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001427 RID: 5159
	// (get) Token: 0x06008208 RID: 33288 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<TraderClass> DisplayableTraders
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001428 RID: 5160
	// (get) Token: 0x06008209 RID: 33289 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<TraderClass> Insurers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001429 RID: 5161
	// (get) Token: 0x0600820A RID: 33290 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<TraderClass> Repairers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700142A RID: 5162
	// (get) Token: 0x0600820B RID: 33291 RVA: 0x00002050 File Offset: 0x00000250
	public TraderClass Medic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700142B RID: 5163
	// (get) Token: 0x0600820C RID: 33292 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600820D RID: 33293 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2087 RepairController
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700142C RID: 5164
	// (get) Token: 0x0600820E RID: 33294 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600820F RID: 33295 RVA: 0x00002050 File Offset: 0x00000250
	public LocationSettingsClass LocationSettings
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x06008210 RID: 33296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	TraderClass GInterface178.GetTrader(string traderId)
	{
		throw null;
	}

	// Token: 0x06008211 RID: 33297 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<SupplyData>> GetSupplyData(string traderId)
	{
		throw null;
	}

	// Token: 0x06008212 RID: 33298 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<TraderAssortment>> GetTraderAssortment(string traderId)
	{
		throw null;
	}

	// Token: 0x06008213 RID: 33299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetOffers(string traderId, Callback<GClass2938[]> onFinished)
	{
		throw null;
	}

	// Token: 0x06008214 RID: 33300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> ConfirmPurchase(string traderId, string itemId, int count, int schemeId, TradingItemReference[] items)
	{
		throw null;
	}

	// Token: 0x06008215 RID: 33301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConfirmSell(string traderId, TradingItemReference[] items, int price, Callback onFinished)
	{
		throw null;
	}

	// Token: 0x06008216 RID: 33302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SellAllFromSavage(string playerId, string petId)
	{
		throw null;
	}

	// Token: 0x06008217 RID: 33303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuyCustomizationWear(string offer, IEnumerable<GClass1223> items, Callback onFinished)
	{
		throw null;
	}

	// Token: 0x06008218 RID: 33304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Texture2D> LoadAvatar(string url)
	{
		throw null;
	}

	// Token: 0x06008219 RID: 33305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetPhpSessionId()
	{
		throw null;
	}

	// Token: 0x1700142D RID: 5165
	// (get) Token: 0x0600821A RID: 33306 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600821B RID: 33307 RVA: 0x00002050 File Offset: 0x00000250
	public float ProfilesUpdateTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700142E RID: 5166
	// (get) Token: 0x0600821C RID: 33308 RVA: 0x00002050 File Offset: 0x00000250
	public ProfileStatusClass ActivePetStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700142F RID: 5167
	// (get) Token: 0x0600821D RID: 33309 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600821E RID: 33310 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsWinter
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001430 RID: 5168
	// (get) Token: 0x0600821F RID: 33311 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008220 RID: 33312 RVA: 0x00002050 File Offset: 0x00000250
	public WeatherClass Weather
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001431 RID: 5169
	// (get) Token: 0x06008221 RID: 33313 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008222 RID: 33314 RVA: 0x00002050 File Offset: 0x00000250
	public string LocationTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001432 RID: 5170
	// (get) Token: 0x06008223 RID: 33315 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008224 RID: 33316 RVA: 0x00002050 File Offset: 0x00000250
	public float Acceleration
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001433 RID: 5171
	// (get) Token: 0x06008225 RID: 33317 RVA: 0x00002050 File Offset: 0x00000250
	public InsuranceCompanyClass InsuranceCompany
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001434 RID: 5172
	// (get) Token: 0x06008226 RID: 33318 RVA: 0x00002050 File Offset: 0x00000250
	public RagFairClass RagFair
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001435 RID: 5173
	// (get) Token: 0x06008227 RID: 33319 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008228 RID: 33320 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3184 WeaponBuildsStorage
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001436 RID: 5174
	// (get) Token: 0x06008229 RID: 33321 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600822A RID: 33322 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3182 EquipmentBuildsStorage
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001437 RID: 5175
	// (get) Token: 0x0600822B RID: 33323 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600822C RID: 33324 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2088 MagBuildsStorage
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001438 RID: 5176
	// (get) Token: 0x0600822D RID: 33325 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime GetCurrentLocationTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600822E RID: 33326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task GetProfiles()
	{
		throw null;
	}

	// Token: 0x0600822F RID: 33327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32()
	{
		throw null;
	}

	// Token: 0x06008230 RID: 33328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33()
	{
		throw null;
	}

	// Token: 0x06008231 RID: 33329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ApplyCustomizationWear(string[] suites, Callback onFinished)
	{
		throw null;
	}

	// Token: 0x06008232 RID: 33330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OfferAlreadyReported(long offerId)
	{
		throw null;
	}

	// Token: 0x06008233 RID: 33331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReceiveInsurancePrices(string traderId, Callback<Dictionary<string, int>> callback)
	{
		throw null;
	}

	// Token: 0x06008234 RID: 33332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetInsurancePrice(string[] traderId, string[] itemIds, Callback<Dictionary<string, Dictionary<string, int>>> callback)
	{
		throw null;
	}

	// Token: 0x06008235 RID: 33333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsureItems(string[] items, string traderId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008236 RID: 33334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RagfairAddOffer(bool sellInOnePiece, string[] items, GClass1841[] requirements, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008237 RID: 33335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RagfairRemoveOffer(string offerId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008238 RID: 33336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RagfairRenewOffer(string offerId, bool priority, int renewalTime, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008239 RID: 33337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RagfairPurchaseOffers(CustomizationClass commodities, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600823A RID: 33338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RagfairGetPrices(Callback<Dictionary<string, float>> callback)
	{
		throw null;
	}

	// Token: 0x0600823B RID: 33339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<CaptchaData>> GetCaptcha()
	{
		throw null;
	}

	// Token: 0x0600823C RID: 33340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<GClass1842>> ValidateCaptcha(IEnumerable<string> items, string captchaType)
	{
		throw null;
	}

	// Token: 0x0600823D RID: 33341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RagfairReportOffer(long offerId, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600823E RID: 33342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<OffersList>> GetOffers(int page, int limit, int sortType, bool direction, int currency, int priceFrom, int priceTo, int quantityFrom, int quantityTo, int conditionFrom, int conditionTo, bool oneHourExpiration, bool removeBartering, int offerOwnerType, bool onlyFunctional, string handbookId, string linkedSearchId, string neededSearchId, Dictionary<string, int> buildItems, int buildCount, bool updateOfferCount)
	{
		throw null;
	}

	// Token: 0x0600823F RID: 33343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetMarketPrices(string templateId, Callback<ItemMarketPrices> callback)
	{
		throw null;
	}

	// Token: 0x06008240 RID: 33344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToWishList(string templateId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008241 RID: 33345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFromWishList(string templateId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008242 RID: 33346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindById(long id, Callback<Offer> callback)
	{
		throw null;
	}

	// Token: 0x06008243 RID: 33347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadEncyclopedia(string[] ids, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008244 RID: 33348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItemsByTrader(string traderId, RepairItem repairItem)
	{
		throw null;
	}

	// Token: 0x06008245 RID: 33349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItemId)
	{
		throw null;
	}

	// Token: 0x06008246 RID: 33350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<bool> RedeemProfileRewards(GStruct72[] rewards)
	{
		throw null;
	}

	// Token: 0x06008247 RID: 33351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1225> SetMainProfile(Profile profile)
	{
		throw null;
	}

	// Token: 0x06008248 RID: 33352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task<BackendConfigClass> GetGlobalConfig()
	{
		throw null;
	}

	// Token: 0x06008249 RID: 33353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<LocationSettingsClass> GetLevelSettings()
	{
		throw null;
	}

	// Token: 0x0600824A RID: 33354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<LocationWeatherTime> GetWeatherAndTime()
	{
		throw null;
	}

	// Token: 0x0600824B RID: 33355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public new Task<IResult> Logout()
	{
		throw null;
	}

	// Token: 0x0600824C RID: 33356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<List<RawQuestClass>> RequestQuestsTemplates(bool withCompleted)
	{
		throw null;
	}

	// Token: 0x0600824D RID: 33357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<DailyQuestClass[]> GetDailyQuests()
	{
		throw null;
	}

	// Token: 0x0600824E RID: 33358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string[]> GetAvailableSuites()
	{
		throw null;
	}

	// Token: 0x0600824F RID: 33359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> QuestChange(string qid)
	{
		throw null;
	}

	// Token: 0x06008250 RID: 33360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> QuestAccept(string qid, bool isRepeatable)
	{
		throw null;
	}

	// Token: 0x06008251 RID: 33361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> QuestComplete(string qid, bool removeExcessItems, bool isRepeatable)
	{
		throw null;
	}

	// Token: 0x06008252 RID: 33362 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> AchievementComplete(string qid, bool removeExcessItems)
	{
		throw null;
	}

	// Token: 0x06008253 RID: 33363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void QuestFail(string qid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008254 RID: 33364 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetSessionId(bool isPet)
	{
		throw null;
	}

	// Token: 0x06008255 RID: 33365 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Profile GetProfileBySide(ESideType side)
	{
		throw null;
	}

	// Token: 0x06008256 RID: 33366 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> QuestHandover(string qid, string conditionId, GClass1223[] items)
	{
		throw null;
	}

	// Token: 0x06008257 RID: 33367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RequestBuilds()
	{
		throw null;
	}

	// Token: 0x06008258 RID: 33368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SaveMagBuild(GClass2089 preset)
	{
		throw null;
	}

	// Token: 0x06008259 RID: 33369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SaveWeaponBuild(MongoID id, string name, string root, GClass1186[] items)
	{
		throw null;
	}

	// Token: 0x0600825A RID: 33370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SaveEquipmentBuild(MongoID id, string name, string root, GClass1186[] items)
	{
		throw null;
	}

	// Token: 0x0600825B RID: 33371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RemoveBuild(MongoID id)
	{
		throw null;
	}

	// Token: 0x0600825C RID: 33372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> FinishScavSession()
	{
		throw null;
	}

	// Token: 0x0600825D RID: 33373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadTextureRagfair(string url, bool cacheOnDisk, Callback<Texture2D> callback = null)
	{
		throw null;
	}

	// Token: 0x0600825E RID: 33374 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckLoginQueue(Callback<GClass1191> callback)
	{
		throw null;
	}

	// Token: 0x0600825F RID: 33375 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_34(Callback<GClass1191> callback)
	{
		throw null;
	}

	// Token: 0x06008260 RID: 33376 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshPings(int sendPingResultInterval, int pingServersInterval, Callback<GameServerClass[]> callback = null)
	{
		throw null;
	}

	// Token: 0x06008261 RID: 33377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_35(int sendPingResultInterval, int pingServersInterval, Callback<GameServerClass[]> callback)
	{
		throw null;
	}

	// Token: 0x06008262 RID: 33378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_36(int sendPingResultInterval, int pingServersInterval)
	{
		throw null;
	}

	// Token: 0x06008263 RID: 33379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_37(GameServerClass server, int timeout, int sendPingResultInterval)
	{
		throw null;
	}

	// Token: 0x06008264 RID: 33380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_38(int sendPingResultInterval)
	{
		throw null;
	}

	// Token: 0x06008265 RID: 33381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AreaInfo[] GetHideoutAreasInfo()
	{
		throw null;
	}

	// Token: 0x06008266 RID: 33382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass748> GetAreaTemplatesUnparsed()
	{
		throw null;
	}

	// Token: 0x06008267 RID: 33383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1905> GetHideoutSettings()
	{
		throw null;
	}

	// Token: 0x06008268 RID: 33384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1920[]> GetProductionRecipes()
	{
		throw null;
	}

	// Token: 0x06008269 RID: 33385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<QteData[]> GetAreasQte()
	{
		throw null;
	}

	// Token: 0x0600826A RID: 33386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1921[]> GetScavRecipes()
	{
		throw null;
	}

	// Token: 0x0600826B RID: 33387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetHideoutShootingRangeScore()
	{
		throw null;
	}

	// Token: 0x0600826C RID: 33388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHideoutShootingRangeScore(int value)
	{
		throw null;
	}

	// Token: 0x0600826D RID: 33389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartSingleProduction(string schemeId, IEnumerable<GClass1223> items, IEnumerable<GClass1223> tools)
	{
		throw null;
	}

	// Token: 0x0600826E RID: 33390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> HideoutProductionCancel(string recipeId)
	{
		throw null;
	}

	// Token: 0x0600826F RID: 33391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> HideoutProductionReset(string recipeId)
	{
		throw null;
	}

	// Token: 0x06008270 RID: 33392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> StartScavCaseProduction(string schemeId, IEnumerable<GClass1223> items, IEnumerable<GClass1223> tools)
	{
		throw null;
	}

	// Token: 0x06008271 RID: 33393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartContinuousProduction(string schemeId)
	{
		throw null;
	}

	// Token: 0x06008272 RID: 33394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> UpgradeZone(int areaType, IEnumerable<GStruct241> items)
	{
		throw null;
	}

	// Token: 0x06008273 RID: 33395 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> CompleteUpgradeZone(int areaType)
	{
		throw null;
	}

	// Token: 0x06008274 RID: 33396 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<string, GClass1910> GetHideoutImprovements()
	{
		throw null;
	}

	// Token: 0x06008275 RID: 33397 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartImprovement(string id, EAreaType areaType, IEnumerable<GClass1223> items)
	{
		throw null;
	}

	// Token: 0x06008276 RID: 33398 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PutItemsInAreaSlots(EAreaType areaType, Dictionary<int, GStruct241> items, Action onComplete)
	{
		throw null;
	}

	// Token: 0x06008277 RID: 33399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleArea(EAreaType areaType, bool enabled)
	{
		throw null;
	}

	// Token: 0x06008278 RID: 33400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> TakeHideoutProduction(string recipeId)
	{
		throw null;
	}

	// Token: 0x06008279 RID: 33401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakeItemsFromAreaSlots(EAreaType areaType, int[] slots, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600827A RID: 33402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> TakeItemsFromAreaSlotsAsync(EAreaType areaType, int[] slots)
	{
		throw null;
	}

	// Token: 0x0600827B RID: 33403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RestoreHealth(TreatmentDataClass treatmentData, List<GClass1223> cost, string traderId)
	{
		throw null;
	}

	// Token: 0x0600827C RID: 33404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1826> CheckVersion()
	{
		throw null;
	}

	// Token: 0x0600827D RID: 33405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendReport(EReportType reportType, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600827E RID: 33406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<LocationSettingsClass.Location> LoadLocationLoot(string locationId, int variantId)
	{
		throw null;
	}

	// Token: 0x0600827F RID: 33407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SendRaidSettings(RaidSettings settings)
	{
		throw null;
	}

	// Token: 0x06008280 RID: 33408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<RaidSettings> ReceiveCoopRaidSettings()
	{
		throw null;
	}

	// Token: 0x06008281 RID: 33409 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task OfflineRaidEnded(ExitStatus exitStatus, string exitName, double raidSeconds)
	{
		throw null;
	}

	// Token: 0x06008282 RID: 33410 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConfigureLobbyRelatedParameters(GClass1300 config)
	{
		throw null;
	}

	// Token: 0x06008283 RID: 33411 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1226> IssueWSToken()
	{
		throw null;
	}

	// Token: 0x06008284 RID: 33412 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task EstablishWSConnection()
	{
		throw null;
	}

	// Token: 0x06008285 RID: 33413 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WorkoutEnded(IEnumerable<bool> results, string id, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008286 RID: 33414 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IEnumerable<GClass3255>> RequestAchievementsTemplates(bool withCompleted)
	{
		throw null;
	}

	// Token: 0x06008287 RID: 33415 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Dictionary<string, float>> RequestAchievementsGlobalProgress()
	{
		throw null;
	}

	// Token: 0x06008288 RID: 33416 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFavoriteItems(IEnumerable<string> items, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x06008289 RID: 33417 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> Unpack(string targetItemId, string profileId)
	{
		throw null;
	}

	// Token: 0x0600828A RID: 33418 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Task Destroy()
	{
		throw null;
	}

	// Token: 0x0600828B RID: 33419 RVA: 0x00002050 File Offset: 0x00000250
	[DebuggerHidden]
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_39()
	{
		throw null;
	}

	// Token: 0x040089D9 RID: 35289
	private const string string_2 = "Trading/InsufficientNumberOfItemsInStock{}{}";

	// Token: 0x040089DA RID: 35290
	private const string string_3 = "Error: Inventory queue failed on the following commands";

	// Token: 0x040089DB RID: 35291
	private const string string_4 = "Item is out of stock";

	// Token: 0x040089DC RID: 35292
	private const string string_5 = "Request error: 1503 - Offer not found 1503";

	// Token: 0x040089DD RID: 35293
	private const string string_6 = "Warnings/Inventory/ExaminationFailed";

	// Token: 0x040089DE RID: 35294
	private const string string_7 = "Price changed error";

	// Token: 0x040089DF RID: 35295
	private const string string_8 = "Warnings/Inventory/NotEnoughSpaceInStash";

	// Token: 0x040089E0 RID: 35296
	[CompilerGenerated]
	private Action<int, string> action_1;

	// Token: 0x040089E1 RID: 35297
	[CompilerGenerated]
	private Action<IInventoryWarning> action_2;

	// Token: 0x040089E2 RID: 35298
	[CompilerGenerated]
	private Action action_3;

	// Token: 0x040089E3 RID: 35299
	private float float_0;

	// Token: 0x040089E4 RID: 35300
	private readonly Class262.Class342 class342_0;

	// Token: 0x040089E5 RID: 35301
	private readonly Queue<Class261.Class1308> queue_0;

	// Token: 0x040089E6 RID: 35302
	private Class261.Class1308 class1308_0;

	// Token: 0x040089E7 RID: 35303
	private readonly List<object> list_0;

	// Token: 0x040089E8 RID: 35304
	private TaskCompletionSource<object> taskCompletionSource_0;

	// Token: 0x040089E9 RID: 35305
	private GInterface143 ginterface143_0;

	// Token: 0x040089EA RID: 35306
	private readonly Dictionary<string, GInterface142> dictionary_0;

	// Token: 0x040089EB RID: 35307
	[CompilerGenerated]
	private Action<string> action_4;

	// Token: 0x040089EC RID: 35308
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x040089ED RID: 35309
	[CompilerGenerated]
	private EOperationQueueStatus eoperationQueueStatus_0;

	// Token: 0x040089EE RID: 35310
	[CompilerGenerated]
	private GClass2087 gclass2087_0;

	// Token: 0x040089EF RID: 35311
	[CompilerGenerated]
	private LocationSettingsClass gclass1213_0;

	// Token: 0x040089F0 RID: 35312
	private readonly List<TraderClass> list_1;

	// Token: 0x040089F1 RID: 35313
	private string string_9;

	// Token: 0x040089F2 RID: 35314
	private readonly Class262.Class343 class343_0;

	// Token: 0x040089F3 RID: 35315
	private readonly HashSet<long> hashSet_2;

	// Token: 0x040089F4 RID: 35316
	[CompilerGenerated]
	private float float_1;

	// Token: 0x040089F5 RID: 35317
	[CompilerGenerated]
	private bool bool_5;

	// Token: 0x040089F6 RID: 35318
	[CompilerGenerated]
	private WeatherClass gclass2101_0;

	// Token: 0x040089F7 RID: 35319
	[CompilerGenerated]
	private string string_10;

	// Token: 0x040089F8 RID: 35320
	[CompilerGenerated]
	private float float_2;

	// Token: 0x040089F9 RID: 35321
	[CompilerGenerated]
	private readonly InsuranceCompanyClass gclass3179_0;

	// Token: 0x040089FA RID: 35322
	[CompilerGenerated]
	private readonly RagFairClass gclass3190_0;

	// Token: 0x040089FB RID: 35323
	[CompilerGenerated]
	private GClass3184 gclass3184_0;

	// Token: 0x040089FC RID: 35324
	[CompilerGenerated]
	private GClass3182 gclass3182_0;

	// Token: 0x040089FD RID: 35325
	[CompilerGenerated]
	private GClass2088 gclass2088_0;

	// Token: 0x040089FE RID: 35326
	private static int int_2;

	// Token: 0x020017A6 RID: 6054
	[Serializable]
	private sealed class QueueData
	{
		// Token: 0x040089FF RID: 35327
		[JsonProperty("profileChanges")]
		public Dictionary<string, ProfileChangesPocoClass> ProfileChanges;

		// Token: 0x04008A00 RID: 35328
		[JsonProperty("warnings")]
		public Class262.InventoryWarning[] InventoryWarnings;
	}

	// Token: 0x020017A7 RID: 6055
	[Serializable]
	private sealed class InventoryWarning : IInventoryWarning
	{
		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600828C RID: 33420 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600828D RID: 33421 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("index")]
		public int RequestIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600828E RID: 33422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600828F RID: 33423 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("errmsg")]
		public string ErrorMessage
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008291 RID: 33425 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("code")]
		public string ErrorCode
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x00002050 File Offset: 0x00000250
		int IInventoryWarning.ErrorCode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (set) Token: 0x06008293 RID: 33427 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("msg")]
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetMessage(out string header, out string description)
		{
			throw null;
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IResult ToResult()
		{
			throw null;
		}

		// Token: 0x04008A01 RID: 35329
		[JsonProperty("data")]
		private GClass748 _data;

		// Token: 0x020017A8 RID: 6056
		[Serializable]
		private struct InsufficientNumberOfItemsData
		{
			// Token: 0x1700143E RID: 5182
			// (get) Token: 0x06008296 RID: 33430 RVA: 0x00002050 File Offset: 0x00000250
			public string LocalizedMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04008A02 RID: 35330
			[JsonProperty("itemId")]
			public string ItemId;

			// Token: 0x04008A03 RID: 35331
			[JsonProperty("requestedCount")]
			public int RequestedCount;

			// Token: 0x04008A04 RID: 35332
			[JsonProperty("actualCount")]
			public int ActualCount;
		}

		// Token: 0x020017A9 RID: 6057
		[Serializable]
		private struct IncorrectClientPriceData
		{
			// Token: 0x1700143F RID: 5183
			// (get) Token: 0x06008297 RID: 33431 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06008298 RID: 33432 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("traderCurrency")]
			public string TraderCurrencyId
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17001440 RID: 5184
			// (get) Token: 0x06008299 RID: 33433 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600829A RID: 33434 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("requestedCount")]
			public int RequestedCount
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17001441 RID: 5185
			// (get) Token: 0x0600829B RID: 33435 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600829C RID: 33436 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty("actualCount")]
			public int ActualCount
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x17001442 RID: 5186
			// (get) Token: 0x0600829D RID: 33437 RVA: 0x00002050 File Offset: 0x00000250
			public string LocalizedMessage
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04008A05 RID: 35333
			private const string INCORRECT_CLIENT_PRICE = "Trading/IncorrectClientPrice{0}{1}";
		}
	}

	// Token: 0x020017AA RID: 6058
	private sealed class Class1309 : Class261.Class1308
	{
		// Token: 0x04008A06 RID: 35334
		public Callback Callback;

		// Token: 0x04008A07 RID: 35335
		public Action<Callback> Execute;
	}

	// Token: 0x020017AB RID: 6059
	private sealed class Class1310 : Class261.Class1308
	{
		// Token: 0x04008A08 RID: 35336
		public Callback Callback;
	}

	// Token: 0x020017AC RID: 6060
	private sealed class Class342 : LoggerClass
	{
	}

	// Token: 0x020017AD RID: 6061
	private sealed class Class343 : LoggerClass
	{
	}

	// Token: 0x020017AE RID: 6062
	[CompilerGenerated]
	private sealed class Class1274
	{
		// Token: 0x0600829E RID: 33438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult executeResult)
		{
			throw null;
		}

		// Token: 0x04008A09 RID: 35337
		public Class262.Class1309 queuedOperation;

		// Token: 0x04008A0A RID: 35338
		public Class262 class262_0;
	}

	// Token: 0x020017AF RID: 6063
	[CompilerGenerated]
	private sealed class Class1275
	{
		// Token: 0x0600829F RID: 33439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04008A0B RID: 35339
		public Class262 class262_0;

		// Token: 0x04008A0C RID: 35340
		public TaskCompletionSource<IResult> taskSource;
	}

	// Token: 0x020017B1 RID: 6065
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1276
	{
		// Token: 0x060082A2 RID: 33442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Callback operationCallback)
		{
			throw null;
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Class31<string, int> method_5(TradingItemReference item)
		{
			throw null;
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Class33<string, int, int> method_6(TradingItemReference item)
		{
			throw null;
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_7(Profile value)
		{
			throw null;
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_8(Profile value)
		{
			throw null;
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Class44<string, int, IEnumerable<Class31<string, int>>> method_9(GClass1864 x)
		{
			throw null;
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Class31<string, int> method_10(GClass1860 item)
		{
			throw null;
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MongoID method_11(GClass3183 x)
		{
			throw null;
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass3183 method_12(GClass3183 x)
		{
			throw null;
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal MongoID method_13(GClass3181 x)
		{
			throw null;
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass3181 method_14(GClass3181 x)
		{
			throw null;
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_15(Result<GameServerClass[]> result)
		{
			throw null;
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GameServerClass method_16(GClass1175 server)
		{
			throw null;
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_17(IResult result)
		{
			throw null;
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_18(IResult result)
		{
			throw null;
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_19(IResult result)
		{
			throw null;
		}

		// Token: 0x04008A13 RID: 35347
		public static readonly Class262.Class1276 class1276_0;

		// Token: 0x04008A14 RID: 35348
		public static Action<Callback> action_0;

		// Token: 0x04008A15 RID: 35349
		public static Func<TraderClass, bool> func_0;

		// Token: 0x04008A16 RID: 35350
		public static Func<TraderClass, bool> func_1;

		// Token: 0x04008A17 RID: 35351
		public static Func<TraderClass, bool> func_2;

		// Token: 0x04008A18 RID: 35352
		public static Func<TraderClass, bool> func_3;

		// Token: 0x04008A19 RID: 35353
		public static Func<TradingItemReference, Class31<string, int>> func_4;

		// Token: 0x04008A1A RID: 35354
		public static Func<TradingItemReference, Class33<string, int, int>> func_5;

		// Token: 0x04008A1B RID: 35355
		public static Func<Profile, bool> func_6;

		// Token: 0x04008A1C RID: 35356
		public static Func<Profile, bool> func_7;

		// Token: 0x04008A1D RID: 35357
		public static Func<GClass1860, Class31<string, int>> func_8;

		// Token: 0x04008A1E RID: 35358
		public static Func<GClass1864, Class44<string, int, IEnumerable<Class31<string, int>>>> func_9;

		// Token: 0x04008A1F RID: 35359
		public static Func<GClass3183, MongoID> func_10;

		// Token: 0x04008A20 RID: 35360
		public static Func<GClass3183, GClass3183> func_11;

		// Token: 0x04008A21 RID: 35361
		public static Func<GClass3181, MongoID> func_12;

		// Token: 0x04008A22 RID: 35362
		public static Func<GClass3181, GClass3181> func_13;

		// Token: 0x04008A23 RID: 35363
		public static Callback<GameServerClass[]> callback_0;

		// Token: 0x04008A24 RID: 35364
		public static Func<GClass1175, GameServerClass> func_14;

		// Token: 0x04008A25 RID: 35365
		public static Callback callback_1;

		// Token: 0x04008A26 RID: 35366
		public static Callback callback_2;

		// Token: 0x04008A27 RID: 35367
		public static Callback callback_3;
	}

	// Token: 0x020017B2 RID: 6066
	[CompilerGenerated]
	private sealed class Class1277
	{
		// Token: 0x060082B6 RID: 33462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Class262.QueueData> result)
		{
			throw null;
		}

		// Token: 0x04008A28 RID: 35368
		public Class262 class262_0;

		// Token: 0x04008A29 RID: 35369
		public object[] commandsToSend;
	}

	// Token: 0x020017B3 RID: 6067
	[CompilerGenerated]
	private sealed class Class1278
	{
		// Token: 0x060082B7 RID: 33463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Class262.InventoryWarning warning)
		{
			throw null;
		}

		// Token: 0x04008A2A RID: 35370
		public object[] commandsToSend;
	}

	// Token: 0x020017B4 RID: 6068
	[CompilerGenerated]
	private sealed class Class1279
	{
		// Token: 0x060082B8 RID: 33464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x04008A2B RID: 35371
		public string traderId;
	}

	// Token: 0x020017B5 RID: 6069
	[CompilerGenerated]
	private sealed class Class1280
	{
		// Token: 0x060082B9 RID: 33465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<SupplyData> result)
		{
			throw null;
		}

		// Token: 0x04008A2C RID: 35372
		public TaskCompletionSource<Result<SupplyData>> taskSource;
	}

	// Token: 0x020017B6 RID: 6070
	[CompilerGenerated]
	private sealed class Class1281
	{
		// Token: 0x060082BA RID: 33466 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<TraderAssortment> result)
		{
			throw null;
		}

		// Token: 0x04008A2D RID: 35373
		public TaskCompletionSource<Result<TraderAssortment>> taskSource;
	}

	// Token: 0x020017B7 RID: 6071
	[CompilerGenerated]
	private sealed class Class1282
	{
		// Token: 0x060082BB RID: 33467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Texture2D> result)
		{
			throw null;
		}

		// Token: 0x04008A2E RID: 35374
		public TaskCompletionSource<Texture2D> source;
	}

	// Token: 0x020017B8 RID: 6072
	[CompilerGenerated]
	private sealed class Class1283
	{
		// Token: 0x060082BC RID: 33468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ProfileStatusClass status)
		{
			throw null;
		}

		// Token: 0x04008A2F RID: 35375
		public Profile profile;
	}

	// Token: 0x020017B9 RID: 6073
	[CompilerGenerated]
	private sealed class Class1284
	{
		// Token: 0x060082BD RID: 33469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Profile[]> result)
		{
			throw null;
		}

		// Token: 0x04008A30 RID: 35376
		public Class262 class262_0;

		// Token: 0x04008A31 RID: 35377
		public TaskCompletionSource<Profile[]> completionSource;
	}

	// Token: 0x020017BA RID: 6074
	[CompilerGenerated]
	private sealed class Class1285
	{
		// Token: 0x060082BE RID: 33470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<CaptchaData> result)
		{
			throw null;
		}

		// Token: 0x04008A32 RID: 35378
		public TaskCompletionSource<Result<CaptchaData>> taskSource;
	}

	// Token: 0x020017BB RID: 6075
	[CompilerGenerated]
	private sealed class Class1286
	{
		// Token: 0x060082BF RID: 33471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1842> result)
		{
			throw null;
		}

		// Token: 0x04008A33 RID: 35379
		public TaskCompletionSource<Result<GClass1842>> taskSource;
	}

	// Token: 0x020017BC RID: 6076
	[CompilerGenerated]
	private sealed class Class1287
	{
		// Token: 0x060082C0 RID: 33472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008A34 RID: 35380
		public Class262 class262_0;

		// Token: 0x04008A35 RID: 35381
		public long offerId;

		// Token: 0x04008A36 RID: 35382
		public Callback callback;
	}

	// Token: 0x020017BD RID: 6077
	[CompilerGenerated]
	private sealed class Class1288
	{
		// Token: 0x060082C1 RID: 33473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<OffersList> result)
		{
			throw null;
		}

		// Token: 0x04008A37 RID: 35383
		public TaskCompletionSource<Result<OffersList>> completionSource;
	}

	// Token: 0x020017BE RID: 6078
	[CompilerGenerated]
	private sealed class Class1289
	{
		// Token: 0x060082C2 RID: 33474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008A38 RID: 35384
		public TaskCompletionSource<bool> source;
	}

	// Token: 0x020017BF RID: 6079
	[CompilerGenerated]
	private sealed class Class1290
	{
		// Token: 0x060082C3 RID: 33475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1225> result)
		{
			throw null;
		}

		// Token: 0x04008A39 RID: 35385
		public Class262 class262_0;

		// Token: 0x04008A3A RID: 35386
		public Profile profile;

		// Token: 0x04008A3B RID: 35387
		public TaskCompletionSource<GClass1225> completionSource;
	}

	// Token: 0x020017C2 RID: 6082
	[CompilerGenerated]
	private sealed class Class1291
	{
		// Token: 0x060082C8 RID: 33480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<LocationWeatherTime> result)
		{
			throw null;
		}

		// Token: 0x04008A46 RID: 35398
		public TaskCompletionSource<LocationWeatherTime> completionSource;

		// Token: 0x04008A47 RID: 35399
		public Class262 class262_0;
	}

	// Token: 0x020017C3 RID: 6083
	[CompilerGenerated]
	private sealed class Class1292
	{
		// Token: 0x060082C9 RID: 33481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008A48 RID: 35400
		public TaskCompletionSource<IResult> taskSource;
	}

	// Token: 0x020017CA RID: 6090
	[CompilerGenerated]
	private sealed class Class1293
	{
		// Token: 0x060082D6 RID: 33494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008A6B RID: 35435
		public TaskCompletionSource<IResult> taskSource;
	}

	// Token: 0x020017CB RID: 6091
	[CompilerGenerated]
	private sealed class Class1294
	{
		// Token: 0x060082D7 RID: 33495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Texture2D> result)
		{
			throw null;
		}

		// Token: 0x04008A6C RID: 35436
		public Callback<Texture2D> callback;
	}

	// Token: 0x020017CC RID: 6092
	[CompilerGenerated]
	private sealed class Class1295
	{
		// Token: 0x060082D8 RID: 33496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1191> result)
		{
			throw null;
		}

		// Token: 0x04008A6D RID: 35437
		public bool skipped;

		// Token: 0x04008A6E RID: 35438
		public Callback<GClass1191> callback;
	}

	// Token: 0x020017CE RID: 6094
	[CompilerGenerated]
	private sealed class Class1297
	{
		// Token: 0x060082DD RID: 33501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1175[]> result)
		{
			throw null;
		}

		// Token: 0x04008A74 RID: 35444
		public Class262 class262_0;

		// Token: 0x04008A75 RID: 35445
		public int sendPingResultInterval;

		// Token: 0x04008A76 RID: 35446
		public int pingServersInterval;

		// Token: 0x04008A77 RID: 35447
		public Callback<GameServerClass[]> callback;
	}

	// Token: 0x020017D8 RID: 6104
	[CompilerGenerated]
	private sealed class Class1301
	{
		// Token: 0x060082F6 RID: 33526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AA9 RID: 35497
		public int value;
	}

	// Token: 0x020017D9 RID: 6105
	[CompilerGenerated]
	private sealed class Class1302
	{
		// Token: 0x060082F7 RID: 33527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AAA RID: 35498
		public string schemeId;
	}

	// Token: 0x020017DA RID: 6106
	[CompilerGenerated]
	private sealed class Class1303
	{
		// Token: 0x060082F8 RID: 33528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AAB RID: 35499
		public TaskCompletionSource<IResult> source;
	}

	// Token: 0x020017DB RID: 6107
	[CompilerGenerated]
	private sealed class Class1304
	{
		// Token: 0x060082F9 RID: 33529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AAC RID: 35500
		public string id;
	}

	// Token: 0x020017DC RID: 6108
	[CompilerGenerated]
	private sealed class Class1305
	{
		// Token: 0x060082FA RID: 33530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AAD RID: 35501
		public Action onComplete;
	}

	// Token: 0x020017DD RID: 6109
	[CompilerGenerated]
	private sealed class Class1306
	{
		// Token: 0x060082FB RID: 33531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AAE RID: 35502
		public TaskCompletionSource<IResult> source;
	}

	// Token: 0x020017DE RID: 6110
	[CompilerGenerated]
	private sealed class Class1307
	{
		// Token: 0x060082FC RID: 33532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008AAF RID: 35503
		public TaskCompletionSource<IResult> source;
	}
}
