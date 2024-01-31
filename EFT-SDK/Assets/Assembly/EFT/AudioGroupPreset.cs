using System;
using Audio.SpatialSystem;
using SteamAudio;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001772 RID: 6002
	[CreateAssetMenu(menuName = "Scriptable objects/AudioGroupPreset", fileName = "AudioGroupPreset")]
	[Serializable]
	public class AudioGroupPreset : ScriptableObject
	{
		// Token: 0x04008884 RID: 34948
		public BetterAudio.AudioSourceGroupType Type;

		// Token: 0x04008885 RID: 34949
		[Range(0f, 1f)]
		public float OverallVolume;

		// Token: 0x04008886 RID: 34950
		[Range(0f, 1f)]
		public float SpatialBlend;

		// Token: 0x04008887 RID: 34951
		public bool SteamSpatialize;

		// Token: 0x04008888 RID: 34952
		public bool SteamSpatializePostEffects;

		// Token: 0x04008889 RID: 34953
		public bool DirectBinaural;

		// Token: 0x0400888A RID: 34954
		public bool IndirectBinaural;

		// Token: 0x0400888B RID: 34955
		public bool BilinearHRTF;

		// Token: 0x0400888C RID: 34956
		public bool DisableBinauralByDist;

		// Token: 0x0400888D RID: 34957
		public bool Reflections;

		// Token: 0x0400888E RID: 34958
		public bool PhysicalBaseAttenuation;

		// Token: 0x0400888F RID: 34959
		public bool AirAbsorption;

		// Token: 0x04008890 RID: 34960
		public float EnableBinauralDist;

		// Token: 0x04008891 RID: 34961
		public float HeightDiffToAllowBinaural;

		// Token: 0x04008892 RID: 34962
		public float AngleToAllowBinaural;

		// Token: 0x04008893 RID: 34963
		public OcclusionMode OcclusionMode;

		// Token: 0x04008894 RID: 34964
		public OcclusionMethod OcclusionMethod;

		// Token: 0x04008895 RID: 34965
		public MetaXRAudioSourceExperimentalFeatures.DirectivityPatternType DirectivityPatternType;

		// Token: 0x04008896 RID: 34966
		[Range(0.1f, 10f)]
		public float OcclusionSourceRadius;

		// Token: 0x04008897 RID: 34967
		[Range(0f, 1f)]
		public float DirectSoundMix;

		// Token: 0x04008898 RID: 34968
		[Range(0f, 10f)]
		public float IndirectSoundMix;

		// Token: 0x04008899 RID: 34969
		[Range(-1f, 1f)]
		public float DeltaPitch;

		// Token: 0x0400889A RID: 34970
		public AnimationCurve SoundRolloff;

		// Token: 0x0400889B RID: 34971
		public AnimationCurve SpreadCurve;

		// Token: 0x0400889C RID: 34972
		public int AudioSourcePriority;

		// Token: 0x0400889D RID: 34973
		public int PreCachedSourcesCount;

		// Token: 0x0400889E RID: 34974
		public int SourcesCountLimit;

		// Token: 0x0400889F RID: 34975
		public float DefaultMaxDistance;

		// Token: 0x040088A0 RID: 34976
		[Header("----- Occlusion Settings -----")]
		public bool OcclusionEnabled;

		// Token: 0x040088A1 RID: 34977
		[Range(0f, 1f)]
		public float OcclusionIntensity;

		// Token: 0x040088A2 RID: 34978
		public EOcclusionTest OcclusionTest;

		// Token: 0x040088A3 RID: 34979
		[Range(0f, 0.5f)]
		public float OcclusionDistanceCoefficient;

		// Token: 0x040088A4 RID: 34980
		[Range(0f, 0.2f)]
		public float OcclusionRotationCoefficient;

		// Token: 0x040088A5 RID: 34981
		[Range(0.1f, 2f)]
		public float IndoorToOutdoorFactor;

		// Token: 0x040088A6 RID: 34982
		[Range(0.1f, 2f)]
		public float OutdoorToIndoorFactor;

		// Token: 0x040088A7 RID: 34983
		public bool IncludeReverbEffect;

		// Token: 0x040088A8 RID: 34984
		public AnimationCurve OcclusionVolumeCurve;

		// Token: 0x040088A9 RID: 34985
		public AnimationCurve OcclusionLowPassFilterCurve;

		// Token: 0x040088AA RID: 34986
		public AnimationCurve PropagationVolumeCurve;

		// Token: 0x040088AB RID: 34987
		public AnimationCurve PropagationLowPassFilterCurve;

		// Token: 0x040088AC RID: 34988
		public AnimationCurve DistanceLowPassFilterCurve;

		// Token: 0x040088AD RID: 34989
		public AnimationCurve DistanceHighPassFilterCurve;

		// Token: 0x040088AE RID: 34990
		public AudioFilterFrequencySettings FrequencySettings;
	}
}
