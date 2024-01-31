using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Visual;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200276D RID: 10093
	public sealed class LampController : Turnable, GInterface27, GInterface351
	{
		// Token: 0x0600CA1F RID: 51743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryToBlowUp(IExplosiveItem grenade, in Vector3 grenadePosition)
		{
			throw null;
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x0600CA20 RID: 51744 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA21 RID: 51745 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600CA22 RID: 51746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600CA24 RID: 51748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600CA25 RID: 51749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool turnOn)
		{
			throw null;
		}

		// Token: 0x0600CA26 RID: 51750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(float strength, int randomSeed)
		{
			throw null;
		}

		// Token: 0x0600CA2B RID: 51755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFlickering(float strength)
		{
			throw null;
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Switch(Turnable.EState switchTo)
		{
			throw null;
		}

		// Token: 0x0600CA2D RID: 51757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(bool on)
		{
			throw null;
		}

		// Token: 0x0600CA2E RID: 51758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600CA2F RID: 51759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_9()
		{
			throw null;
		}

		// Token: 0x0600CA30 RID: 51760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate()
		{
			throw null;
		}

		// Token: 0x0600CA31 RID: 51761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10([CanBeNull] AudioClip clip, bool loop = false)
		{
			throw null;
		}

		// Token: 0x0600CA32 RID: 51762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(bool on, bool force = false)
		{
			throw null;
		}

		// Token: 0x0600CA33 RID: 51763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(float intensity)
		{
			throw null;
		}

		// Token: 0x0400CA05 RID: 51717
		private const float float_0 = 30f;

		// Token: 0x0400CA06 RID: 51718
		private const int int_0 = 20;

		// Token: 0x0400CA07 RID: 51719
		private static int int_1;

		// Token: 0x0400CA08 RID: 51720
		private int int_2;

		// Token: 0x0400CA09 RID: 51721
		private int int_3;

		// Token: 0x0400CA0A RID: 51722
		[SerializeField]
		private AnimationCurve _animationCurve;

		// Token: 0x0400CA0B RID: 51723
		[SerializeField]
		private bool _useCurve;

		// Token: 0x0400CA0C RID: 51724
		[SerializeField]
		private AudioSource AudioSource;

		// Token: 0x0400CA0D RID: 51725
		[Space(32f)]
		public Light[] Lights;

		// Token: 0x0400CA0E RID: 51726
		public BaseLight[] AreaAndTubeLights;

		// Token: 0x0400CA0F RID: 51727
		public AdvancedLight[] CustomLights;

		// Token: 0x0400CA10 RID: 51728
		[SerializeField]
		private MultiFlareLight[] MultiFlareLights;

		// Token: 0x0400CA11 RID: 51729
		[SerializeField]
		private MaterialEmission[] _materialEmissions;

		// Token: 0x0400CA12 RID: 51730
		[SerializeField]
		private MaterialColor[] Materials;

		// Token: 0x0400CA13 RID: 51731
		[SerializeField]
		private GameObject[] OnObjects;

		// Token: 0x0400CA14 RID: 51732
		[SerializeField]
		private GameObject[] OffObjects;

		// Token: 0x0400CA15 RID: 51733
		[SerializeField]
		private GameObject[] DestroyedObjects;

		// Token: 0x0400CA16 RID: 51734
		[Header("Working Interval (hours)")]
		public bool isTimeOfDayDependant;

		// Token: 0x0400CA17 RID: 51735
		public bool isCertainInterval;

		// Token: 0x0400CA18 RID: 51736
		public Vector2 MinMaxAmount1;

		// Token: 0x0400CA19 RID: 51737
		public Vector2 MinMaxAmount2;

		// Token: 0x0400CA1A RID: 51738
		[Header("Audio")]
		public int Rolloff;

		// Token: 0x0400CA1B RID: 51739
		[SerializeField]
		private AudioClip TurnOffClip;

		// Token: 0x0400CA1C RID: 51740
		[SerializeField]
		private AudioClip TurnedOnClipStart;

		// Token: 0x0400CA1D RID: 51741
		[SerializeField]
		private AudioClip TurnedOnClipLoop;

		// Token: 0x0400CA1E RID: 51742
		[SerializeField]
		private AudioClip FlickeringClipLoop;

		// Token: 0x0400CA1F RID: 51743
		[SerializeField]
		private float PitchRandom;

		// Token: 0x0400CA20 RID: 51744
		[SerializeField]
		[Space(32f)]
		private Vector2 TurnedOnLengthMinMax;

		// Token: 0x0400CA21 RID: 51745
		[SerializeField]
		private Vector2 TurnedOffLengthMinMax;

		// Token: 0x0400CA22 RID: 51746
		[SerializeField]
		private float FadeInPower;

		// Token: 0x0400CA23 RID: 51747
		[SerializeField]
		private float FadeOutPower;

		// Token: 0x0400CA24 RID: 51748
		[SerializeField]
		[Space(32f)]
		private bool Blinking;

		// Token: 0x0400CA25 RID: 51749
		[SerializeField]
		private float BlinkingFreq;

		// Token: 0x0400CA26 RID: 51750
		[SerializeField]
		private float SingleBlinkLength;

		// Token: 0x0400CA27 RID: 51751
		[SerializeField]
		[Range(0f, 1f)]
		private float Randomness;

		// Token: 0x0400CA28 RID: 51752
		[Space(32f)]
		public float FlickeringFreq;

		// Token: 0x0400CA29 RID: 51753
		[SerializeField]
		private float TurningOnFlickering;

		// Token: 0x0400CA2A RID: 51754
		[SerializeField]
		private float TurningOffFlickering;

		// Token: 0x0400CA2B RID: 51755
		[SerializeField]
		private float TurnedOnFlickering;

		// Token: 0x0400CA2C RID: 51756
		[Header("Flick Audio")]
		[SerializeField]
		[Space(32f)]
		private AudioClip[] TurnOnClips;

		// Token: 0x0400CA2D RID: 51757
		[SerializeField]
		private float FlickHighTreshold;

		// Token: 0x0400CA2E RID: 51758
		[SerializeField]
		private float FlickLowTreshold;

		// Token: 0x0400CA2F RID: 51759
		[SerializeField]
		private Vector2 FlickVolume;

		// Token: 0x0400CA30 RID: 51760
		[SerializeField]
		[Header("Damage")]
		private string SparksEffect;

		// Token: 0x0400CA31 RID: 51761
		[SerializeField]
		private Vector2 SparksFreq;

		// Token: 0x0400CA32 RID: 51762
		[SerializeField]
		private string DestroyEffect;

		// Token: 0x0400CA33 RID: 51763
		[SerializeField]
		private float IntactTime;

		// Token: 0x0400CA34 RID: 51764
		[Range(0f, 1f)]
		[SerializeField]
		private float JointBreakProbability;

		// Token: 0x0400CA35 RID: 51765
		[SerializeField]
		private Transform SparksEmmiterTransform;

		// Token: 0x0400CA36 RID: 51766
		[SerializeField]
		private Transform DestroyEffectPivot;

		// Token: 0x0400CA37 RID: 51767
		[SerializeField]
		private Vector3 EffectDirection;

		// Token: 0x0400CA38 RID: 51768
		private int int_4;

		// Token: 0x0400CA39 RID: 51769
		private bool bool_0;

		// Token: 0x0400CA3A RID: 51770
		private bool bool_1;

		// Token: 0x0400CA3B RID: 51771
		private float float_1;

		// Token: 0x0400CA3C RID: 51772
		private float float_2;

		// Token: 0x0400CA3D RID: 51773
		private float float_3;

		// Token: 0x0400CA3E RID: 51774
		private float float_4;

		// Token: 0x0400CA3F RID: 51775
		private float float_5;

		// Token: 0x0400CA40 RID: 51776
		private float float_6;

		// Token: 0x0400CA41 RID: 51777
		private float float_7;

		// Token: 0x0400CA42 RID: 51778
		private LampController.Class2275 class2275_0;

		// Token: 0x0400CA43 RID: 51779
		private float float_8;

		// Token: 0x0400CA44 RID: 51780
		private float[] float_9;

		// Token: 0x0400CA45 RID: 51781
		private float[] float_10;

		// Token: 0x0400CA46 RID: 51782
		private Color[] color_0;

		// Token: 0x0400CA47 RID: 51783
		private Flicker[] flicker_0;

		// Token: 0x0400CA48 RID: 51784
		private List<CullingLightObject> list_0;

		// Token: 0x0400CA49 RID: 51785
		private List<CullingAdvancedLightObject> list_1;

		// Token: 0x0400CA4A RID: 51786
		private List<VolumetricLight> list_2;

		// Token: 0x0400CA4B RID: 51787
		private float float_11;

		// Token: 0x0400CA4C RID: 51788
		private float float_12;

		// Token: 0x0400CA4D RID: 51789
		private RigidbodySpawner rigidbodySpawner_0;

		// Token: 0x0400CA4E RID: 51790
		private ConfigurableJointSpawner configurableJointSpawner_0;

		// Token: 0x0400CA4F RID: 51791
		private Rigidbody rigidbody_0;

		// Token: 0x0400CA50 RID: 51792
		private bool bool_2;

		// Token: 0x0400CA51 RID: 51793
		private float float_13;

		// Token: 0x0400CA52 RID: 51794
		private float float_14;

		// Token: 0x0400CA53 RID: 51795
		private Turnable.EState estate_0;

		// Token: 0x0400CA54 RID: 51796
		private bool bool_3;

		// Token: 0x0400CA55 RID: 51797
		private bool bool_4;

		// Token: 0x0200276E RID: 10094
		private sealed class Class2275
		{
			// Token: 0x0600CA34 RID: 51764 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsBlink(float time, float bandWidth, float randomness)
			{
				throw null;
			}

			// Token: 0x0400CA56 RID: 51798
			private readonly int int_0;

			// Token: 0x0400CA57 RID: 51799
			private int int_1;

			// Token: 0x0400CA58 RID: 51800
			private float float_0;
		}

		// Token: 0x0200276F RID: 10095
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2276
		{
			// Token: 0x0600CA35 RID: 51765 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(MaterialEmission mat)
			{
				throw null;
			}

			// Token: 0x0400CA59 RID: 51801
			public static readonly LampController.Class2276 class2276_0;

			// Token: 0x0400CA5A RID: 51802
			public static Func<MaterialEmission, bool> func_0;
		}
	}
}
