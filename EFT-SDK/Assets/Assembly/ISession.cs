using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.Binding;
using EFT;
using EFT.Hideout;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using JsonType;
using UnityEngine;

// Token: 0x02001814 RID: 6164
public interface ISession : GInterface16, GInterface144, GInterface146, GInterface178, GInterface181
{
	// Token: 0x14000189 RID: 393
	// (add) Token: 0x06008410 RID: 33808
	// (remove) Token: 0x06008411 RID: 33809
	event Action<int, string> InventoryErrorHappened;

	// Token: 0x1400018A RID: 394
	// (add) Token: 0x06008412 RID: 33810
	// (remove) Token: 0x06008413 RID: 33811
	event Action<IInventoryWarning> InventoryWarningHappened;

	// Token: 0x06008414 RID: 33812
	void SendOperationRightNow(object operation, Callback callback);

	// Token: 0x06008415 RID: 33813
	void TrySendCommands();

	// Token: 0x06008416 RID: 33814
	Task<IResult> FlushOperationQueue();

	// Token: 0x06008417 RID: 33815
	[CanBeNull]
	string GetPhpSessionId();

	// Token: 0x17001466 RID: 5222
	// (get) Token: 0x06008418 RID: 33816
	GInterface14 Cache { get; }

	// Token: 0x06008419 RID: 33817
	void RegisterCaptchaHandler(GInterface143 captchaHandler);

	// Token: 0x0600841A RID: 33818
	void ClearProfileUpdaters();

	// Token: 0x0600841B RID: 33819
	void RegisterProfileUpdater(string profileId, GInterface142 profileUpdater);

	// Token: 0x0600841C RID: 33820
	Task<GClass1225> SetMainProfile(Profile profile);

	// Token: 0x0600841D RID: 33821
	Task GetProfiles();

	// Token: 0x0600841E RID: 33822
	bool OfferAlreadyReported(long offerId);

	// Token: 0x0600841F RID: 33823
	void CheckLoginQueue(Callback<GClass1191> callback);

	// Token: 0x06008420 RID: 33824
	void LoadTextureRagfair(string url, bool cacheOnDisk, Callback<Texture2D> callback = null);

	// Token: 0x17001467 RID: 5223
	// (get) Token: 0x06008421 RID: 33825
	RagFairClass RagFair { get; }

	// Token: 0x17001468 RID: 5224
	// (get) Token: 0x06008422 RID: 33826
	GClass3184 WeaponBuildsStorage { get; }

	// Token: 0x17001469 RID: 5225
	// (get) Token: 0x06008423 RID: 33827
	GClass3182 EquipmentBuildsStorage { get; }

	// Token: 0x1700146A RID: 5226
	// (get) Token: 0x06008424 RID: 33828
	GClass2088 MagBuildsStorage { get; }

	// Token: 0x06008425 RID: 33829
	void RagfairAddOffer(bool sellInOnePiece, string[] items, GClass1841[] requirements, Callback callback);

	// Token: 0x06008426 RID: 33830
	void RagfairRemoveOffer(string offerId, Callback callback);

	// Token: 0x06008427 RID: 33831
	void RagfairRenewOffer(string offerId, bool priority, int renewalTime, Callback callback);

	// Token: 0x06008428 RID: 33832
	void RagfairPurchaseOffers(CustomizationClass commodities, Callback callback);

	// Token: 0x06008429 RID: 33833
	void RagfairGetPrices(Callback<Dictionary<string, float>> callback);

	// Token: 0x0600842A RID: 33834
	void RagfairReportOffer(long offerId, Callback callback);

	// Token: 0x0600842B RID: 33835
	Task<Result<CaptchaData>> GetCaptcha();

	// Token: 0x0600842C RID: 33836
	Task<Result<GClass1842>> ValidateCaptcha(IEnumerable<string> items, string captchaType);

	// Token: 0x0600842D RID: 33837
	Task<Result<OffersList>> GetOffers(int page, int limit, int sortType, bool direction, int currency, int priceFrom, int priceTo, int quantityFrom, int quantityTo, int conditionFrom, int conditionTo, bool oneHourExpiration, bool removeBartering, int offerOwnerType, bool onlyFunctional, string handbookId, string linkedSearchId, string neededSearchId, Dictionary<string, int> buildItems, int buildCount, bool updateOfferCount);

	// Token: 0x0600842E RID: 33838
	void GetMarketPrices(string templateId, Callback<ItemMarketPrices> callback);

	// Token: 0x0600842F RID: 33839
	void AddToWishList(string templateId, Callback callback);

	// Token: 0x06008430 RID: 33840
	void RemoveFromWishList(string templateId, Callback callback);

