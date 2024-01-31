using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Comfort.Common;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B6E RID: 11118
	public sealed class TasksScreen : UIElement
	{
		// Token: 0x14000304 RID: 772
		// (add) Token: 0x0600DBAF RID: 56239 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DBB0 RID: 56240 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnBackButtonClick
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

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600DBB1 RID: 56241 RVA: 0x00002050 File Offset: 0x00000250
		private bool SelectedItemInRaidStash
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600DBB2 RID: 56242 RVA: 0x00002050 File Offset: 0x00000250
		private string RaidQuestWarningText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DBB3 RID: 56243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DBB4 RID: 56244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(InventoryControllerClass inventoryController, AbstractQuestControllerClass questController, ISession session, Profile profile, GClass2490 notesManager)
		{
			throw null;
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool FilterInGame(AbstractQuestControllerClass questController, GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool InRaid()
		{
			throw null;
		}

		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowQuests(AbstractQuestControllerClass questController, ISession session)
		{
			throw null;
		}

		// Token: 0x0600DBB8 RID: 56248 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TaskSelectedHandler(RectTransform rectTransform)
		{
			throw null;
		}

		// Token: 0x0600DBB9 RID: 56249 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Sort(EQuestsSortType sortType, bool sortDirection)
		{
			throw null;
		}

		// Token: 0x0600DBBA RID: 56250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsRegularQuest(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0600DBBB RID: 56251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsDailyQuest(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0600DBBC RID: 56252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QuestItemSelectedHandler([CanBeNull] QuestItemView itemView)
		{
			throw null;
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateNotes()
		{
			throw null;
		}

		// Token: 0x0600DBBE RID: 56254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CleanNotes()
		{
			throw null;
		}

		// Token: 0x0600DBBF RID: 56255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartAddNote()
		{
			throw null;
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateNote(GClass2489 note)
		{
			throw null;
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JournalNote GetNoteView(GClass2489 note)
		{
			throw null;
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartEditNote(GClass2489 note)
		{
			throw null;
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DestroyNote(GClass2489 note)
		{
			throw null;
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnSearchTextChanged(string newText)
		{
			throw null;
		}

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string text)
		{
			throw null;
		}

		// Token: 0x0400DF80 RID: 57216
		private const string ANY_LOCATION_KEY = "any";

		// Token: 0x0400DF81 RID: 57217
		[SerializeField]
		private UIAnimatedToggleSpawner _defaultQuestsToggleSpawner;

		// Token: 0x0400DF82 RID: 57218
		[SerializeField]
		private UIAnimatedToggleSpawner _dailyQuestsToggleSpawner;

		// Token: 0x0400DF83 RID: 57219
		[SerializeField]
		private UIAnimatedToggleSpawner _notesToggleSpawner;

		// Token: 0x0400DF84 RID: 57220
		[SerializeField]
		private UIAnimatedToggleSpawner _questItemsToggleSpawner;

		// Token: 0x0400DF85 RID: 57221
		[SerializeField]
		private GameObject _notesPart;

		// Token: 0x0400DF86 RID: 57222
		[SerializeField]
		private GameObject _questItemsPart;

		// Token: 0x0400DF87 RID: 57223
		[Space]
		[SerializeField]
		private NotesTask _notesTaskTemplate;

		// Token: 0x0400DF88 RID: 57224
		[SerializeField]
		private GameObject _notesTaskDescriptionTemplate;

		// Token: 0x0400DF89 RID: 57225
		[SerializeField]
		private GameObject _notesTaskDescription;

		// Token: 0x0400DF8A RID: 57226
		[SerializeField]
		private QuestsSortPanel QuestsSortPanel;

		// Token: 0x0400DF8B RID: 57227
		[SerializeField]
		private RectTransform _notesTaskContent;

		// Token: 0x0400DF8C RID: 57228
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400DF8D RID: 57229
		[SerializeField]
		private NoteWindow _noteWindow;

		// Token: 0x0400DF8E RID: 57230
		[SerializeField]
		private GameObject _notesIsBusySpinner;

		// Token: 0x0400DF8F RID: 57231
		[SerializeField]
		private CanvasGroup _notesCanvasGroup;

		// Token: 0x0400DF90 RID: 57232
		[SerializeField]
		private JournalNote _noteTemplate;

		// Token: 0x0400DF91 RID: 57233
		[SerializeField]
		private RectTransform _notesContent;

		// Token: 0x0400DF92 RID: 57234
		[SerializeField]
		private DefaultUIButton _addNoteButton;

		// Token: 0x0400DF93 RID: 57235
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DF94 RID: 57236
		[SerializeField]
		[Space]
		private GridView _questRaidGrid;

		// Token: 0x0400DF95 RID: 57237
		[SerializeField]
		private GridView _questStashGrid;

		// Token: 0x0400DF96 RID: 57238
		[SerializeField]
		private CanvasGroup _transferCanvasGroup;

		// Token: 0x0400DF97 RID: 57239
		[SerializeField]
		private DefaultUIButton _transferButtonSpawner;

		// Token: 0x0400DF98 RID: 57240
		[SerializeField]
		private Image _transferIcon;

		// Token: 0x0400DF99 RID: 57241
		[SerializeField]
		private Sprite _downTransferSprite;

		// Token: 0x0400DF9A RID: 57242
		[SerializeField]
		private Sprite _upTransferSprite;

		// Token: 0x0400DF9B RID: 57243
		[SerializeField]
		private Image _warningImage;

		// Token: 0x0400DF9C RID: 57244
		[SerializeField]
		private GameObject _noActiveTasksObject;

		// Token: 0x0400DF9D RID: 57245
		[SerializeField]
		private TextMeshProUGUI _notesCounter;

		// Token: 0x0400DF9E RID: 57246
		[SerializeField]
		private TMP_InputField _searchField;

		// Token: 0x0400DF9F RID: 57247
		private EQuestsSortType _sortType;

		// Token: 0x0400DFA0 RID: 57248
		private bool _sortAscend;

		// Token: 0x0400DFA2 RID: 57250
		private readonly Dictionary<GClass1246, bool> _questsAvailability;

		// Token: 0x0400DFA3 RID: 57251
		private SimpleTooltip _tooltip;

		// Token: 0x0400DFA4 RID: 57252
		public static Action<QuestItemView> OnQuestItemSelected;

		// Token: 0x0400DFA5 RID: 57253
		private QuestItemView _selectedItemView;

		// Token: 0x0400DFA6 RID: 57254
		private InventoryControllerClass _inventoryController;

		// Token: 0x0400DFA7 RID: 57255
		private GClass2490 _notesManager;

		// Token: 0x0400DFA8 RID: 57256
		private readonly List<JournalNote> _notes;

		// Token: 0x0400DFA9 RID: 57257
		private LootItemClass _questRaidItem;

		// Token: 0x0400DFAA RID: 57258
		private LootItemClass _questStashItem;

		// Token: 0x0400DFAB RID: 57259
		private string _currentLocationId;

		// Token: 0x0400DFAC RID: 57260
		private ISession _session;

		// Token: 0x0400DFAD RID: 57261
		private Profile _activeProfile;

		// Token: 0x0400DFAE RID: 57262
		private AbstractQuestControllerClass _questController;

		// Token: 0x0400DFAF RID: 57263
		private Func<GClass1246, bool> _questsAdditionalFilter;

		// Token: 0x0400DFB0 RID: 57264
		private readonly GClass764 _questListDisposable;

		// Token: 0x02002B6F RID: 11119
		private sealed class QuestLocationComparer : IComparer<GClass1246>
		{
			// Token: 0x0600DBC7 RID: 56263 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(GClass1246 x, GClass1246 y)
			{
				throw null;
			}

			// Token: 0x0400DFB1 RID: 57265
			private readonly string _locationId;
		}

		// Token: 0x02002B70 RID: 11120
		private sealed class QuestStatusComparer : IComparer<GClass1246>
		{
			// Token: 0x0600DBC8 RID: 56264 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(GClass1246 x, GClass1246 y)
			{
				throw null;
			}
		}

		// Token: 0x02002B71 RID: 11121
		private sealed class QuestProgressComparer : IComparer<GClass1246>
		{
			// Token: 0x0600DBC9 RID: 56265 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(GClass1246 x, GClass1246 y)
			{
				throw null;
			}
		}

		// Token: 0x02002B72 RID: 11122
		private sealed class QuestStringFieldComparer : IComparer<GClass1246>
		{
			// Token: 0x0600DBCA RID: 56266 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(GClass1246 x, GClass1246 y)
			{
				throw null;
			}

			// Token: 0x0400DFB2 RID: 57266
			private readonly EQuestsSortType _sortType;

			// Token: 0x0400DFB3 RID: 57267
			private string _xField;

			// Token: 0x0400DFB4 RID: 57268
			private string _yField;
		}

		// Token: 0x02002B73 RID: 11123
		public sealed class TasksTabController : GClass3058<TasksScreen>
		{
			// Token: 0x0600DBCB RID: 56267 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400DFB5 RID: 57269
			private readonly InventoryControllerClass _inventoryController;

			// Token: 0x0400DFB6 RID: 57270
			private readonly AbstractQuestControllerClass _questController;

			// Token: 0x0400DFB7 RID: 57271
			private readonly ISession _session;

			// Token: 0x0400DFB8 RID: 57272
			private readonly Profile _activeProfile;

			// Token: 0x0400DFB9 RID: 57273
			private readonly GClass2490 _notesManager;
		}

		// Token: 0x02002B74 RID: 11124
		[CompilerGenerated]
		private sealed class Class2629
		{
			// Token: 0x0400DFBA RID: 57274
			public TasksScreen tasksScreen_0;

			// Token: 0x0400DFBB RID: 57275
			public AbstractQuestControllerClass questController;

			// Token: 0x0400DFBC RID: 57276
			public ISession session;

			// Token: 0x0400DFBD RID: 57277
			public NotesTaskDescriptionShort description;
		}

		// Token: 0x02002B75 RID: 11125
		[CompilerGenerated]
		private sealed class Class2630
		{
			// Token: 0x0400DFBE RID: 57278
			public NotesTask view;

			// Token: 0x0400DFBF RID: 57279
			public TasksScreen.Class2629 class2629_0;
		}

		// Token: 0x02002B76 RID: 11126
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2631
		{
			// Token: 0x0400DFC0 RID: 57280
			public static readonly TasksScreen.Class2631 class2631_0;

			// Token: 0x0400DFC1 RID: 57281
			public static Func<GClass1246, bool> func_0;

			// Token: 0x0400DFC2 RID: 57282
			public static Func<JournalNote, bool> func_1;
		}

		// Token: 0x02002B77 RID: 11127
		[CompilerGenerated]
		private sealed class Class2632
		{
			// Token: 0x0400DFC3 RID: 57283
			public TasksScreen tasksScreen_0;

			// Token: 0x0400DFC4 RID: 57284
			public RectTransform rectTransform;
		}

		// Token: 0x02002B78 RID: 11128
		[CompilerGenerated]
		private sealed class Class2633
		{
			// Token: 0x0400DFC5 RID: 57285
			public GClass2489 note;
		}

		// Token: 0x02002B79 RID: 11129
		[CompilerGenerated]
		private sealed class Class2634
		{
			// Token: 0x0600DBCC RID: 56268 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(string text)
			{
				throw null;
			}

			// Token: 0x0400DFC6 RID: 57286
			public TasksScreen tasksScreen_0;

			// Token: 0x0400DFC7 RID: 57287
			public GClass2489 note;

			// Token: 0x02002B7A RID: 11130
			[StructLayout(LayoutKind.Auto)]
			public struct Struct903 : IAsyncStateMachine
			{
				// Token: 0x0600DBCD RID: 56269 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600DBCE RID: 56270 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400DFC8 RID: 57288
				public int int_0;

				// Token: 0x0400DFC9 RID: 57289
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x0400DFCA RID: 57290
				public TasksScreen.Class2634 class2634_0;

				// Token: 0x0400DFCB RID: 57291
				public string text;

				// Token: 0x0400DFCC RID: 57292
				private GClass1243<GClass2490> gclass1243_0;

				// Token: 0x0400DFCD RID: 57293
				private TaskAwaiter<IResult> taskAwaiter_0;
			}
		}
	}
}
