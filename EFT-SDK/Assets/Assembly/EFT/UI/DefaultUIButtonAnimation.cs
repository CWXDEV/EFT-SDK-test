using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028E2 RID: 10466
	public class DefaultUIButtonAnimation : SerializedMonoBehaviour, GInterface360<EButtonAnimationState>, GInterface359
	{
		// Token: 0x0600D0F9 RID: 53497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransitionToState(EButtonAnimationState state)
		{
			throw null;
		}

		// Token: 0x0600D0FA RID: 53498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(EButtonAnimationState state)
		{
			throw null;
		}

		// Token: 0x0600D0FB RID: 53499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EButtonAnimationState state, bool animated)
		{
			throw null;
		}

		// Token: 0x0600D0FC RID: 53500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x0600D0FD RID: 53501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool animated)
		{
			throw null;
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_2(bool animated)
		{
			throw null;
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool animated)
		{
			throw null;
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool animated)
		{
			throw null;
		}

		// Token: 0x0600D101 RID: 53505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_5(params Tween[] tweens)
		{
			throw null;
		}

		// Token: 0x0600D102 RID: 53506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_6(Tween tween, Ease ease = Ease.OutQuad)
		{
			throw null;
		}

		// Token: 0x0400D1DF RID: 53727
		private const float float_0 = 0.15f;

		// Token: 0x0400D1E0 RID: 53728
		private const float float_1 = 0.3f;

		// Token: 0x0400D1E1 RID: 53729
		[SerializeField]
		public RectTransform Background;

		// Token: 0x0400D1E2 RID: 53730
		[SerializeField]
		public Image Image;

		// Token: 0x0400D1E3 RID: 53731
		[SerializeField]
		public Image Icon;

		// Token: 0x0400D1E4 RID: 53732
		[SerializeField]
		public TMP_Text Label;

		// Token: 0x0400D1E5 RID: 53733
		[SerializeField]
		private Dictionary<EButtonAnimationState, GameObject> _stateAttachments;

		// Token: 0x0400D1E6 RID: 53734
		private readonly List<Tween> list_0;

		// Token: 0x0400D1E7 RID: 53735
		[SerializeField]
		private bool _changeColors;

		// Token: 0x0400D1E8 RID: 53736
		[SerializeField]
		private Color _normalLabelColor;

		// Token: 0x0400D1E9 RID: 53737
		[SerializeField]
		private Color _highlightedLabelColor;

		// Token: 0x0400D1EA RID: 53738
		private Color color_0;

		// Token: 0x0400D1EB RID: 53739
		private Color color_1;

		// Token: 0x0400D1EC RID: 53740
		private Color color_2;

		// Token: 0x0400D1ED RID: 53741
		private Color color_3;

		// Token: 0x020028E4 RID: 10468
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2380
		{
			// Token: 0x0600D105 RID: 53509 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(bool result)
			{
				throw null;
			}

			// Token: 0x0400D1F4 RID: 53748
			public static readonly DefaultUIButtonAnimation.Class2380 class2380_0;

			// Token: 0x0400D1F5 RID: 53749
			public static Func<bool, bool> func_0;
		}
	}
}
