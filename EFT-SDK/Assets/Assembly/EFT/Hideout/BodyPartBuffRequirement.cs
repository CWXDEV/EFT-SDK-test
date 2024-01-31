using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BCD RID: 7117
	[Serializable]
	public sealed class BodyPartBuffRequirement : Requirement
	{
		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06009564 RID: 38244 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		private EBodyPart EBodyPart_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x00002050 File Offset: 0x00000250
		public override bool Fulfilled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Test(HealthControllerClass healthController)
		{
			throw null;
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(IEffect effect)
		{
			throw null;
		}

		// Token: 0x04009C21 RID: 39969
		[JsonProperty("EffectName")]
		private string _effectName;

		// Token: 0x04009C22 RID: 39970
		[JsonProperty("BodyPart")]
		private string _bodyPart;

		// Token: 0x04009C23 RID: 39971
		[JsonProperty("Excluded")]
		private bool _excluded;

		// Token: 0x04009C24 RID: 39972
		private HealthControllerClass _healthController;
	}
}
