using System;
using UnityEngine;

// Token: 0x020006D8 RID: 1752
[CreateAssetMenu]
public class AnimatorPose : ScriptableObject
{
	// Token: 0x040026D0 RID: 9936
	public Vector3 Position;

	// Token: 0x040026D1 RID: 9937
	public Vector3 Rotation;

	// Token: 0x040026D2 RID: 9938
	public Vector3 CameraRotation;

	// Token: 0x040026D3 RID: 9939
	public Vector3 CameraPosition;

	// Token: 0x040026D4 RID: 9940
	public AnimationCurve Blend;
}
