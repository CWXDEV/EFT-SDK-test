using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using ChatShared;
using Comfort.Common;
using EFT;
using EFT.UI;
using EFT.UI.Matchmaker;
using UnityEngine;

// Token: 0x02002D91 RID: 11665
public sealed class GClass3166
{
	// Token: 0x14000332 RID: 818
	// (add) Token: 0x0600E54D RID: 58701 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E54E RID: 58702 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnGroupCreated
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

	// Token: 0x14000333 RID: 819
	// (add) Token: 0x0600E54F RID: 58703 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E550 RID: 58704 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnGroupRemoved
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

	// Token: 0x14000334 RID: 820
	// (add) Token: 0x0600E551 RID: 58705 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E552 RID: 58706 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnGroupStatusChanged
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

	// Token: 0x14000335 RID: 821
	// (add) Token: 0x0600E553 RID: 58707 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E554 RID: 58708 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnLimitedServersAvailability
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

	// Token: 0x14000336 RID: 822
	// (add) Token: 0x0600E555 RID: 58709 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E556 RID: 58710 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnActiveInviteCancelled
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

	// Token: 0x14000337 RID: 823
	// (add) Token: 0x0600E557 RID: 58711 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E558 RID: 58712 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnInviteAccepted
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

	// Token: 0x14000338 RID: 824
	// (add) Token: 0x0600E559 RID: 58713 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E55A RID: 58714 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1210> OnInviteReceived
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

	// Token: 0x14000339 RID: 825
	// (add) Token: 0x0600E55B RID: 58715 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E55C RID: 58716 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnInviteInRaidReceived
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

	// Token: 0x1400033A RID: 826
	// (add) Token: 0x0600E55D RID: 58717 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E55E RID: 58718 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EMatchingType> OnMatchingTypeUpdate
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

	// Token: 0x1400033B RID: 827
	// (add) Token: 0x0600E55F RID: 58719 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E560 RID: 58720 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EMatchingStatus> OnMatchingAvailabilityChanged
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

	// Token: 0x1400033C RID: 828
	// (add) Token: 0x0600E561 RID: 58721 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E562 RID: 58722 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnLookingForGroupStatusChanged
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

	// Token: 0x1400033D RID: 829
	// (add) Token: 0x0600E563 RID: 58723 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E564 RID: 58724 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1207, Vector2> OnPlayerContextRequest
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

	// Token: 0x1400033E RID: 830
	// (add) Token: 0x0600E565 RID: 58725 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E566 RID: 58726 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass1207, bool> OnRaidReadyStatusChanged
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

	// Token: 0x1400033F RID: 831
	// (add) Token: 0x0600E567 RID: 58727 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E568 RID: 58728 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnReadyToStartRaid
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

	// Token: 0x170027E2 RID: 10210
	// (get) Token: 0x0600E569 RID: 58729 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3357<GClass1210> SentInvites
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027E3 RID: 10211
	// (get) Token: 0x0600E56A RID: 58730 RVA: 0x00002050 File Offset: 0x00000250
	public BindableState<GClass3167> GroupState
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027E4 RID: 10212
	// (get) Token: 0x0600E56B RID: 58731 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3364<GClass1207> RaidReadyPlayers
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027E5 RID: 10213
	// (get) Token: 0x0600E56C RID: 58732 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3357<GClass1207> GroupPlayers
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027E6 RID: 10214
	// (get) Token: 0x0600E56D RID: 58733 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E56E RID: 58734 RVA: 0x00002050 File Offset: 0x00000250
	public bool Initialized
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

