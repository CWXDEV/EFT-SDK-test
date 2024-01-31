using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.Communications;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.UI;
using EFT.UI.Chat;
using EFT.UI.Map;
using EFT.UI.Matchmaker;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02001742 RID: 5954
public sealed class MainMenuController : Operation, NotifierView.GInterface366
{
	// Token: 0x06007F7E RID: 32638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task<MainMenuController> Execute(IBackendInterface<ISession> backEnd, EnvironmentUI environmentUI, MenuUI menuUI, CommonUI commonUI, PreloaderUI preloaderUI, RaidSettings raidSettings, TarkovApplication.GClass1813 hideoutController, Action onLogoutPressed, Action reconnectAction)
	{
		throw null;
	}

	// Token: 0x170013D3 RID: 5075
	// (get) Token: 0x06007F7F RID: 32639 RVA: 0x00002050 File Offset: 0x00000250
	public IHealthController HealthController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170013D4 RID: 5076
	// (get) Token: 0x06007F80 RID: 32640 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007F81 RID: 32641 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2760 InventoryController
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

	// Token: 0x170013D5 RID: 5077
	// (get) Token: 0x06007F82 RID: 32642 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007F83 RID: 32643 RVA: 0x00002050 File Offset: 0x00000250
	public string GroupId
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

	// Token: 0x170013D6 RID: 5078
	// (get) Token: 0x06007F84 RID: 32644 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007F85 RID: 32645 RVA: 0x00002050 File Offset: 0x00000250
	public EMatchingType MatchingType
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

	// Token: 0x170013D7 RID: 5079
	// (get) Token: 0x06007F86 RID: 32646 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007F87 RID: 32647 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInSession
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06007F88 RID: 32648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(EEftScreenType eftScreenType)
	{
		throw null;
	}

	// Token: 0x06007F89 RID: 32649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06007F8A RID: 32650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06007F8B RID: 32651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopAfkMonitor()
	{
		throw null;
	}

	// Token: 0x06007F8C RID: 32652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_3()
	{
		throw null;
	}

	// Token: 0x06007F8D RID: 32653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnProfileChangeApplied(ENotificationRequirements requirement)
	{
		throw null;
	}

	// Token: 0x06007F8E RID: 32654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06007F8F RID: 32655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_5()
	{
		throw null;
	}

	// Token: 0x06007F90 RID: 32656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GClass1763 skill)
	{
		throw null;
	}

	// Token: 0x06007F91 RID: 32657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(ISession session, Profile mainProfile, Profile scavProfile, GClass2760 mainController)
	{
		throw null;
	}

	// Token: 0x06007F92 RID: 32658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_8()
	{
		throw null;
	}

	// Token: 0x06007F93 RID: 32659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_9()
	{
		throw null;
	}

	// Token: 0x06007F94 RID: 32660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10(GClass1200 preset)
	{
		throw null;
	}

	// Token: 0x06007F95 RID: 32661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(bool isActive, EBonusType bonusType)
	{
		throw null;
	}

	// Token: 0x06007F96 RID: 32662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreProfile()
	{
		throw null;
	}

	// Token: 0x06007F97 RID: 32663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(int errorCode, string error)
	{
		throw null;
	}

	// Token: 0x06007F98 RID: 32664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13()
	{
		throw null;
	}

	// Token: 0x06007F99 RID: 32665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14(IInventoryWarning inventoryWarning)
	{
		throw null;
	}

	// Token: 0x06007F9A RID: 32666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_15()
	{
		throw null;
	}

	// Token: 0x06007F9B RID: 32667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowScreen(EMenuType screen, bool turnOn)
	{
		throw null;
	}

	// Token: 0x06007F9C RID: 32668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_16(EAreaType? area = null)
	{
		throw null;
	}

	// Token: 0x06007F9D RID: 32669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_17()
	{
		throw null;
	}

	// Token: 0x06007F9E RID: 32670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_18()
	{
		throw null;
	}

