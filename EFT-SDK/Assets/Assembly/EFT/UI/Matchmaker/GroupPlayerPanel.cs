using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002D85 RID: 11653
	public sealed class GroupPlayerPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
	{
		// Token: 0x14000330 RID: 816
		// (add) Token: 0x0600E527 RID: 58663 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E528 RID: 58664 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass1207, Vector2> OnPlayerClick
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

		// Token: 0x0600E529 RID: 58665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1207 player, bool friendPanel, string profileAid, BindableState<GClass1207> groupOwner)
		{
			throw null;
		}

		// Token: 0x0600E52A RID: 58666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E52B RID: 58667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E52C RID: 58668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool hover)
		{
			throw null;
		}

		// Token: 0x0600E52D RID: 58669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E52F RID: 58671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUp(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E531 RID: 58673 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400EA4F RID: 59983
		private const float float_0 = 0.76f;

		// Token: 0x0400EA50 RID: 59984
		[CompilerGenerated]
		private Action<GClass1207, Vector2> action_0;

		// Token: 0x0400EA51 RID: 59985
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400EA52 RID: 59986
		[SerializeField]
		private ChatSpecialIcon _icon;

		// Token: 0x0400EA53 RID: 59987
		[SerializeField]
		private Color _defaultImageColor;

		// Token: 0x0400EA54 RID: 59988
		[SerializeField]
		private Color _readyColor;

		// Token: 0x0400EA55 RID: 59989
		[SerializeField]
		private Color _notReadyColor;

		// Token: 0x0400EA56 RID: 59990
		[SerializeField]
		private CustomTextMeshProUGUI _nameLabel;

		// Token: 0x0400EA57 RID: 59991
		[SerializeField]
		private CustomTextMeshProUGUI _sideLabel;

		// Token: 0x0400EA58 RID: 59992
		[SerializeField]
		private CustomTextMeshProUGUI _statusLabel;

		// Token: 0x0400EA59 RID: 59993
		private GClass1207 gclass1207_0;

		// Token: 0x0400EA5A RID: 59994
		private bool bool_0;

		// Token: 0x0400EA5B RID: 59995
		private bool bool_1;

		// Token: 0x0400EA5C RID: 59996
		private bool bool_2;

		// Token: 0x0400EA5D RID: 59997
		private GClass1207 gclass1207_1;

		// Token: 0x0400EA5E RID: 59998
		private bool bool_3;

		// Token: 0x02002D86 RID: 11654
		[CompilerGenerated]
		private sealed class Class2813
		{
			// Token: 0x0600E532 RID: 58674 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1207 owner)
			{
				throw null;
			}

			// Token: 0x0400EA5F RID: 59999
			public string youStatus;

			// Token: 0x0400EA60 RID: 60000
			public GroupPlayerPanel groupPlayerPanel_0;
		}
	}
}
