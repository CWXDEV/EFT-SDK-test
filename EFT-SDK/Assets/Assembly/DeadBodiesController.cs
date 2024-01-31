using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000483 RID: 1155
public class DeadBodiesController
{
	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00002050 File Offset: 0x00000250
	public int BodiesCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBody(GClass320 body)
	{
		throw null;
	}

	// Token: 0x06001BDE RID: 7134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GClass320> BodiesByGroup(BotsGroup botsGroup)
	{
		throw null;
	}

	// Token: 0x06001BDF RID: 7135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBody(BotsGroup botsGroup, GClass320 body)
	{
		throw null;
	}

	// Token: 0x06001BE0 RID: 7136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveBody(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBody(IPlayer player)
	{
		throw null;
	}

	// Token: 0x040017B2 RID: 6066
	public List<GClass320> Bodies;

	// Token: 0x040017B3 RID: 6067
	private readonly Dictionary<BotsGroup, List<GClass320>> Bodiesgroups;

	// Token: 0x040017B4 RID: 6068
	private readonly BotZoneGroupsDictionary _groups;
}