	// Token: 0x06008431 RID: 33841
	void FindById(long id, Callback<Offer> callback);

	// Token: 0x06008432 RID: 33842
	void ReadEncyclopedia(string[] ids, Callback callback);

	// Token: 0x1700146B RID: 5227
	// (get) Token: 0x06008433 RID: 33843
	[CanBeNull]
	Profile ProfileOfPet { get; }

	// Token: 0x1700146C RID: 5228
	// (get) Token: 0x06008434 RID: 33844
	float ProfilesUpdateTime { get; }

	// Token: 0x1700146D RID: 5229
	// (get) Token: 0x06008435 RID: 33845
	[CanBeNull]
	ProfileStatusClass ActivePetStatus { get; }

	// Token: 0x06008436 RID: 33846
	[CanBeNull]
	ProfileStatusClass GetProfileStatus(bool isPet);

	// Token: 0x06008437 RID: 33847
	void SendOperationQueued(object operation, Action<Callback> execute, [CanBeNull] Callback callback);

	// Token: 0x1700146E RID: 5230
	// (get) Token: 0x06008438 RID: 33848
	// (set) Token: 0x06008439 RID: 33849
	bool IsFlushing { get; set; }

	// Token: 0x1700146F RID: 5231
	// (get) Token: 0x0600843A RID: 33850
	// (set) Token: 0x0600843B RID: 33851
	EOperationQueueStatus QueueStatus { get; set; }

	// Token: 0x17001470 RID: 5232
	// (get) Token: 0x0600843C RID: 33852
	BindableEvent QueueStatusChanged { get; }

	// Token: 0x17001471 RID: 5233
	// (get) Token: 0x0600843D RID: 33853
	// (set) Token: 0x0600843E RID: 33854
	Action<string> ExamineRequestFailed { get; set; }

	// Token: 0x0600843F RID: 33855
	Task<LocationSettingsClass> GetLevelSettings();

	// Token: 0x17001472 RID: 5234
	// (get) Token: 0x06008440 RID: 33856
	LocationSettingsClass LocationSettings { get; }

	// Token: 0x17001473 RID: 5235
	// (get) Token: 0x06008441 RID: 33857
	DateTime GetCurrentLocationTime { get; }

	// Token: 0x06008442 RID: 33858
	Task<LocationWeatherTime> GetWeatherAndTime();

	// Token: 0x17001474 RID: 5236
	// (get) Token: 0x06008443 RID: 33859
	bool IsWinter { get; }

	// Token: 0x17001475 RID: 5237
	// (get) Token: 0x06008444 RID: 33860
	WeatherClass Weather { get; }

	// Token: 0x17001476 RID: 5238
	// (get) Token: 0x06008445 RID: 33861
	string LocationTime { get; }

	// Token: 0x17001477 RID: 5239
	// (get) Token: 0x06008446 RID: 33862
	float Acceleration { get; }

	// Token: 0x06008447 RID: 33863
	Task<string[]> GetAvailableSuites();

	// Token: 0x06008448 RID: 33864
	Task<List<RawQuestClass>> RequestQuestsTemplates(bool withCompleted);

	// Token: 0x06008449 RID: 33865
	Task<DailyQuestClass[]> GetDailyQuests();

	// Token: 0x0600844A RID: 33866
	Task<IResult> QuestChange(string qid);

	// Token: 0x0600844B RID: 33867
	Task<IResult> QuestAccept(string questId, bool isRepeatable);

	// Token: 0x0600844C RID: 33868
	Task<IResult> QuestComplete(string questId, bool removeExcessItems, bool isRepeatable);

	// Token: 0x0600844D RID: 33869
	Task<IResult> AchievementComplete(string qid, bool removeExcessItems);

	// Token: 0x0600844E RID: 33870
	Task<IResult> QuestHandover(string qid, string conditionId, GClass1223[] items);

	// Token: 0x0600844F RID: 33871
	Task<IResult> SaveWeaponBuild(MongoID id, string name, string root, GClass1186[] items);

	// Token: 0x06008450 RID: 33872
	Task<IResult> SaveEquipmentBuild(MongoID id, string name, string root, GClass1186[] items);

	// Token: 0x06008451 RID: 33873
	Task<IResult> RemoveBuild(MongoID id);

	// Token: 0x06008452 RID: 33874
	Task<IResult> RequestBuilds();

	// Token: 0x06008453 RID: 33875
	Task<IResult> SaveMagBuild(GClass2089 preset);

	// Token: 0x06008454 RID: 33876
	Task<IResult> FinishScavSession();

