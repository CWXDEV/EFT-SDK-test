using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020016B3 RID: 5811
public class GClass1805
{
	// Token: 0x06007D7F RID: 32127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ETagStatus GetGroupStatus(GClass1804 speaker)
	{
		throw null;
	}

	// Token: 0x06007D80 RID: 32128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPhraseToldInGroup(EPhraseTrigger @event, TaggedClip clip, TagBank bankPlayed, GClass1804 speaker)
	{
		throw null;
	}

	// Token: 0x0400845D RID: 33885
	public string GroupId;

	// Token: 0x0400845E RID: 33886
	public List<Player> Members;

	// Token: 0x0400845F RID: 33887
	public List<Blocker> Blockers;

	// Token: 0x04008460 RID: 33888
	public Action<EPhraseTrigger, GClass1805, GClass1804> OnEvent;

	// Token: 0x020016B4 RID: 5812
	[CompilerGenerated]
	private sealed class Class1198
	{
		// Token: 0x06007D81 RID: 32129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Player member)
		{
			throw null;
		}

		// Token: 0x04008461 RID: 33889
		public GClass1804 speaker;
	}
}
