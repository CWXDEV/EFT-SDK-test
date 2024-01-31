using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI.Health
{
	// Token: 0x02002E9E RID: 11934
	public class InventoryScreenHealthPanel : UIElement
	{
		// Token: 0x0600EB85 RID: 60293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, Inventory inventory, SkillManager skillManager, DamageHistory damageHistory = null)
		{
			throw null;
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParametersVisibility(bool value)
		{
			throw null;
		}

		// Token: 0x0400F09E RID: 61598
		[SerializeField]
		private HealthParametersPanel _parametersPanel;

		// Token: 0x0400F09F RID: 61599
		[SerializeField]
		private GameObject _silhouette;

		// Token: 0x0400F0A0 RID: 61600
		[SerializeField]
		private BodyPartView _head;

		// Token: 0x0400F0A1 RID: 61601
		[SerializeField]
		private BodyPartView _chest;

		// Token: 0x0400F0A2 RID: 61602
		[SerializeField]
		private BodyPartView _stomach;

		// Token: 0x0400F0A3 RID: 61603
		[SerializeField]
		private BodyPartView _leftArm;

		// Token: 0x0400F0A4 RID: 61604
		[SerializeField]
		private BodyPartView _rightArm;

		// Token: 0x0400F0A5 RID: 61605
		[SerializeField]
		private BodyPartView _leftLeg;

		// Token: 0x0400F0A6 RID: 61606
		[SerializeField]
		private BodyPartView _rightLeg;

		// Token: 0x0400F0A7 RID: 61607
		[SerializeField]
		private GameObject _damageLegend;

		// Token: 0x0400F0A8 RID: 61608
		private readonly Dictionary<EBodyPart, BodyPartView> dictionary_0;

		// Token: 0x0400F0A9 RID: 61609
		private SimpleTooltip simpleTooltip_0;
	}
}
