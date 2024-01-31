using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using TMPro;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DB9 RID: 11705
	public sealed class RaidReadyList : UIElement
	{
		// Token: 0x14000340 RID: 832
		// (add) Token: 0x0600E61F RID: 58911 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E620 RID: 58912 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0600E621 RID: 58913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E622 RID: 58914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3364<GClass1207> playersList, GClass3357<GClass1210> invites, IList<UpdatableChatMember> friends, string profileAid)
		{
			throw null;
		}

		// Token: 0x0600E623 RID: 58915 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass1207 player, Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600E624 RID: 58916 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass1207 player)
		{
			throw null;
		}

		// Token: 0x0600E625 RID: 58917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E626 RID: 58918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_3(string profileAid)
		{
			throw null;
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E628 RID: 58920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E629 RID: 58921 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(string arg)
		{
			throw null;
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(KeyValuePair<string, RaidReadyPlayerPanel> x)
		{
			throw null;
		}

		// Token: 0x0400EB25 RID: 60197
		[CompilerGenerated]
		private Action<GClass1207, Vector2> action_0;

		// Token: 0x0400EB26 RID: 60198
		[SerializeField]
		private TMP_InputField _inputField;

		// Token: 0x0400EB27 RID: 60199
		[SerializeField]
		private RectTransform _groupReadyPlayersContainer;

		// Token: 0x0400EB28 RID: 60200
		[SerializeField]
		private RaidReadyPlayerPanel _playerPanelTemplate;

		// Token: 0x0400EB29 RID: 60201
		public Dictionary<string, RaidReadyPlayerPanel> PlayerPanels;

		// Token: 0x0400EB2A RID: 60202
		private GClass3079<GClass1207, RaidReadyPlayerPanel> gclass3079_0;

		// Token: 0x0400EB2B RID: 60203
		private IList<UpdatableChatMember> ilist_0;

		// Token: 0x0400EB2C RID: 60204
		private string string_0;

		// Token: 0x0400EB2D RID: 60205
		private GClass3364<GClass1207> gclass3364_0;

		// Token: 0x0400EB2E RID: 60206
		private string string_1;

		// Token: 0x02002DBA RID: 11706
		private sealed class Class2847 : IComparer<GClass1207>
		{
			// Token: 0x0600E62B RID: 58923 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(GClass1207 x, GClass1207 y)
			{
				throw null;
			}

			// Token: 0x0400EB2F RID: 60207
			public static readonly RaidReadyList.Class2847 Instance;
		}

		// Token: 0x02002DBB RID: 11707
		[CompilerGenerated]
		private sealed class Class2848
		{
			// Token: 0x0600E62C RID: 58924 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1207 player, RaidReadyPlayerPanel playerPanel)
			{
				throw null;
			}

			// Token: 0x0600E62D RID: 58925 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400EB30 RID: 60208
			public IList<UpdatableChatMember> friends;

			// Token: 0x0400EB31 RID: 60209
			public string profileAid;

			// Token: 0x0400EB32 RID: 60210
			public GClass3357<GClass1210> invites;

			// Token: 0x0400EB33 RID: 60211
			public RaidReadyList raidReadyList_0;
		}

		// Token: 0x02002DBC RID: 11708
		[CompilerGenerated]
		private sealed class Class2849
		{
			// Token: 0x0600E62E RID: 58926 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EB34 RID: 60212
			public RaidReadyPlayerPanel playerPanel;

			// Token: 0x0400EB35 RID: 60213
			public RaidReadyList.Class2848 class2848_0;
		}

		// Token: 0x02002DBD RID: 11709
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2850
		{
			// Token: 0x0600E62F RID: 58927 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(UpdatableChatMember x)
			{
				throw null;
			}

			// Token: 0x0600E630 RID: 58928 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1207 method_1(GClass1207 x)
			{
				throw null;
			}

			// Token: 0x0600E631 RID: 58929 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(UpdatableChatMember y)
			{
				throw null;
			}

			// Token: 0x0400EB36 RID: 60214
			public static readonly RaidReadyList.Class2850 class2850_0;

			// Token: 0x0400EB37 RID: 60215
			public static Func<UpdatableChatMember, string> func_0;

			// Token: 0x0400EB38 RID: 60216
			public static Func<GClass1207, GClass1207> func_1;

			// Token: 0x0400EB39 RID: 60217
			public static Func<UpdatableChatMember, string> func_2;
		}

		// Token: 0x02002DBE RID: 11710
		[CompilerGenerated]
		private sealed class Class2851
		{
			// Token: 0x0600E632 RID: 58930 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1207 x)
			{
				throw null;
			}

			// Token: 0x0400EB3A RID: 60218
			public string profileAid;
		}
	}
}
