using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A0A RID: 10762
	public class RepairWarningStatusPanel : UIElement
	{
		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x0600D5E8 RID: 54760 RVA: 0x00002050 File Offset: 0x00000250
		private RepairWarningStatus RepairWarningStatus_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x0600D5E9 RID: 54761 RVA: 0x00002050 File Offset: 0x00000250
		private RepairWarningStatus RepairWarningStatus_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x0600D5EA RID: 54762 RVA: 0x00002050 File Offset: 0x00000250
		private RepairWarningStatus RepairWarningStatus_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x0600D5EB RID: 54763 RVA: 0x00002050 File Offset: 0x00000250
		private RepairWarningStatus RepairWarningStatus_3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowDurabilityWarning(float percent)
		{
			throw null;
		}

		// Token: 0x0600D5ED RID: 54765 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowBuffPossibilityInfo(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600D5EE RID: 54766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowCommonBuffInfo(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600D5EF RID: 54767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowRareBuffInfo(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600D5F0 RID: 54768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCriticalCondition(ERepairStatusWarning repairStatus, bool hasError, bool isWarningPanelVisible = true)
		{
			throw null;
		}

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool value)
		{
			throw null;
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDegradationPrediction(Vector2 range)
		{
			throw null;
		}

		// Token: 0x0400D80D RID: 55309
		[SerializeField]
		private RepairWarningStatus _errorPanelTemplate;

		// Token: 0x0400D80E RID: 55310
		[SerializeField]
		private RepairWarningStatus _warningPanelTemplate;

		// Token: 0x0400D80F RID: 55311
		[SerializeField]
		private RepairWarningStatus _infoPanelTemplate;

		// Token: 0x0400D810 RID: 55312
		[SerializeField]
		private RepairWarningStatus _commonBuffPanelTemplate;

		// Token: 0x0400D811 RID: 55313
		[SerializeField]
		private RepairWarningStatus _rareBuffPanelTemplate;

		// Token: 0x0400D812 RID: 55314
		[SerializeField]
		private RectTransform _warningsPlaceholder;

		// Token: 0x0400D813 RID: 55315
		[SerializeField]
		private ConditionCharacteristicsSlider _characteristicsSlider;

		// Token: 0x0400D814 RID: 55316
		[SerializeField]
		private CanvasGroup _repairerParametersPanel;

		// Token: 0x0400D815 RID: 55317
		[NonSerialized]
		public readonly GClass3355<ERepairStatusWarning?> OnRepairStatusChanged;

		// Token: 0x0400D816 RID: 55318
		private readonly Dictionary<ERepairStatusWarning, RepairWarningStatus> dictionary_0;

		// Token: 0x0400D817 RID: 55319
		private RepairWarningStatus repairWarningStatus_0;

		// Token: 0x0400D818 RID: 55320
		private RepairWarningStatus repairWarningStatus_1;

		// Token: 0x0400D819 RID: 55321
		private RepairWarningStatus repairWarningStatus_2;

		// Token: 0x0400D81A RID: 55322
		private RepairWarningStatus repairWarningStatus_3;

		// Token: 0x0400D81B RID: 55323
		private Vector2 vector2_0;
	}
}
