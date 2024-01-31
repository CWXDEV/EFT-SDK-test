using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CF0 RID: 11504
	public sealed class SessionResultKillList : EftScreen<SessionResultKillList.GClass3146, SessionResultKillList>
	{
		// Token: 0x0600E244 RID: 57924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E245 RID: 57925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SessionResultKillList.GClass3146 controller)
		{
			throw null;
		}

		// Token: 0x0600E246 RID: 57926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(GClass3364<VictimStats> victims, DogtagComponent[] tags)
		{
			throw null;
		}

		// Token: 0x0600E247 RID: 57927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E248 RID: 57928 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E249 RID: 57929 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400E719 RID: 59161
		[SerializeField]
		private KillListVictim _victimTemplate;

		// Token: 0x0400E71A RID: 59162
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400E71B RID: 59163
		[SerializeField]
		private GameObject _noKillsObject;

		// Token: 0x0400E71C RID: 59164
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400E71D RID: 59165
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x02002CF1 RID: 11505
		public sealed class GClass3146 : GClass3142<SessionResultKillList.GClass3146, SessionResultKillList>
		{
			// Token: 0x1700277C RID: 10108
			// (get) Token: 0x0600E24A RID: 57930 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700277D RID: 10109
			// (get) Token: 0x0600E24B RID: 57931 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700277E RID: 10110
			// (get) Token: 0x0600E24C RID: 57932 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700277F RID: 10111
			// (get) Token: 0x0600E24D RID: 57933 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002780 RID: 10112
			// (get) Token: 0x0600E24E RID: 57934 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400E71E RID: 59166
			public readonly GClass3364<VictimStats> Victims;

			// Token: 0x0400E71F RID: 59167
			public readonly DogtagComponent[] Tags;
		}

		// Token: 0x02002CF2 RID: 11506
		[CompilerGenerated]
		private sealed class Class2753
		{
			// Token: 0x0600E24F RID: 57935 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(VictimStats victim, KillListVictim view)
			{
				throw null;
			}

			// Token: 0x0400E720 RID: 59168
			public DogtagComponent[] tags;

			// Token: 0x0400E721 RID: 59169
			public int index;
		}

		// Token: 0x02002CF3 RID: 11507
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2754
		{
			// Token: 0x0600E250 RID: 57936 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(DogtagComponent x)
			{
				throw null;
			}

			// Token: 0x0400E722 RID: 59170
			public static readonly SessionResultKillList.Class2754 class2754_0;

			// Token: 0x0400E723 RID: 59171
			public static Func<DogtagComponent, string> func_0;
		}
	}
}
