using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Health
{
	// Token: 0x02002E93 RID: 11923
	public sealed class BodyPartView : UIElement
	{
		// Token: 0x0600EB5F RID: 60255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB60 RID: 60256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, EBodyPart bodyPart, SimpleTooltip tooltip, DamageHistory damageHistory = null)
		{
			throw null;
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEffectsFilter(IEnumerable<Type> effectsFilter)
		{
			throw null;
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400F058 RID: 61528
		private const float float_0 = 1f;

		// Token: 0x0400F059 RID: 61529
		[SerializeField]
		private CustomTextMeshProUGUI _valueText;

		// Token: 0x0400F05A RID: 61530
		[SerializeField]
		private Image _healthBar;

		// Token: 0x0400F05B RID: 61531
		[SerializeField]
		private Image _healthBarBorder;

		// Token: 0x0400F05C RID: 61532
		[SerializeField]
		private Image _image;

		// Token: 0x0400F05D RID: 61533
		[SerializeField]
		private Image _brokenCross;

		// Token: 0x0400F05E RID: 61534
		[SerializeField]
		private EffectsPanel _effectsPanel;

		// Token: 0x0400F05F RID: 61535
		[SerializeField]
		private DamagePanel _damagePanel;

		// Token: 0x0400F060 RID: 61536
		[SerializeField]
		private HealthBarButton _button;

		// Token: 0x0400F061 RID: 61537
		private Color color_0;

		// Token: 0x0400F062 RID: 61538
		private IHealthController ihealthController_0;

		// Token: 0x0400F063 RID: 61539
		private EBodyPart ebodyPart_0;

		// Token: 0x0400F064 RID: 61540
		private float float_1;

		// Token: 0x0400F065 RID: 61541
		private bool bool_0;
	}
}