	// Token: 0x06007F9F RID: 32671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_19()
	{
		throw null;
	}

	// Token: 0x06007FA0 RID: 32672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(EEftScreenType eftScreenType, Action showAction)
	{
		throw null;
	}

	// Token: 0x06007FA1 RID: 32673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(IEnumerable<EEftScreenType> eftScreenTypes, Action showAction)
	{
		throw null;
	}

	// Token: 0x06007FA2 RID: 32674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private InventoryScreen.GClass3116 method_22()
	{
		throw null;
	}

	// Token: 0x06007FA3 RID: 32675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23()
	{
		throw null;
	}

	// Token: 0x06007FA4 RID: 32676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_24()
	{
		throw null;
	}

	// Token: 0x06007FA5 RID: 32677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_25(IEnumerable<ChatMessageClass> messages, DateTime? expirationTime)
	{
		throw null;
	}

	// Token: 0x06007FA6 RID: 32678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_26()
	{
		throw null;
	}

	// Token: 0x06007FA7 RID: 32679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_27()
	{
		throw null;
	}

	// Token: 0x06007FA8 RID: 32680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_28(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06007FA9 RID: 32681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_29(GClass3195 search)
	{
		throw null;
	}

	// Token: 0x06007FAA RID: 32682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_30(GClass3192 filter)
	{
		throw null;
	}

	// Token: 0x06007FAB RID: 32683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(GClass3192 filter)
	{
		throw null;
	}

	// Token: 0x06007FAC RID: 32684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_32()
	{
		throw null;
	}

	// Token: 0x06007FAD RID: 32685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33()
	{
		throw null;
	}

	// Token: 0x06007FAE RID: 32686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_34()
	{
		throw null;
	}

	// Token: 0x06007FAF RID: 32687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_35()
	{
		throw null;
	}

	// Token: 0x06007FB0 RID: 32688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_36()
	{
		throw null;
	}

	// Token: 0x06007FB1 RID: 32689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_37()
	{
		throw null;
	}

	// Token: 0x06007FB2 RID: 32690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_38()
	{
		throw null;
	}

	// Token: 0x06007FB3 RID: 32691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_39()
	{
		throw null;
	}

	// Token: 0x06007FB4 RID: 32692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_40()
	{
		throw null;
	}

	// Token: 0x06007FB5 RID: 32693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_41()
	{
		throw null;
	}

	// Token: 0x06007FB6 RID: 32694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_42()
	{
		throw null;
	}

	// Token: 0x06007FB7 RID: 32695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_43(out string keyId)
	{
		throw null;
	}

	// Token: 0x06007FB8 RID: 32696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_44()
	{
		throw null;
	}

	// Token: 0x06007FB9 RID: 32697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_45()
	{
		throw null;
	}

	// Token: 0x06007FBA RID: 32698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_46()
	{
		throw null;
	}

	// Token: 0x06007FBB RID: 32699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_47()
	{
		throw null;
	}

	// Token: 0x06007FBC RID: 32700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_48()
	{
		throw null;
	}

	// Token: 0x06007FBD RID: 32701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_49()
	{
		throw null;
	}

	// Token: 0x06007FBE RID: 32702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_50(EAreaType area)
	{
		throw null;
	}

	// Token: 0x06007FBF RID: 32703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_51()
	{
		throw null;
	}

	// Token: 0x06007FC0 RID: 32704 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unsubscribe()
	{
		throw null;
	}

	// Token: 0x06007FC1 RID: 32705 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_52()
	{
		throw null;
	}

	// Token: 0x06007FC2 RID: 32706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(string message)
	{
		throw null;
	}

	// Token: 0x06007FC3 RID: 32707 RVA: 0x00002050 File Offset: 0x00000250
	[UsedImplicitly]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_53(RaidSettings raidSettings)
	{
		throw null;
	}

	// Token: 0x06007FC4 RID: 32708 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_54()
	{
		throw null;
	}

