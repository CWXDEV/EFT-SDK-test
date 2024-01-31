using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x0200083B RID: 2107
public static class GClass778
{
	// Token: 0x0200083C RID: 2108
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct50
	{
		// Token: 0x04002F4A RID: 12106
		public int vertCount;

		// Token: 0x04002F4B RID: 12107
		public Vector3[] verts;

		// Token: 0x04002F4C RID: 12108
		public int indCount;

		// Token: 0x04002F4D RID: 12109
		public int[] indices;

		// Token: 0x04002F4E RID: 12110
		public int colorCount;

		// Token: 0x04002F4F RID: 12111
		public Color[] colors;
	}

	// Token: 0x0200083D RID: 2109
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct51
	{
		// Token: 0x04002F50 RID: 12112
		public Vector3 boundsCenter;

		// Token: 0x04002F51 RID: 12113
		public Vector3 boundsSize;

		// Token: 0x04002F52 RID: 12114
		public Matrix4x4 mat4x4;
	}

	// Token: 0x0200083E RID: 2110
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct52
	{
		// Token: 0x04002F53 RID: 12115
		public GClass778.GStruct50 meshData;

		// Token: 0x04002F54 RID: 12116
		public int transformationCount;

		// Token: 0x04002F55 RID: 12117
		public GClass778.GStruct51[] transformations;

		// Token: 0x04002F56 RID: 12118
		public int renderMode;

		// Token: 0x0200083F RID: 2111
		public enum NativeMeshRenderMode
		{
			// Token: 0x04002F58 RID: 12120
			TriangleFill,
			// Token: 0x04002F59 RID: 12121
			Wireframe
		}
	}

	// Token: 0x02000840 RID: 2112
	public class GClass779
	{
		// Token: 0x04002F5A RID: 12122
		public string NativeLibPath;

		// Token: 0x04002F5B RID: 12123
		public Vector3[] SamplingPositions;

		// Token: 0x04002F5C RID: 12124
		public GClass778.GStruct52[] NativeMeshRenderers;
	}
}
