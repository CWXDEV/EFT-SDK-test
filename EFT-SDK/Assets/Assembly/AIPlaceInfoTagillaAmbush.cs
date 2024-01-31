using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000524 RID: 1316
public class AIPlaceInfoTagillaAmbush : AIPlaceInfo
{
	// Token: 0x0600201D RID: 8221 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnterPlace(Player player)
	{
		throw null;
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnLeavePlace(Player player)
	{
		throw null;
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Player player, bool state)
	{
		throw null;
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Transform method_1(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(BotOwner ambushOwner, bool state)
	{
		throw null;
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x04001EC3 RID: 7875
	[SerializeField]
	private readonly List<Transform> _ambushPoints;

	// Token: 0x04001EC4 RID: 7876
	[SerializeField]
	private readonly AIPlaceInfoTagillaAmbush.EPointSearchType _pointSearchType;

	// Token: 0x04001EC5 RID: 7877
	[SerializeField]
	private readonly float _maxAmbushDistance;

	// Token: 0x02000525 RID: 1317
	public enum EPointSearchType
	{
		// Token: 0x04001EC7 RID: 7879
		Random = 1,
		// Token: 0x04001EC8 RID: 7880
		Nearest
	}
}
