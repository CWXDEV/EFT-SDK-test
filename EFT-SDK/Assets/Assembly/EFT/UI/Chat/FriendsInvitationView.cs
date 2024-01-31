using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E7B RID: 11899
	public class FriendsInvitationView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600EAEF RID: 60143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass941 invitation, Action<GClass941, Vector2> onClick)
		{
			throw null;
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400EFC1 RID: 61377
		[SerializeField]
		private TextMeshProUGUI _playerNameLabel;

		// Token: 0x0400EFC2 RID: 61378
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400EFC3 RID: 61379
		[SerializeField]
		private Image _friendIcon;

		// Token: 0x0400EFC4 RID: 61380
		[SerializeField]
		private ChatSpecialIcon _icon;

		// Token: 0x0400EFC5 RID: 61381
		[SerializeField]
		private Sprite _inputInvitation;

		// Token: 0x0400EFC6 RID: 61382
		[SerializeField]
		private Sprite _outputInvitation;

		// Token: 0x0400EFC7 RID: 61383
		[SerializeField]
		private Color _defaultImageColor;

		// Token: 0x0400EFC8 RID: 61384
		[SerializeField]
		private Color _selectedImageColor;

		// Token: 0x0400EFC9 RID: 61385
		private GClass941 gclass941_0;

		// Token: 0x0400EFCA RID: 61386
		private Action<GClass941, Vector2> action_0;
	}
}
