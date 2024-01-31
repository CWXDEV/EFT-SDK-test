using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000767 RID: 1895
public class PreviewPivot : MonoBehaviour
{
	// Token: 0x06002C9C RID: 11420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AutoAdjustPivot()
	{
		throw null;
	}

	// Token: 0x04002B3E RID: 11070
	public Vector3 pivotPosition;

	// Token: 0x04002B3F RID: 11071
	public Quaternion pivotRotation;

	// Token: 0x04002B40 RID: 11072
	public Vector3 scale;

	// Token: 0x04002B41 RID: 11073
	public Vector3 SpawnPosition;

	// Token: 0x04002B42 RID: 11074
	public PreviewPivot.IconSettings Icon;

	// Token: 0x02000768 RID: 1896
	[Serializable]
	public class IconSettings
	{
		// Token: 0x06002C9D RID: 11421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(PreviewPivot.IconSettings newSettings)
		{
			throw null;
		}

		// Token: 0x04002B43 RID: 11075
		public Vector3 position;

		// Token: 0x04002B44 RID: 11076
		public bool hasOffset;

		// Token: 0x04002B45 RID: 11077
		public Quaternion rotation;

		// Token: 0x04002B46 RID: 11078
		public float boundsScale;

		// Token: 0x04002B47 RID: 11079
		public float perspective;

		// Token: 0x04002B48 RID: 11080
		public bool orthographic;

		// Token: 0x04002B49 RID: 11081
		public float orthographicSize;

		// Token: 0x04002B4A RID: 11082
		public Sprite overrideIcon;
	}
}
