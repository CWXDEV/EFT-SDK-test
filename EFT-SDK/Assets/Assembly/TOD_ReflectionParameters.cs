using System;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000BA RID: 186
[Serializable]
public class TOD_ReflectionParameters
{
	// Token: 0x040003F8 RID: 1016
	[Tooltip("Reflection probe mode.")]
	public TOD_ReflectionType Mode;

	// Token: 0x040003F9 RID: 1017
	[Tooltip("Clear flags to use for the reflection.")]
	public ReflectionProbeClearFlags ClearFlags;

	// Token: 0x040003FA RID: 1018
	[Tooltip("Layers to include in the reflection.")]
	public LayerMask CullingMask;

	// Token: 0x040003FB RID: 1019
	[Tooltip("Time slicing behaviour to spread out rendering cost over multiple frames.")]
	public ReflectionProbeTimeSlicingMode TimeSlicing;

	// Token: 0x040003FC RID: 1020
	public float UpdateInterval;
}