	// Token: 0x170027E7 RID: 10215
	// (get) Token: 0x0600E56F RID: 58735 RVA: 0x00002050 File Offset: 0x00000250
	public BindableState<bool> LeaderRaidReadyState
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027E8 RID: 10216
	// (get) Token: 0x0600E570 RID: 58736 RVA: 0x00002050 File Offset: 0x00000250
	public bool LeaderRaidReadyStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027E9 RID: 10217
	// (get) Token: 0x0600E571 RID: 58737 RVA: 0x00002050 File Offset: 0x00000250
	public int TotalReadyGroupPlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027EA RID: 10218
	// (get) Token: 0x0600E572 RID: 58738 RVA: 0x00002050 File Offset: 0x00000250
	public bool LookingForGroupBlocked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027EB RID: 10219
	// (get) Token: 0x0600E573 RID: 58739 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLocalGame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027EC RID: 10220
	// (get) Token: 0x0600E574 RID: 58740 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E575 RID: 58741 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3167 Group
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170027ED RID: 10221
	// (get) Token: 0x0600E576 RID: 58742 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E577 RID: 58743 RVA: 0x00002050 File Offset: 0x00000250
	public bool LimitedServersAvailability
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170027EE RID: 10222
	// (get) Token: 0x0600E578 RID: 58744 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E579 RID: 58745 RVA: 0x00002050 File Offset: 0x00000250
	public EMatchingStatus MatchingStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170027EF RID: 10223
	// (get) Token: 0x0600E57A RID: 58746 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E57B RID: 58747 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLookingForGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170027F0 RID: 10224
	// (get) Token: 0x0600E57C RID: 58748 RVA: 0x00002050 File Offset: 0x00000250
	public EMatchingType CurrentProfileMatchingStatus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F1 RID: 10225
	// (get) Token: 0x0600E57D RID: 58749 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E57E RID: 58750 RVA: 0x00002050 File Offset: 0x00000250
	public bool Disposed
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

