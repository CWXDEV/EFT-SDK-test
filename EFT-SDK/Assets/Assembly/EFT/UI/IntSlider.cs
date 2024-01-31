using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C3E RID: 11326
	public class IntSlider : MonoBehaviour, GInterface370<int>
	{
		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x0600DF2E RID: 57134 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DF2F RID: 57135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DF30 RID: 57136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float value)
		{
			throw null;
		}

		// Token: 0x0600DF31 RID: 57137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(string text)
		{
			throw null;
		}

		// Token: 0x0600DF32 RID: 57138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DF33 RID: 57139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int minSliderValue, int maxSliderValue, int minValue, int maxValue, int currentValue, bool allowZero = false)
		{
			throw null;
		}

		// Token: 0x0600DF34 RID: 57140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Focus()
		{
			throw null;
		}

		// Token: 0x0600DF35 RID: 57141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValue(int value, bool sendCallback = true, int? min = null, int? max = null)
		{
			throw null;
		}

		// Token: 0x0600DF36 RID: 57142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Bind(Action<int> valueChanged)
		{
			throw null;
		}

		// Token: 0x0600DF37 RID: 57143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CurrentValue()
		{
			throw null;
		}

		// Token: 0x0400E3FD RID: 58365
		[SerializeField]
		private Slider _slider;

		// Token: 0x0400E3FE RID: 58366
		[SerializeField]
		private CustomTextMeshProInputField _valueInput;

		// Token: 0x0400E3FF RID: 58367
		[SerializeField]
		private GameObject _notchTemplate;

		// Token: 0x0400E400 RID: 58368
		[SerializeField]
		private GameObject _notchNotAvailableTemplate;

		// Token: 0x0400E401 RID: 58369
		[SerializeField]
		private RectTransform _notchContainer;

		// Token: 0x0400E402 RID: 58370
		private readonly List<GameObject> list_0;

		// Token: 0x0400E403 RID: 58371
		private int int_0;

		// Token: 0x0400E404 RID: 58372
		private int int_1;

		// Token: 0x0400E405 RID: 58373
		private int int_2;

		// Token: 0x0400E406 RID: 58374
		private bool bool_0;

		// Token: 0x02002C3F RID: 11327
		[CompilerGenerated]
		private sealed class Class2695
		{
			// Token: 0x0600DF38 RID: 57144 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(string value)
			{
				throw null;
			}

			// Token: 0x0400E407 RID: 58375
			public int outValue;

			// Token: 0x0400E408 RID: 58376
			public IntSlider intSlider_0;
		}
	}
}