	// Token: 0x06008455 RID: 33877
	void RefreshPings(int sendPingResultInterval, int pingServersInterval, Callback<GameServerClass[]> callback = null);

	// Token: 0x06008456 RID: 33878
	AreaInfo[] GetHideoutAreasInfo();

	// Token: 0x06008457 RID: 33879
	Task<GClass748> GetAreaTemplatesUnparsed();

	// Token: 0x06008458 RID: 33880
	Task<GClass1905> GetHideoutSettings();

	// Token: 0x06008459 RID: 33881
	Task<GClass1920[]> GetProductionRecipes();

	// Token: 0x0600845A RID: 33882
	Task<GClass1921[]> GetScavRecipes();

	// Token: 0x0600845B RID: 33883
	Task<IResult> HideoutProductionCancel(string recipeId);

	// Token: 0x0600845C RID: 33884
	Task<IResult> HideoutProductionReset(string recipeId);

	// Token: 0x0600845D RID: 33885
	void StartSingleProduction(string schemeId, IEnumerable<GClass1223> items, IEnumerable<GClass1223> tools);

	// Token: 0x0600845E RID: 33886
	Task<IResult> StartScavCaseProduction(string schemeId, IEnumerable<GClass1223> items, IEnumerable<GClass1223> tools);

	// Token: 0x0600845F RID: 33887
	void StartContinuousProduction(string schemeId);

	// Token: 0x06008460 RID: 33888
	Task<IResult> UpgradeZone(int areaType, IEnumerable<GStruct241> items);

	// Token: 0x06008461 RID: 33889
	Task<IResult> CompleteUpgradeZone(int areaType);

	// Token: 0x06008462 RID: 33890
	Dictionary<string, GClass1910> GetHideoutImprovements();

	// Token: 0x06008463 RID: 33891
	void StartImprovement(string id, EAreaType areaType, IEnumerable<GClass1223> items);

	// Token: 0x06008464 RID: 33892
	void PutItemsInAreaSlots(EAreaType areaType, Dictionary<int, GStruct241> items, Action onComplete);

	// Token: 0x06008465 RID: 33893
	void ToggleArea(EAreaType areaType, bool enabled);

	// Token: 0x06008466 RID: 33894
	Task<IResult> TakeHideoutProduction(string recipeId);

	// Token: 0x06008467 RID: 33895
	void TakeItemsFromAreaSlots(EAreaType areaType, int[] slots, Callback callback);

	// Token: 0x06008468 RID: 33896
	Task<IResult> TakeItemsFromAreaSlotsAsync(EAreaType areaType, int[] slots);

	// Token: 0x06008469 RID: 33897
	void RestoreHealth(TreatmentDataClass treatmentData, List<GClass1223> cost, string traderId);

	// Token: 0x0600846A RID: 33898
	Task<GClass1826> CheckVersion();

	// Token: 0x0600846B RID: 33899
	void SendReport(EReportType reportType, Callback callback);

	// Token: 0x0600846C RID: 33900
	Task<LocationSettingsClass.Location> LoadLocationLoot(string locationId, int variantId);

	// Token: 0x0600846D RID: 33901
	Task OfflineRaidEnded(ExitStatus exitStatus, string exitName, double raidSeconds);

	// Token: 0x0600846E RID: 33902
	Task<IResult> Unpack(string targetItemId, string profileId);

	// Token: 0x0600846F RID: 33903
	int GetHideoutShootingRangeScore();

	// Token: 0x06008470 RID: 33904
	void SetHideoutShootingRangeScore(int value);

	// Token: 0x06008471 RID: 33905
	void ConfigureLobbyRelatedParameters(GClass1300 config);

	// Token: 0x06008472 RID: 33906
	Task<GClass1226> IssueWSToken();

	// Token: 0x06008473 RID: 33907
	Task EstablishWSConnection();

	// Token: 0x06008474 RID: 33908
	Task<IResult> SendRaidSettings(RaidSettings raidSettings);

	// Token: 0x06008475 RID: 33909
	Task<RaidSettings> ReceiveCoopRaidSettings();

	// Token: 0x06008476 RID: 33910
	Task<QteData[]> GetAreasQte();

	// Token: 0x06008477 RID: 33911
	void WorkoutEnded(IEnumerable<bool> qtesResult, string qteId, Callback callback);

	// Token: 0x06008478 RID: 33912
	void SetFavoriteItems(IEnumerable<string> items, Callback callback = null);

	// Token: 0x06008479 RID: 33913
	Task<IEnumerable<GClass3255>> RequestAchievementsTemplates(bool withCompleted);

	// Token: 0x0600847A RID: 33914
	Task<Dictionary<string, float>> RequestAchievementsGlobalProgress();
}
