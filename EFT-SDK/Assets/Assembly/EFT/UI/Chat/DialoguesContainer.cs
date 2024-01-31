using System;
using System.Runtime.CompilerServices;
using EFT.UI.Utilities.LightScroller;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Chat
{
	// Token: 0x02002E6E RID: 11886
	public sealed class DialoguesContainer : UIElement
	{
		// Token: 0x0600EAC2 RID: 60098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1839 social, Action<GClass940> onTransferAll, Action<GClass940, DialogueView> onSelected, Action<GClass940> onRemoved)
		{
			throw null;
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(GClass940 dialogue, out GClass3171 dialogueData)
		{
			throw null;
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EAC5 RID: 60101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool arg, GClass940 dialogue, DialogueView view)
		{
			throw null;
		}

		// Token: 0x0600EAC6 RID: 60102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass940 dialogue)
		{
			throw null;
		}

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool status, GClass940 item)
		{
			throw null;
		}

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400EF79 RID: 61305
		[SerializeField]
		private LightScroller _scroller;

		// Token: 0x0400EF7A RID: 61306
		[SerializeField]
		private DialogueView _cellViewPrefab;

		// Token: 0x0400EF7B RID: 61307
		[SerializeField]
		private ChatMessageSendBlock _chatMessageSendBlock;

		// Token: 0x0400EF7C RID: 61308
		[SerializeField]
		private ChatInvitePlayersPanel _invitePlayersPanel;

		// Token: 0x0400EF7D RID: 61309
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400EF7E RID: 61310
		[SerializeField]
		private GameObject _noDialogsPlaceholder;

		// Token: 0x0400EF7F RID: 61311
		[SerializeField]
		private SimpleContextMenu _dialogueListContextMenu;

		// Token: 0x0400EF80 RID: 61312
		[SerializeField]
		private SimpleContextMenu _channelContextMenu;

		// Token: 0x0400EF81 RID: 61313
		[SerializeField]
		private CustomTextMeshProUGUI _dialogueHeaderLabel;

		// Token: 0x0400EF82 RID: 61314
		[SerializeField]
		private CustomTextMeshProUGUI _dialogueUsersCountLabel;

		// Token: 0x0400EF83 RID: 61315
		private ToggleGroup toggleGroup_0;

		// Token: 0x0400EF84 RID: 61316
		private GClass1839 gclass1839_0;

		// Token: 0x0400EF85 RID: 61317
		private Action<GClass940> action_0;

		// Token: 0x0400EF86 RID: 61318
		private Action<GClass940, DialogueView> action_1;

		// Token: 0x0400EF87 RID: 61319
		private Action<GClass940> action_2;

		// Token: 0x02002E6F RID: 11887
		private enum EDialogType
		{
			// Token: 0x0400EF89 RID: 61321
			None,
			// Token: 0x0400EF8A RID: 61322
			Trader,
			// Token: 0x0400EF8B RID: 61323
			User
		}

		// Token: 0x02002E70 RID: 11888
		[CompilerGenerated]
		private sealed class Class2911
		{
			// Token: 0x0600EACA RID: 60106 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600EACB RID: 60107 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal DialogueView method_1(GClass3171 dialog)
			{
				throw null;
			}

			// Token: 0x0600EACC RID: 60108 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(GClass3171 item, DialogueView view)
			{
				throw null;
			}

			// Token: 0x0400EF8C RID: 61324
			public DialoguesContainer dialoguesContainer_0;

			// Token: 0x0400EF8D RID: 61325
			public GClass3363<GClass940, GClass3171> dialogsList;
		}

		// Token: 0x02002E71 RID: 11889
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2912
		{
			// Token: 0x0600EACD RID: 60109 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Enum method_0(GClass3171 dialog)
			{
				throw null;
			}

			// Token: 0x0400EF8E RID: 61326
			public static readonly DialoguesContainer.Class2912 class2912_0;

			// Token: 0x0400EF8F RID: 61327
			public static LightScroller.GDelegate76<GClass3171, Enum> gdelegate76_0;
		}

		// Token: 0x02002E72 RID: 11890
		[CompilerGenerated]
		private sealed class Class2913
		{
			// Token: 0x0600EACE RID: 60110 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass940 view, Vector2 pos)
			{
				throw null;
			}

			// Token: 0x0600EACF RID: 60111 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Vector2 pos)
			{
				throw null;
			}

			// Token: 0x0400EF90 RID: 61328
			public DialoguesContainer dialoguesContainer_0;

			// Token: 0x0400EF91 RID: 61329
			public GClass940 dialogue;
		}
	}
}
