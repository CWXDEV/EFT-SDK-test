using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using UnityEngine;

namespace EFT.UI.Chat
{
	// Token: 0x02002E61 RID: 11873
	public sealed class ChatMembersPanel : UIElement
	{
		// Token: 0x0600EA6F RID: 60015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social, GClass3364<UpdatableChatMember> chatMembers)
		{
			throw null;
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400EEF1 RID: 61169
		[SerializeField]
		private SimpleContextMenu _contextMenu;

		// Token: 0x0400EEF2 RID: 61170
		[SerializeField]
		private BanTimeWindow _banTimeWindow;

		// Token: 0x0400EEF3 RID: 61171
		[SerializeField]
		private ChatMember _chatMemberTemplate;

		// Token: 0x0400EEF4 RID: 61172
		[SerializeField]
		private RectTransform _membersPlaceholder;

		// Token: 0x0400EEF5 RID: 61173
		private GClass1839 gclass1839_0;

		// Token: 0x0400EEF6 RID: 61174
		private GClass3364<UpdatableChatMember> gclass3364_0;

		// Token: 0x02002E62 RID: 11874
		private sealed class Class2905 : IComparer<UpdatableChatMember>
		{
			// Token: 0x0600EA71 RID: 60017 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(UpdatableChatMember x, UpdatableChatMember y)
			{
				throw null;
			}

			// Token: 0x0400EEF7 RID: 61175
			public static readonly ChatMembersPanel.Class2905 Instance;
		}

		// Token: 0x02002E63 RID: 11875
		[CompilerGenerated]
		private sealed class Class2906
		{
			// Token: 0x0600EA72 RID: 60018 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(UpdatableChatMember member, ChatMember view)
			{
				throw null;
			}

			// Token: 0x0400EEF8 RID: 61176
			public GClass1839 social;

			// Token: 0x0400EEF9 RID: 61177
			public ChatMembersPanel chatMembersPanel_0;
		}

		// Token: 0x02002E64 RID: 11876
		[CompilerGenerated]
		private sealed class Class2907
		{
			// Token: 0x0600EA73 RID: 60019 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Vector2 pos)
			{
				throw null;
			}

			// Token: 0x0400EEFA RID: 61178
			public UpdatableChatMember member;

			// Token: 0x0400EEFB RID: 61179
			public ChatMembersPanel.Class2906 class2906_0;
		}
	}
}
