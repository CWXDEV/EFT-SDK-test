using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200064B RID: 1611
[ExecuteInEditMode]
public class EasySuspension : MonoBehaviour
{
	// Token: 0x060024EA RID: 9450 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRigidbody(Rigidbody rigidbody)
	{
		throw null;
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x040023DA RID: 9178
	[Tooltip("Natural frequency of the suspension springs. Describes bounciness of the suspension.")]
	[Range(0.1f, 20f)]
	public float naturalFrequency;

	// Token: 0x040023DB RID: 9179
	[Range(0f, 3f)]
	[Tooltip("Damping ratio of the suspension springs. Describes how fast the spring returns back after a bounce. ")]
	public float dampingRatio;

	// Token: 0x040023DC RID: 9180
	[Range(-1f, 1f)]
	[Tooltip("The distance along the Y axis the suspension forces application point is offset below the center of mass")]
	public float forceShift;

	// Token: 0x040023DD RID: 9181
	[Tooltip("Adjust the length of the suspension springs according to the natural frequency and damping ratio. When off, can cause unrealistic suspension bounce.")]
	public bool setSuspensionDistance;

	// Token: 0x040023DE RID: 9182
	private Rigidbody rigidbody_0;
}
