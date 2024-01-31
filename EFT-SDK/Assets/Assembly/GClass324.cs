using System;
using System.Runtime.CompilerServices;
using EFT;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x0200014E RID: 334
public class GClass324 : ISerializer<NavGraphFindDebug>
{
	// Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavGraphFindDebug Deserialize()
	{
		throw null;
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(NavGraphFindDebug t)
	{
		throw null;
	}

	// Token: 0x040007E1 RID: 2017
	[JsonProperty("centerPosition")]
	public Vector3 _centerPosition;

	// Token: 0x040007E2 RID: 2018
	[JsonProperty("startPoint")]
	public int _startPoint;

	// Token: 0x040007E3 RID: 2019
	[JsonProperty("shootType")]
	public CoverShootType _shootType;

	// Token: 0x040007E4 RID: 2020
	[JsonProperty("botId")]
	public int _botId;

	// Token: 0x040007E5 RID: 2021
	[JsonProperty("steps")]
	public NavGraphFindDebugStepInfo[] _steps;

	// Token: 0x040007E6 RID: 2022
	[JsonProperty("endInfo")]
	public string _endInfo;

	// Token: 0x040007E7 RID: 2023
	[JsonProperty("zoneName")]
	public string _zoneName;

	// Token: 0x040007E8 RID: 2024
	[JsonProperty("ResultWayIds")]
	public int[] ResultWayIds;
}
