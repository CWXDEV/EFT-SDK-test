using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A08 RID: 10760
	public sealed class ConditionCharacteristicsSlider : UIElement
	{
		// Token: 0x140002EC RID: 748
		// (add) Token: 0x0600D5D6 RID: 54742 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D5D7 RID: 54743 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float> OnSliderValueChangedEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600D5D8 RID: 54744 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x0600D5D9 RID: 54745 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x0600D5DB RID: 54747 RVA: 0x00002050 File Offset: 0x00000250
		public float RealCurrentDurability
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0600D5DC RID: 54748 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D5DD RID: 54749 RVA: 0x00002050 File Offset: 0x00000250
		public float Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600D5DE RID: 54750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GInterface33 repairStrategy)
		{
			throw null;
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float value)
		{
			throw null;
		}

		// Token: 0x0600D5E1 RID: 54753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSliderValues(bool setAnchors = true)
		{
			throw null;
		}

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSliderActive(bool value)
		{
			throw null;
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSliderInteractable(bool value)
		{
			throw null;
		}

		// Token: 0x0600D5E4 RID: 54756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDegradationPrediction(Vector2 range)
		{
			throw null;
		}

		// Token: 0x0600D5E5 RID: 54757 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0400D7FB RID: 55291
		[SerializeField]
		private Image _border;

		// Token: 0x0400D7FC RID: 55292
		[SerializeField]
		private Image _currentDurabilityImage;

		// Token: 0x0400D7FD RID: 55293
		[SerializeField]
		private Image _selectedDurabilityImage;

		// Token: 0x0400D7FE RID: 55294
		[SerializeField]
		private Image _maximumDirabilityImage;

		// Token: 0x0400D7FF RID: 55295
		[SerializeField]
		private Image _maximumDurabilityRemovedImage;

		// Token: 0x0400D800 RID: 55296
		[SerializeField]
		private Image _maxDegradation;

		// Token: 0x0400D801 RID: 55297
		[SerializeField]
		private Slider _durabilitySlider;

		// Token: 0x0400D802 RID: 55298
		[SerializeField]
		private CustomTextMeshProUGUI _durabilityLabel;

		// Token: 0x0400D803 RID: 55299
		[SerializeField]
		private Button _maximumSliderValueButton;

		// Token: 0x0400D804 RID: 55300
		[SerializeField]
		private Color _criticalColor;

		// Token: 0x0400D805 RID: 55301
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400D806 RID: 55302
		private float float_0;

		// Token: 0x0400D807 RID: 55303
		[CompilerGenerated]
		private Action<float> action_0;

		// Token: 0x0400D808 RID: 55304
		private ItemAttributeClass gclass2745_0;

		// Token: 0x0400D809 RID: 55305
		private ItemAttributeClass gclass2745_1;

		// Token: 0x0400D80A RID: 55306
		private Vector2 vector2_0;

		// Token: 0x0400D80B RID: 55307
		private GInterface33 ginterface33_0;
	}
}
