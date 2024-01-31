using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BFC RID: 11260
	[UsedImplicitly]
	public sealed class TraderDialogScreen : EftScreen<TraderDialogScreen.GClass3132, TraderDialogScreen>
	{
		// Token: 0x0600DDE1 RID: 56801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TraderDialogScreen.GClass3132 controller)
		{
			throw null;
		}

		// Token: 0x0600DDE2 RID: 56802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DDE3 RID: 56803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600DDE4 RID: 56804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass2069 dialog)
		{
			throw null;
		}

		// Token: 0x0600DDE5 RID: 56805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600DDE6 RID: 56806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600DDE7 RID: 56807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600DDE8 RID: 56808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600DDE9 RID: 56809 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0400E28C RID: 57996
		[SerializeField]
		private SubtitlesView _subtitlesView;

		// Token: 0x0400E28D RID: 57997
		[SerializeField]
		private TraderDialogWindow _dialogWindow;

		// Token: 0x0400E28E RID: 57998
		private Profile profile_0;

		// Token: 0x0400E28F RID: 57999
		private string string_0;

		// Token: 0x0400E290 RID: 58000
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400E291 RID: 58001
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E292 RID: 58002
		private GClass2048 gclass2048_0;

		// Token: 0x0400E293 RID: 58003
		private GInterface180 ginterface180_0;

		// Token: 0x02002BFD RID: 11261
		public sealed class GClass3132 : GClass3107.GClass3109<TraderDialogScreen.GClass3132, TraderDialogScreen>
		{
			// Token: 0x170026C2 RID: 9922
			// (get) Token: 0x0600DDEA RID: 56810 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026C3 RID: 9923
			// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026C4 RID: 9924
			// (get) Token: 0x0600DDEC RID: 56812 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher UnrestrictedFrameRate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600DDED RID: 56813 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void HideDialog()
			{
				throw null;
			}

			// Token: 0x0400E294 RID: 58004
			public readonly Profile Profile;

			// Token: 0x0400E295 RID: 58005
			public readonly string TraderId;

			// Token: 0x0400E296 RID: 58006
			public readonly AbstractQuestControllerClass QuestController;

			// Token: 0x0400E297 RID: 58007
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400E298 RID: 58008
			public readonly GInterface180 AnimationController;
		}
	}
}
