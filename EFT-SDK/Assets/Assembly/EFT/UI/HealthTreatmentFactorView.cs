using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BDB RID: 11227
	public sealed class HealthTreatmentFactorView : HealthTreatmentView
	{
		// Token: 0x0600DD46 RID: 56646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GInterface372 observer)
		{
			throw null;
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400E1B6 RID: 57782
		[SerializeField]
		private TextMeshProUGUI _valueToHealField;

		// Token: 0x0400E1B7 RID: 57783
		[SerializeField]
		private Image _icon;

		// Token: 0x0400E1B8 RID: 57784
		[SerializeField]
		private Dictionary<EHealthFactorType, HealthTreatmentFactorView.HealthFactorSettings> _healthFactorsSettings;

		// Token: 0x0400E1B9 RID: 57785
		private GInterface372 ginterface372_0;

		// Token: 0x02002BDC RID: 11228
		[Serializable]
		public struct HealthFactorSettings
		{
			// Token: 0x0400E1BA RID: 57786
			[SerializeField]
			public Color Color;

			// Token: 0x0400E1BB RID: 57787
			[SerializeField]
			public Sprite Icon;
		}
	}
}
