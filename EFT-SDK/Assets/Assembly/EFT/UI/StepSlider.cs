using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C50 RID: 11344
	public class StepSlider : MonoBehaviour, GInterface370<float>
	{
		// Token: 0x0600DF8A RID: 57226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DF8B RID: 57227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Focus()
		{
			throw null;
		}

		// Token: 0x0600DF8C RID: 57228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int minValue, int maxValue, int currentValue)
		{
			throw null;
		}

		// Token: 0x0600DF8D RID: 57229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int value)
		{
			throw null;
		}

		// Token: 0x0600DF8E RID: 57230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_0(decimal value)
		{
			throw null;
		}

		// Token: 0x0600DF8F RID: 57231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_1(IList<int> list, int value)
		{
			throw null;
		}

		// Token: 0x0600DF90 RID: 57232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(int realValue, float sliderValue)
		{
			throw null;
		}

		// Token: 0x0600DF91 RID: 57233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValue(float value, bool sendCallback = true, float? min = null, float? max = null)
		{
			throw null;
		}

		// Token: 0x0600DF92 RID: 57234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Bind(Action<float> valueChanged)
		{
			throw null;
		}

		// Token: 0x0600DF93 RID: 57235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float CurrentValue()
		{
			throw null;
		}

		// Token: 0x0600DF94 RID: 57236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(float arg)
		{
			throw null;
		}

		// Token: 0x0600DF96 RID: 57238 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(string arg)
		{
			throw null;
		}

		// Token: 0x0600DF97 RID: 57239 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(string value)
		{
			throw null;
		}

		// Token: 0x0400E44E RID: 58446
		[SerializeField]
		private Slider _slider;

		// Token: 0x0400E44F RID: 58447
		[SerializeField]
		private CustomTextMeshProInputField _valueInput;

		// Token: 0x0400E450 RID: 58448
		[SerializeField]
		private GameObject _notchTemplate;

		// Token: 0x0400E451 RID: 58449
		[SerializeField]
		private RectTransform _notchContainer;

		// Token: 0x0400E452 RID: 58450
		private readonly List<GameObject> list_0;

		// Token: 0x0400E453 RID: 58451
		private readonly List<int> list_1;

		// Token: 0x0400E454 RID: 58452
		private int int_0;

		// Token: 0x0400E455 RID: 58453
		private int int_1;

		// Token: 0x0400E456 RID: 58454
		private int int_2;

		// Token: 0x0400E457 RID: 58455
		private int int_3;

		// Token: 0x02002C51 RID: 11345
		[CompilerGenerated]
		private sealed class Class2699
		{
			// Token: 0x0600DF98 RID: 57240 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(int x, int y)
			{
				throw null;
			}

			// Token: 0x0400E458 RID: 58456
			public int value;
		}
	}
}
