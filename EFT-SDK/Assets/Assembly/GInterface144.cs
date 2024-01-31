using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.HandBook;
using JetBrains.Annotations;
using JsonType;
using UnityEngine;

// Token: 0x02001813 RID: 6163
public interface GInterface144 : GInterface16, GInterface146
{
	// Token: 0x14000188 RID: 392
	// (add) Token: 0x060083CF RID: 33743
	// (remove) Token: 0x060083D0 RID: 33744
	event Action<EBackendErrorCode, string> OnSessionError;

	// Token: 0x060083D1 RID: 33745
	void CreateProfile(EPlayerSide profileSide, string profileNickname, string headId, string voiceId, Callback callback);

	// Token: 0x060083D2 RID: 33746
	void ChangeProfileStatus(ProfileStatusClass status);

	// Token: 0x060083D3 RID: 33747
	void RefreshProfileStatuses(bool isPet, Callback<ProfileStatusClass[]> callback = null);

	// Token: 0x1700145B RID: 5211
	// (get) Token: 0x060083D4 RID: 33748
	Profile[] AllProfiles { get; }

	// Token: 0x1700145C RID: 5212
	// (get) Token: 0x060083D5 RID: 33749
	[CanBeNull]
	Profile Profile { get; }

	// Token: 0x1700145D RID: 5213
	// (get) Token: 0x060083D6 RID: 33750
	[CanBeNull]
	ProfileStatusClass[] AllProfileStatus { get; }

	// Token: 0x1700145E RID: 5214
	// (get) Token: 0x060083D7 RID: 33751
	[CanBeNull]
	ProfileStatusClass ActiveProfileStatus { get; }

	// Token: 0x060083D8 RID: 33752
	Task<IResult> Logout();

	// Token: 0x1700145F RID: 5215
	// (get) Token: 0x060083D9 RID: 33753
	SessionCountersClass OverallAccountStats { get; }

	// Token: 0x060083DA RID: 33754
	Task<string[]> GetAvailableAccountCustomization();

	// Token: 0x060083DB RID: 33755
	void ApplyCustomizationWear(string[] suites, Callback onFinished);

	// Token: 0x060083DC RID: 33756
	void ChangeVoice(string voice, Callback callback);

	// Token: 0x060083DD RID: 33757
	void ChangeNickname(string profileId, string nickname, Callback<GClass688> callback);

	// Token: 0x060083DE RID: 33758
	void ValidateNickname(string nickname, Callback<object> callback);

	// Token: 0x060083DF RID: 33759
	void GetReservedNickname(Callback<string> callback);

	// Token: 0x060083E0 RID: 33760
	void ReportNickname(string profileId, Callback callback);

	// Token: 0x17001460 RID: 5216
	// (get) Token: 0x060083E1 RID: 33761
	bool ReportAvailable { get; }

	// Token: 0x060083E2 RID: 33762
	bool PlayerAlreadyReported(string playerId);

	// Token: 0x060083E3 RID: 33763
	void GetRaidReadyStatus(string locationId, bool savage, string dt, string keyId, ERaidMode raidMode, EPlayersSpawnPlace spawnPlace, Callback<GClass1211> callback);

	// Token: 0x060083E4 RID: 33764
	void SendClientProfileSettings(bool groupInvitesRestrict, Callback callback);

	// Token: 0x060083E5 RID: 33765
	void SendGroupInvite(string accountId, bool inLobby, Callback<string> callback);

	// Token: 0x060083E6 RID: 33766
	void CancelInvite(string requestId, Callback callback);

	// Token: 0x060083E7 RID: 33767
	void CancelAllInvites(Callback callback);

	// Token: 0x060083E8 RID: 33768
	void AcceptGroupInvite(string requestId, Callback<GClass1206[]> callback);

	// Token: 0x060083E9 RID: 33769
	void GetGroupStatus(Callback<GClass1212> callback);

	// Token: 0x060083EA RID: 33770
	void DeclineGroupInvite(string requestId, Callback callback);

	// Token: 0x060083EB RID: 33771
	void SetReadyRaidStatus(Callback callback);

