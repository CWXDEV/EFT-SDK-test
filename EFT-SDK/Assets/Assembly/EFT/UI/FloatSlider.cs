using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C39 RID: 11321
	public sealed class FloatSlider : MonoBehaviour, GInterface370<float>
	{
		// Token: 0x0600DF1A RID: 57114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DF1B RID: 57115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float value)
		{
			throw null;
		}

		// Token: 0x0600DF1C RID: 57116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(float minValue, float maxValue)
		{
			throw null;
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValue(float value, bool sendCallback = true, float? min = null, float? max = null)
		{
			throw null;
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Bind(Action<float> valueChanged)
		{
			throw null;
		}

		// Token: 0x0600DF1F RID: 57119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float CurrentValue()
		{
			throw null;
		}

		// Token: 0x0400E3F7 RID: 58359
		[SerializeField]
		private Slider _slider;

		// Token: 0x0400E3F8 RID: 58360
		[SerializeField]
		private TMP_InputField _valueInput;

		// Token: 0x0400E3F9 RID: 58361
		public string Format;

		// Token: 0x0400E3FA RID: 58362
		private Action<float> action_0;
	}
}
