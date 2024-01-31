using System;
using UnityEngine;

// Token: 0x02000BF5 RID: 3061
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
public class MeshProjector : MonoBehaviour
{
	// Token: 0x04004BCF RID: 19407
	private LayerMask layerMask_0;

	// Token: 0x04004BD0 RID: 19408
	[SerializeField]
	[Range(0f, 1f)]
	private float _offset;

	// Token: 0x04004BD1 RID: 19409
	[SerializeField]
	private float _raycastOffset;

	// Token: 0x04004BD2 RID: 19410
	[HideInInspector]
	public bool UpdateByTimer;

	// Token: 0x04004BD3 RID: 19411
	[HideInInspector]
	public float UpdateTime;

	// Token: 0x04004BD4 RID: 19412
	private Transform transform_0;

	// Token: 0x04004BD5 RID: 19413
	private MeshFilter meshFilter_0;

	// Token: 0x04004BD6 RID: 19414
	private const float float_0 = 50f;

	// Token: 0x04004BD7 RID: 19415
	private float float_1;

	// Token: 0x04004BD8 RID: 19416
	public static Action<int> OnMeshUpdated;
}
