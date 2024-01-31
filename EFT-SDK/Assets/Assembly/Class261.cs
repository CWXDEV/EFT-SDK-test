using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using ChatShared;
using Comfort.Common;
using Diz.Binding;
using EFT;
using EFT.HandBook;
using JetBrains.Annotations;
using JsonType;
using UnityEngine;

// Token: 0x020017E6 RID: 6118
internal abstract class Class261 : Class258, GInterface16, GInterface144, GInterface146
{
	// Token: 0x14000187 RID: 391
	// (add) Token: 0x0600830B RID: 33547 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600830C RID: 33548 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBackendErrorCode, string> OnSessionError
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

	// Token: 0x1700144B RID: 5195
	// (get) Token: 0x0600830D RID: 33549 RVA: 0x00002050 File Offset: 0x00000250
	public BindableEvent QueueStatusChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700144C RID: 5196
	// (get) Token: 0x0600830E RID: 33550 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600830F RID: 33551 RVA: 0x00002050 File Offset: 0x00000250
	public Profile[] AllProfiles
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x1700144D RID: 5197
	// (get) Token: 0x06008310 RID: 33552 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008311 RID: 33553 RVA: 0x00002050 File Offset: 0x00000250
	public Profile Profile
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x1700144E RID: 5198
	// (get) Token: 0x06008312 RID: 33554 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008313 RID: 33555 RVA: 0x00002050 File Offset: 0x00000250
	public SessionCountersClass OverallAccountStats
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x1700144F RID: 5199
	// (get) Token: 0x06008314 RID: 33556 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008315 RID: 33557 RVA: 0x00002050 File Offset: 0x00000250
	public ProfileStatusClass[] AllProfileStatus
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

	// Token: 0x17001450 RID: 5200
	// (get) Token: 0x06008316 RID: 33558 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008317 RID: 33559 RVA: 0x00002050 File Offset: 0x00000250
	public BackendConfigClass BackEndConfig
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

	// Token: 0x17001451 RID: 5201
	// (get) Token: 0x06008318 RID: 33560 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1839 SocialNetwork
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001452 RID: 5202
	// (get) Token: 0x06008319 RID: 33561 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600831A RID: 33562 RVA: 0x00002050 File Offset: 0x00000250
	public ChatServerClass[] ChatServers
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

	// Token: 0x17001453 RID: 5203
	// (get) Token: 0x0600831B RID: 33563 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600831C RID: 33564 RVA: 0x00002050 File Offset: 0x00000250
	public GameServerClass[] GameServers
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001454 RID: 5204
	// (get) Token: 0x0600831D RID: 33565 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600831E RID: 33566 RVA: 0x00002050 File Offset: 0x00000250
	public bool LimitedServersAvailability
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

	// Token: 0x17001455 RID: 5205
	// (get) Token: 0x0600831F RID: 33567 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008320 RID: 33568 RVA: 0x00002050 File Offset: 0x00000250
	public PlayerVisualRepresentation LastPlayerState
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

