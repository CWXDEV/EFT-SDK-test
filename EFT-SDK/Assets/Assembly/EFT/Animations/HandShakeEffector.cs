using System;
using System.Runtime.CompilerServices;
using CW2.Animations;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.Animations
{
	// Token: 0x02001EF4 RID: 7924
	[Serializable]
	public class HandShakeEffector : IEffector
	{
		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x0600A3A5 RID: 41893 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3A6 RID: 41894 RVA: 0x00002050 File Offset: 0x00000250
		public Transform Transform
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

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(PlayerSpring playerSpring)
		{
			throw null;
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStop()
		{
			throw null;
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Process(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateDamping(float duration)
		{
			throw null;
		}

		// Token: 0x0600A3AB RID: 41899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(float tremorIntensity, float curveFrequency, float curveIntensity)
		{
			throw null;
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string DebugOutput()
		{
			throw null;
		}

		// Token: 0x0600A3AD RID: 41901 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x0600A3AE RID: 41902 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1()
		{
			throw null;
		}

		// Token: 0x0400AAF1 RID: 43761
		private const float DEFAULT_SHAKE_INTENSITY = 3f;

		// Token: 0x0400AAF2 RID: 43762
		private const float DEFAULT_CURVE_INTENSITY = 1f;

		// Token: 0x0400AAF3 RID: 43763
		private const float DEFAULT_CURVE_FREQUENCY = 1f;

		// Token: 0x0400AAF5 RID: 43765
		public GClass678 Physical;

		// Token: 0x0400AAF6 RID: 43766
		public bool IsAiming;

		// Token: 0x0400AAF7 RID: 43767
		[SerializeField]
		private float _shakeIntensity;

		// Token: 0x0400AAF8 RID: 43768
		[Space(10f)]
		[Header("Smooth Random")]
		[SerializeField]
		private float _energyMultiplier;

		// Token: 0x0400AAF9 RID: 43769
		[SerializeField]
		private float _energyLowerLimit;

		// Token: 0x0400AAFA RID: 43770
		[SerializeField]
		private float _energyFractureLimit;

		// Token: 0x0400AAFB RID: 43771
		[SerializeField]
		private bool _useHandShakeParams;

		// Token: 0x0400AAFC RID: 43772
		[SerializeField]
		private BreathParameters _handShakeParams;

		// Token: 0x0400AAFD RID: 43773
		[Tooltip("Affects on Hands Rotation Spring")]
		[SerializeField]
		private SmoothRandom _handsRotationSpringXRandom;

		// Token: 0x0400AAFE RID: 43774
		[SerializeField]
		[Tooltip("Affects on Hands Rotation Spring")]
		private SmoothRandom _handsRotationSpringYRandom;

		// Token: 0x0400AAFF RID: 43775
		private Vector3 _handsRotationSpringAcceleration;

		// Token: 0x0400AB00 RID: 43776
		[SerializeField]
		[Space(10f)]
		[Header("Tremor")]
		[Tooltip("Affects on Recoil Rotation Spring Zero")]
		private SmoothRandom _recoilRotationSpringTremorXRandom;

		// Token: 0x0400AB01 RID: 43777
		[SerializeField]
		[Tooltip("Affects on Recoil Rotation Spring Zero")]
		private SmoothRandom _recoilRotationSpringTremorYRandom;

		// Token: 0x0400AB02 RID: 43778
		[SerializeField]
		[Tooltip("Affects on Recoil Rotation Spring Zero")]
		private SmoothRandom _recoilRotationSpringTremorZRandom;

		// Token: 0x0400AB03 RID: 43779
		private Vector3 _recoilRotationSpringZero;

		// Token: 0x0400AB04 RID: 43780
		[Space(10f)]
		[Header("Curves")]
		[SerializeField]
		private float _curveFrequency;

		// Token: 0x0400AB05 RID: 43781
		[SerializeField]
		private float _curveIntensity;

		// Token: 0x0400AB06 RID: 43782
		[FormerlySerializedAs("Curves")]
		[Tooltip("Curves are initializing on weapon switch, so if you delete vals of curves or curves themselves, need to initialize them again to apply changes by switching the gun")]
		[SerializeField]
		private AnimVal[] _curves;

		// Token: 0x0400AB07 RID: 43783
		[SerializeField]
		[Header("Damping")]
		[Space(10f)]
		private bool _enableDamping;

		// Token: 0x0400AB08 RID: 43784
		[SerializeField]
		private float _dampingStartTimePercent;

		// Token: 0x0400AB09 RID: 43785
		private float _passedTime;

		// Token: 0x0400AB0A RID: 43786
		private float _dampingCoef;

		// Token: 0x0400AB0B RID: 43787
		private float _dampingPassedTime;

		// Token: 0x0400AB0C RID: 43788
		private float _dampingDuration;

		// Token: 0x0400AB0D RID: 43789
		private float _dampingStartTime;

		// Token: 0x0400AB0E RID: 43790
		private GClass2210[] _processors;

		// Token: 0x0400AB0F RID: 43791
		private GClass750<float> _staminaLevel;

		// Token: 0x0400AB10 RID: 43792
		private Spring _handsRotationSpring;

		// Token: 0x0400AB11 RID: 43793
		private RecoilProcessBase _recoilRotationSpring;

		// Token: 0x0400AB12 RID: 43794
		private ShotEffector _shotEffector;

		// Token: 0x02001EF5 RID: 7925
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1815
		{
			// Token: 0x0600A3AF RID: 41903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2210 method_0(AnimVal curve)
			{
				throw null;
			}

			// Token: 0x0400AB13 RID: 43795
			public static readonly HandShakeEffector.Class1815 class1815_0;

			// Token: 0x0400AB14 RID: 43796
			public static Func<AnimVal, GClass2210> func_0;
		}
	}
}
