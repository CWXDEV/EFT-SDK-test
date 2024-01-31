using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BE0 RID: 11232
	public abstract class HealthTreatmentView : UIElement
	{
		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DD68 RID: 56680 RVA: 0x00002050 File Offset: 0x00000250
		protected bool Active
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

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DD6A RID: 56682 RVA: 0x00002050 File Offset: 0x00000250
		protected float CostTotal
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600DD6B RID: 56683 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DD6C RID: 56684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(GInterface371 treatment)
		{
			throw null;
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool selected)
		{
			throw null;
		}

		// Token: 0x0600DD6E RID: 56686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateCost()
		{
			throw null;
		}

		// Token: 0x0400E1E6 RID: 57830
		private const string string_0 = "UI/HealthTreatmentName_";

		// Token: 0x0400E1E7 RID: 57831
		private const string string_1 = "UI/HealthTreatmentAction_";

		// Token: 0x0400E1E8 RID: 57832
		[SerializeField]
		private UpdatableToggle _checkbox;

		// Token: 0x0400E1E9 RID: 57833
		[SerializeField]
		private TextMeshProUGUI _treatmentNameField;

		// Token: 0x0400E1EA RID: 57834
		[SerializeField]
		private TextMeshProUGUI _treatmentActionNameField;

		// Token: 0x0400E1EB RID: 57835
		[SerializeField]
		private TextMeshProUGUI _costField;

		// Token: 0x0400E1EC RID: 57836
		[SerializeField]
		private Image _highlight;

		// Token: 0x0400E1ED RID: 57837
		[NonSerialized]
		public GClass3355<bool> OnSelect;

		// Token: 0x0400E1EE RID: 57838
		private GInterface371 ginterface371_0;

		// Token: 0x0400E1EF RID: 57839
		private bool bool_0;

		// Token: 0x0400E1F0 RID: 57840
		[CompilerGenerated]
		private float float_0;
	}
}
