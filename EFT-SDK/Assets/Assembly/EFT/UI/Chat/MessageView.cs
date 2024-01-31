using System;
using System.Runtime.CompilerServices;
using ChatShared;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Chat
{
	// Token: 0x02002E81 RID: 11905
	public class MessageView : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600EB00 RID: 60160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ChatMessageClass chatMessage, UpdatableChatMember chatMember, [CanBeNull] GClass939 quote, Action<ChatMessageClass, Vector2> onMessageClicked, Action<ChatMessageClass> onMessageDoubleClicked, Action<string> onOfferSelected)
		{
			throw null;
		}

		// Token: 0x0600EB01 RID: 60161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetSenderName()
		{
			throw null;
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetSenderMessage(ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateMessageStatus()
		{
			throw null;
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EB06 RID: 60166 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400EFE3 RID: 61411
		[SerializeField]
		private TextMeshProUGUI _senderName;

		// Token: 0x0400EFE4 RID: 61412
		[SerializeField]
		private ClickableUIText _senderMessage;

		// Token: 0x0400EFE5 RID: 61413
		[SerializeField]
		private TextMeshProUGUI _timestampLabel;

		// Token: 0x0400EFE6 RID: 61414
		[SerializeField]
		private GameObject _quoteGameObject;

		// Token: 0x0400EFE7 RID: 61415
		[SerializeField]
		private TextMeshProUGUI _quotedName;

		// Token: 0x0400EFE8 RID: 61416
		[SerializeField]
		private TextMeshProUGUI _quotedMessage;

		// Token: 0x0400EFE9 RID: 61417
		[SerializeField]
		private ChatSpecialIcon _specialIcon;

		// Token: 0x0400EFEA RID: 61418
		protected ChatMessageClass DialogueChatMessage;

		// Token: 0x0400EFEB RID: 61419
		private UpdatableChatMember updatableChatMember_0;

		// Token: 0x0400EFEC RID: 61420
		private Action<ChatMessageClass, Vector2> action_0;

		// Token: 0x0400EFED RID: 61421
		private Action<ChatMessageClass> action_1;

		// Token: 0x0400EFEE RID: 61422
		private Action<string> action_2;

		// Token: 0x0400EFEF RID: 61423
		private const float float_0 = 0.3f;

		// Token: 0x0400EFF0 RID: 61424
		private float float_1;

		// Token: 0x0400EFF1 RID: 61425
		private bool bool_0;

		// Token: 0x0400EFF2 RID: 61426
		private static readonly EMessageType[] emessageType_0;
	}
}
