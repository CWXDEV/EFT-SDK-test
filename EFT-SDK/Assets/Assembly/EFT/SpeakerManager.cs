using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016AF RID: 5807
	public class SpeakerManager : MonoBehaviour
	{
		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007D6F RID: 32111 RVA: 0x00002050 File Offset: 0x00000250
		public List<GClass1804> Speakers
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

		// Token: 0x06007D70 RID: 32112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddSpeaker(GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveSpeaker(GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(float dt)
		{
			throw null;
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1804 GetSpeaker(int id)
		{
			throw null;
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ETagStatus GetGroupStatus(GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FreeToSpeak(EPhraseTrigger trigger, int id)
		{
			throw null;
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromGroup(Player player)
		{
			throw null;
		}

		// Token: 0x06007D77 RID: 32119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass1805 AddNewGroup(string groupId)
		{
			throw null;
		}

		// Token: 0x06007D78 RID: 32120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssignToGroup(EPlayerSide side, Player player)
		{
			throw null;
		}

		// Token: 0x06007D79 RID: 32121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EPhraseTrigger trigger, TaggedClip clip, TagBank bank, GClass1804 speaker)
		{
			throw null;
		}

		// Token: 0x06007D7A RID: 32122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(int id1, int id2)
		{
			throw null;
		}

		// Token: 0x06007D7B RID: 32123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GroupEvent(int speakerId, EPhraseTrigger @event, Vector3 position, ETagStatus tags, int probability = 50)
		{
			throw null;
		}

		// Token: 0x04008456 RID: 33878
		private List<GClass1805> list_0;

		// Token: 0x04008457 RID: 33879
		[CompilerGenerated]
		private List<GClass1804> list_1;

		// Token: 0x04008458 RID: 33880
		private Dictionary<int, GClass1805> dictionary_0;

		// Token: 0x04008459 RID: 33881
		public GClass1804 ClientSpeaker;

		// Token: 0x020016B0 RID: 5808
		[CompilerGenerated]
		private sealed class Class1195
		{
			// Token: 0x06007D7C RID: 32124 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1804 s)
			{
				throw null;
			}

			// Token: 0x0400845A RID: 33882
			public int id;
		}

		// Token: 0x020016B1 RID: 5809
		[CompilerGenerated]
		private sealed class Class1196
		{
			// Token: 0x06007D7D RID: 32125 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1805 g)
			{
				throw null;
			}

			// Token: 0x0400845B RID: 33883
			public Player player;
		}

		// Token: 0x020016B2 RID: 5810
		[CompilerGenerated]
		private sealed class Class1197
		{
			// Token: 0x06007D7E RID: 32126 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1805 x)
			{
				throw null;
			}

			// Token: 0x0400845C RID: 33884
			public string groupId;
		}
	}
}
