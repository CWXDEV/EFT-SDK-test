using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Matchmaker;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C91 RID: 11409
	public sealed class RaidInviteWindow : DialogWindow<GClass3087>
	{
		// Token: 0x0600E0D3 RID: 57555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 Show(ISession session, GClass1206 player, RaidSettings raidSettings, GClass2760 inventoryController)
		{
			throw null;
		}

		// Token: 0x0600E0D4 RID: 57556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool active)
		{
			throw null;
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(out string names, int profileLevel)
		{
			throw null;
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E0D8 RID: 57560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0400E585 RID: 58757
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400E586 RID: 58758
		[SerializeField]
		private TextMeshProUGUI _locationName;

		// Token: 0x0400E587 RID: 58759
		[SerializeField]
		private LocationConditionsPanel _locationConditionsPanel;

		// Token: 0x0400E588 RID: 58760
		[SerializeField]
		private GameObject _footer;

		// Token: 0x0400E589 RID: 58761
		[SerializeField]
		private Image _redLight;

		// Token: 0x0400E58A RID: 58762
		[SerializeField]
		private TextMeshProUGUI _footerText;

		// Token: 0x0400E58B RID: 58763
		private ChatSpecialIconSettings chatSpecialIconSettings_0;

		// Token: 0x0400E58C RID: 58764
		private RaidSettings raidSettings_0;

		// Token: 0x0400E58D RID: 58765
		private GClass2760 gclass2760_0;

		// Token: 0x02002C92 RID: 11410
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2718
		{
			// Token: 0x0600E0D9 RID: 57561 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E0DA RID: 57562 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(string item)
			{
				throw null;
			}

			// Token: 0x0400E58E RID: 58766
			public static readonly RaidInviteWindow.Class2718 class2718_0;

			// Token: 0x0400E58F RID: 58767
			public static Action action_0;

			// Token: 0x0400E590 RID: 58768
			public static Func<string, string> func_0;
		}

		// Token: 0x02002C93 RID: 11411
		[CompilerGenerated]
		private sealed class Class2719
		{
			// Token: 0x0600E0DB RID: 57563 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item equippedItem)
			{
				throw null;
			}

			// Token: 0x0400E591 RID: 58769
			public RaidInviteWindow raidInviteWindow_0;

			// Token: 0x0400E592 RID: 58770
			public string[] accessKeys;
		}
	}
}
