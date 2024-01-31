using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028C2 RID: 10434
	public sealed class BattleUiVoipPanel : UIElement
	{
		// Token: 0x0600D062 RID: 53346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IPlayerVoipController controller)
		{
			throw null;
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EVoipControllerStatus status)
		{
			throw null;
		}

		// Token: 0x0600D066 RID: 53350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool force)
		{
			throw null;
		}

		// Token: 0x0400D131 RID: 53553
		[SerializeField]
		private BattleUiVoipPanel.StatusContainer _status;

		// Token: 0x0400D132 RID: 53554
		[SerializeField]
		private BattleUiVoipPanel.BanContainer _ban;

		// Token: 0x0400D133 RID: 53555
		public float ShowHideDuration;

		// Token: 0x0400D134 RID: 53556
		private IPlayerVoipController iplayerVoipController_0;

		// Token: 0x0400D135 RID: 53557
		private int int_0;

		// Token: 0x020028C3 RID: 10435
		[Serializable]
		private sealed class BanContainer
		{
			// Token: 0x0600D067 RID: 53351 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Show()
			{
				throw null;
			}

			// Token: 0x0600D068 RID: 53352 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Hide()
			{
				throw null;
			}

			// Token: 0x0400D136 RID: 53558
			public CanvasGroup Group;

			// Token: 0x0400D137 RID: 53559
			public CustomTextMeshProUGUI LeftTimeText;
		}

		// Token: 0x020028C4 RID: 10436
		[Serializable]
		private sealed class StatusContainer
		{
			// Token: 0x0600D069 RID: 53353 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StartTalkDetection(IPlayerVoipController controller)
			{
				throw null;
			}

			// Token: 0x0600D06A RID: 53354 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StartTalkingAnimation(float duration)
			{
				throw null;
			}

			// Token: 0x0600D06B RID: 53355 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowBlock(float duration)
			{
				throw null;
			}

			// Token: 0x0600D06C RID: 53356 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowBan()
			{
				throw null;
			}

			// Token: 0x0600D06D RID: 53357 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Hide(float duration = -1f)
			{
				throw null;
			}

			// Token: 0x0600D06E RID: 53358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(Sprite sprite, float duration = -1f)
			{
				throw null;
			}

			// Token: 0x0600D06F RID: 53359 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_1(bool detected)
			{
				throw null;
			}

			// Token: 0x0600D070 RID: 53360 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Sequence method_2()
			{
				throw null;
			}

			// Token: 0x0600D071 RID: 53361 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_3()
			{
				throw null;
			}

			// Token: 0x0600D072 RID: 53362 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x0400D138 RID: 53560
			public CanvasGroup Group;

			// Token: 0x0400D139 RID: 53561
			public CustomTextMeshProUGUI LeftTimeText;

			// Token: 0x0400D13A RID: 53562
			public Image StaticImage;

			// Token: 0x0400D13B RID: 53563
			public Sprite BlockedSprite;

			// Token: 0x0400D13C RID: 53564
			public Sprite BannedSprite;

			// Token: 0x0400D13D RID: 53565
			public Sprite TalkDetectedSprite;

			// Token: 0x0400D13E RID: 53566
			public Image[] TalkingStates;

			// Token: 0x0400D13F RID: 53567
			public float TweenDuration;

			// Token: 0x0400D140 RID: 53568
			public Ease TweenEase;

			// Token: 0x0400D141 RID: 53569
			private Sequence _talkingAnimation;

			// Token: 0x0400D142 RID: 53570
			private Action _talkDetectionBinding;
		}
	}
}
