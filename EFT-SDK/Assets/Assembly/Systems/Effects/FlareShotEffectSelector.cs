using System;
using System.Runtime.CompilerServices;
using EFT.Airdrop;
using EFT.PrefabSettings;
using UnityEngine;

namespace Systems.Effects
{
	// Token: 0x02000C35 RID: 3125
	public sealed class FlareShotEffectSelector : MonoBehaviour
	{
		// Token: 0x0600441A RID: 17434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFlareEffect(FlareColorType flareColorType, float lifetime)
		{
			throw null;
		}

		// Token: 0x04004D9E RID: 19870
		[SerializeField]
		private FlareShotEffectSelector.FlareParameters _lightFlareParameters;

		// Token: 0x04004D9F RID: 19871
		[SerializeField]
		private FlareShotEffectSelector.FlareParameters _redAirdropFlareParameters;

		// Token: 0x04004DA0 RID: 19872
		[SerializeField]
		private FlareShotEffectSelector.FlareParameters _greenExitActivateFlareParameters;

		// Token: 0x04004DA1 RID: 19873
		[SerializeField]
		private FlareShotEffectSelector.FlareParameters _yellowQuestFlareParameters;

		// Token: 0x04004DA2 RID: 19874
		[SerializeField]
		private FlareShotEffectSelector.FlareParameters _acidGreenFlareParameters;

		// Token: 0x04004DA3 RID: 19875
		[SerializeField]
		[Space(10f)]
		private ParticleSystem _flareParticleSystem;

		// Token: 0x04004DA4 RID: 19876
		[SerializeField]
		private ParticleSystem _smokeParticleSystem;

		// Token: 0x04004DA5 RID: 19877
		[SerializeField]
		private Light _flareLight;

		// Token: 0x04004DA6 RID: 19878
		[SerializeField]
		private FlareShotEffectAnimator _flareAnimator;

		// Token: 0x04004DA7 RID: 19879
		[Space(10f)]
		[SerializeField]
		private FlarePatronSound _flarePatronSound;

		// Token: 0x02000C36 RID: 3126
		[Serializable]
		private struct FlareParameters
		{
			// Token: 0x04004DA8 RID: 19880
			public Color32 Color;

			// Token: 0x04004DA9 RID: 19881
			public float LightIntensity;

			// Token: 0x04004DAA RID: 19882
			public float LightRange;

			// Token: 0x04004DAB RID: 19883
			public bool CastShadows;
		}
	}
}
