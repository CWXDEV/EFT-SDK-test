using System;
using System.Runtime.CompilerServices;
using Dissonance;
using UnityEngine;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02002047 RID: 8263
	public class ObservedPlayerVoIP : MonoBehaviour, IDissonancePlayer
	{
		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x0600ABC2 RID: 43970 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABC3 RID: 43971 RVA: 0x00002050 File Offset: 0x00000250
		public AudioSource VoipAudioSource
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

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x00002050 File Offset: 0x00000250
		public string PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600ABC5 RID: 43973 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x0600ABC7 RID: 43975 RVA: 0x00002050 File Offset: 0x00000250
		public NetworkPlayerType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsTracking
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x0600ABC9 RID: 43977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABCA RID: 43978 RVA: 0x00002050 File Offset: 0x00000250
		public BetterSource VoipEftSource
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

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600ABCB RID: 43979 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABCC RID: 43980 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayerVoipController VoipController
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

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x0600ABCD RID: 43981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABCE RID: 43982 RVA: 0x00002050 File Offset: 0x00000250
		private DissonanceComms DissonanceComms_0
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

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x0600ABCF RID: 43983 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABD0 RID: 43984 RVA: 0x00002050 File Offset: 0x00000250
		private Player.EVoipState EVoipState_0
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

		// Token: 0x14000231 RID: 561
		// (add) Token: 0x0600ABD1 RID: 43985 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600ABD2 RID: 43986 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<AudioSource> OnVoipSourceCreated
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

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitVoip(ObservedPlayerView player, Player.EVoipState voipState)
		{
			throw null;
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueTuple<bool, bool> IsHeard(in Vector3 voicePos, float sqrDistance)
		{
			throw null;
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(GInterface218 command)
		{
			throw null;
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass2257 voIPCommandMessage)
		{
			throw null;
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Player.EVoipState voipState)
		{
			throw null;
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600ABDB RID: 43995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600ABDC RID: 43996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(AudioSource source)
		{
			throw null;
		}

		// Token: 0x0600ABDD RID: 43997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5(in Vector3 voicePos, float sqrDistance)
		{
			throw null;
		}

		// Token: 0x0600ABDE RID: 43998 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(int value)
		{
			throw null;
		}

		// Token: 0x0400B25F RID: 45663
		private AudioSource audioSource_0;

		// Token: 0x0400B260 RID: 45664
		[CompilerGenerated]
		private BetterSource betterSource_0;

		// Token: 0x0400B261 RID: 45665
		[CompilerGenerated]
		private IPlayerVoipController iplayerVoipController_0;

		// Token: 0x0400B262 RID: 45666
		private ObservedPlayerView observedPlayerView_0;

		// Token: 0x0400B263 RID: 45667
		private VoiceBroadcastTrigger voiceBroadcastTrigger_0;

		// Token: 0x0400B264 RID: 45668
		private GClass953 gclass953_0;

		// Token: 0x0400B265 RID: 45669
		private readonly GClass763 gclass763_0;

		// Token: 0x0400B266 RID: 45670
		[CompilerGenerated]
		private DissonanceComms dissonanceComms_0;

		// Token: 0x0400B267 RID: 45671
		[CompilerGenerated]
		private Player.EVoipState evoipState_0;

		// Token: 0x0400B268 RID: 45672
		private bool bool_0;

		// Token: 0x0400B269 RID: 45673
		private bool bool_1;

		// Token: 0x0400B26A RID: 45674
		[CompilerGenerated]
		private Action<AudioSource> action_0;

		// Token: 0x02002048 RID: 8264
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1859
		{
			// Token: 0x0600ABDF RID: 43999 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(AudioSource source)
			{
				throw null;
			}

			// Token: 0x0400B26B RID: 45675
			public static readonly ObservedPlayerVoIP.Class1859 class1859_0;

			// Token: 0x0400B26C RID: 45676
			public static Action<AudioSource> action_0;
		}
	}
}