	// Token: 0x060083EC RID: 33772
	void SetNotReadyReadyStatus(Callback callback);

	// Token: 0x060083ED RID: 33773
	void DisbandRaidGroup(Callback callback);

	// Token: 0x060083EE RID: 33774
	Task<IResult> LeaveMatchmakerGroup();

	// Token: 0x060083EF RID: 33775
	void RemovePlayerFromGroup(string profileAid, Callback callback);

	// Token: 0x060083F0 RID: 33776
	void TransferGroupLeadership(string profileAid, Callback callback);

	// Token: 0x060083F1 RID: 33777
	Task<IResult> ExitFromMatchmakerGroupMenu();

	// Token: 0x060083F2 RID: 33778
	Task<GClass1193> StartGameGroupLeader(string groupId, bool isPet);

	// Token: 0x060083F3 RID: 33779
	Task<GClass1193> StartGameGroupPlayer(string groupId, bool isPet);

	// Token: 0x060083F4 RID: 33780
	Task<IResult> CancelGameSearching(bool isPet);

	// Token: 0x060083F5 RID: 33781
	Task<IResult> StartLookingForGroup();

	// Token: 0x060083F6 RID: 33782
	Task<IResult> StopLookingForGroup();

	// Token: 0x060083F7 RID: 33783
	Task<bool> IsMatchingAvailable();

	// Token: 0x060083F8 RID: 33784
	Task<GClass1193> StartMatching(string locationId, bool isPet, EDateTime dateTime, string keyId);

	// Token: 0x060083F9 RID: 33785
	void AbortMatching(bool isPet, Callback callback);

	// Token: 0x060083FA RID: 33786
	void QuestFail(string qid, Callback callback);

	// Token: 0x17001461 RID: 5217
	// (get) Token: 0x060083FB RID: 33787
	long TotalInGameTime { get; }

	// Token: 0x060083FC RID: 33788
	string GetSessionId(bool isPet);

	// Token: 0x060083FD RID: 33789
	Profile GetProfileBySide(ESideType side);

	// Token: 0x17001462 RID: 5218
	// (get) Token: 0x060083FE RID: 33790
	bool LimitedServersAvailability { get; }

	// Token: 0x17001463 RID: 5219
	// (get) Token: 0x060083FF RID: 33791
	GameServerClass[] GameServers { get; }

	// Token: 0x06008400 RID: 33792
	void CreateNotifierChannel(Callback<GClass1227> callback);

	// Token: 0x06008401 RID: 33793
	Task<BackendConfigClass> GetGlobalConfig();

	// Token: 0x06008402 RID: 33794
	Task<GClass1229> GetClientSettingsConfig();

	// Token: 0x17001464 RID: 5220
	// (get) Token: 0x06008403 RID: 33795
	BackendConfigClass BackEndConfig { get; }

	// Token: 0x06008404 RID: 33796
	Task<Dictionary<string, string>> GetLocalization(string locale);

	// Token: 0x06008405 RID: 33797
	Task<MetricsConfigClass> GetMetricsConfig();

	// Token: 0x06008406 RID: 33798
	Task<GClass2882<HandbookData>> RequestHandbookInfo();

	// Token: 0x06008407 RID: 33799
	Task SendMetrics(MetricsClass metrics);

	// Token: 0x06008408 RID: 33800
	void StartKeepAliveCoroutine(int keepAliveInterval);

	// Token: 0x06008409 RID: 33801
	void StopKeepAlive();

	// Token: 0x17001465 RID: 5221
	// (get) Token: 0x0600840A RID: 33802
	// (set) Token: 0x0600840B RID: 33803
	PlayerVisualRepresentation LastPlayerState { get; set; }

	// Token: 0x0600840C RID: 33804
	void LoadTextureMain(string url, Callback<Texture2D> callback = null);

	// Token: 0x0600840D RID: 33805
	Task<Profile[]> LoadBots(List<WaveInfo> limit);

	// Token: 0x0600840E RID: 33806
	void SetBotSettings(BackendConfigClass backEndConfig);

	// Token: 0x0600840F RID: 33807
	Task Destroy();
}