	// Token: 0x170027F2 RID: 10226
	// (get) Token: 0x0600E57F RID: 58751 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMeInGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F3 RID: 10227
	// (get) Token: 0x0600E580 RID: 58752 RVA: 0x00002050 File Offset: 0x00000250
	public string GroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F4 RID: 10228
	// (get) Token: 0x0600E581 RID: 58753 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsOwner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F5 RID: 10229
	// (get) Token: 0x0600E582 RID: 58754 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLeader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F6 RID: 10230
	// (get) Token: 0x0600E583 RID: 58755 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanShowGroupPreview
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F7 RID: 10231
	// (get) Token: 0x0600E584 RID: 58756 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F8 RID: 10232
	// (get) Token: 0x0600E585 RID: 58757 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027F9 RID: 10233
	// (get) Token: 0x0600E586 RID: 58758 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027FA RID: 10234
	// (get) Token: 0x0600E587 RID: 58759 RVA: 0x00002050 File Offset: 0x00000250
	public bool CoopAvailableForGroup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027FB RID: 10235
	// (get) Token: 0x0600E588 RID: 58760 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInvited
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027FC RID: 10236
	// (get) Token: 0x0600E589 RID: 58761 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1210 ActiveInvite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027FD RID: 10237
	// (get) Token: 0x0600E58A RID: 58762 RVA: 0x00002050 File Offset: 0x00000250
	public bool GroupIsFull
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170027FE RID: 10238
	// (get) Token: 0x0600E58B RID: 58763 RVA: 0x00002050 File Offset: 0x00000250
	public string CurrentProfileAid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600E58C RID: 58764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600E58D RID: 58765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass1207 _, bool __)
	{
		throw null;
	}

	// Token: 0x0600E58E RID: 58766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasLockedScav(out string playerName, out double farScavTime)
	{
		throw null;
	}

	// Token: 0x0600E58F RID: 58767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600E590 RID: 58768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateMatchmakerSettings()
	{
		throw null;
	}

	// Token: 0x0600E591 RID: 58769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateMaxGroupCount()
	{
		throw null;
	}

	// Token: 0x0600E592 RID: 58770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetMaxGroupCount()
	{
		throw null;
	}

	// Token: 0x0600E593 RID: 58771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600E594 RID: 58772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_4()
	{
		throw null;
	}

	// Token: 0x0600E595 RID: 58773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600E596 RID: 58774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x0600E597 RID: 58775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1207 CreateRaidPlayer(Profile mainProfile, Profile profileOfPet)
	{
		throw null;
	}

	// Token: 0x0600E598 RID: 58776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1205 CreateRaidPlayerInfo(Profile mainProfile, Profile profileOfPet)
	{
		throw null;
	}

	// Token: 0x0600E599 RID: 58777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportNickname(string profileId)
	{
		throw null;
	}

	// Token: 0x0600E59A RID: 58778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanReportPlayer(string profileId)
	{
		throw null;
	}

	// Token: 0x0600E59B RID: 58779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(GClass1210 invite, Action<bool> callback)
	{
		throw null;
	}

	// Token: 0x0600E59C RID: 58780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(GClass1210 invite)
	{
		throw null;
	}

	// Token: 0x0600E59D RID: 58781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(GClass1210 invite)
	{
		throw null;
	}

	// Token: 0x0600E59E RID: 58782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task UpdateStatus()
	{
		throw null;
	}

	// Token: 0x0600E59F RID: 58783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5A0 RID: 58784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInGroup(string profileAid)
	{
		throw null;
	}

	// Token: 0x0600E5A1 RID: 58785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransferLeadership(string newLeaderAid, Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5A2 RID: 58786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisbandGroup(Action callback = null)
	{
		throw null;
	}

	// Token: 0x0600E5A3 RID: 58787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task LeaveGroup()
	{
		throw null;
	}

	// Token: 0x0600E5A4 RID: 58788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendInvite(string accountId, bool inLobby, Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5A5 RID: 58789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(GClass1207 player, bool inLobby, Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5A6 RID: 58790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(Action callback = null)
	{
		throw null;
	}

	// Token: 0x0600E5A7 RID: 58791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelInvite(string playerAid, Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5A8 RID: 58792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task StartLookingForGroup()
	{
		throw null;
	}

	// Token: 0x0600E5A9 RID: 58793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task StopLookingForGroup()
	{
		throw null;
	}

	// Token: 0x0600E5AA RID: 58794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePlayerFromGroup(string playerAid, Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5AB RID: 58795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInvitedByMe(string playerAid)
	{
		throw null;
	}

	// Token: 0x0600E5AC RID: 58796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EMatchingType GetMatchingType(string profileAid)
	{
		throw null;
	}

	// Token: 0x0600E5AD RID: 58797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass1207 method_13(string profileAid)
	{
		throw null;
	}

	// Token: 0x0600E5AE RID: 58798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentPlayerReadyStatus(bool isReady, Action callback = null)
	{
		throw null;
	}

	// Token: 0x0600E5AF RID: 58799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14(bool status, Action callback)
	{
		throw null;
	}

	// Token: 0x0600E5B0 RID: 58800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetReadyStatus(string profileAid)
	{
		throw null;
	}

	// Token: 0x0600E5B1 RID: 58801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartSearchingForGame()
	{
		throw null;
	}

	// Token: 0x0600E5B2 RID: 58802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ExitFromMatchMaker()
	{
		throw null;
	}

	// Token: 0x0600E5B3 RID: 58803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15(NotificationClass notification)
	{
		throw null;
	}

	// Token: 0x0600E5B4 RID: 58804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_16(GClass2003 notificationGroupMatchRaidReady)
	{
		throw null;
	}

	// Token: 0x0600E5B5 RID: 58805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17(GClass2004 notificationGroupMatchRaidNotReady)
	{
		throw null;
	}

	// Token: 0x0600E5B6 RID: 58806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18(GClass2002 notificationMatchRaidSettings)
	{
		throw null;
	}

	// Token: 0x0600E5B7 RID: 58807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19(RaidSettings raidSettings)
	{
		throw null;
	}

	// Token: 0x0600E5B8 RID: 58808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3047 GetContextInteractions(GClass1206 player, bool canShowProfile, bool inLobby = false)
	{
		throw null;
	}

	// Token: 0x0600E5B9 RID: 58809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(ERaidPlayerButton button, Action acceptAction)
	{
		throw null;
	}

	// Token: 0x0600E5BA RID: 58810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(bool revertSettings = true)
	{
		throw null;
	}

	// Token: 0x0600E5BB RID: 58811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22()
	{
		throw null;
	}

	// Token: 0x0600E5BC RID: 58812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23(GClass2006 notification)
	{
		throw null;
	}

	// Token: 0x0600E5BD RID: 58813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_24(GClass1987 notification)
	{
		throw null;
	}

	// Token: 0x0600E5BE RID: 58814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_25(GClass1988 notification)
	{
		throw null;
	}

	// Token: 0x0600E5BF RID: 58815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_26(GClass1989 notification)
	{
		throw null;
	}

	// Token: 0x0600E5C0 RID: 58816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_27(GClass1985 notification)
	{
		throw null;
	}

	// Token: 0x0600E5C1 RID: 58817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_28(GClass1986 notification)
	{
		throw null;
	}

	// Token: 0x0600E5C2 RID: 58818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_29(string playerAid)
	{
		throw null;
	}

	// Token: 0x0600E5C3 RID: 58819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_30(GClass1984 notification)
	{
		throw null;
	}

	// Token: 0x0600E5C4 RID: 58820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(GClass1210 invite)
	{
		throw null;
	}

	// Token: 0x0600E5C5 RID: 58821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32(string ownerAid)
	{
		throw null;
	}

	// Token: 0x0600E5C6 RID: 58822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33()
	{
		throw null;
	}

	// Token: 0x0600E5C7 RID: 58823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateGroupForSoloPlayer()
	{
		throw null;
	}

	// Token: 0x0600E5C8 RID: 58824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_34(string playerAid)
	{
		throw null;
	}

	// Token: 0x0600E5C9 RID: 58825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_35(string playerAid)
	{
		throw null;
	}

	// Token: 0x0600E5CA RID: 58826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_36(GClass1210 invite)
	{
		throw null;
	}

	// Token: 0x0600E5CB RID: 58827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_37()
	{
		throw null;
	}

	// Token: 0x0600E5CC RID: 58828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_38(string playerAid)
	{
		throw null;
	}

	// Token: 0x0600E5CD RID: 58829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_39()
	{
		throw null;
	}

	// Token: 0x0600E5CE RID: 58830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_40(GClass1207 player)
	{
		throw null;
	}

	// Token: 0x0600E5CF RID: 58831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_41(GClass1206[] players)
	{
		throw null;
	}

	// Token: 0x0600E5D0 RID: 58832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_42(string fromAid)
	{
		throw null;
	}

	// Token: 0x0600E5D1 RID: 58833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetCoopBlockReason(out ECoopBlock reason)
	{
		throw null;
	}

	// Token: 0x0600E5D2 RID: 58834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_43(string gameVersion)
	{
		throw null;
	}

	// Token: 0x0600E5D3 RID: 58835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestContextMenuForPlayer(GClass1207 player, Vector2 position)
	{
		throw null;
	}

	// Token: 0x0600E5D4 RID: 58836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenPlayerProfile(string accountId)
	{
		throw null;
	}

	// Token: 0x0600E5D5 RID: 58837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600E5D6 RID: 58838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_44()
	{
		throw null;
	}

	// Token: 0x0600E5D7 RID: 58839 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_45(Result<GClass1212> groupStatusResult)
	{
		throw null;
	}

	// Token: 0x0600E5D8 RID: 58840 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_46()
	{
		throw null;
	}

	// Token: 0x0600E5D9 RID: 58841 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_47()
	{
		throw null;
	}

	// Token: 0x0600E5DA RID: 58842 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_48(GClass1206 x)
	{
		throw null;
	}

	// Token: 0x0600E5DB RID: 58843 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_49(Result<GClass1208> result)
	{
		throw null;
	}

	// Token: 0x0400EA96 RID: 60054
	public const int MAX_PMC_COUNT = 5;

	// Token: 0x0400EA97 RID: 60055
	public const int MAX_SCAV_COUNT = 4;

	// Token: 0x0400EA98 RID: 60056
	public static bool StartLookingForGroupByDefault;

	// Token: 0x0400EA99 RID: 60057
	private static bool bool_0;

	// Token: 0x0400EA9A RID: 60058
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400EA9B RID: 60059
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400EA9C RID: 60060
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400EA9D RID: 60061
	[CompilerGenerated]
	private Action<bool> action_3;

	// Token: 0x0400EA9E RID: 60062
	[CompilerGenerated]
	private Action action_4;

	// Token: 0x0400EA9F RID: 60063
	[CompilerGenerated]
	private Action action_5;

	// Token: 0x0400EAA0 RID: 60064
	[CompilerGenerated]
	private Action<GClass1210> action_6;

	// Token: 0x0400EAA1 RID: 60065
	[CompilerGenerated]
	private Action action_7;

	// Token: 0x0400EAA2 RID: 60066
	[CompilerGenerated]
	private Action<EMatchingType> action_8;

	// Token: 0x0400EAA3 RID: 60067
	[CompilerGenerated]
	private Action<EMatchingStatus> action_9;

	// Token: 0x0400EAA4 RID: 60068
	[CompilerGenerated]
	private Action<bool> action_10;

	// Token: 0x0400EAA5 RID: 60069
	[CompilerGenerated]
	private Action<GClass1207, Vector2> action_11;

	// Token: 0x0400EAA6 RID: 60070
	[CompilerGenerated]
	private Action<GClass1207, bool> action_12;

	// Token: 0x0400EAA7 RID: 60071
	[CompilerGenerated]
	private Action action_13;

	// Token: 0x0400EAA8 RID: 60072
	public readonly BindableState<int> MaxGroupCount;

	// Token: 0x0400EAA9 RID: 60073
	public GClass1207 CurrentPlayer;

	// Token: 0x0400EAAA RID: 60074
	public readonly bool Enabled;

	// Token: 0x0400EAAB RID: 60075
	private readonly List<GClass1210> list_0;

	// Token: 0x0400EAAC RID: 60076
	private RaidSettings raidSettings_0;

	// Token: 0x0400EAAD RID: 60077
	private readonly RaidSettings raidSettings_1;

	// Token: 0x0400EAAE RID: 60078
	private readonly string string_0;

	// Token: 0x0400EAAF RID: 60079
	private EPlayerSide eplayerSide_0;

	// Token: 0x0400EAB0 RID: 60080
	private readonly ISession ginterface145_0;

	// Token: 0x0400EAB1 RID: 60081
	private readonly ItemUiContext itemUiContext_0;

	// Token: 0x0400EAB2 RID: 60082
	private readonly GClass763 gclass763_0;

	// Token: 0x0400EAB3 RID: 60083
	private GClass3167 gclass3167_0;

	// Token: 0x0400EAB4 RID: 60084
	private bool bool_1;

	// Token: 0x0400EAB5 RID: 60085
	private bool bool_2;

	// Token: 0x0400EAB6 RID: 60086
	private bool bool_3;

	// Token: 0x0400EAB7 RID: 60087
	private bool bool_4;

	// Token: 0x0400EAB8 RID: 60088
	private bool bool_5;

	// Token: 0x0400EAB9 RID: 60089
	private EMatchingStatus ematchingStatus_0;

	// Token: 0x0400EABA RID: 60090
	private GClass3087 gclass3087_0;

	// Token: 0x0400EABB RID: 60091
	private readonly GClass2760 gclass2760_0;

	// Token: 0x0400EABC RID: 60092
	[CompilerGenerated]
	private readonly GClass3357<GClass1210> gclass3357_0;

	// Token: 0x0400EABD RID: 60093
	[CompilerGenerated]
	private readonly BindableState<GClass3167> gclass3370_0;

	// Token: 0x0400EABE RID: 60094
	[CompilerGenerated]
	private readonly GClass3364<GClass1207> gclass3364_0;

	// Token: 0x0400EABF RID: 60095
	[CompilerGenerated]
	private readonly GClass3357<GClass1207> gclass3357_1;

	// Token: 0x0400EAC0 RID: 60096
	[CompilerGenerated]
	private bool bool_6;

	// Token: 0x0400EAC1 RID: 60097
	[CompilerGenerated]
	private readonly BindableState<bool> gclass3370_1;

	// Token: 0x0400EAC2 RID: 60098
	[CompilerGenerated]
	private bool bool_7;

	// Token: 0x02002D92 RID: 11666
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2818
	{
		// Token: 0x0600E5DC RID: 58844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 item)
		{
			throw null;
		}

		// Token: 0x0600E5DD RID: 58845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x0600E5DE RID: 58846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x0600E5DF RID: 58847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1207 method_3(GClass1206 x)
		{
			throw null;
		}

		// Token: 0x0400EAC3 RID: 60099
		public static readonly GClass3166.Class2818 class2818_0;

		// Token: 0x0400EAC4 RID: 60100
		public static Func<GClass1207, bool> func_0;

		// Token: 0x0400EAC5 RID: 60101
		public static Callback callback_0;

		// Token: 0x0400EAC6 RID: 60102
		public static Action action_0;

		// Token: 0x0400EAC7 RID: 60103
		public static Func<GClass1206, GClass1207> func_1;
	}

	// Token: 0x02002D93 RID: 11667
	[CompilerGenerated]
	private sealed class Class2819
	{
		// Token: 0x0600E5E0 RID: 58848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 player)
		{
			throw null;
		}

		// Token: 0x0400EAC8 RID: 60104
		public BackendConfigSettingsClass.GClass1372 coopSettings;
	}

	// Token: 0x02002D94 RID: 11668
	[CompilerGenerated]
	private sealed class Class2820
	{
		// Token: 0x0600E5E1 RID: 58849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400EAC9 RID: 60105
		public NotificationManagerClass notificator;

		// Token: 0x0400EACA RID: 60106
		public GClass3166 gclass3166_0;
	}

	// Token: 0x02002D95 RID: 11669
	[CompilerGenerated]
	private sealed class Class2821
	{
		// Token: 0x0600E5E2 RID: 58850 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0()
		{
			throw null;
		}

		// Token: 0x0400EACB RID: 60107
		public CancellationToken cancellationToken;

		// Token: 0x0400EACC RID: 60108
		public GClass3166 gclass3166_0;
	}

	// Token: 0x02002D97 RID: 11671
	[CompilerGenerated]
	private sealed class Class2822
	{
		// Token: 0x0600E5E5 RID: 58853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0()
		{
			throw null;
		}

		// Token: 0x0400EAD4 RID: 60116
		public CancellationToken cancellationToken;

		// Token: 0x0400EAD5 RID: 60117
		public GClass3166 gclass3166_0;
	}

	// Token: 0x02002D99 RID: 11673
	[CompilerGenerated]
	private sealed class Class2823
	{
		// Token: 0x0600E5E8 RID: 58856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1206[]> result)
		{
			throw null;
		}

		// Token: 0x0400EADC RID: 60124
		public GClass3166 gclass3166_0;

		// Token: 0x0400EADD RID: 60125
		public Action<bool> callback;

		// Token: 0x0400EADE RID: 60126
		public GClass1210 invite;
	}

	// Token: 0x02002D9A RID: 11674
	[CompilerGenerated]
	private sealed class Class2824
	{
		// Token: 0x0600E5E9 RID: 58857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1210 x)
		{
			throw null;
		}

		// Token: 0x0400EADF RID: 60127
		public GClass1210 invite;
	}

	// Token: 0x02002D9B RID: 11675
	[CompilerGenerated]
	private sealed class Class2825
	{
		// Token: 0x0600E5EA RID: 58858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400EAE0 RID: 60128
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAE1 RID: 60129
		public GClass1210 invite;
	}

	// Token: 0x02002D9C RID: 11676
	[CompilerGenerated]
	private sealed class Class2826
	{
		// Token: 0x0600E5EB RID: 58859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400EAE2 RID: 60130
		public TaskCompletionSource<bool> source;
	}

	// Token: 0x02002D9D RID: 11677
	[CompilerGenerated]
	private sealed class Class2827
	{
		// Token: 0x0600E5EC RID: 58860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1211> groupStatusResult)
		{
			throw null;
		}

		// Token: 0x0400EAE3 RID: 60131
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAE4 RID: 60132
		public Action callback;
	}

	// Token: 0x02002D9E RID: 11678
	[CompilerGenerated]
	private sealed class Class2828
	{
		// Token: 0x0600E5ED RID: 58861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 player)
		{
			throw null;
		}

		// Token: 0x0400EAE5 RID: 60133
		public string profileAid;
	}

	// Token: 0x02002D9F RID: 11679
	[CompilerGenerated]
	private sealed class Class2829
	{
		// Token: 0x0600E5EE RID: 58862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400EAE6 RID: 60134
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAE7 RID: 60135
		public string newLeaderAid;

		// Token: 0x0400EAE8 RID: 60136
		public Action callback;
	}

	// Token: 0x02002DA0 RID: 11680
	[CompilerGenerated]
	private sealed class Class2830
	{
		// Token: 0x0600E5EF RID: 58863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400EAE9 RID: 60137
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAEA RID: 60138
		public Action callback;
	}

	// Token: 0x02002DA2 RID: 11682
	[CompilerGenerated]
	private sealed class Class2831
	{
		// Token: 0x0600E5F2 RID: 58866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(UpdatableChatMember item)
		{
			throw null;
		}

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass1207 p)
		{
			throw null;
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x0400EAEF RID: 60143
		public string accountId;

		// Token: 0x0400EAF0 RID: 60144
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAF1 RID: 60145
		public GClass1207 player;

		// Token: 0x0400EAF2 RID: 60146
		public bool inLobby;

		// Token: 0x0400EAF3 RID: 60147
		public Action callback;
	}

	// Token: 0x02002DA3 RID: 11683
	[CompilerGenerated]
	private sealed class Class2832
	{
		// Token: 0x0600E5F5 RID: 58869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<string> result)
		{
			throw null;
		}

		// Token: 0x0400EAF4 RID: 60148
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAF5 RID: 60149
		public GClass1207 player;

		// Token: 0x0400EAF6 RID: 60150
		public Action callback;
	}

	// Token: 0x02002DA4 RID: 11684
	[CompilerGenerated]
	private sealed class Class2833
	{
		// Token: 0x0600E5F6 RID: 58870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1210 item)
		{
			throw null;
		}

		// Token: 0x0600E5F7 RID: 58871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x0400EAF7 RID: 60151
		public string playerAid;

		// Token: 0x0400EAF8 RID: 60152
		public GClass3166 gclass3166_0;

		// Token: 0x0400EAF9 RID: 60153
		public Action callback;
	}

	// Token: 0x02002DA7 RID: 11687
	[CompilerGenerated]
	private sealed class Class2834
	{
		// Token: 0x0600E5FC RID: 58876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400EB04 RID: 60164
		public GClass3166 gclass3166_0;

		// Token: 0x0400EB05 RID: 60165
		public string playerAid;

		// Token: 0x0400EB06 RID: 60166
		public Action callback;
	}

	// Token: 0x02002DA8 RID: 11688
	[CompilerGenerated]
	private sealed class Class2835
	{
		// Token: 0x0600E5FD RID: 58877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1210 invite)
		{
			throw null;
		}

		// Token: 0x0400EB07 RID: 60167
		public string playerAid;
	}

	// Token: 0x02002DA9 RID: 11689
	[CompilerGenerated]
	private sealed class Class2836
	{
		// Token: 0x0600E5FE RID: 58878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 groupPlayer)
		{
			throw null;
		}

		// Token: 0x0400EB08 RID: 60168
		public string profileAid;
	}

	// Token: 0x02002DAA RID: 11690
	[CompilerGenerated]
	private sealed class Class2837
	{
		// Token: 0x0600E5FF RID: 58879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0600E600 RID: 58880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x0400EB09 RID: 60169
		public GClass3166 gclass3166_0;

		// Token: 0x0400EB0A RID: 60170
		public Action callback;
	}

	// Token: 0x02002DAC RID: 11692
	[CompilerGenerated]
	private sealed class Class2838
	{
		// Token: 0x0600E603 RID: 58883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(LocationSettingsClass.Location item)
		{
			throw null;
		}

		// Token: 0x0400EB0F RID: 60175
		public string locationName;
	}

	// Token: 0x02002DAD RID: 11693
	[CompilerGenerated]
	private sealed class Class2839
	{
		// Token: 0x0600E604 RID: 58884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1206 player)
		{
			throw null;
		}

		// Token: 0x0600E605 RID: 58885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass1210 i)
		{
			throw null;
		}

		// Token: 0x0400EB10 RID: 60176
		public GClass1984 notification;

		// Token: 0x0400EB11 RID: 60177
		public GClass1210 invite;
	}

	// Token: 0x02002DAE RID: 11694
	[CompilerGenerated]
	private sealed class Class2840
	{
		// Token: 0x0600E606 RID: 58886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1210 item)
		{
			throw null;
		}

		// Token: 0x0400EB12 RID: 60178
		public string ownerAid;
	}

	// Token: 0x02002DAF RID: 11695
	[CompilerGenerated]
	private sealed class Class2841
	{
		// Token: 0x0600E607 RID: 58887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 player)
		{
			throw null;
		}

		// Token: 0x0400EB13 RID: 60179
		public string playerAid;
	}

	// Token: 0x02002DB0 RID: 11696
	[CompilerGenerated]
	private sealed class Class2842
	{
		// Token: 0x0600E608 RID: 58888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 player)
		{
			throw null;
		}

		// Token: 0x0400EB14 RID: 60180
		public string playerAid;
	}

	// Token: 0x02002DB1 RID: 11697
	[CompilerGenerated]
	private sealed class Class2843
	{
		// Token: 0x0600E609 RID: 58889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1210 x)
		{
			throw null;
		}

		// Token: 0x0400EB15 RID: 60181
		public string playerAid;
	}

	// Token: 0x02002DB2 RID: 11698
	[CompilerGenerated]
	private sealed class Class2844
	{
		// Token: 0x0600E60A RID: 58890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 p)
		{
			throw null;
		}

		// Token: 0x0600E60B RID: 58891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass1207 x)
		{
			throw null;
		}

		// Token: 0x0400EB16 RID: 60182
		public GClass1207 player;
	}

	// Token: 0x02002DB3 RID: 11699
	[CompilerGenerated]
	private sealed class Class2845
	{
		// Token: 0x0600E60C RID: 58892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1207 gp)
		{
			throw null;
		}

		// Token: 0x0400EB17 RID: 60183
		public GClass1206 x;
	}

	// Token: 0x02002DB4 RID: 11700
	[CompilerGenerated]
	private sealed class Class2846
	{
		// Token: 0x0600E60D RID: 58893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1210 x)
		{
			throw null;
		}

		// Token: 0x0400EB18 RID: 60184
		public string fromAid;
	}
}
