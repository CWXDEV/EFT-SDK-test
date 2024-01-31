using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C8A RID: 11402
	public sealed class GroupInviteWindow : DialogWindow<GClass3087>
	{
		// Token: 0x0600E0B0 RID: 57520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3087 Show(GClass1210 groupInvite)
		{
			throw null;
		}

		// Token: 0x0600E0B1 RID: 57521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1210 invite)
		{
			throw null;
		}

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0400E55E RID: 58718
		private const string string_2 = "GroupInviteDescription";

		// Token: 0x0400E55F RID: 58719
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400E560 RID: 58720
		[SerializeField]
		private Transform _groupListContainer;

		// Token: 0x0400E561 RID: 58721
		[SerializeField]
		private GroupMemberView _groupMemberTemplate;

		// Token: 0x0400E562 RID: 58722
		private ChatSpecialIconSettings chatSpecialIconSettings_0;

		// Token: 0x02002C8B RID: 11403
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2715
		{
			// Token: 0x0600E0B5 RID: 57525 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E0B6 RID: 57526 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GClass1206 player, GroupMemberView playerPanel)
			{
				throw null;
			}

			// Token: 0x0400E563 RID: 58723
			public static readonly GroupInviteWindow.Class2715 class2715_0;

			// Token: 0x0400E564 RID: 58724
			public static Action action_0;

			// Token: 0x0400E565 RID: 58725
			public static Action<GClass1206, GroupMemberView> action_1;
		}
	}
}
