using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Audio.SpatialSystem;
using DG.Tweening;
using EFT;
using EFT.Interactive;
using EFT.ItemGameSounds;
using JetBrains.Annotations;
using JsonType;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x0200088F RID: 2191
public sealed class BetterAudio : MonoBehaviourSingleton<BetterAudio>
{
	// Token: 0x06003145 RID: 12613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCompressor(GClass2538 template)
	{
		throw null;
	}

	// Token: 0x14000098 RID: 152
	// (add) Token: 0x06003146 RID: 12614 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06003147 RID: 12615 RVA: 0x00002050 File Offset: 0x00000250
	public event Action AudioControllerInitialized
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

	// Token: 0x1700087F RID: 2175
	// (get) Token: 0x06003148 RID: 12616 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003149 RID: 12617 RVA: 0x00002050 File Offset: 0x00000250
	public AudioListener AudioListener
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

	// Token: 0x17000880 RID: 2176
	// (get) Token: 0x0600314A RID: 12618 RVA: 0x00002050 File Offset: 0x00000250
	public float ProtagonistHearing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000099 RID: 153
	// (add) Token: 0x0600314B RID: 12619 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600314C RID: 12620 RVA: 0x00002050 File Offset: 0x00000250
	public event Action ProtagonistHearingChanged
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

	// Token: 0x1400009A RID: 154
	// (add) Token: 0x0600314D RID: 12621 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600314E RID: 12622 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> ListenerSpawned
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

	// Token: 0x17000881 RID: 2177
	// (set) Token: 0x0600314F RID: 12623 RVA: 0x00002050 File Offset: 0x00000250
	private int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000882 RID: 2178
	// (get) Token: 0x06003150 RID: 12624 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003151 RID: 12625 RVA: 0x00002050 File Offset: 0x00000250
	public GClass990 AudioMixerData
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

	// Token: 0x17000883 RID: 2179
	// (get) Token: 0x06003152 RID: 12626 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003153 RID: 12627 RVA: 0x00002050 File Offset: 0x00000250
	public bool UseNewOcclusionSystem
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

	// Token: 0x17000884 RID: 2180
	// (get) Token: 0x06003154 RID: 12628 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003155 RID: 12629 RVA: 0x00002050 File Offset: 0x00000250
	public Player ListenerPlayer
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

	// Token: 0x06003156 RID: 12630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Awake()
	{
		throw null;
	}

	// Token: 0x06003157 RID: 12631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06003158 RID: 12632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003159 RID: 12633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Preload()
	{
		throw null;
	}

	// Token: 0x0600315A RID: 12634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task PreloadCoroutine()
	{
		throw null;
	}

	// Token: 0x0600315B RID: 12635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600315C RID: 12636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600315D RID: 12637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600315E RID: 12638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600315F RID: 12639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static AudioGroupPreset smethod_0(string groupName)
	{
		throw null;
	}

	// Token: 0x06003160 RID: 12640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06003161 RID: 12641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06003162 RID: 12642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BetterAudio.GInterface30 method_6<T>(AudioMixerGroup mixerGroup, GameObject steamPrefab, GameObject origPrefab, AudioGroupPreset preset) where T : BetterSource
	{
		throw null;
	}

	// Token: 0x06003163 RID: 12643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioMixerGroup FindMixerGroup(string groupName)
	{
		throw null;
	}

	// Token: 0x06003164 RID: 12644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableAllSpatialization(bool val)
	{
		throw null;
	}

	// Token: 0x06003165 RID: 12645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableAllBinaural(bool val)
	{
		throw null;
	}

	// Token: 0x06003166 RID: 12646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadSoundBundles()
	{
		throw null;
	}

	// Token: 0x06003167 RID: 12647 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProtagonist(Player player)
	{
		throw null;
	}

	// Token: 0x06003168 RID: 12648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnsubscribeProtagonist()
	{
		throw null;
	}

	// Token: 0x06003169 RID: 12649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InvokeProtagonistAction()
	{
		throw null;
	}

	// Token: 0x0600316A RID: 12650 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass789 BorrowWeaponAudioQueue(BetterAudio.AudioSourceGroupType groupType)
	{
		throw null;
	}

	// Token: 0x0600316B RID: 12651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseQueue(GClass787 queue)
	{
		throw null;
	}

	// Token: 0x0600316C RID: 12652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseQueueDelayed(GClass787 queue, float delay)
	{
		throw null;
	}

