using System;
using System.Runtime.CompilerServices;
using CW2.Animations;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EF2 RID: 7922
	[Serializable]
	public class BreathEffector : IEffector
	{
		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600A39A RID: 41882 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A39B RID: 41883 RVA: 0x00002050 File Offset: 0x00000250
		public float Overweight
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(PlayerSpring playerSpring)
		{
			throw null;
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnShot()
		{
			throw null;
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A39F RID: 41887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string DebugOutput()
		{
			throw null;
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1()
		{
			throw null;
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_2()
		{
			throw null;
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_3()
		{
			throw null;
		}

		// Token: 0x0400AACA RID: 43722
		public GClass678 Physical;

		// Token: 0x0400AACB RID: 43723
		public bool IsAiming;

		// Token: 0x0400AACC RID: 43724
		private Spring _handsRotationSpring;

		// Token: 0x0400AACD RID: 43725
		private ShotEffector _shotEffector;

		// Token: 0x0400AACE RID: 43726
		public float Intensity;

		// Token: 0x0400AACF RID: 43727
		[Header("Smooth Random")]
		private float _shakeIntensity;

		// Token: 0x0400AAD0 RID: 43728
		public SmoothRandom XRandom;

		// Token: 0x0400AAD1 RID: 43729
		public SmoothRandom YRandom;

		// Token: 0x0400AAD2 RID: 43730
		private float _breathIntensity;

		// Token: 0x0400AAD3 RID: 43731
		private float _breathFrequency;

		// Token: 0x0400AAD4 RID: 43732
		[Header("Tremor")]
		public SmoothRandom TremorXRandom;

		// Token: 0x0400AAD5 RID: 43733
		public SmoothRandom TremorYRandom;

		// Token: 0x0400AAD6 RID: 43734
		public SmoothRandom TremorZRandom;

		// Token: 0x0400AAD7 RID: 43735
		[Header("Hip Wiggle")]
		public SmoothRandom HipXRandom;

		// Token: 0x0400AAD8 RID: 43736
		public SmoothRandom HipZRandom;

		// Token: 0x0400AAD9 RID: 43737
		public float HipPenalty;

		// Token: 0x0400AADA RID: 43738
		public AnimVal[] Curves;

		// Token: 0x0400AADB RID: 43739
		private GClass2210[] _processors;

		// Token: 0x0400AADC RID: 43740
		public BreathParameters BreathParams;

		// Token: 0x0400AADD RID: 43741
		public bool TremorOn;

		// Token: 0x0400AADE RID: 43742
		public bool Fracture;

		// Token: 0x0400AADF RID: 43743
		private float _cameraSensetivity;

		// Token: 0x0400AAE0 RID: 43744
		public float StiffUntill;

		// Token: 0x0400AAE1 RID: 43745
		public float EnergyLowerLimit;

		// Token: 0x0400AAE2 RID: 43746
		public float EnergyFractureLimit;

		// Token: 0x0400AAE3 RID: 43747
		public float AmplitudeGainPerShot;

		// Token: 0x0400AAE4 RID: 43748
		public float Delay;

		// Token: 0x0400AAE5 RID: 43749
		public Player.BetterValueBlender AmplitudeGain;

		// Token: 0x0400AAE6 RID: 43750
		public Player.BetterValueBlender Hardness;

		// Token: 0x0400AAE7 RID: 43751
		[SerializeField]
		private Vector2 _baseHipRandomAmplitudes;

		// Token: 0x0400AAE8 RID: 43752
		[SerializeField]
		private Vector2 _randomBetween;

		// Token: 0x0400AAE9 RID: 43753
		[SerializeField]
		private float _shotHardness;

		// Token: 0x0400AAEA RID: 43754
		[SerializeField]
		private AnimationCurve _lackOfOxygenStrength;

		// Token: 0x0400AAEC RID: 43756
		public GClass750<float> OxygenLevel;

		// Token: 0x0400AAED RID: 43757
		public GClass750<float> StaminaLevel;

		// Token: 0x0400AAEE RID: 43758
		public bool TestBreath;

		// Token: 0x02001EF3 RID: 7923
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1814
		{
			// Token: 0x0600A3A4 RID: 41892 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2210 method_0(AnimVal val)
			{
				throw null;
			}

			// Token: 0x0400AAEF RID: 43759
			public static readonly BreathEffector.Class1814 class1814_0;

			// Token: 0x0400AAF0 RID: 43760
			public static Func<AnimVal, GClass2210> func_0;
		}
	}
}
