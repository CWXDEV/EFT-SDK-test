using System;
using System.Runtime.CompilerServices;

namespace EFT.Quests
{
	// Token: 0x02002FEC RID: 12268
	public class ConditionHit : Condition
	{
		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600F1EF RID: 61935 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual string LocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x0600F1F0 RID: 61936 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F1F1 RID: 61937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GenerateFormattedDescription()
		{
			throw null;
		}

		// Token: 0x0400F7FB RID: 63483
		public string target;

		// Token: 0x0400F7FC RID: 63484
		public GClass3216 distance;

		// Token: 0x0400F7FD RID: 63485
		public string[] weapon;

		// Token: 0x0400F7FE RID: 63486
		public string[] weaponCategories;

		// Token: 0x0400F7FF RID: 63487
		public string[][] weaponModsInclusive;

		// Token: 0x0400F800 RID: 63488
		public string[][] weaponModsExclusive;

		// Token: 0x0400F801 RID: 63489
		public EBodyPart[] bodyPart;

		// Token: 0x0400F802 RID: 63490
		public string[] savageRole;

		// Token: 0x0400F803 RID: 63491
		public GClass3217 daytime;

		// Token: 0x0400F804 RID: 63492
		public new bool resetOnSessionEnd;

		// Token: 0x0400F805 RID: 63493
		public string[][] enemyEquipmentInclusive;

		// Token: 0x0400F806 RID: 63494
		public string[][] enemyEquipmentExclusive;

		// Token: 0x0400F807 RID: 63495
		public GClass2458[] enemyHealthEffects;

		// Token: 0x02002FED RID: 12269
		private enum EHitTagTypes
		{
			// Token: 0x0400F809 RID: 63497
			Target,
			// Token: 0x0400F80A RID: 63498
			Distance,
			// Token: 0x0400F80B RID: 63499
			Weapon,
			// Token: 0x0400F80C RID: 63500
			WeaponType,
			// Token: 0x0400F80D RID: 63501
			BodyPart,
			// Token: 0x0400F80E RID: 63502
			OneSession,
			// Token: 0x0400F80F RID: 63503
			BotRole
		}

		// Token: 0x02002FEE RID: 12270
		[CompilerGenerated]
		private sealed class Class3065
		{
			// Token: 0x0400F810 RID: 63504
			public string localeKey;
		}

		// Token: 0x02002FEF RID: 12271
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3066
		{
			// Token: 0x0400F811 RID: 63505
			public static readonly ConditionHit.Class3066 class3066_0;

			// Token: 0x0400F812 RID: 63506
			public static Func<string, string> func_0;
		}
	}
}
