using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI.Health
{
	// Token: 0x02002E9C RID: 11932
	public class HealthParametersPanel : UIElement
	{
		// Token: 0x0600EB7D RID: 60285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, Inventory inventory, SkillManager skills)
		{
			throw null;
		}

		// Token: 0x0600EB7E RID: 60286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowSecondaryParameters(bool value)
		{
			throw null;
		}

		// Token: 0x0600EB7F RID: 60287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EB80 RID: 60288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400F091 RID: 61585
		[SerializeField]
		private BuffableHealthParameterPanel _overallHealth;

		// Token: 0x0400F092 RID: 61586
		[SerializeField]
		private HealthParameterPanel _poisoning;

		// Token: 0x0400F093 RID: 61587
		[SerializeField]
		private HealthParameterPanel _radiation;

		// Token: 0x0400F094 RID: 61588
		[SerializeField]
		private HealthParameterPanel _bloodPressure;

		// Token: 0x0400F095 RID: 61589
		[SerializeField]
		private BuffableHealthParameterPanel _energy;

		// Token: 0x0400F096 RID: 61590
		[SerializeField]
		private BuffableHealthParameterPanel _hydration;

		// Token: 0x0400F097 RID: 61591
		[SerializeField]
		private BuffableHealthParameterPanel _temperature;

		// Token: 0x0400F098 RID: 61592
		[SerializeField]
		private HealthParameterPanel _weight;

		// Token: 0x0400F099 RID: 61593
		private IHealthController ihealthController_0;

		// Token: 0x0400F09A RID: 61594
		private Inventory inventory_0;

		// Token: 0x0400F09B RID: 61595
		private SkillManager skillManager_0;

		// Token: 0x02002E9D RID: 11933
		[CompilerGenerated]
		private sealed class Class2928
		{
			// Token: 0x0600EB81 RID: 60289 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600EB82 RID: 60290 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IEffect effect)
			{
				throw null;
			}

			// Token: 0x0600EB83 RID: 60291 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600EB84 RID: 60292 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0400F09C RID: 61596
			public SkillManager skills;

			// Token: 0x0400F09D RID: 61597
			public HealthParametersPanel healthParametersPanel_0;
		}
	}
}
