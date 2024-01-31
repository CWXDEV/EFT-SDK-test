using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002D8C RID: 11660
	public sealed class MatchMakerPlayerPreview : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x170027E1 RID: 10209
		// (get) Token: 0x0600E541 RID: 58689 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E542 RID: 58690 RVA: 0x00002050 File Offset: 0x00000250
		public string PlayerAid
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

		// Token: 0x0600E543 RID: 58691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(GClass3166 matchmaker, RaidSettings raidSettings, GClass1207 player, GClass3047 contextInteractions)
		{
			throw null;
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E545 RID: 58693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(EMatchingType _)
		{
			throw null;
		}

		// Token: 0x0600E546 RID: 58694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E547 RID: 58695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool active)
		{
			throw null;
		}

		// Token: 0x0600E548 RID: 58696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E549 RID: 58697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400EA74 RID: 60020
		private const int int_0 = 23;

		// Token: 0x0400EA75 RID: 60021
		private const int int_1 = 19;

		// Token: 0x0400EA76 RID: 60022
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400EA77 RID: 60023
		[SerializeField]
		private Image _noVisualImage;

		// Token: 0x0400EA78 RID: 60024
		[SerializeField]
		private RawImage _playerVisualImage;

		// Token: 0x0400EA79 RID: 60025
		[SerializeField]
		private PlayerNamePanel _namePanel;

		// Token: 0x0400EA7A RID: 60026
		[SerializeField]
		private ChatSpecialIcon _scavName;

		// Token: 0x0400EA7B RID: 60027
		[SerializeField]
		private TextMeshProUGUI _groupStatusField;

		// Token: 0x0400EA7C RID: 60028
		[SerializeField]
		private InteractionButtonsContainer _interactionButtons;

		// Token: 0x0400EA7D RID: 60029
		[SerializeField]
		private PlayerLevelPanel _levelPanel;

		// Token: 0x0400EA7E RID: 60030
		[SerializeField]
		private bool _isMainCharacter;

		// Token: 0x0400EA7F RID: 60031
		private GClass1205 gclass1205_0;

		// Token: 0x0400EA80 RID: 60032
		private GClass3166 gclass3166_0;

		// Token: 0x0400EA81 RID: 60033
		private GClass1207 gclass1207_0;

		// Token: 0x0400EA82 RID: 60034
		private GClass3047 gclass3047_0;

		// Token: 0x0400EA83 RID: 60035
		[CompilerGenerated]
		private string string_0;

		// Token: 0x02002D8D RID: 11661
		[CompilerGenerated]
		private sealed class Class2817
		{
			// Token: 0x0600E54A RID: 58698 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EA84 RID: 60036
			public GClass3166 matchmaker;

			// Token: 0x0400EA85 RID: 60037
			public MatchMakerPlayerPreview matchMakerPlayerPreview_0;
		}
	}
}
