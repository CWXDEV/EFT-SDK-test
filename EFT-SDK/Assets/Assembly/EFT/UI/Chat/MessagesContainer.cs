using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using EFT.UI.Utilities.LightScroller;
using UnityEngine;

namespace EFT.UI.Chat
{
	// Token: 0x02002E83 RID: 11907
	public sealed class MessagesContainer : UIElement
	{
		// Token: 0x0600EB08 RID: 60168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Display()
		{
			throw null;
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social, ChatScreen screen, GClass940 dialogue, Action<ChatMessageClass> onItemsTransferClicked, Action<string> onOfferSelected)
		{
			throw null;
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(ChatMessageClass info, out GClass3173 messageData)
		{
			throw null;
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private UpdatableChatMember method_2(ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(ChatMessageClass message, Vector2 pos)
		{
			throw null;
		}

		// Token: 0x0600EB0F RID: 60175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600EB10 RID: 60176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EB11 RID: 60177 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(ChatMessageClass message)
		{
			throw null;
		}

		// Token: 0x0600EB12 RID: 60178 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(bool isLoading)
		{
			throw null;
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MessageFork method_7(GClass3173 messageData)
		{
			throw null;
		}

		// Token: 0x0400EFFE RID: 61438
		[SerializeField]
		private LightScroller _scroller;

		// Token: 0x0400EFFF RID: 61439
		[SerializeField]
		private MessageFork _cellViewPrefab;

		// Token: 0x0400F000 RID: 61440
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400F001 RID: 61441
		[SerializeField]
		private SimpleContextMenu _contextMenu;

		// Token: 0x0400F002 RID: 61442
		[SerializeField]
		private BanTimeWindow _banTimeWindow;

		// Token: 0x0400F003 RID: 61443
		[SerializeField]
		private ChatMembersPanel _chatMembersPanel;

		// Token: 0x0400F004 RID: 61444
		private GClass1839 gclass1839_0;

		// Token: 0x0400F005 RID: 61445
		private ChatScreen chatScreen_0;

		// Token: 0x0400F006 RID: 61446
		private GClass940 gclass940_0;

		// Token: 0x0400F007 RID: 61447
		private GClass3363<ChatMessageClass, GClass3173> gclass3363_0;

		// Token: 0x0400F008 RID: 61448
		private IEnumerable<ChatMessageClass> ienumerable_0;

		// Token: 0x0400F009 RID: 61449
		private Action<string> action_0;

		// Token: 0x0400F00A RID: 61450
		private Action<ChatMessageClass> action_1;

		// Token: 0x02002E84 RID: 11908
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2919
		{
			// Token: 0x0600EB14 RID: 60180 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Enum method_0(GClass3173 messageData)
			{
				throw null;
			}

			// Token: 0x0600EB15 RID: 60181 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GClass3173 messageData, MessageFork view)
			{
				throw null;
			}

			// Token: 0x0400F00B RID: 61451
			public static readonly MessagesContainer.Class2919 class2919_0;

			// Token: 0x0400F00C RID: 61452
			public static LightScroller.GDelegate76<GClass3173, Enum> gdelegate76_0;

			// Token: 0x0400F00D RID: 61453
			public static Action<GClass3173, MessageFork> action_0;
		}

		// Token: 0x02002E85 RID: 11909
		[CompilerGenerated]
		private sealed class Class2920
		{
			// Token: 0x0600EB16 RID: 60182 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_0(string id)
			{
				throw null;
			}

			// Token: 0x0400F00E RID: 61454
			public BackendConfigSettingsClass.TraderSettings traderSettings;
		}
	}
}
