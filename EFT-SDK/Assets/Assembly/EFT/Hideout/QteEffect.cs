using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001B1D RID: 6941
	public sealed class QteEffect
	{
		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x0600928C RID: 37516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600928D RID: 37517 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Type")]
		public QteEffect.EQteRewardType Type
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x0600928E RID: 37518 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600928F RID: 37519 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("SkillId")]
		public ESkillId Skill
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06009290 RID: 37520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009291 RID: 37521 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("levelMultipliers")]
		public QteEffect.SkillExperienceMultiplierData[] SkillExpMultiplierData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06009292 RID: 37522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009293 RID: 37523 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Time")]
		public float Duration
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009295 RID: 37525 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Weight")]
		public float Weight
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06009296 RID: 37526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009297 RID: 37527 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Result")]
		public QteEffect.EQteResultType Result
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x02001B1E RID: 6942
		public enum EQteRewardType
		{
			// Token: 0x0400993D RID: 39229
			Skill,
			// Token: 0x0400993E RID: 39230
			HealthEffect,
			// Token: 0x0400993F RID: 39231
			MusclePain,
			// Token: 0x04009940 RID: 39232
			GymArmTrauma
		}

		// Token: 0x02001B1F RID: 6943
		public enum EQteResultType
		{
			// Token: 0x04009942 RID: 39234
			None,
			// Token: 0x04009943 RID: 39235
			Exit
		}

		// Token: 0x02001B20 RID: 6944
		public struct SkillExperienceMultiplierData
		{
			// Token: 0x04009944 RID: 39236
			[JsonProperty("level")]
			public int level;

			// Token: 0x04009945 RID: 39237
			[JsonProperty("multiplier")]
			public float value;
		}
	}
}