	// Token: 0x06007FC5 RID: 32709 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_55()
	{
		throw null;
	}

	// Token: 0x06007FC6 RID: 32710 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_56()
	{
		throw null;
	}

	// Token: 0x06007FC7 RID: 32711 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_57(Result<ProfileStatusClass[]> _)
	{
		throw null;
	}

	// Token: 0x06007FC8 RID: 32712 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_58()
	{
		throw null;
	}

	// Token: 0x06007FC9 RID: 32713 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_59()
	{
		throw null;
	}

	// Token: 0x06007FCA RID: 32714 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_60()
	{
		throw null;
	}

	// Token: 0x06007FCB RID: 32715 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_61()
	{
		throw null;
	}

	// Token: 0x06007FCC RID: 32716 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_62()
	{
		throw null;
	}

	// Token: 0x06007FCD RID: 32717 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_63()
	{
		throw null;
	}

	// Token: 0x06007FCE RID: 32718 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_64()
	{
		throw null;
	}

	// Token: 0x06007FCF RID: 32719 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_65()
	{
		throw null;
	}

	// Token: 0x06007FD0 RID: 32720 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_66()
	{
		throw null;
	}

	// Token: 0x06007FD1 RID: 32721 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_67()
	{
		throw null;
	}

	// Token: 0x06007FD2 RID: 32722 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_68()
	{
		throw null;
	}

	// Token: 0x06007FD3 RID: 32723 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_69()
	{
		throw null;
	}

	// Token: 0x06007FD4 RID: 32724 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_70()
	{
		throw null;
	}

	// Token: 0x06007FD5 RID: 32725 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_71()
	{
		throw null;
	}

	// Token: 0x06007FD6 RID: 32726 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_72()
	{
		throw null;
	}

	// Token: 0x06007FD7 RID: 32727 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_73()
	{
		throw null;
	}

	// Token: 0x06007FD8 RID: 32728 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_74()
	{
		throw null;
	}

	// Token: 0x04008755 RID: 34645
	private const string string_0 = "Critical error";

	// Token: 0x04008756 RID: 34646
	private const string string_1 = "Inventory/CriticalErrorMessage";

	// Token: 0x04008757 RID: 34647
	private const string string_2 = "MapPointConfigs/";

	// Token: 0x04008758 RID: 34648
	private const float float_0 = 3f;

	// Token: 0x04008759 RID: 34649
	private const float float_1 = 30f;

	// Token: 0x0400875A RID: 34650
	private static readonly Color color_0;

	// Token: 0x0400875B RID: 34651
	private static readonly HashSet<int> hashSet_0;

	// Token: 0x0400875C RID: 34652
	private readonly GClass1814 gclass1814_0;

	// Token: 0x0400875D RID: 34653
	private IBackendInterface<ISession> ginterface32_0;

	// Token: 0x0400875E RID: 34654
	private ISession ginterface145_0;

	// Token: 0x0400875F RID: 34655
	private BonusController bonusController_0;

	// Token: 0x04008760 RID: 34656
	private CommonUI commonUI_0;

	// Token: 0x04008761 RID: 34657
	private PreloaderUI preloaderUI_0;

	// Token: 0x04008762 RID: 34658
	private MenuUI menuUI_0;

	// Token: 0x04008763 RID: 34659
	private EnvironmentUI environmentUI_0;

	// Token: 0x04008764 RID: 34660
	private TarkovApplication.GClass1813 gclass1813_0;

	// Token: 0x04008765 RID: 34661
	private RaidSettings raidSettings_0;

	// Token: 0x04008766 RID: 34662
	private GClass3166 gclass3166_0;

	// Token: 0x04008767 RID: 34663
	private Action action_0;

	// Token: 0x04008768 RID: 34664
	private Action action_1;

	// Token: 0x04008769 RID: 34665
	private MapPoints mapPoints_0;

	// Token: 0x0400876A RID: 34666
	private GClass3195 gclass3195_0;

