using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020009DA RID: 2522
public class UISoundsWrapper : ScriptableObject
{
	// Token: 0x17000972 RID: 2418
	// (get) Token: 0x0600381A RID: 14362 RVA: 0x00002050 File Offset: 0x00000250
	public UISoundsWrapper.UIClipSounds LoadSounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000973 RID: 2419
	// (get) Token: 0x0600381B RID: 14363 RVA: 0x00002050 File Offset: 0x00000250
	public UISoundsWrapper.UIClipSounds UnloadSounds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600381C RID: 14364 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip GetSocialNetworkClip(ESocialNetworkSoundType soundType)
	{
		throw null;
	}

	// Token: 0x0600381D RID: 14365 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip GetUIClip(EUISoundType soundType)
	{
		throw null;
	}

	// Token: 0x0600381E RID: 14366 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioClip GetEndGameClip(EEndGameSoundType soundType)
	{
		throw null;
	}

	// Token: 0x0600381F RID: 14367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003820 RID: 14368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0<T>(UISoundsWrapper.SoundElement<T>[] clipList, Dictionary<T, AudioClip> clipsIndex)
	{
		throw null;
	}

	// Token: 0x040039DC RID: 14812
	[SerializeField]
	private UISoundsWrapper.UISound[] _UIAudioClips;

	// Token: 0x040039DD RID: 14813
	[SerializeField]
	private UISoundsWrapper.SotialNetworkSound[] _socialNetworkAudioClips;

	// Token: 0x040039DE RID: 14814
	[SerializeField]
	private UISoundsWrapper.EndGameSound[] _endGameAudioClips;

	// Token: 0x040039DF RID: 14815
	[SerializeField]
	private UISoundsWrapper.UIClipSounds _loadSounds;

	// Token: 0x040039E0 RID: 14816
	[SerializeField]
	private UISoundsWrapper.UIClipSounds _unloadSounds;

	// Token: 0x040039E1 RID: 14817
	private static readonly UISoundsWrapper.Class336 class336_0;

	// Token: 0x040039E2 RID: 14818
	private readonly Dictionary<EUISoundType, AudioClip> dictionary_0;

	// Token: 0x040039E3 RID: 14819
	private readonly Dictionary<ESocialNetworkSoundType, AudioClip> dictionary_1;

	// Token: 0x040039E4 RID: 14820
	private readonly Dictionary<EEndGameSoundType, AudioClip> dictionary_2;

	// Token: 0x020009DB RID: 2523
	[Serializable]
	public class UISound : UISoundsWrapper.SoundElement<EUISoundType>
	{
	}

	// Token: 0x020009DC RID: 2524
	[Serializable]
	public class SotialNetworkSound : UISoundsWrapper.SoundElement<ESocialNetworkSoundType>
	{
	}

	// Token: 0x020009DD RID: 2525
	[Serializable]
	public class EndGameSound : UISoundsWrapper.SoundElement<EEndGameSoundType>
	{
	}

	// Token: 0x020009DE RID: 2526
	[Serializable]
	public abstract class SoundElement<TSoundTypeEnum>
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x00002050 File Offset: 0x00000250
		public TSoundTypeEnum TSoundType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x00002050 File Offset: 0x00000250
		public AudioClip TSound
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040039E5 RID: 14821
		[SerializeField]
		private TSoundTypeEnum _soundType;

		// Token: 0x040039E6 RID: 14822
		[SerializeField]
		private AudioClip _sound;
	}

	// Token: 0x020009DF RID: 2527
	[Serializable]
	public class UIClipSounds
	{
		// Token: 0x06003823 RID: 14371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetRandomClip()
		{
			throw null;
		}

		// Token: 0x040039E7 RID: 14823
		[SerializeField]
		private AudioClip[] _audioClips;
	}

	// Token: 0x020009E0 RID: 2528
	private class Class336 : LoggerClass
	{
		// Token: 0x06003824 RID: 14372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogMissingSound(Enum soundType)
		{
			throw null;
		}
	}
}
