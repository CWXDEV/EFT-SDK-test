using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B12 RID: 11026
	public class JournalNote : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600DAC1 RID: 56001 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DAC2 RID: 56002 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2489 Note
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

		// Token: 0x0600DAC3 RID: 56003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DAC4 RID: 56004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600DAC5 RID: 56005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init([CanBeNull] Action<GClass2489> editButtonPressed, [CanBeNull] Action<GClass2489> destroyButtonPressed)
		{
			throw null;
		}

		// Token: 0x0600DAC6 RID: 56006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Show(GClass2489 note)
		{
			throw null;
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowFull()
		{
			throw null;
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideFull()
		{
			throw null;
		}

		// Token: 0x0600DAC9 RID: 56009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ButtonClickHandler()
		{
			throw null;
		}

		// Token: 0x0600DACA RID: 56010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DACB RID: 56011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DDFB RID: 56827
		private const string TRUNCATE_STRING = "...";

		// Token: 0x0400DDFC RID: 56828
		[SerializeField]
		private CustomTextMeshProUGUI _noteName;

		// Token: 0x0400DDFD RID: 56829
		[SerializeField]
		private CustomTextMeshProUGUI _noteDescription;

		// Token: 0x0400DDFE RID: 56830
		[SerializeField]
		private Button _deleteNoteButton;

		// Token: 0x0400DDFF RID: 56831
		[SerializeField]
		private Button _editNoteButton;

		// Token: 0x0400DE00 RID: 56832
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0400DE01 RID: 56833
		[SerializeField]
		private RectTransform _mask;

		// Token: 0x0400DE02 RID: 56834
		[SerializeField]
		private int _maxTitleLength;

		// Token: 0x0400DE04 RID: 56836
		private float _minHeight;

		// Token: 0x0400DE05 RID: 56837
		private float _minTextHeight;

		// Token: 0x0400DE06 RID: 56838
		private static JournalNote _selectedNote;

		// Token: 0x0400DE07 RID: 56839
		private Action<GClass2489> _editButtonPressed;

		// Token: 0x0400DE08 RID: 56840
		private Action<GClass2489> _destroyButtonPressed;
	}
}
