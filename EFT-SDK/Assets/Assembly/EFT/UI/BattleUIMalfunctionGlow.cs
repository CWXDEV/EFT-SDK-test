using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028AE RID: 10414
	public class BattleUIMalfunctionGlow : UIElement
	{
		// Token: 0x0600CFEC RID: 53228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600CFED RID: 53229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ShowGlow(BattleUIMalfunctionGlow.GlowType glowType, bool force = false, float alphaMult = 1f)
		{
			throw null;
		}

		// Token: 0x0600CFEE RID: 53230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(Sprite sprite, AnimationCurve curve, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0400D0CF RID: 53455
		private const float float_0 = 2f;

		// Token: 0x0400D0D0 RID: 53456
		[SerializeField]
		private Image _glow;

		// Token: 0x0400D0D1 RID: 53457
		[SerializeField]
		private BattleUIMalfunctionGlow.GlowParams[] _glows;

		// Token: 0x0400D0D2 RID: 53458
		private float float_1;

		// Token: 0x0400D0D3 RID: 53459
		private int int_0;

		// Token: 0x0400D0D4 RID: 53460
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400D0D5 RID: 53461
		private float float_2;

		// Token: 0x020028AF RID: 10415
		public enum GlowType
		{
			// Token: 0x0400D0D7 RID: 53463
			Examined,
			// Token: 0x0400D0D8 RID: 53464
			Repaired,
			// Token: 0x0400D0D9 RID: 53465
			TypeExamined
		}

		// Token: 0x020028B0 RID: 10416
		[Serializable]
		public struct GlowParams
		{
			// Token: 0x0400D0DA RID: 53466
			public BattleUIMalfunctionGlow.GlowType Type;

			// Token: 0x0400D0DB RID: 53467
			public Sprite Glow;

			// Token: 0x0400D0DC RID: 53468
			public AnimationCurve Curve;
		}

		// Token: 0x020028B1 RID: 10417
		[CompilerGenerated]
		private sealed class Class2365
		{
			// Token: 0x0600CFEF RID: 53231 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BattleUIMalfunctionGlow.GlowParams t)
			{
				throw null;
			}

			// Token: 0x0400D0DD RID: 53469
			public BattleUIMalfunctionGlow.GlowType glowType;
		}
	}
}
