using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Communications;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E67 RID: 11879
	public sealed class ChatScreen : UIScreen, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x00002050 File Offset: 0x00000250
		private GameObject GameObject_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x0600EA82 RID: 60034 RVA: 0x00002050 File Offset: 0x00000250
		private ChatMessageClass GClass937_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social, InfoClass profileInfo, TraderControllerClass itemController, Action<IEnumerable<ChatMessageClass>, DateTime?> onTransferItems, Action<string> onOfferSelected)
		{
			throw null;
		}

		// Token: 0x0600EA85 RID: 60037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EBanType banType = EBanType.Friends)
		{
			throw null;
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EA87 RID: 60039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass940 dialog)
		{
			throw null;
		}

		// Token: 0x0600EA88 RID: 60040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass940 dialog)
		{
			throw null;
		}

		// Token: 0x0600EA89 RID: 60041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass940 dialogue, DialogueView dialogueView)
		{
			throw null;
		}

		// Token: 0x0600EA8A RID: 60042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6(ChatMessageClass[] messages)
		{
			throw null;
		}

		// Token: 0x0600EA8B RID: 60043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_7(List<ChatMessageClass> messagesWithQuestItems, IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(GClass940 dialogue)
		{
			throw null;
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetQuotedMessage([CanBeNull] ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600EA8F RID: 60047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600EA90 RID: 60048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600EA91 RID: 60049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600EA92 RID: 60050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EA93 RID: 60051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0600EA94 RID: 60052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600EA95 RID: 60053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EA96 RID: 60054 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600EA97 RID: 60055 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600EA98 RID: 60056 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(ChatMessageClass[] messages)
		{
			throw null;
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(ChatMessageClass chatMessage)
		{
			throw null;
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(string arg)
		{
			throw null;
		}

		// Token: 0x0400EF08 RID: 61192
		private const float float_0 = 80f;

		// Token: 0x0400EF09 RID: 61193
		[SerializeField]
		private GameObject _chatScreenObject;

		// Token: 0x0400EF0A RID: 61194
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400EF0B RID: 61195
		[SerializeField]
		private ChatMessageSendBlock _inputPanel;

		// Token: 0x0400EF0C RID: 61196
		[SerializeField]
		private ChatMembersPanel _chatMembersPanel;

		// Token: 0x0400EF0D RID: 61197
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400EF0E RID: 61198
		[SerializeField]
		private SwitchableParamsButton _switchableParamsButton;

		// Token: 0x0400EF0F RID: 61199
		[SerializeField]
		private Button _friendsButton;

		// Token: 0x0400EF10 RID: 61200
		[SerializeField]
		private CustomTextMeshProUGUI _friendsButtonLabel;

		// Token: 0x0400EF11 RID: 61201
		[SerializeField]
		private Button _createGroupDialog;

		// Token: 0x0400EF12 RID: 61202
		[SerializeField]
		private GameObject _quoteGameObject;

		// Token: 0x0400EF13 RID: 61203
		[SerializeField]
		private CustomTextMeshProUGUI _quoteLabel;

		// Token: 0x0400EF14 RID: 61204
		[SerializeField]
		private RectTransform _messagesContainerParent;

		// Token: 0x0400EF15 RID: 61205
		[SerializeField]
		private MessagesContainer _messagesContainerTemplate;

		// Token: 0x0400EF16 RID: 61206
		[SerializeField]
		private DialoguesContainer _dialoguesContainer;

		// Token: 0x0400EF17 RID: 61207
		[SerializeField]
		private ChatFriendsPanel _chatFriendsPanel;

		// Token: 0x0400EF18 RID: 61208
		[SerializeField]
		private ChatCreateDialoguePanel _chatCreateDialoguePanel;

		// Token: 0x0400EF19 RID: 61209
		[SerializeField]
		private ValidationInputField _chatInputField;

		// Token: 0x0400EF1A RID: 61210
		[SerializeField]
		private DefaultUIButton _sendButton;

		// Token: 0x0400EF1B RID: 61211
		[SerializeField]
		private ProfileEventsWindow _profileEventsWindow;

		// Token: 0x0400EF1C RID: 61212
		[SerializeField]
		private UiElementBlocker _friendsBlocker;

		// Token: 0x0400EF1D RID: 61213
		private GClass1839 gclass1839_0;

		// Token: 0x0400EF1E RID: 61214
		private InfoClass gclass1757_0;

		// Token: 0x0400EF1F RID: 61215
		private TraderControllerClass gclass2754_0;

		// Token: 0x0400EF20 RID: 61216
		private Action<IEnumerable<ChatMessageClass>, DateTime?> action_0;

		// Token: 0x0400EF21 RID: 61217
		private Action<string> action_1;

		// Token: 0x0400EF22 RID: 61218
		private DateTime dateTime_0;

		// Token: 0x0400EF23 RID: 61219
		private int int_0;

		// Token: 0x0400EF24 RID: 61220
		private int int_1;

		// Token: 0x0400EF25 RID: 61221
		private readonly Dictionary<GClass940, MessagesContainer> dictionary_0;

		// Token: 0x02002E68 RID: 11880
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2909
		{
			// Token: 0x0600EA9C RID: 60060 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600EA9D RID: 60061 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ProfileChangeEvent evt)
			{
				throw null;
			}

			// Token: 0x0600EA9E RID: 60062 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_2(ChatMessageClass message)
			{
				throw null;
			}

			// Token: 0x0600EA9F RID: 60063 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(Item item)
			{
				throw null;
			}

			// Token: 0x0600EAA0 RID: 60064 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_4(Item item)
			{
				throw null;
			}

			// Token: 0x0600EAA1 RID: 60065 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(ProfileChangeEvent evt)
			{
				throw null;
			}

			// Token: 0x0600EAA2 RID: 60066 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6(ProfileChangeEvent evt)
			{
				throw null;
			}

			// Token: 0x0600EAA3 RID: 60067 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_7(ChatMessageClass message)
			{
				throw null;
			}

			// Token: 0x0600EAA4 RID: 60068 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_8()
			{
				throw null;
			}

			// Token: 0x0400EF26 RID: 61222
			public static readonly ChatScreen.Class2909 class2909_0;

			// Token: 0x0400EF27 RID: 61223
			public static Action action_0;

			// Token: 0x0400EF28 RID: 61224
			public static Func<ProfileChangeEvent, bool> func_0;

			// Token: 0x0400EF29 RID: 61225
			public static Func<ChatMessageClass, IEnumerable<Item>> func_1;

			// Token: 0x0400EF2A RID: 61226
			public static Func<Item, bool> func_2;

			// Token: 0x0400EF2B RID: 61227
			public static Func<Item, string> func_3;

			// Token: 0x0400EF2C RID: 61228
			public static Func<ProfileChangeEvent, bool> func_4;

			// Token: 0x0400EF2D RID: 61229
			public static Action<ProfileChangeEvent> action_1;

			// Token: 0x0400EF2E RID: 61230
			public static Action<ChatMessageClass> action_2;

			// Token: 0x0400EF2F RID: 61231
			public static Action action_3;
		}
	}
}
