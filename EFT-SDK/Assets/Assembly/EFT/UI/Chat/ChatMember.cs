using System;
using System.Runtime.CompilerServices;
using ChatShared;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E60 RID: 11872
	public class ChatMember : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600EA68 RID: 60008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(UpdatableChatMember member, UpdatableChatMember playerMember, bool active, Action<Vector2> onClick)
		{
			throw null;
		}

		// Token: 0x0600EA69 RID: 60009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarkAsChosen(bool state)
		{
			throw null;
		}

		// Token: 0x0600EA6A RID: 60010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EA6B RID: 60011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EA6C RID: 60012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EA6D RID: 60013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateIgnoreStatus()
		{
			throw null;
		}

		// Token: 0x0600EA6E RID: 60014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool value)
		{
			throw null;
		}

		// Token: 0x0400EEE4 RID: 61156
		[SerializeField]
		private TextMeshProUGUI _playerNameLabel;

		// Token: 0x0400EEE5 RID: 61157
		[SerializeField]
		private ChatSpecialIcon _specialIcon;

		// Token: 0x0400EEE6 RID: 61158
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400EEE7 RID: 61159
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400EEE8 RID: 61160
		[SerializeField]
		private GameObject _muteIcon;

		// Token: 0x0400EEE9 RID: 61161
		[SerializeField]
		private GameObject _banIcon;

		// Token: 0x0400EEEA RID: 61162
		[SerializeField]
		private Color _defaultImageColor;

		// Token: 0x0400EEEB RID: 61163
		[SerializeField]
		private Color _hoveredImageColor;

		// Token: 0x0400EEEC RID: 61164
		[SerializeField]
		private Color _chosenHoverImageColor;

		// Token: 0x0400EEED RID: 61165
		[SerializeField]
		private Color _chosenImageColor;

		// Token: 0x0400EEEE RID: 61166
		private UpdatableChatMember updatableChatMember_0;

		// Token: 0x0400EEEF RID: 61167
		private Action<Vector2> action_0;

		// Token: 0x0400EEF0 RID: 61168
		private bool bool_0;
	}
}
