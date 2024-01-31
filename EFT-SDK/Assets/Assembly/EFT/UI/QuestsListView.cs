using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BA6 RID: 11174
	public sealed class QuestsListView : UIElement
	{
		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x0600DC75 RID: 56437 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DC76 RID: 56438 RVA: 0x00002050 File Offset: 0x00000250
		private static bool ListShowLocked
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

		// Token: 0x0600DC77 RID: 56439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DC78 RID: 56440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ISession backendSession, GInterface313 controller, AbstractQuestControllerClass questController, TraderClass trader, QuestView questView)
		{
			throw null;
		}

		// Token: 0x0600DC79 RID: 56441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRemoveQuestFromList(GClass1246 removedQuest)
		{
			throw null;
		}

		// Token: 0x0600DC7A RID: 56442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateVisibility()
		{
			throw null;
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AutoSelectQuest()
		{
			throw null;
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnQuestSelected(QuestListItem view)
		{
			throw null;
		}

		// Token: 0x0600DC7D RID: 56445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnToggleShowCompleted(bool show)
		{
			throw null;
		}

		// Token: 0x0600DC7E RID: 56446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnToggleShowLocked(bool show)
		{
			throw null;
		}

		// Token: 0x0600DC7F RID: 56447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E0AB RID: 57515
		private const string LIST_SHOW_LOCKED_KEY = "quests_list_ShowLocked";

		// Token: 0x0400E0AC RID: 57516
		[SerializeField]
		private RectTransform _questListContainer;

		// Token: 0x0400E0AD RID: 57517
		[SerializeField]
		private QuestListItem _questListItemPrefab;

		// Token: 0x0400E0AE RID: 57518
		[SerializeField]
		private CustomTextMeshProUGUI _questsCounterText;

		// Token: 0x0400E0AF RID: 57519
		[SerializeField]
		private Toggle _toggleShowCompleted;

		// Token: 0x0400E0B0 RID: 57520
		[SerializeField]
		private Toggle _toggleShowLocked;

		// Token: 0x0400E0B1 RID: 57521
		private AbstractQuestControllerClass _questController;

		// Token: 0x0400E0B2 RID: 57522
		private QuestView _questView;

		// Token: 0x0400E0B3 RID: 57523
		private ISession _backendSession;

		// Token: 0x0400E0B4 RID: 57524
		private GClass3079<GClass1246, QuestListItem> _questBindableViewList;

		// Token: 0x0400E0B5 RID: 57525
		private QuestListItem _questListItemSelected;

		// Token: 0x0400E0B6 RID: 57526
		private readonly List<EQuestStatus> _questListExcludeFilter;

		// Token: 0x0400E0B7 RID: 57527
		private GInterface313 _itemController;

		// Token: 0x0400E0B8 RID: 57528
		private TraderClass _trader;

		// Token: 0x0400E0B9 RID: 57529
		private bool _listShowCompleted;

		// Token: 0x0400E0BA RID: 57530
		private static bool? _listShowLocked;

		// Token: 0x02002BA7 RID: 11175
		[CompilerGenerated]
		private sealed class Class2648
		{
			// Token: 0x0400E0BB RID: 57531
			public string traderId;

			// Token: 0x0400E0BC RID: 57532
			public QuestsListView questsListView_0;
		}

		// Token: 0x02002BA8 RID: 11176
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2649
		{
			// Token: 0x0400E0BD RID: 57533
			public static readonly QuestsListView.Class2649 class2649_0;

			// Token: 0x0400E0BE RID: 57534
			public static Func<KeyValuePair<GClass1246, QuestListItem>, bool> func_0;
		}
	}
}
