using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI.Matchmaker;
using EFT.UI.Screens;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002994 RID: 10644
	public sealed class GroupPanel : UIElement
	{
		// Token: 0x140002E7 RID: 743
		// (add) Token: 0x0600D3BC RID: 54204 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D3BD RID: 54205 RVA: 0x00002050 File Offset: 0x00000250
		public event Action RaidReadyButtonPressed
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

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x0600D3BE RID: 54206 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D3BF RID: 54207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3166 matchmakerPlayersController, GClass1839 socialNetwork)
		{
			throw null;
		}

		// Token: 0x0600D3C1 RID: 54209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass1207 leader)
		{
			throw null;
		}

		// Token: 0x0600D3C2 RID: 54210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EEftScreenType eftScreen)
		{
			throw null;
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGroupsAvailability(bool available)
		{
			throw null;
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass1207 raidPlayer)
		{
			throw null;
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass1207 raidPlayer)
		{
			throw null;
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(EMatchingType _)
		{
			throw null;
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(GClass1207 player, bool _)
		{
			throw null;
		}

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D3CA RID: 54218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D3CB RID: 54219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600D3CC RID: 54220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowContextMenu(GClass1206 player, PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400D622 RID: 54818
		private const string string_0 = "InRaidButton";

		// Token: 0x0400D623 RID: 54819
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400D624 RID: 54820
		[SerializeField]
		private SimpleContextMenu _contextMenu;

		// Token: 0x0400D625 RID: 54821
		[SerializeField]
		private Transform _groupListContainer;

		// Token: 0x0400D626 RID: 54822
		[SerializeField]
		private Transform _emptyMemberContainer;

		// Token: 0x0400D627 RID: 54823
		[SerializeField]
		private GroupMemberView _groupMemberTemplate;

		// Token: 0x0400D628 RID: 54824
		[SerializeField]
		private EmptyMemberView _emptyMemberTemplate;

		// Token: 0x0400D629 RID: 54825
		[SerializeField]
		private Button _inRaidButton;

		// Token: 0x0400D62A RID: 54826
		[SerializeField]
		private TextMeshProUGUI _inRaidButtonLabel;

		// Token: 0x0400D62B RID: 54827
		[SerializeField]
		private GameObject _groupPanelBlocker;

		// Token: 0x0400D62C RID: 54828
		private readonly List<EmptyMemberView> list_0;

		// Token: 0x0400D62D RID: 54829
		private GClass3166 gclass3166_0;

		// Token: 0x0400D62E RID: 54830
		private GClass3357<GClass1207> gclass3357_0;

		// Token: 0x0400D62F RID: 54831
		private bool bool_0;

		// Token: 0x0400D630 RID: 54832
		private bool bool_1;

		// Token: 0x0400D631 RID: 54833
		private GClass3079<GClass1207, GroupMemberView> gclass3079_0;

		// Token: 0x0400D632 RID: 54834
		private GClass1839 gclass1839_0;

		// Token: 0x02002995 RID: 10645
		[CompilerGenerated]
		private sealed class Class2435
		{
			// Token: 0x0600D3CD RID: 54221 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1207 player, GroupMemberView playerPanel)
			{
				throw null;
			}

			// Token: 0x0600D3CE RID: 54222 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400D633 RID: 54835
			public BindableState<GClass3167> group;

			// Token: 0x0400D634 RID: 54836
			public GroupPanel groupPanel_0;

			// Token: 0x0400D635 RID: 54837
			public GClass3357<GClass1207> groupPlayers;
		}

		// Token: 0x02002996 RID: 10646
		[CompilerGenerated]
		private sealed class Class2436
		{
			// Token: 0x0600D3CF RID: 54223 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D636 RID: 54838
			public GroupMemberView playerPanel;

			// Token: 0x0400D637 RID: 54839
			public GroupPanel.Class2435 class2435_0;
		}

		// Token: 0x02002997 RID: 10647
		[CompilerGenerated]
		private sealed class Class2437
		{
			// Token: 0x0600D3D0 RID: 54224 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1207 p)
			{
				throw null;
			}

			// Token: 0x0400D638 RID: 54840
			public GClass1207 raidPlayer;
		}
	}
}
