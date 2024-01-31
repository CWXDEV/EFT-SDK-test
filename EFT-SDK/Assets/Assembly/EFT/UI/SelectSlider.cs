using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C4A RID: 11338
	public sealed class SelectSlider : UIElement, GInterface370<int>
	{
		// Token: 0x0600DF78 RID: 57208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DF79 RID: 57209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string[] values)
		{
			throw null;
		}

		// Token: 0x0600DF7A RID: 57210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Func<string[]> values)
		{
			throw null;
		}

		// Token: 0x0600DF7B RID: 57211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValue(int value, bool sendCallback = true, int? min = null, int? max = null)
		{
			throw null;
		}

		// Token: 0x0600DF7D RID: 57213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string text)
		{
			throw null;
		}

		// Token: 0x0600DF7E RID: 57214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Bind([CanBeNull] Action<int> valueChanged)
		{
			throw null;
		}

		// Token: 0x0600DF7F RID: 57215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CurrentValue()
		{
			throw null;
		}

		// Token: 0x0600DF80 RID: 57216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DF81 RID: 57217 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(float val)
		{
			throw null;
		}

		// Token: 0x0400E43B RID: 58427
		[SerializeField]
		private Slider _slider;

		// Token: 0x0400E43C RID: 58428
		[SerializeField]
		private TextMeshProUGUI _valueText;

		// Token: 0x0400E43D RID: 58429
		[SerializeField]
		private GameObject _notchTemplate;

		// Token: 0x0400E43E RID: 58430
		[SerializeField]
		private RectTransform _notchContainer;

		// Token: 0x0400E43F RID: 58431
		private readonly List<GameObject> list_0;

		// Token: 0x0400E440 RID: 58432
		private Action<int> action_0;

		// Token: 0x0400E441 RID: 58433
		private Func<string[]> func_0;

		// Token: 0x0400E442 RID: 58434
		private bool bool_0;

		// Token: 0x0400E443 RID: 58435
		private string[] string_0;
	}
}
