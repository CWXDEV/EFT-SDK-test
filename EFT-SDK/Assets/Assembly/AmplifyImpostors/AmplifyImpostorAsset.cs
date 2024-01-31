using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x020031B7 RID: 12727
	[CreateAssetMenu(fileName = "New Impostor", order = 85)]
	public class AmplifyImpostorAsset : ScriptableObject
	{
		// Token: 0x0400FF4D RID: 65357
		[SerializeField]
		public Material Material;

		// Token: 0x0400FF4E RID: 65358
		[SerializeField]
		public Mesh Mesh;

		// Token: 0x0400FF4F RID: 65359
		[HideInInspector]
		[SerializeField]
		public int Version;

		// Token: 0x0400FF50 RID: 65360
		[SerializeField]
		public ImpostorType ImpostorType;

		// Token: 0x0400FF51 RID: 65361
		[SerializeField]
		[HideInInspector]
		public bool LockedSizes;

		// Token: 0x0400FF52 RID: 65362
		[HideInInspector]
		[SerializeField]
		public int SelectedSize;

		// Token: 0x0400FF53 RID: 65363
		[SerializeField]
		public Vector2 TexSize;

		// Token: 0x0400FF54 RID: 65364
		[HideInInspector]
		[SerializeField]
		public bool DecoupleAxisFrames;

		// Token: 0x0400FF55 RID: 65365
		[SerializeField]
		[Range(1f, 32f)]
		public int HorizontalFrames;

		// Token: 0x0400FF56 RID: 65366
		[SerializeField]
		[Range(1f, 33f)]
		public int VerticalFrames;

		// Token: 0x0400FF57 RID: 65367
		[Range(0f, 64f)]
		[SerializeField]
		public int PixelPadding;

		// Token: 0x0400FF58 RID: 65368
		[SerializeField]
		[Range(4f, 16f)]
		public int MaxVertices;

		// Token: 0x0400FF59 RID: 65369
		[Range(0f, 0.2f)]
		[SerializeField]
		public float Tolerance;

		// Token: 0x0400FF5A RID: 65370
		[Range(0f, 1f)]
		[SerializeField]
		public float NormalScale;

		// Token: 0x0400FF5B RID: 65371
		[SerializeField]
		public Vector2[] ShapePoints;

		// Token: 0x0400FF5C RID: 65372
		[SerializeField]
		public AmplifyImpostorBakePreset Preset;

		// Token: 0x0400FF5D RID: 65373
		[SerializeField]
		public List<TextureOutput> OverrideOutput;
	}
}
