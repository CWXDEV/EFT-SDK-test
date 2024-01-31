using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio.AudioWeatherSystem;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.EnvironmentEffect
{
	// Token: 0x020026C6 RID: 9926
	public class EnvironmentManager : EnvironmentManagerBase
	{
		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0600C4B6 RID: 50358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C4B7 RID: 50359 RVA: 0x00002050 File Offset: 0x00000250
		public EnvironmentType Environment
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

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600C4B8 RID: 50360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C4B9 RID: 50361 RVA: 0x00002050 File Offset: 0x00000250
		public bool InBunker
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

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600C4BA RID: 50362 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C4BB RID: 50363 RVA: 0x00002050 File Offset: 0x00000250
		public float PrismExposureSpeed
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

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x0600C4BC RID: 50364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C4BD RID: 50365 RVA: 0x00002050 File Offset: 0x00000250
		public float PrismExposureOffset
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

		// Token: 0x140002C8 RID: 712
		// (add) Token: 0x0600C4BE RID: 50366 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C4BF RID: 50367 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<string, EnvironmentType> OnPlayerEnvironmentChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x0600C4C0 RID: 50368 RVA: 0x00002050 File Offset: 0x00000250
		public new static EnvironmentManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600C4C1 RID: 50369 RVA: 0x00002050 File Offset: 0x00000250
		private RainController.ERainIntensity ERainIntensity_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600C4C3 RID: 50371 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Init()
		{
			throw null;
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnvironmentType GetPlayerCurrentEnvironmentType(string profileID)
		{
			throw null;
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnvironmentType GetEnvironmentByPos(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateEnvironmentForPlayer(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPlayerAndTargetInDifferentEnvironments(Vector3 sourcePos)
		{
			throw null;
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsPlayerAndTargetOutdoor(Vector3 targetPos)
		{
			throw null;
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetTriggerForPlayer(IPlayer player, IndoorTrigger trigger)
		{
			throw null;
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndoorTrigger TryFindTriggerByPos(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2()
		{
			throw null;
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3()
		{
			throw null;
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_5(float speed, float bunkerDepth = -15f, float bunkerLowPass = 300f)
		{
			throw null;
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_6(float speed)
		{
			throw null;
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_7()
		{
			throw null;
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(AudioSource source, bool isActive)
		{
			throw null;
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(Class419 controller)
		{
			throw null;
		}

		// Token: 0x0600C4D7 RID: 50391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(EWinterStatus status)
		{
			throw null;
		}

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(EWinterStatus status)
		{
			throw null;
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_14()
		{
			throw null;
		}

		// Token: 0x0600C4DA RID: 50394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_15(int clipIndex, out AudioClip clip)
		{
			throw null;
		}

		// Token: 0x0600C4DB RID: 50395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_16()
		{
			throw null;
		}

		// Token: 0x0600C4DC RID: 50396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400C65E RID: 50782
		private const float float_0 = 0.025f;

		// Token: 0x0400C65F RID: 50783
		[SerializeField]
		[Space]
		private AudioSource OutdoorSource;

		// Token: 0x0400C660 RID: 50784
		[SerializeField]
		private AudioSource OutdoorMixSource;

		// Token: 0x0400C661 RID: 50785
		[SerializeField]
		private AudioSource BunkerSource;

		// Token: 0x0400C662 RID: 50786
		[SerializeField]
		private AudioSource IndoorSource;

		// Token: 0x0400C663 RID: 50787
		[Header("Rain")]
		[SerializeField]
		private AudioSource Rain1;

		// Token: 0x0400C664 RID: 50788
		[SerializeField]
		private AudioSource Rain2;

		// Token: 0x0400C665 RID: 50789
		[SerializeField]
		private AudioClip[] OutdoorRainClips;

		// Token: 0x0400C666 RID: 50790
		[SerializeField]
		private AudioClip[] IndoorRainClips;

		// Token: 0x0400C667 RID: 50791
		[SerializeField]
		private float NightBlendStart;

		// Token: 0x0400C668 RID: 50792
		[SerializeField]
		private float NightBlendEnd;

		// Token: 0x0400C669 RID: 50793
		[Header("Winter")]
		[SerializeField]
		private AudioClip[] OutdoorSnowClips;

		// Token: 0x0400C66A RID: 50794
		[SerializeField]
		private AudioClip[] IndoorSnowClips;

		// Token: 0x0400C66B RID: 50795
		[SerializeField]
		private AudioClip[] OutdoorWinterStormClips;

		// Token: 0x0400C66C RID: 50796
		[SerializeField]
		private AudioClip[] IndoorWinterStormClips;

		// Token: 0x0400C66D RID: 50797
		[SerializeField]
		private WeatherAmbientContainer _weatherAmbientContainer;

		// Token: 0x0400C66E RID: 50798
		[SerializeField]
		private SeasonLocalAmbientSoundMuter _localAmbientSoundMuter;

		// Token: 0x0400C66F RID: 50799
		[Header("Outdoor")]
		[SerializeField]
		private float OutdoorFadeTime;

		// Token: 0x0400C670 RID: 50800
		[SerializeField]
		private float OutdoorExposureSpeed;

		// Token: 0x0400C671 RID: 50801
		[SerializeField]
		private float OutdoorExposureOffset;

		// Token: 0x0400C672 RID: 50802
		[SerializeField]
		private float OutdoorRainVolume;

		// Token: 0x0400C673 RID: 50803
		[Header("Long Shadow Reduising")]
		public bool EnableLongShadowsCorrection;

		// Token: 0x0400C674 RID: 50804
		private Vector2 ShadowInterval1;

		// Token: 0x0400C675 RID: 50805
		private Vector2 ShadowInterval2;

		// Token: 0x0400C676 RID: 50806
		[SerializeField]
		private float ShadowDecreaseFactor;

		// Token: 0x0400C677 RID: 50807
		[SerializeField]
		private float ShadowMinDistance;

		// Token: 0x0400C678 RID: 50808
		[CompilerGenerated]
		private EnvironmentType environmentType_0;

		// Token: 0x0400C679 RID: 50809
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400C67A RID: 50810
		[CompilerGenerated]
		private float float_1;

		// Token: 0x0400C67B RID: 50811
		[CompilerGenerated]
		private float float_2;

		// Token: 0x0400C67C RID: 50812
		[CompilerGenerated]
		private Action<string, EnvironmentType> action_0;

		// Token: 0x0400C67D RID: 50813
		private AudioSource audioSource_0;

		// Token: 0x0400C67E RID: 50814
		private RainController.ERainIntensity erainIntensity_0;

		// Token: 0x0400C67F RID: 50815
		private float float_3;

		// Token: 0x0400C680 RID: 50816
		private float float_4;

		// Token: 0x0400C681 RID: 50817
		private float float_5;

		// Token: 0x0400C682 RID: 50818
		private float float_6;

		// Token: 0x0400C683 RID: 50819
		private float float_7;

		// Token: 0x0400C684 RID: 50820
		private Coroutine coroutine_0;

		// Token: 0x0400C685 RID: 50821
		private Coroutine coroutine_1;

		// Token: 0x0400C686 RID: 50822
		private Coroutine coroutine_2;

		// Token: 0x0400C687 RID: 50823
		private Coroutine coroutine_3;

		// Token: 0x0400C688 RID: 50824
		private float float_8;

		// Token: 0x0400C689 RID: 50825
		private Dictionary<string, EnvironmentType> dictionary_0;

		// Token: 0x0400C68A RID: 50826
		private EWinterStatus ewinterStatus_0;

		// Token: 0x0400C68B RID: 50827
		private float float_9;

		// Token: 0x0400C68C RID: 50828
		private float float_10;

		// Token: 0x0400C68D RID: 50829
		private float float_11;

		// Token: 0x0400C68E RID: 50830
		private ThermalVision thermalVision_0;

		// Token: 0x0400C68F RID: 50831
		private int int_0;
	}
}
