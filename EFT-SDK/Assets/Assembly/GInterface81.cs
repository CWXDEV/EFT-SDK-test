using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02001011 RID: 4113
public interface GInterface81
{
	// Token: 0x17000D88 RID: 3464
	// (get) Token: 0x06005605 RID: 22021
	string Name { get; }

	// Token: 0x17000D89 RID: 3465
	// (get) Token: 0x06005606 RID: 22022
	int ParameterXHash { get; }

	// Token: 0x17000D8A RID: 3466
	// (get) Token: 0x06005607 RID: 22023
	int ParameterYHash { get; }

	// Token: 0x17000D8B RID: 3467
	// (get) Token: 0x06005608 RID: 22024
	float MaxClipTime { get; }

	// Token: 0x17000D8C RID: 3468
	// (get) Token: 0x06005609 RID: 22025
	bool IsLooping { get; }

	// Token: 0x17000D8D RID: 3469
	// (get) Token: 0x0600560A RID: 22026
	Vector3 PosMotion { get; }

	// Token: 0x17000D8E RID: 3470
	// (get) Token: 0x0600560B RID: 22027
	Quaternion PosRotation { get; }

	// Token: 0x0600560C RID: 22028
	Vector3 ComputeRootPosition(float deltaTime, float stateNormalizedTime, GInterface82 parametersCache);

	// Token: 0x0600560D RID: 22029
	Quaternion ComputeDeltaRotation(float deltaTime, GInterface82 parametersCache);

	// Token: 0x0600560E RID: 22030
	float ComputeClipTime(GInterface82 parametersCache);

	// Token: 0x0600560F RID: 22031
	void ComputeActiveClips(List<GStruct106> nodes, GInterface82 parametersCache);
}