	// Token: 0x0400876B RID: 34667
	private DateTime dateTime_0;

	// Token: 0x0400876C RID: 34668
	private bool bool_0;

	// Token: 0x0400876D RID: 34669
	private double double_0;

	// Token: 0x0400876E RID: 34670
	private GClass1790 gclass1790_0;

	// Token: 0x0400876F RID: 34671
	private GClass3205 gclass3205_0;

	// Token: 0x04008770 RID: 34672
	private AbstractAchievementControllerClass gclass3207_0;

	// Token: 0x04008771 RID: 34673
	private HealthControllerClass gclass2415_0;

	// Token: 0x04008772 RID: 34674
	[CompilerGenerated]
	private GClass2760 gclass2760_0;

	// Token: 0x04008773 RID: 34675
	[CompilerGenerated]
	private string string_3;

	// Token: 0x04008774 RID: 34676
	[CompilerGenerated]
	private EMatchingType ematchingType_0;

	// Token: 0x02001746 RID: 5958
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1249
	{
		// Token: 0x06007FE1 RID: 32737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass3247> method_0(DailyQuestClass questRange)
		{
			throw null;
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass936 method_3(ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5()
		{
			throw null;
		}

		// Token: 0x04008789 RID: 34697
		public static readonly MainMenuController.Class1249 class1249_0;

		// Token: 0x0400878A RID: 34698
		public static Func<DailyQuestClass, IEnumerable<GClass3247>> func_0;

		// Token: 0x0400878B RID: 34699
		public static Action action_0;

		// Token: 0x0400878C RID: 34700
		public static Func<ChatMessageClass, bool> func_1;

		// Token: 0x0400878D RID: 34701
		public static Func<ChatMessageClass, GClass936> func_2;

		// Token: 0x0400878E RID: 34702
		public static Func<TraderClass, bool> func_3;

		// Token: 0x0400878F RID: 34703
		public static Action action_1;
	}

	// Token: 0x0200174D RID: 5965
	[CompilerGenerated]
	private sealed class Class1250
	{
		// Token: 0x06007FF3 RID: 32755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_0()
		{
			throw null;
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x040087B5 RID: 34741
		public MainMenuController gclass1819_0;

		// Token: 0x040087B6 RID: 34742
		public bool finished;

		// Token: 0x0200174E RID: 5966
		[StructLayout(LayoutKind.Auto)]
		public struct Struct326 : IAsyncStateMachine
		{
			// Token: 0x06007FF5 RID: 32757 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.MoveNext()
			{
				throw null;
			}

			// Token: 0x06007FF6 RID: 32758 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x040087B7 RID: 34743
			public int int_0;

			// Token: 0x040087B8 RID: 34744
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x040087B9 RID: 34745
			public MainMenuController.Class1250 class1250_0;

			// Token: 0x040087BA RID: 34746
			private TaskAwaiter taskAwaiter_0;

			// Token: 0x040087BB RID: 34747
			private TaskAwaiter<IResult> taskAwaiter_1;
		}
	}

	// Token: 0x02001751 RID: 5969
	[CompilerGenerated]
	private sealed class Class1251
	{
		// Token: 0x06007FFB RID: 32763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IEnumerable<ChatMessageClass> messages, DateTime? expirationTime)
		{
			throw null;
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string offerId)
		{
			throw null;
		}

		// Token: 0x040087C6 RID: 34758
		public ChatScreen chatPanel;

		// Token: 0x040087C7 RID: 34759
		public MainMenuController gclass1819_0;
	}

	// Token: 0x02001753 RID: 5971
	[CompilerGenerated]
	private sealed class Class1252
	{
		// Token: 0x06007FFF RID: 32767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item equippedItem)
		{
			throw null;
		}

		// Token: 0x040087CD RID: 34765
		public MainMenuController gclass1819_0;

		// Token: 0x040087CE RID: 34766
		public string[] accessKeys;
	}
}
