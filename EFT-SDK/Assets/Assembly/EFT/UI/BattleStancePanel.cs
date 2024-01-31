using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028A6 RID: 10406
	[RequireComponent(typeof(BattleUIComponentAnimation))]
	public sealed class BattleStancePanel : UIElement
	{
		// Token: 0x0600CFCF RID: 53199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CFD0 RID: 53200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNoiseLevel(int index)
		{
			throw null;
		}

		// Token: 0x0600CFD1 RID: 53201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600CFD2 RID: 53202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Player player)
		{
			throw null;
		}

		// Token: 0x0600CFD3 RID: 53203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatedShow(bool autohide)
		{
			throw null;
		}

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatedHide(float delaySeconds = 0f)
		{
			throw null;
		}

		// Token: 0x0600CFD5 RID: 53205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CFD6 RID: 53206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool b)
		{
			throw null;
		}

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(float type, int noise)
		{
			throw null;
		}

		// Token: 0x0600CFD8 RID: 53208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(int current, int to, bool direction)
		{
			throw null;
		}

		// Token: 0x0600CFD9 RID: 53209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600CFDA RID: 53210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(float inputSpeed, float maxCharacterSpeed = 1f, int noise = 1)
		{
			throw null;
		}

		// Token: 0x0600CFDB RID: 53211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(float stateSpeedLimit, float clampedSpeed, float maxSpeed = 1f, int noise = 1)
		{
			throw null;
		}

		// Token: 0x0600CFDC RID: 53212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_0(IEnumerable<float> values, float value)
		{
			throw null;
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D09B RID: 53403
		[SerializeField]
		private List<BattleStance> _battleStances;

		// Token: 0x0400D09C RID: 53404
		[SerializeField]
		private BattleUINoiseLevel _noiseLevel;

		// Token: 0x0400D09D RID: 53405
		[SerializeField]
		private BattleStanceNotch _battleStanceNotchTemplate;

		// Token: 0x0400D09E RID: 53406
		[SerializeField]
		private BattleUiVoipPanel _voipPanel;

		// Token: 0x0400D09F RID: 53407
		[SerializeField]
		private BattleStanceNotch _finalNotch;

		// Token: 0x0400D0A0 RID: 53408
		[SerializeField]
		private RectTransform _notchesPlaceholder;

		// Token: 0x0400D0A1 RID: 53409
		[SerializeField]
		private Slider _stanceSlider;

		// Token: 0x0400D0A2 RID: 53410
		[SerializeField]
		private Slider _speedSlider;

		// Token: 0x0400D0A3 RID: 53411
		[SerializeField]
		private Image _sprintFillImage;

		// Token: 0x0400D0A4 RID: 53412
		[SerializeField]
		private Image _handsFillImage;

		// Token: 0x0400D0A5 RID: 53413
		[SerializeField]
		private Sprite _defaultFillSprite;

		// Token: 0x0400D0A6 RID: 53414
		[SerializeField]
		private Sprite _defaultFillSpriteForHands;

		// Token: 0x0400D0A7 RID: 53415
		[SerializeField]
		private Sprite _exhaustedFillSprite;

		// Token: 0x0400D0A8 RID: 53416
		private BattleUIComponentAnimation battleUIComponentAnimation_0;

		// Token: 0x0400D0A9 RID: 53417
		private Player player_0;

		// Token: 0x0400D0AA RID: 53418
		private int int_0;

		// Token: 0x0400D0AB RID: 53419
		private Coroutine coroutine_0;

		// Token: 0x0400D0AC RID: 53420
		private float float_0;

		// Token: 0x0400D0AD RID: 53421
		private readonly Dictionary<BattleStanceNotch, float> dictionary_0;

		// Token: 0x020028A7 RID: 10407
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2362
		{
			// Token: 0x0600CFDE RID: 53214 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(BattleStance x)
			{
				throw null;
			}

			// Token: 0x0400D0AE RID: 53422
			public static readonly BattleStancePanel.Class2362 class2362_0;

			// Token: 0x0400D0AF RID: 53423
			public static Func<BattleStance, float> func_0;
		}

		// Token: 0x020028A8 RID: 10408
		[CompilerGenerated]
		private sealed class Class2363
		{
			// Token: 0x0600CFDF RID: 53215 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D0B0 RID: 53424
			public BattleStancePanel battleStancePanel_0;

			// Token: 0x0400D0B1 RID: 53425
			public int current;

			// Token: 0x0400D0B2 RID: 53426
			public int to;

			// Token: 0x0400D0B3 RID: 53427
			public bool direction;
		}

		// Token: 0x020028A9 RID: 10409
		[CompilerGenerated]
		private sealed class Class2364
		{
			// Token: 0x0600CFE0 RID: 53216 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(float x)
			{
				throw null;
			}

			// Token: 0x0400D0B4 RID: 53428
			public float value;
		}
	}
}
