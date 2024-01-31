using System;
using System.Runtime.InteropServices;

// Token: 0x02000DD2 RID: 3538
[StructLayout(LayoutKind.Auto)]
public struct GStruct75
{
	// Token: 0x040055AD RID: 21933
	public float bakeWidth;

	// Token: 0x040055AE RID: 21934
	public float bakeHeight;

	// Token: 0x040055AF RID: 21935
	public float fov;

	// Token: 0x040055B0 RID: 21936
	public float nearClipPlane;

	// Token: 0x040055B1 RID: 21937
	public float farClipPlane;

	// Token: 0x040055B2 RID: 21938
	public int debugMode;

	// Token: 0x040055B3 RID: 21939
	[Obsolete("Unused")]
	public int showConsole;

	// Token: 0x040055B4 RID: 21940
	[Obsolete("Unused, drawing meshes uses individual settings")]
	public int useWireFrame;

	// Token: 0x040055B5 RID: 21941
	public int outputPixelData;
}
