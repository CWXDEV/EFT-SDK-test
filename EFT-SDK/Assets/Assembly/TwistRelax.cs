using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020008FC RID: 2300
public class TwistRelax : MonoBehaviour
{
	// Token: 0x060033F2 RID: 13298 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Store values")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060033F3 RID: 13299 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Relax")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Relax()
	{
		throw null;
	}

	// Token: 0x040034A4 RID: 13476
	[Tooltip("The weight of relaxing the twist of this Transform")]
	[Range(0f, 1f)]
	public float weight;

	// Token: 0x040034A5 RID: 13477
	[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
	[Range(0f, 1f)]
	public float parentChildCrossfade;

	// Token: 0x040034A6 RID: 13478
	[Tooltip("The parent Transform, does not need to be the actual transform.parent.")]
	public Transform parent;

	// Token: 0x040034A7 RID: 13479
	[Tooltip("The child Transform, does not need to be the direct child, you can skip bones in the hierarchy.")]
	public Transform child;

	// Token: 0x040034A8 RID: 13480
	[Tooltip("The local axis of this Transform that it will be twisted around (the axis pointing towards the parent).")]
	public Vector3 twistAxis;

	// Token: 0x040034A9 RID: 13481
	[Tooltip("Another axis, orthogonal to twistAxis.")]
	public Vector3 axis;

	// Token: 0x040034AA RID: 13482
	[SerializeField]
	private Vector3 _axisRelativeToParentDefault;

	// Token: 0x040034AB RID: 13483
	[SerializeField]
	private Vector3 _axisRelativeToChildDefault;
}
