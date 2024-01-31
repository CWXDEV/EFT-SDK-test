using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;

namespace EFT.UI.Health
{
	// Token: 0x02002E96 RID: 11926
	public class DamagePanel : UIElement
	{
		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x0600EB6C RID: 60268 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EB6D RID: 60269 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, EBodyPart bodyPart, DamageHistory damage)
		{
			throw null;
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EBodyPart bodyPart, float diff, DamageInfo damageInfo)
		{
			throw null;
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private DamagePanel.Class2925 method_1(DamageStats.EDamageResult resultType, List<DamageStats> damageHistory)
		{
			throw null;
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400F075 RID: 61557
		[SerializeField]
		private DamageIcon _damageIconTemplate;

		// Token: 0x0400F076 RID: 61558
		private GClass3357<DamagePanel.Class2925> gclass3357_0;

		// Token: 0x0400F077 RID: 61559
		private IHealthController ihealthController_0;

		// Token: 0x0400F078 RID: 61560
		private EBodyPart ebodyPart_0;

		// Token: 0x02002E97 RID: 11927
		private sealed class Class2925 : List<DamageStats>
		{
			// Token: 0x0400F079 RID: 61561
			public readonly DamageStats.EDamageResult ResultType;
		}

		// Token: 0x02002E98 RID: 11928
		[CompilerGenerated]
		private sealed class Class2926
		{
			// Token: 0x0600EB71 RID: 60273 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400F07A RID: 61562
			public IHealthController healthController;

			// Token: 0x0400F07B RID: 61563
			public DamagePanel damagePanel_0;
		}

		// Token: 0x02002E99 RID: 11929
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2927
		{
			// Token: 0x0600EB72 RID: 60274 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(DamagePanel.Class2925 dmg, DamageIcon view)
			{
				throw null;
			}

			// Token: 0x0400F07C RID: 61564
			public static readonly DamagePanel.Class2927 class2927_0;

			// Token: 0x0400F07D RID: 61565
			public static Action<DamagePanel.Class2925, DamageIcon> action_0;
		}
	}
}
