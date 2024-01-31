using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200023A RID: 570
public class BotZoneEntranceInfo : MonoBehaviour
{
	// Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotZoneEntrance GetClosest(Vector3 pos, int areaId)
	{
		throw null;
	}

	// Token: 0x04000B85 RID: 2949
	[FormerlySerializedAs("EntraceList")]
	public List<BotZoneEntrance> EntranceList;

	// Token: 0x04000B86 RID: 2950
	private Dictionary<int, List<BotZoneEntrance>> dictionary_0;
}
