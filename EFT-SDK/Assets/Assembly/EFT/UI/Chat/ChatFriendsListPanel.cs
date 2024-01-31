using System;
using System.Runtime.CompilerServices;
using ChatShared;
using UnityEngine;

namespace EFT.UI.Chat
{
	// Token: 0x02002E73 RID: 11891
	public sealed class ChatFriendsListPanel : UIElement
	{
		// Token: 0x0600EAD0 RID: 60112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social)
		{
			throw null;
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400EF92 RID: 61330
		[SerializeField]
		private SimpleContextMenu _contextMenu;

		// Token: 0x0400EF93 RID: 61331
		[SerializeField]
		private ChatMember _chatMember;

		// Token: 0x0400EF94 RID: 61332
		[SerializeField]
		private RectTransform _membersContainer;

		// Token: 0x0400EF95 RID: 61333
		[SerializeField]
		private CustomTextMeshProUGUI _friendsLabel;

		// Token: 0x0400EF96 RID: 61334
		private GClass1839 gclass1839_0;

		// Token: 0x0400EF97 RID: 61335
		private int int_0;

		// Token: 0x02002E74 RID: 11892
		[CompilerGenerated]
		private sealed class Class2914
		{
			// Token: 0x0600EAD2 RID: 60114 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(UpdatableChatMember member, ChatMember view)
			{
				throw null;
			}

			// Token: 0x0400EF98 RID: 61336
			public GClass1839 social;

			// Token: 0x0400EF99 RID: 61337
			public ChatFriendsListPanel chatFriendsListPanel_0;
		}

		// Token: 0x02002E75 RID: 11893
		[CompilerGenerated]
		private sealed class Class2915
		{
			// Token: 0x0600EAD3 RID: 60115 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Vector2 pos)
			{
				throw null;
			}

			// Token: 0x0400EF9A RID: 61338
			public UpdatableChatMember member;

			// Token: 0x0400EF9B RID: 61339
			public ChatFriendsListPanel.Class2914 class2914_0;
		}
	}
}
