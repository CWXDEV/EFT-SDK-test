using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002C98 RID: 11416
	[RequireComponent(typeof(TextMeshProUGUI))]
	public sealed class ClickableUIText : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600E0F8 RID: 57592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetText(string message, Action<PointerEventData> onMouseClicked, [CanBeNull] Action<string> onOfferClicked)
		{
			throw null;
		}

		// Token: 0x0600E0F9 RID: 57593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E0FA RID: 57594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E0FB RID: 57595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600E0FC RID: 57596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E5A3 RID: 58787
		[SerializeField]
		private TextMeshProUGUI _textMessage;

		// Token: 0x0400E5A4 RID: 58788
		private ECursorType ecursorType_0;

		// Token: 0x0400E5A5 RID: 58789
		private Action<string> action_0;

		// Token: 0x0400E5A6 RID: 58790
		private Action<PointerEventData> action_1;
	}
}
