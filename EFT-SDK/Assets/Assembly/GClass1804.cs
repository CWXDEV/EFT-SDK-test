using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x020016AB RID: 5803
public class GClass1804
{
	// Token: 0x14000178 RID: 376
	// (add) Token: 0x06007D56 RID: 32086 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007D57 RID: 32087 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EPhraseTrigger, TaggedClip, TagBank, GClass1804> OnPhraseTold
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

	// Token: 0x14000179 RID: 377
	// (add) Token: 0x06007D58 RID: 32088 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06007D59 RID: 32089 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnRelease
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

	// Token: 0x170013B2 RID: 5042
	// (get) Token: 0x06007D5A RID: 32090 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007D5B RID: 32091 RVA: 0x00002050 File Offset: 0x00000250
	public int Id
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

	// Token: 0x170013B3 RID: 5043
	// (get) Token: 0x06007D5C RID: 32092 RVA: 0x00002050 File Offset: 0x00000250
	public int Importance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170013B4 RID: 5044
	// (get) Token: 0x06007D5D RID: 32093 RVA: 0x00002050 File Offset: 0x00000250
	public bool Busy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170013B5 RID: 5045
	// (get) Token: 0x06007D5E RID: 32094 RVA: 0x00002050 File Offset: 0x00000250
	public float TimeLeft
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170013B6 RID: 5046
	// (get) Token: 0x06007D5F RID: 32095 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06007D60 RID: 32096 RVA: 0x00002050 File Offset: 0x00000250
	public string PlayerVoice
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

	// Token: 0x06007D61 RID: 32097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Queue(EPhraseTrigger trigger, ETagStatus tags, float delay, bool demand)
	{
		throw null;
	}

	// Token: 0x06007D62 RID: 32098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shut()
	{
		throw null;
	}

	// Token: 0x06007D63 RID: 32099 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TagBank Play(EPhraseTrigger trigger, ETagStatus tags, bool demand = false, int? importance = null)
	{
		throw null;
	}

	// Token: 0x06007D64 RID: 32100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayDirect(EPhraseTrigger trigger, int index)
	{
		throw null;
	}

	// Token: 0x06007D65 RID: 32101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(EPlayerSide side, int id, string playerVoice, bool registerInSpeakerManager = true)
	{
		throw null;
	}

	// Token: 0x06007D66 RID: 32102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayDirectRandom(EPhraseTrigger trigger)
	{
		throw null;
	}

	// Token: 0x06007D67 RID: 32103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReplaceVoice(EPlayerSide side, string playerVoice)
	{
		throw null;
	}

	// Token: 0x06007D68 RID: 32104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float dt)
	{
		throw null;
	}

	// Token: 0x06007D69 RID: 32105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDestroy()
	{
		throw null;
	}

	// Token: 0x04008443 RID: 33859
	private const float float_0 = 0.1f;

	// Token: 0x04008444 RID: 33860
	private static readonly GClass1804.Class341 class341_0;

	// Token: 0x04008445 RID: 33861
	public readonly Dictionary<EPhraseTrigger, TagBank> PhrasesBanks;

	// Token: 0x04008446 RID: 33862
	public bool OnDemandOnly;

	// Token: 0x04008447 RID: 33863
	public float ReleaseTime;

	// Token: 0x04008448 RID: 33864
	public bool Speaking;

	// Token: 0x04008449 RID: 33865
	public EPhraseTrigger QueuedEvent;

	// Token: 0x0400844A RID: 33866
	public ETagStatus QueuedTags;

	// Token: 0x0400844B RID: 33867
	public ETagStatus SideTag;

	// Token: 0x0400844C RID: 33868
	public float QueuedDelay;

	// Token: 0x0400844D RID: 33869
	[CompilerGenerated]
	private Action<EPhraseTrigger, TaggedClip, TagBank, GClass1804> action_0;

	// Token: 0x0400844E RID: 33870
	[CompilerGenerated]
	private Action<bool> action_1;

	// Token: 0x0400844F RID: 33871
	public TaggedClip Clip;

	// Token: 0x04008450 RID: 33872
	public BifacialTransform TrackTransform;

	// Token: 0x04008451 RID: 33873
	private int int_0;

	// Token: 0x04008452 RID: 33874
	[CompilerGenerated]
	private int int_1;

	// Token: 0x04008453 RID: 33875
	[CompilerGenerated]
	private string string_0;

	// Token: 0x020016AC RID: 5804
	private sealed class Class341 : LoggerClass
	{
	}
}
