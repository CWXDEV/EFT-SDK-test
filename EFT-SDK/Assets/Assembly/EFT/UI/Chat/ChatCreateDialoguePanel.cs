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
	// Token: 0x02002E57 RID: 11863
	public sealed class ChatCreateDialoguePanel : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x0600EA54 RID: 59988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EA55 RID: 59989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social)
		{
			throw null;
		}

		// Token: 0x0600EA56 RID: 59990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EA57 RID: 59991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EA58 RID: 59992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EA59 RID: 59993 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600EA5A RID: 59994 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IResult result)
		{
			throw null;
		}

		// Token: 0x0600EA5B RID: 59995 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(string arg)
		{
			throw null;
		}

		// Token: 0x0400EEC3 RID: 61123
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400EEC4 RID: 61124
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400EEC5 RID: 61125
		[SerializeField]
		private ValidationInputField _dialogNameInputField;

		// Token: 0x0400EEC6 RID: 61126
		[SerializeField]
		private DefaultUIButton _createButton;

		// Token: 0x0400EEC7 RID: 61127
		[SerializeField]
		private DefaultUIButton _cancelButton;

		// Token: 0x0400EEC8 RID: 61128
		[SerializeField]
		private ChatMember _chatMemberTemplate;

		// Token: 0x0400EEC9 RID: 61129
		[SerializeField]
		private RectTransform _membersPlaceholder;

		// Token: 0x0400EECA RID: 61130
		private readonly List<UpdatableChatMember> list_0;

		// Token: 0x0400EECB RID: 61131
		private GClass1839 gclass1839_0;

		// Token: 0x02002E58 RID: 11864
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2899
		{
			// Token: 0x0600EA5C RID: 59996 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x0400EECC RID: 61132
			public static readonly ChatCreateDialoguePanel.Class2899 class2899_0;

			// Token: 0x0400EECD RID: 61133
			public static Func<UpdatableChatMember, string> func_0;
		}

		// Token: 0x02002E59 RID: 11865
		[CompilerGenerated]
		private sealed class Class2900
		{
			// Token: 0x0600EA5D RID: 59997 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(UpdatableChatMember member, ChatMember view)
			{
				throw null;
			}

			// Token: 0x0400EECE RID: 61134
			public GClass1839 social;

			// Token: 0x0400EECF RID: 61135
			public ChatCreateDialoguePanel chatCreateDialoguePanel_0;
		}

		// Token: 0x02002E5A RID: 11866
		[CompilerGenerated]
		private sealed class Class2901
		{
			// Token: 0x0600EA5E RID: 59998 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Vector2 pos)
			{
				throw null;
			}

			// Token: 0x0400EED0 RID: 61136
			public UpdatableChatMember member;

			// Token: 0x0400EED1 RID: 61137
			public ChatMember view;

			// Token: 0x0400EED2 RID: 61138
			public ChatCreateDialoguePanel.Class2900 class2900_0;
		}
	}
}