	// Token: 0x17001456 RID: 5206
	// (get) Token: 0x06008321 RID: 33569 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008322 RID: 33570 RVA: 0x00002050 File Offset: 0x00000250
	public long TotalInGameTime
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001457 RID: 5207
	// (get) Token: 0x06008323 RID: 33571 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06008324 RID: 33572 RVA: 0x00002050 File Offset: 0x00000250
	public bool ReportAvailable
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17001458 RID: 5208
	// (get) Token: 0x06008325 RID: 33573 RVA: 0x00002050 File Offset: 0x00000250
	public ProfileStatusClass ActiveProfileStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001459 RID: 5209
	// (get) Token: 0x06008326 RID: 33574 RVA: 0x00002050 File Offset: 0x00000250
	public Profile ProfileOfPet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06008327 RID: 33575 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateProfile(EPlayerSide profileSide, string profileNickname, string headId, string voiceId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008328 RID: 33576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeProfileStatus(ProfileStatusClass status)
	{
		throw null;
	}

	// Token: 0x06008329 RID: 33577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshProfileStatuses(bool isPet, Callback<ProfileStatusClass[]> callback = null)
	{
		throw null;
	}

	// Token: 0x0600832A RID: 33578 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(bool isPet)
	{
		throw null;
	}

	// Token: 0x0600832B RID: 33579 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(bool isPet, Result<GClass1743> result)
	{
		throw null;
	}

	// Token: 0x0600832C RID: 33580 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_14(bool isPet)
	{
		throw null;
	}

	// Token: 0x0600832D RID: 33581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_15(bool isPet)
	{
		throw null;
	}

	// Token: 0x0600832E RID: 33582
	public abstract string GetSessionId(bool isPet);

	// Token: 0x0600832F RID: 33583
	public abstract Profile GetProfileBySide(ESideType side);

	// Token: 0x06008330 RID: 33584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_16(bool isPet)
	{
		throw null;
	}

	// Token: 0x06008331 RID: 33585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_17()
	{
		throw null;
	}

	// Token: 0x06008332 RID: 33586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProfileStatusClass GetProfileStatus(bool isPet)
	{
		throw null;
	}

	// Token: 0x06008333 RID: 33587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(Callback callback)
	{
		throw null;
	}

	// Token: 0x06008334 RID: 33588
	public abstract Task<BackendConfigClass> GetGlobalConfig();

	// Token: 0x06008335 RID: 33589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass2882<HandbookData>> RequestHandbookInfo()
	{
		throw null;
	}

	// Token: 0x06008336 RID: 33590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1229> GetClientSettingsConfig()
	{
		throw null;
	}

	// Token: 0x06008337 RID: 33591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<MetricsConfigClass> GetMetricsConfig()
	{
		throw null;
	}

	// Token: 0x06008338 RID: 33592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task SendMetrics(MetricsClass metrics)
	{
		throw null;
	}

	// Token: 0x06008339 RID: 33593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1203> GetTemplates(GClass1203 returnInCaseOfCache)
	{
		throw null;
	}

	// Token: 0x0600833A RID: 33594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Dictionary<string, string>> GetLocalization(string locale)
	{
		throw null;
	}

	// Token: 0x0600833B RID: 33595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Dictionary<string, GClass2932>> GetCustomizations()
	{
		throw null;
	}

	// Token: 0x0600833C RID: 33596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Profile[]> LoadBots(List<WaveInfo> conditions)
	{
		throw null;
	}

	// Token: 0x0600833D RID: 33597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBotSettings(BackendConfigClass backEndSettings)
	{
		throw null;
	}

	// Token: 0x0600833E RID: 33598
	public abstract void QuestFail(string qid, Callback callback);

	// Token: 0x0600833F RID: 33599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadTextureMain(string url, Callback<Texture2D> callback = null)
	{
		throw null;
	}

	// Token: 0x06008340 RID: 33600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_19(string baseUrl, string url, [CanBeNull] Callback<Texture2D> callback)
	{
		throw null;
	}

	// Token: 0x06008341 RID: 33601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(string url, Callback<Texture2D> callback)
	{
		throw null;
	}

	// Token: 0x06008342 RID: 33602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void smethod_1(string url, Callback<Texture2D> callback = null)
	{
		throw null;
	}

	// Token: 0x06008343 RID: 33603
	public abstract void ApplyCustomizationWear(string[] suites, Callback onFinished);

	// Token: 0x06008344 RID: 33604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeVoice(string voice, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008345 RID: 33605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> Logout()
	{
		throw null;
	}

	// Token: 0x06008346 RID: 33606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<string[]> GetAvailableAccountCustomization()
	{
		throw null;
	}

	// Token: 0x06008347 RID: 33607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeNickname(string profileId, string nick, Callback<GClass688> callback)
	{
		throw null;
	}

	// Token: 0x06008348 RID: 33608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ValidateNickname(string profileNickname, Callback<object> callback)
	{
		throw null;
	}

	// Token: 0x06008349 RID: 33609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetReservedNickname(Callback<string> callback)
	{
		throw null;
	}

	// Token: 0x0600834A RID: 33610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateNotifierChannel(Callback<GClass1227> callback)
	{
		throw null;
	}

	// Token: 0x0600834B RID: 33611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> IsMatchingAvailable()
	{
		throw null;
	}

	// Token: 0x0600834C RID: 33612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1193> StartMatching(string locationId, bool isPet = false, EDateTime dateTime = EDateTime.CURR, string keyId = "")
	{
		throw null;
	}

	// Token: 0x0600834D RID: 33613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1193> StartGameGroupLeader(string groupId, bool isPet)
	{
		throw null;
	}

	// Token: 0x0600834E RID: 33614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1193> StartGameGroupPlayer(string groupId, bool isPet)
	{
		throw null;
	}

	// Token: 0x0600834F RID: 33615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> CancelGameSearching(bool isPet)
	{
		throw null;
	}

	// Token: 0x06008350 RID: 33616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(string url, bool isPet, object parameters, byte? retries, Callback<GClass1193> callback)
	{
		throw null;
	}

	// Token: 0x06008351 RID: 33617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AbortMatching(bool isPet, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008352 RID: 33618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetRaidReadyStatus(object raidParams, Callback<GClass1211> callback)
	{
		throw null;
	}

	// Token: 0x06008353 RID: 33619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetRaidReadyStatus(string locationId, bool savage, string dt, string keyId, ERaidMode raidMode, EPlayersSpawnPlace spawnPlace, Callback<GClass1211> callback)
	{
		throw null;
	}

	// Token: 0x06008354 RID: 33620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendClientProfileSettings(bool groupInvitesRestrict, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008355 RID: 33621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetGroupStatus(Callback<GClass1212> callback)
	{
		throw null;
	}

	// Token: 0x06008356 RID: 33622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendGroupInvite(string accountId, bool inLobby, Callback<string> callback)
	{
		throw null;
	}

	// Token: 0x06008357 RID: 33623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelInvite(string requestId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008358 RID: 33624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelAllInvites(Callback callback)
	{
		throw null;
	}

	// Token: 0x06008359 RID: 33625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AcceptGroupInvite(string requestId, Callback<GClass1206[]> callback)
	{
		throw null;
	}

	// Token: 0x0600835A RID: 33626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeclineGroupInvite(string requestId, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600835B RID: 33627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetReadyRaidStatus(Callback callback)
	{
		throw null;
	}

	// Token: 0x0600835C RID: 33628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNotReadyReadyStatus(Callback callback)
	{
		throw null;
	}

	// Token: 0x0600835D RID: 33629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisbandRaidGroup(Callback callback)
	{
		throw null;
	}

	// Token: 0x0600835E RID: 33630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> LeaveMatchmakerGroup()
	{
		throw null;
	}

	// Token: 0x0600835F RID: 33631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlayerFromGroup(string profileAid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008360 RID: 33632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> ExitFromMatchmakerGroupMenu()
	{
		throw null;
	}

	// Token: 0x06008361 RID: 33633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransferGroupLeadership(string profileAid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008362 RID: 33634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> StartLookingForGroup()
	{
		throw null;
	}

	// Token: 0x06008363 RID: 33635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> StopLookingForGroup()
	{
		throw null;
	}

	// Token: 0x06008364 RID: 33636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportNickname(string profileId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008365 RID: 33637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool PlayerAlreadyReported(string playerId)
	{
		throw null;
	}

	// Token: 0x06008366 RID: 33638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetChatServers(string versionId, Callback<ChatServerClass[]> callback)
	{
		throw null;
	}

	// Token: 0x06008367 RID: 33639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetOtherPlayerProfile(string accountId, Callback<GClass1208> callback)
	{
		throw null;
	}

	// Token: 0x06008368 RID: 33640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChatGetDialogList(int limit, int offset, Callback<GClass930[]> callback)
	{
		throw null;
	}

	// Token: 0x06008369 RID: 33641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChatGetDialogMessages(string id, int type, int limit, double time, Callback<GClass932> callback)
	{
		throw null;
	}

	// Token: 0x0600836A RID: 33642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PinDialog(string dialogId, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600836B RID: 33643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnpinDialog(string dialogId, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600836C RID: 33644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AllAttachmentsFromDialog(string dialogId, Callback<GClass932> callback)
	{
		throw null;
	}

	// Token: 0x0600836D RID: 33645
	public abstract Task<bool> RedeemProfileRewards(GStruct72[] rewards);

	// Token: 0x0600836E RID: 33646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetDialogInformation(string dialogId, Callback<GClass930> callback)
	{
		throw null;
	}

	// Token: 0x0600836F RID: 33647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MutePlayer(string uid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008370 RID: 33648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnmutePlayer(string uid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008371 RID: 33649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InviteToDialogue(string dialogId, string[] uid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008372 RID: 33650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFromDialogue(string dialogId, string uid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008373 RID: 33651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LeaveChatDialogue(string dialogId, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008374 RID: 33652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChatReadDialogues(string[] dialogs, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008375 RID: 33653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindAccountByNickname(string nickname, Callback<UpdatableChatMember[]> callback)
	{
		throw null;
	}

	// Token: 0x06008376 RID: 33654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetFriendsList(Callback<GClass926> callback)
	{
		throw null;
	}

	// Token: 0x06008377 RID: 33655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFromFriendsList(string id, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008378 RID: 33656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetInputFriendsRequests(Callback<GClass927[]> callback)
	{
		throw null;
	}

	// Token: 0x06008379 RID: 33657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetOutputFriendsRequests(Callback<GClass927[]> callback)
	{
		throw null;
	}

	// Token: 0x0600837A RID: 33658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendFriendRequest(string id, Callback<GClass3172> callback)
	{
		throw null;
	}

	// Token: 0x0600837B RID: 33659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> CancelFriendRequest(string profileId)
	{
		throw null;
	}

	// Token: 0x0600837C RID: 33660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AcceptFriendRequest(string profileId, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600837D RID: 33661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task AcceptAllFriendRequests()
	{
		throw null;
	}

	// Token: 0x0600837E RID: 33662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeclineFriendRequest(string profileId, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600837F RID: 33663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransferChatLeadership(string dialogId, string uid, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008380 RID: 33664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChatCreateGroupDialog(string chatName, string[] groupMembers, Callback callback)
	{
		throw null;
	}

	// Token: 0x06008381 RID: 33665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChatSendMessage(string id, int type, string text, string replyTo, Callback<string> callback)
	{
		throw null;
	}

	// Token: 0x06008382 RID: 33666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChatDeleteMessage(string dialogId, string messageId, Callback<string> callback)
	{
		throw null;
	}

	// Token: 0x06008383 RID: 33667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> ChatDeleteAllMessages(string dialogId)
	{
		throw null;
	}

	// Token: 0x06008384 RID: 33668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> DeleteDialog(string dialogId)
	{
		throw null;
	}

	// Token: 0x06008385 RID: 33669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartKeepAliveCoroutine(int keepAliveInterval)
	{
		throw null;
	}

	// Token: 0x06008386 RID: 33670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopKeepAlive()
	{
		throw null;
	}

	// Token: 0x06008387 RID: 33671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void vmethod_0(EBackendErrorCode errorCode, string errorMessage)
	{
		throw null;
	}

	// Token: 0x06008388 RID: 33672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(ERequestErrorHandlingResult handlingResult)
	{
		throw null;
	}

	// Token: 0x06008389 RID: 33673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task Destroy()
	{
		throw null;
	}

	// Token: 0x0600838A RID: 33674 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_22(ProfileStatusClass status)
	{
		throw null;
	}

	// Token: 0x0600838B RID: 33675 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_23(Profile p)
	{
		throw null;
	}

	// Token: 0x0600838C RID: 33676 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_24(ref Class261.Struct382 struct382_0)
	{
		throw null;
	}

	// Token: 0x04008ACF RID: 35535
	[CompilerGenerated]
	private Action<EBackendErrorCode, string> action_0;

	// Token: 0x04008AD0 RID: 35536
	protected GClass1188 gclass1188_0;

	// Token: 0x04008AD1 RID: 35537
	protected DateTime dateTime_0;

	// Token: 0x04008AD2 RID: 35538
	private Task task_0;

	// Token: 0x04008AD3 RID: 35539
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x04008AD4 RID: 35540
	protected int int_1;

	// Token: 0x04008AD5 RID: 35541
	private readonly HashSet<string> hashSet_1;

	// Token: 0x04008AD6 RID: 35542
	private Callback<ProfileStatusClass[]> callback_0;

	// Token: 0x04008AD7 RID: 35543
	private Callback<GClass1193> callback_1;

	// Token: 0x04008AD8 RID: 35544
	private Callback callback_2;

	// Token: 0x04008AD9 RID: 35545
	[CompilerGenerated]
	private readonly BindableEvent bindableEvent_0;

	// Token: 0x04008ADA RID: 35546
	[CompilerGenerated]
	private Profile[] profile_0;

	// Token: 0x04008ADB RID: 35547
	[CompilerGenerated]
	private Profile profile_1;

	// Token: 0x04008ADC RID: 35548
	[CompilerGenerated]
	private SessionCountersClass gclass2198_0;

	// Token: 0x04008ADD RID: 35549
	[CompilerGenerated]
	private ProfileStatusClass[] gclass1744_0;

	// Token: 0x04008ADE RID: 35550
	[CompilerGenerated]
	private BackendConfigClass gclass1228_0;

	// Token: 0x04008ADF RID: 35551
	[CompilerGenerated]
	private readonly GClass1839 gclass1839_0;

	// Token: 0x04008AE0 RID: 35552
	[CompilerGenerated]
	private ChatServerClass[] gclass921_0;

	// Token: 0x04008AE1 RID: 35553
	[CompilerGenerated]
	private GameServerClass[] gclass1176_0;

	// Token: 0x04008AE2 RID: 35554
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x04008AE3 RID: 35555
	[CompilerGenerated]
	private PlayerVisualRepresentation playerVisualRepresentation_0;

	// Token: 0x04008AE4 RID: 35556
	[CompilerGenerated]
	private long long_0;

	// Token: 0x04008AE5 RID: 35557
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x020017E7 RID: 6119
	protected class Class1308
	{
		// Token: 0x0600838D RID: 33677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04008AE6 RID: 35558
		public object Operation;
	}

	// Token: 0x020017E8 RID: 6120
	[CompilerGenerated]
	private sealed class Class1311
	{
		// Token: 0x0600838E RID: 33678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1743> result)
		{
			throw null;
		}

		// Token: 0x04008AE7 RID: 35559
		public Class261 class261_0;

		// Token: 0x04008AE8 RID: 35560
		public bool isPet;
	}

	// Token: 0x020017EA RID: 6122
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct382
	{
		// Token: 0x04008AEE RID: 35566
		public Class261 class261_0;

		// Token: 0x04008AEF RID: 35567
		public bool isPet;
	}

	// Token: 0x020017EC RID: 6124
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1312
	{
		// Token: 0x06008393 RID: 33683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult error)
		{
			throw null;
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult error)
		{
			throw null;
		}

		// Token: 0x04008AF8 RID: 35576
		public static readonly Class261.Class1312 class1312_0;

		// Token: 0x04008AF9 RID: 35577
		public static Callback callback_0;

		// Token: 0x04008AFA RID: 35578
		public static Callback callback_1;
	}

	// Token: 0x020017ED RID: 6125
	[CompilerGenerated]
	private sealed class Class1313
	{
		// Token: 0x06008395 RID: 33685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ProfileStatusClass status)
		{
			throw null;
		}

		// Token: 0x04008AFB RID: 35579
		public Profile profile;
	}

	// Token: 0x020017EE RID: 6126
	[CompilerGenerated]
	private sealed class Class1314
	{
		// Token: 0x06008396 RID: 33686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<MetricsConfigClass> result)
		{
			throw null;
		}

		// Token: 0x04008AFC RID: 35580
		public TaskCompletionSource<MetricsConfigClass> completionSource;
	}

	// Token: 0x020017F0 RID: 6128
	[CompilerGenerated]
	private sealed class Class1315
	{
		// Token: 0x06008399 RID: 33689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Texture2D> result)
		{
			throw null;
		}

		// Token: 0x04008B01 RID: 35585
		public string diskPath;

		// Token: 0x04008B02 RID: 35586
		public Callback<Texture2D> callback;
	}

	// Token: 0x020017F2 RID: 6130
	[CompilerGenerated]
	private sealed class Class1316
	{
		// Token: 0x0600839C RID: 33692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B0A RID: 35594
		public TaskCompletionSource<IResult> taskSource;
	}

	// Token: 0x020017F3 RID: 6131
	[CompilerGenerated]
	private sealed class Class1317
	{
		// Token: 0x0600839D RID: 33693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<string[]> response)
		{
			throw null;
		}

		// Token: 0x04008B0B RID: 35595
		public TaskCompletionSource<string[]> source;
	}

	// Token: 0x020017F4 RID: 6132
	[CompilerGenerated]
	private sealed class Class1318
	{
		// Token: 0x0600839E RID: 33694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass688> status)
		{
			throw null;
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Profile value)
		{
			throw null;
		}

		// Token: 0x04008B0C RID: 35596
		public Class261 class261_0;

		// Token: 0x04008B0D RID: 35597
		public string profileId;

		// Token: 0x04008B0E RID: 35598
		public string nick;

		// Token: 0x04008B0F RID: 35599
		public Callback<GClass688> callback;

		// Token: 0x04008B10 RID: 35600
		public Func<Profile, bool> func_0;
	}

	// Token: 0x020017F5 RID: 6133
	[CompilerGenerated]
	private sealed class Class1319
	{
		// Token: 0x060083A0 RID: 33696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1193> result)
		{
			throw null;
		}

		// Token: 0x04008B11 RID: 35601
		public TaskCompletionSource<GClass1193> completionSource;
	}

	// Token: 0x020017F6 RID: 6134
	[CompilerGenerated]
	private sealed class Class1320
	{
		// Token: 0x060083A1 RID: 33697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B12 RID: 35602
		public TaskCompletionSource<IResult> source;

		// Token: 0x04008B13 RID: 35603
		public Class261 class261_0;

		// Token: 0x04008B14 RID: 35604
		public bool isPet;
	}

	// Token: 0x020017F7 RID: 6135
	[CompilerGenerated]
	private sealed class Class1321
	{
		// Token: 0x060083A2 RID: 33698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1743> result)
		{
			throw null;
		}

		// Token: 0x04008B15 RID: 35605
		public Class261 class261_0;

		// Token: 0x04008B16 RID: 35606
		public Callback<GClass1193> callback;

		// Token: 0x04008B17 RID: 35607
		public bool isPet;
	}

	// Token: 0x020017F8 RID: 6136
	[CompilerGenerated]
	private sealed class Class1322
	{
		// Token: 0x060083A3 RID: 33699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B18 RID: 35608
		public Callback callback;

		// Token: 0x04008B19 RID: 35609
		public Class261 class261_0;

		// Token: 0x04008B1A RID: 35610
		public bool isPet;
	}

	// Token: 0x020017F9 RID: 6137
	[CompilerGenerated]
	private sealed class Class1323
	{
		// Token: 0x060083A4 RID: 33700 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1212> result)
		{
			throw null;
		}

		// Token: 0x04008B1B RID: 35611
		public Callback<GClass1212> callback;
	}

	// Token: 0x020017FA RID: 6138
	[CompilerGenerated]
	private sealed class Class1324
	{
		// Token: 0x060083A5 RID: 33701 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B1C RID: 35612
		public TaskCompletionSource<IResult> completionSource;
	}

	// Token: 0x020017FB RID: 6139
	[CompilerGenerated]
	private sealed class Class1325
	{
		// Token: 0x060083A6 RID: 33702 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B1D RID: 35613
		public TaskCompletionSource<IResult> completionSource;
	}

	// Token: 0x020017FC RID: 6140
	[CompilerGenerated]
	private sealed class Class1326
	{
		// Token: 0x060083A7 RID: 33703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B1E RID: 35614
		public TaskCompletionSource<IResult> source;
	}

	// Token: 0x020017FE RID: 6142
	[CompilerGenerated]
	private sealed class Class1327
	{
		// Token: 0x060083AA RID: 33706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B23 RID: 35619
		public TaskCompletionSource<IResult> source;
	}

	// Token: 0x02001800 RID: 6144
	[CompilerGenerated]
	private sealed class Class1328
	{
		// Token: 0x060083AD RID: 33709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B28 RID: 35624
		public Class261 class261_0;

		// Token: 0x04008B29 RID: 35625
		public string profileId;

		// Token: 0x04008B2A RID: 35626
		public Callback callback;
	}

	// Token: 0x02001801 RID: 6145
	[CompilerGenerated]
	private sealed class Class1329
	{
		// Token: 0x060083AE RID: 33710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<ChatServerClass[]> result)
		{
			throw null;
		}

		// Token: 0x04008B2B RID: 35627
		public Class261 class261_0;

		// Token: 0x04008B2C RID: 35628
		public Callback<ChatServerClass[]> callback;
	}

	// Token: 0x02001802 RID: 6146
	[CompilerGenerated]
	private sealed class Class1330
	{
		// Token: 0x060083AF RID: 33711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1208> response)
		{
			throw null;
		}

		// Token: 0x04008B2D RID: 35629
		public Callback<GClass1208> callback;
	}

	// Token: 0x02001803 RID: 6147
	[CompilerGenerated]
	private sealed class Class1331
	{
		// Token: 0x060083B0 RID: 33712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x04008B2E RID: 35630
		public TaskCompletionSource<bool> source;
	}
}
