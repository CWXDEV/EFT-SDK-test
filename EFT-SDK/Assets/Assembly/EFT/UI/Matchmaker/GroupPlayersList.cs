using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002D87 RID: 11655
	public sealed class GroupPlayersList : UIElement
	{
		// Token: 0x14000331 RID: 817
		// (add) Token: 0x0600E533 RID: 58675 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E534 RID: 58676 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<GClass1207, Vector2> OnPlayerClick
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3357<GClass1207> playersList, BindableState<GClass3167> group, IList<UpdatableChatMember> friends, string profileAid)
		{
			throw null;
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass1207 leader)
		{
			throw null;
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass1207 player, Vector2 position)
		{
			throw null;
		}

		// Token: 0x0400EA61 RID: 60001
		[CompilerGenerated]
		private Action<GClass1207, Vector2> action_0;

		// Token: 0x0400EA62 RID: 60002
		[SerializeField]
		private RectTransform _groupPlayersContainer;

		// Token: 0x0400EA63 RID: 60003
		[SerializeField]
		private GroupPlayerPanel _groupPlayerPanelTemplate;

		// Token: 0x0400EA64 RID: 60004
		private GClass3079<GClass1207, GroupPlayerPanel> gclass3079_0;

		// Token: 0x02002D88 RID: 11656
		[CompilerGenerated]
		private sealed class Class2814
		{
			// Token: 0x0600E538 RID: 58680 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1207 player, GroupPlayerPanel playerPanel)
			{
				throw null;
			}

			// Token: 0x0400EA65 RID: 60005
			public IList<UpdatableChatMember> friends;

			// Token: 0x0400EA66 RID: 60006
			public string profileAid;

			// Token: 0x0400EA67 RID: 60007
			public BindableState<GClass3167> group;

			// Token: 0x0400EA68 RID: 60008
			public GroupPlayersList groupPlayersList_0;
		}

		// Token: 0x02002D89 RID: 11657
		[CompilerGenerated]
		private sealed class Class2815
		{
			// Token: 0x0600E539 RID: 58681 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EA69 RID: 60009
			public GroupPlayerPanel playerPanel;

			// Token: 0x0400EA6A RID: 60010
			public GroupPlayersList.Class2814 class2814_0;
		}

		// Token: 0x02002D8A RID: 11658
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2816
		{
			// Token: 0x0600E53A RID: 58682 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x0400EA6B RID: 60011
			public static readonly GroupPlayersList.Class2816 class2816_0;

			// Token: 0x0400EA6C RID: 60012
			public static Func<UpdatableChatMember, string> func_0;
		}
	}
}
