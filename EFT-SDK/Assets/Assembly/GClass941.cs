using System;
using System.Runtime.CompilerServices;
using ChatShared;
using Diz.Binding;

// Token: 0x02000CEE RID: 3310
public class GClass941 : IUpdatable<GClass941>
{
	// Token: 0x060046A8 RID: 18088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Compare(GClass941 other)
	{
		throw null;
	}

	// Token: 0x060046A9 RID: 18089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateFromAnotherItem(GClass941 other)
	{
		throw null;
	}

	// Token: 0x040051B4 RID: 20916
	public string _id;

	// Token: 0x040051B5 RID: 20917
	public UpdatableChatMember From;

	// Token: 0x040051B6 RID: 20918
	public UpdatableChatMember To;

	// Token: 0x040051B7 RID: 20919
	public double Date;

	// Token: 0x040051B8 RID: 20920
	public UpdatableChatMember Profile;

	// Token: 0x040051B9 RID: 20921
	public bool InputInvitation;
}
