using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using Comfort.Common;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E5C RID: 11868
	public sealed class ChatInvitePlayersPanel : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600EA60 RID: 60000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EA61 RID: 60001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social, GClass940 selectedDialogue)
		{
			throw null;
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400EED4 RID: 61140
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400EED5 RID: 61141
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400EED6 RID: 61142
		[SerializeField]
		private DefaultUIButton _inviteButtonSpawner;

		// Token: 0x0400EED7 RID: 61143
		[SerializeField]
		private ChatMember _chatMemberTemplate;

		// Token: 0x0400EED8 RID: 61144
		[SerializeField]
		private RectTransform _membersPlaceholder;

		// Token: 0x0400EED9 RID: 61145
		private readonly List<UpdatableChatMember> list_0;

		// Token: 0x0400EEDA RID: 61146
		private GClass1839 gclass1839_0;

		// Token: 0x0400EEDB RID: 61147
		private GClass940 gclass940_0;

		// Token: 0x02002E5D RID: 11869
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2902
		{
			// Token: 0x0600EA65 RID: 60005 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult result)
			{
				throw null;
			}

			// Token: 0x0400EEDC RID: 61148
			public static readonly ChatInvitePlayersPanel.Class2902 class2902_0;

			// Token: 0x0400EEDD RID: 61149
			public static Callback callback_0;
		}

		// Token: 0x02002E5E RID: 11870
		[CompilerGenerated]
		private sealed class Class2903
		{
			// Token: 0x0600EA66 RID: 60006 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(UpdatableChatMember member, ChatMember view)
			{
				throw null;
			}

			// Token: 0x0400EEDE RID: 61150
			public GClass1839 social;

			// Token: 0x0400EEDF RID: 61151
			public GClass940 selectedDialogue;

			// Token: 0x0400EEE0 RID: 61152
			public ChatInvitePlayersPanel chatInvitePlayersPanel_0;
		}

		// Token: 0x02002E5F RID: 11871
		[CompilerGenerated]
		private sealed class Class2904
		{
			// Token: 0x0600EA67 RID: 60007 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Vector2 pos)
			{
				throw null;
			}

			// Token: 0x0400EEE1 RID: 61153
			public UpdatableChatMember member;

			// Token: 0x0400EEE2 RID: 61154
			public ChatMember view;

			// Token: 0x0400EEE3 RID: 61155
			public ChatInvitePlayersPanel.Class2903 class2903_0;
		}
	}
}
