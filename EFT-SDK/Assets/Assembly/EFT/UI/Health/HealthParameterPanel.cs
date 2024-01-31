using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Health
{
	// Token: 0x02002E9B RID: 11931
	public class HealthParameterPanel : MonoBehaviour
	{
		// Token: 0x0600EB79 RID: 60281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParameterValue(ValueStruct value, float warningThreshold, int roundValue, bool countFromTop = false)
		{
			throw null;
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWarningColor(bool display, bool useAlternative)
		{
			throw null;
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(ValueStruct value, float warningThreshold, int roundValue)
		{
			throw null;
		}

		// Token: 0x0400F084 RID: 61572
		[SerializeField]
		private TMP_Text _currentValue;

		// Token: 0x0400F085 RID: 61573
		[SerializeField]
		private TMP_Text _maxValue;

		// Token: 0x0400F086 RID: 61574
		[SerializeField]
		private Image _glow;

		// Token: 0x0400F087 RID: 61575
		[SerializeField]
		private Image _icon;

		// Token: 0x0400F088 RID: 61576
		[SerializeField]
		private Color _warningColor;

		// Token: 0x0400F089 RID: 61577
		[SerializeField]
		private Color _alternativeWarningColor;

		// Token: 0x0400F08A RID: 61578
		[SerializeField]
		private int _minimalStringLength;

		// Token: 0x0400F08B RID: 61579
		[SerializeField]
		private Color _additionalZerosColor;

		// Token: 0x0400F08C RID: 61580
		private float float_0;

		// Token: 0x0400F08D RID: 61581
		private float float_1;

		// Token: 0x0400F08E RID: 61582
		private float float_2;

		// Token: 0x0400F08F RID: 61583
		private float float_3;

		// Token: 0x0400F090 RID: 61584
		private Color color_0;
	}
}
