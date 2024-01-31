using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Health
{
	// Token: 0x02002E94 RID: 11924
	public class BuffableHealthParameterPanel : HealthParameterPanel
	{
		// Token: 0x0600EB63 RID: 60259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBuffValue(float value, bool active, bool positiveIncrease = true)
		{
			throw null;
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600EB65 RID: 60261 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400F066 RID: 61542
		private const string string_0 = "Active";

		// Token: 0x0400F067 RID: 61543
		[SerializeField]
		private Image _upBuffArrow;

		// Token: 0x0400F068 RID: 61544
		[SerializeField]
		private Image _downBuffArrow;

		// Token: 0x0400F069 RID: 61545
		[SerializeField]
		private TMP_Text _buffValue;

		// Token: 0x0400F06A RID: 61546
		private static readonly Color color_1;

		// Token: 0x0400F06B RID: 61547
		private static readonly Color color_2;

		// Token: 0x0400F06C RID: 61548
		private Animator animator_0;

		// Token: 0x0400F06D RID: 61549
		private Animator animator_1;

		// Token: 0x0400F06E RID: 61550
		private float float_4;

		// Token: 0x0400F06F RID: 61551
		private bool? nullable_0;

		// Token: 0x0400F070 RID: 61552
		private bool bool_0;
	}
}