	// Token: 0x0600316D RID: 12653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_7(GClass787 queue, float delay)
	{
		throw null;
	}

	// Token: 0x0600316E RID: 12654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransitToEnvironment(EnvironmentType environment)
	{
		throw null;
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransitToEnvironment(EnvironmentType environment, float transitionTime)
	{
		throw null;
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterVolume(BetterPropagationVolume volume)
	{
		throw null;
	}

	// Token: 0x06003171 RID: 12657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveVolume(BetterPropagationVolume volume)
	{
		throw null;
	}

	// Token: 0x06003172 RID: 12658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterGroup(BetterPropagationGroups group)
	{
		throw null;
	}

	// Token: 0x06003173 RID: 12659 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("погнали ёбанарот")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterAllVolumes()
	{
		throw null;
	}

	// Token: 0x06003174 RID: 12660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BetterPropagationVolume> GetVolumesByPosition(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06003175 RID: 12661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterPropagationVolume GetVolumeByPosition(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06003176 RID: 12662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BetterPropagationVolume> GetAdjustedAndIsolatedVolumes(Vector3 position, List<BetterPropagationVolume> volumesBuffer)
	{
		throw null;
	}

	// Token: 0x06003177 RID: 12663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSourcesInDifferentVolume(Vector3 firstSourcePos, Vector3 secondSourcePos)
	{
		throw null;
	}

	// Token: 0x06003178 RID: 12664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTinnitusEffect(float time, AudioClip clip = null)
	{
		throw null;
	}

	// Token: 0x06003179 RID: 12665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TogglePauseTinnitusEffect(bool pause)
	{
		throw null;
	}

	// Token: 0x0600317A RID: 12666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_8(AudioClip clip)
	{
		throw null;
	}

	// Token: 0x0600317B RID: 12667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioMixerGroup GetOcclusionGroupSimple(Vector3 soundPosition, float distance = 0f)
	{
		throw null;
	}

	// Token: 0x0600317C RID: 12668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioMixerGroup GetOcclusionGroupSimple(Vector3 soundPosition, ref float volume, float distance = 0f)
	{
		throw null;
	}

	// Token: 0x0600317D RID: 12669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayNonspatial(AudioClip clip, BetterAudio.AudioSourceGroupType sourceGroup, float panStereo = 0f, float volume = 1f)
	{
		throw null;
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterSource PlayAtPoint(Vector3 position, AudioClip clip, float distance, BetterAudio.AudioSourceGroupType sourceGroup, int rolloff, float volume = 1f, EOcclusionTest occlusionTest = EOcclusionTest.None, AudioMixerGroup forceMixerGroup = null, bool forceStereo = false)
	{
		throw null;
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterSource PlayAtPoint(Vector3 position, SoundBank bank, int outputGroup, float distance, float volume = 1f, float bankBlendValue = -1f, EnvironmentType env = EnvironmentType.Outdoor, EOcclusionTest occlusionTest = EOcclusionTest.None, Player sourcePlayer = null)
	{
		throw null;
	}

	// Token: 0x06003180 RID: 12672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayAtPoint(Vector3 position, SoundBank bank, float distance, float volume = 1f, float bankBlendValue = -1f, EnvironmentType env = EnvironmentType.Outdoor, EOcclusionTest occlusionTest = EOcclusionTest.None)
	{
		throw null;
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayAtPointDistant(Vector3 position, SoundBank bank, float distance, float volume = 1f, float spatialBlend = 1f, EnvironmentType env = EnvironmentType.Outdoor, EOcclusionTest occlusionTest = EOcclusionTest.None, AudioMixerGroup forceGroup = null)
	{
		throw null;
	}

	// Token: 0x06003182 RID: 12674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LimitedPlay(Vector3 position, SoundBank bank, float distance, Vector3 gagRadius, float chokeTime, float volume = 1f, float bankBlendValue = -1f, EnvironmentType env = EnvironmentType.Outdoor, EOcclusionTest occlusionTest = EOcclusionTest.None, string key = "")
	{
		throw null;
	}

	// Token: 0x06003183 RID: 12675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayDropItem(BaseBallistic.ESurfaceSound surfaceSound, EItemDropSoundType dropSoundType, Vector3 position, float energy)
	{
		throw null;
	}

	// Token: 0x06003184 RID: 12676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayDropItem(SoundBank bank, Vector3 position, float energy)
	{
		throw null;
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrecacheGag(string key)
	{
		throw null;
	}

	// Token: 0x06003186 RID: 12678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetGroupPreset(BetterAudio.AudioSourceGroupType groupType, out AudioGroupPreset preset)
	{
		throw null;
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T CreateBetterSource<T>(AudioSource parentSource, BetterAudio.AudioSourceGroupType groupType) where T : BetterSource
	{
		throw null;
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterSource GetSource(SoundBank bank, bool activateSource = true)
	{
		throw null;
	}

	// Token: 0x0600318A RID: 12682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToAudioSourceQueue(GClass836.GInterface37 queueItem, float endTime)
	{
		throw null;
	}

	// Token: 0x0600318B RID: 12683 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BetterSource GetSource(BetterAudio.AudioSourceGroupType sourceType, bool activateSource = true)
	{
		throw null;
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeMixerVolume(string mixerKey, float endValDb, float seconds, bool force = false)
	{
		throw null;
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeInVolumeBeforeRaid(float seconds)
	{
		throw null;
	}

	// Token: 0x0600318E RID: 12686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FadeOutVolumeAfterRaid()
	{
		throw null;
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceSetCommonVolume(float valDb)
	{
		throw null;
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AudioMixerSnapshot method_9(string x)
	{
		throw null;
	}

	// Token: 0x0400327C RID: 12924
	public static GClass2538 LowMute;

	// Token: 0x0400327D RID: 12925
	public static GClass2538 StrongMute;

	// Token: 0x0400327E RID: 12926
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400327F RID: 12927
	public const float TRANSITION_TIME = 0.25f;

	// Token: 0x04003280 RID: 12928
	public const float SOUND_SPEED = 340f;

	// Token: 0x04003281 RID: 12929
	[CompilerGenerated]
	private AudioListener audioListener_0;

	// Token: 0x04003282 RID: 12930
	public WeaponSounds MiscCollisionSounds;

	// Token: 0x04003283 RID: 12931
	public ItemDropSounds ItemDropSounds;

	// Token: 0x04003284 RID: 12932
	private SkillManager.GClass1771 gclass1771_0;

	// Token: 0x04003285 RID: 12933
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x04003286 RID: 12934
	[CompilerGenerated]
	private Action<Player> action_2;

	// Token: 0x04003287 RID: 12935
	private GClass1765 gclass1765_0;

	// Token: 0x04003288 RID: 12936
	private float float_0;

	// Token: 0x04003289 RID: 12937
	private GameObject gameObject_0;

	// Token: 0x0400328A RID: 12938
	private GameObject gameObject_1;

	// Token: 0x0400328B RID: 12939
	private GameObject gameObject_2;

	// Token: 0x0400328C RID: 12940
	private GameObject gameObject_3;

	// Token: 0x0400328D RID: 12941
	private Coroutine coroutine_0;

	// Token: 0x0400328E RID: 12942
	private bool bool_0;

	// Token: 0x0400328F RID: 12943
	private Action action_3;

	// Token: 0x04003290 RID: 12944
	private readonly GClass836 gclass836_0;

	// Token: 0x04003291 RID: 12945
	private int int_0;

	// Token: 0x04003292 RID: 12946
	public BetterAudio.GInterface30[] SourceGroups;

	// Token: 0x04003293 RID: 12947
	public AudioMixer Master;

	// Token: 0x04003294 RID: 12948
	public AudioMixerSnapshot[] Snapshots;

	// Token: 0x04003295 RID: 12949
	public AudioMixerGroup MasterMixerGroup;

	// Token: 0x04003296 RID: 12950
	public AudioMixerGroup GunshotOccludedMixerGroup;

	// Token: 0x04003297 RID: 12951
	public AudioMixerGroup SimpleOccludedMixerGroup;

	// Token: 0x04003298 RID: 12952
	public AudioMixerGroup MutedGroup;

	// Token: 0x04003299 RID: 12953
	public AudioMixerGroup UpperOccluded;

	// Token: 0x0400329A RID: 12954
	public AudioMixerGroup LowerOccluded;

	// Token: 0x0400329B RID: 12955
	public AudioMixerGroup GunshotMixerGroup;

	// Token: 0x0400329C RID: 12956
	public AudioMixerGroup VeryStandartMixerGroup;

	// Token: 0x0400329D RID: 12957
	public AudioMixerGroup SelfSpeechReverb;

	// Token: 0x0400329E RID: 12958
	public AudioMixerGroup OutEnvironment;

	// Token: 0x0400329F RID: 12959
	public AudioMixerGroup VoipMixer;

	// Token: 0x040032A0 RID: 12960
	public AudioMixerGroup NonSpatialBypassMixer;

	// Token: 0x040032A1 RID: 12961
	public AudioMixerGroup VehicleInSpeechMixer;

	// Token: 0x040032A2 RID: 12962
	private float float_1;

	// Token: 0x040032A3 RID: 12963
	private float float_2;

	// Token: 0x040032A4 RID: 12964
	private float float_3;

	// Token: 0x040032A5 RID: 12965
	public int OcclusionMask;

	// Token: 0x040032A6 RID: 12966
	public int OcclusionHighPolyMask;

	// Token: 0x040032A7 RID: 12967
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x040032A8 RID: 12968
	private readonly List<GClass787> list_0;

	// Token: 0x040032A9 RID: 12969
	private readonly GClass831<GClass789> gclass831_0;

	// Token: 0x040032AA RID: 12970
	private static readonly Dictionary<BetterAudio.AudioSourceGroupType, AudioGroupPreset> dictionary_0;

	// Token: 0x040032AB RID: 12971
	private static Tweener tweener_0;

	// Token: 0x040032AC RID: 12972
	private Action action_4;

	// Token: 0x040032AD RID: 12973
	private RaycastHit raycastHit_0;

	// Token: 0x040032AE RID: 12974
	[CompilerGenerated]
	private GClass990 gclass990_0;

	// Token: 0x040032AF RID: 12975
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040032B0 RID: 12976
	[CompilerGenerated]
	private Player player_0;

	// Token: 0x040032B1 RID: 12977
	public Dictionary<string, List<BetterAudio.GClass784>> Gags;

	// Token: 0x040032B2 RID: 12978
	private GClass831<BetterAudio.GClass784> gclass831_1;

	// Token: 0x02000890 RID: 2192
	public enum AudioSourceGroupType
	{
		// Token: 0x040032B4 RID: 12980
		Gunshots,
		// Token: 0x040032B5 RID: 12981
		Weaponry,
		// Token: 0x040032B6 RID: 12982
		Impacts,
		// Token: 0x040032B7 RID: 12983
		Character,
		// Token: 0x040032B8 RID: 12984
		Environment,
		// Token: 0x040032B9 RID: 12985
		Collisions,
		// Token: 0x040032BA RID: 12986
		Speech,
		// Token: 0x040032BB RID: 12987
		Distant,
		// Token: 0x040032BC RID: 12988
		NonspatialBypass,
		// Token: 0x040032BD RID: 12989
		Nonspatial,
		// Token: 0x040032BE RID: 12990
		Voip,
		// Token: 0x040032BF RID: 12991
		Grenades,
		// Token: 0x040032C0 RID: 12992
		Windows,
		// Token: 0x040032C1 RID: 12993
		VehicleInSpeech
	}

	// Token: 0x02000891 RID: 2193
	public class GClass784
	{
		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsChoked(Vector3 newPosition, Vector3 listener, float distance)
		{
			throw null;
		}

		// Token: 0x040032C2 RID: 12994
		private const float float_0 = 5f;

		// Token: 0x040032C3 RID: 12995
		private const float float_1 = 0.2f;

		// Token: 0x040032C4 RID: 12996
		public Vector3 Position;

		// Token: 0x040032C5 RID: 12997
		public Vector2 Radius;

		// Token: 0x040032C6 RID: 12998
		public float EndTime;

		// Token: 0x040032C7 RID: 12999
		public float Rolloff;
	}

	// Token: 0x02000892 RID: 2194
	public interface GInterface30
	{
		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003194 RID: 12692
		AudioGroupPreset Preset { get; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003195 RID: 12693
		float DeltaPitch { get; }

		// Token: 0x06003196 RID: 12694
		[CanBeNull]
		BetterSource BorrowSource(bool activateSource = true);

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06003197 RID: 12695
		// (set) Token: 0x06003198 RID: 12696
		AudioMixerGroup MixerGroup { get; set; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06003199 RID: 12697
		string DebugName { get; }

		// Token: 0x0600319A RID: 12698
		void RefreshSourceSettings();

		// Token: 0x0600319B RID: 12699
		void SetSpatialize(bool val);

		// Token: 0x0600319C RID: 12700
		void ForceChangePreset(SpatialAudioSettings preset);
	}

	// Token: 0x02000893 RID: 2195
	public class GClass785<T> : BetterAudio.GInterface30, BetterSource.GInterface31 where T : BetterSource
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x00002050 File Offset: 0x00000250
		public float DeltaPitch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x00002050 File Offset: 0x00000250
		public AudioGroupPreset Preset
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x00002050 File Offset: 0x00000250
		public AudioMixerGroup MixerGroup
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x00002050 File Offset: 0x00000250
		public string DebugName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BetterSource BorrowSource(bool activateSource = true)
		{
			throw null;
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release(BetterSource source)
		{
			throw null;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshSourceSettings()
		{
			throw null;
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpatialize(bool val)
		{
			throw null;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceChangePreset(SpatialAudioSettings preset)
		{
			throw null;
		}

		// Token: 0x040032C8 RID: 13000
		private T gparam_0;

		// Token: 0x040032C9 RID: 13001
		[CompilerGenerated]
		private AudioGroupPreset audioGroupPreset_0;

		// Token: 0x040032CA RID: 13002
		[CompilerGenerated]
		private AudioMixerGroup audioMixerGroup_0;
	}

	// Token: 0x02000894 RID: 2196
	public class GClass786<T> : BetterAudio.GInterface30, BetterSource.GInterface31 where T : BetterSource
	{
		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x00002050 File Offset: 0x00000250
		public AudioGroupPreset Preset
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x00002050 File Offset: 0x00000250
		public float DeltaPitch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x00002050 File Offset: 0x00000250
		public AudioMixerGroup MixerGroup
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

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x00002050 File Offset: 0x00000250
		public string DebugName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x00002050 File Offset: 0x00000250
		protected float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual T InstantiateNewSource(bool spatialization = false)
		{
			throw null;
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BetterSource BorrowSource(bool activateSource = true)
		{
			throw null;
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RefreshSourceSettings()
		{
			throw null;
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ForceChangePreset(SpatialAudioSettings preset)
		{
			throw null;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSpatialize(bool val)
		{
			throw null;
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Release(BetterSource source)
		{
			throw null;
		}

		// Token: 0x040032CB RID: 13003
		protected Stack<T> stack_0;

		// Token: 0x040032CC RID: 13004
		private int int_0;

		// Token: 0x040032CD RID: 13005
		private GameObject gameObject_0;

		// Token: 0x040032CE RID: 13006
		[CompilerGenerated]
		private AudioGroupPreset audioGroupPreset_0;

		// Token: 0x040032CF RID: 13007
		[CompilerGenerated]
		private AudioMixerGroup audioMixerGroup_0;
	}

	// Token: 0x02000895 RID: 2197
	private sealed class Class448<T> : BetterAudio.GClass786<T> where T : BetterSource
	{
		// Token: 0x060031B5 RID: 12725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override T InstantiateNewSource(bool spatialization = false)
		{
			throw null;
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void RefreshSourceSettings()
		{
			throw null;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ForceChangePreset(SpatialAudioSettings preset)
		{
			throw null;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetSpatialize(bool val)
		{
			throw null;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(BaseSpatialAudioSource spatialAudioSource, AudioSource audioSource)
		{
			throw null;
		}

		// Token: 0x040032D0 RID: 13008
		private readonly List<BaseSpatialAudioSource> list_0;
	}

	// Token: 0x0200089A RID: 2202
	[CompilerGenerated]
	private sealed class Class451
	{
		// Token: 0x060031C6 RID: 12742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(float x)
		{
			throw null;
		}

		// Token: 0x040032E9 RID: 13033
		public BetterAudio betterAudio_0;

		// Token: 0x040032EA RID: 13034
		public string mixerKey;
	}

	// Token: 0x0200089B RID: 2203
	[CompilerGenerated]
	[Serializable]
	private sealed class Class452
	{
		// Token: 0x060031C8 RID: 12744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(Player player)
		{
			throw null;
		}

		// Token: 0x040032EB RID: 13035
		public static readonly BetterAudio.Class452 class452_0;

		// Token: 0x040032EC RID: 13036
		public static Action action_0;

		// Token: 0x040032ED RID: 13037
		public static Action<Player> action_1;
	}
}
