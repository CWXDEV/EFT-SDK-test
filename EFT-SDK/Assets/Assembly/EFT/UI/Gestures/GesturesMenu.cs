using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.Binding;
using EFT.InputSystem;
using UnityEngine;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EAC RID: 11948
	public class GesturesMenu : UIInputNode
	{
		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600EBDF RID: 60383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBE0 RID: 60384 RVA: 0x00002050 File Offset: 0x00000250
		public GClass3175 Binds
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

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600EBE1 RID: 60385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBE2 RID: 60386 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsShowing
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

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBE4 RID: 60388 RVA: 0x00002050 File Offset: 0x00000250
		public bool HideOnlySituationalGroups
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private get
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

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EBE6 RID: 60390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GClass3174 gesturesStorage, HashSet<EPhraseTrigger> availablePhrases)
		{
			throw null;
		}

		// Token: 0x0600EBE7 RID: 60391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x0600EBE8 RID: 60392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPhraseActive(EPhraseTrigger phrase, bool active)
		{
			throw null;
		}

		// Token: 0x0600EBE9 RID: 60393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600EBEA RID: 60394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600EBEB RID: 60395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600EBEC RID: 60396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseWithSelected()
		{
			throw null;
		}

		// Token: 0x0600EBED RID: 60397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EBEE RID: 60398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CreateGesture(EGesture gesture)
		{
			throw null;
		}

		// Token: 0x0600EBEF RID: 60399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GesturesAudioItem CreatePhraseGroup(string localizationKey, GesturesAudioItem groupTemplate, params EPhraseTrigger[] phrases)
		{
			throw null;
		}

		// Token: 0x0600EBF0 RID: 60400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GestureBaseItem.GStruct399 click, bool isSituational)
		{
			throw null;
		}

		// Token: 0x0600EBF1 RID: 60401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(int index, Vector2 pos)
		{
			throw null;
		}

		// Token: 0x0600EBF2 RID: 60402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EBF3 RID: 60403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600EBF4 RID: 60404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ECommand command, int index)
		{
			throw null;
		}

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitPhraseGroups()
		{
			throw null;
		}

		// Token: 0x0600EBF7 RID: 60407 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(int item)
		{
			throw null;
		}

		// Token: 0x0600EBF8 RID: 60408 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GestureBaseItem.GStruct399 x)
		{
			throw null;
		}

		// Token: 0x0400F0EA RID: 61674
		public static readonly GClass3355<GesturesMenu.GStruct400> OnBindUpdated;

		// Token: 0x0400F0EB RID: 61675
		[SerializeField]
		[Space]
		private Transform _audioContainer;

		// Token: 0x0400F0EC RID: 61676
		[SerializeField]
		protected GesturesAudioItem _commonGroupTemplate;

		// Token: 0x0400F0ED RID: 61677
		[SerializeField]
		protected GesturesAudioItem _situationalGroupTemplate;

		// Token: 0x0400F0EE RID: 61678
		private readonly List<GesturesAudioItem> list_0;

		// Token: 0x0400F0EF RID: 61679
		[Space]
		[SerializeField]
		protected Transform _gestureContainer;

		// Token: 0x0400F0F0 RID: 61680
		[SerializeField]
		private GesturesMenuItem _gestureItemTemplate;

		// Token: 0x0400F0F1 RID: 61681
		protected readonly List<GesturesMenuItem> _gestureItems;

		// Token: 0x0400F0F2 RID: 61682
		[Space]
		[SerializeField]
		private GesturesBindPanel _gesturesBindPanel;

		// Token: 0x0400F0F3 RID: 61683
		[SerializeField]
		private SimpleContextMenu _gesturesContextMenu;

		// Token: 0x0400F0F4 RID: 61684
		[Space]
		[SerializeField]
		private Sprite _defaultSubItemBack;

		// Token: 0x0400F0F5 RID: 61685
		[SerializeField]
		private Sprite _selectedSubItemBack;

		// Token: 0x0400F0F6 RID: 61686
		[SerializeField]
		private Sprite _defaultGestureBack;

		// Token: 0x0400F0F7 RID: 61687
		[SerializeField]
		private Sprite _selectedGestureBack;

		// Token: 0x0400F0F8 RID: 61688
		[SerializeField]
		private ColorMap _colorMap;

		// Token: 0x0400F0F9 RID: 61689
		[NonSerialized]
		public readonly BindableEvent OnShow;

		// Token: 0x0400F0FA RID: 61690
		[NonSerialized]
		public readonly BindableEvent OnClose;

		// Token: 0x0400F0FB RID: 61691
		[NonSerialized]
		public readonly GClass3355<ValueTuple<int, bool>> OnItemSelected;

		// Token: 0x0400F0FC RID: 61692
		private readonly List<GestureBaseItem> list_1;

		// Token: 0x0400F0FD RID: 61693
		private GesturesAudioItem gesturesAudioItem_0;

		// Token: 0x0400F0FE RID: 61694
		private GClass3174 gclass3174_0;

		// Token: 0x0400F0FF RID: 61695
		private HashSet<EPhraseTrigger> hashSet_1;

		// Token: 0x0400F100 RID: 61696
		[CompilerGenerated]
		private GClass3175 gclass3175_0;

		// Token: 0x0400F101 RID: 61697
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400F102 RID: 61698
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x02002EAD RID: 11949
		[StructLayout(LayoutKind.Auto)]
		public readonly struct GStruct400
		{
			// Token: 0x0400F103 RID: 61699
			public readonly ECommand Command;

			// Token: 0x0400F104 RID: 61700
			public readonly int Index;

			// Token: 0x0400F105 RID: 61701
			public readonly string Caption;
		}

		// Token: 0x02002EAE RID: 11950
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2930
		{
			// Token: 0x0600EBF9 RID: 60409 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GestureBaseItem x)
			{
				throw null;
			}

			// Token: 0x0600EBFA RID: 60410 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GesturesBindItem x)
			{
				throw null;
			}

			// Token: 0x0600EBFB RID: 60411 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(GesturesAudioItem x)
			{
				throw null;
			}

			// Token: 0x0400F106 RID: 61702
			public static readonly GesturesMenu.Class2930 class2930_0;

			// Token: 0x0400F107 RID: 61703
			public static Func<GestureBaseItem, bool> func_0;

			// Token: 0x0400F108 RID: 61704
			public static Func<GesturesBindItem, bool> func_1;

			// Token: 0x0400F109 RID: 61705
			public static Func<GesturesAudioItem, bool> func_2;
		}

		// Token: 0x02002EAF RID: 11951
		[CompilerGenerated]
		private sealed class Class2931
		{
			// Token: 0x0600EBFC RID: 60412 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GestureBaseItem.GStruct399 x)
			{
				throw null;
			}

			// Token: 0x0400F10A RID: 61706
			public bool isSituational;

			// Token: 0x0400F10B RID: 61707
			public GesturesMenu gesturesMenu_0;
		}

		// Token: 0x02002EB0 RID: 11952
		[CompilerGenerated]
		private sealed class Class2932
		{
			// Token: 0x0600EBFD RID: 60413 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ECommand command)
			{
				throw null;
			}

			// Token: 0x0400F10C RID: 61708
			public GesturesMenu gesturesMenu_0;

			// Token: 0x0400F10D RID: 61709
			public int index;
		}

		// Token: 0x02002EB1 RID: 11953
		[CompilerGenerated]
		private sealed class Class2933
		{
			// Token: 0x0600EBFE RID: 60414 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<ECommand, int> x)
			{
				throw null;
			}

			// Token: 0x0400F10E RID: 61710
			public int index;
		}
	}
}
