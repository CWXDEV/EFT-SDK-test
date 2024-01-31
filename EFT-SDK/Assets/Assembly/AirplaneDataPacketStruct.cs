using System;
using System.Runtime.InteropServices;
using EFT.SynchronizableObjects;
using UnityEngine;

// Token: 0x0200077A RID: 1914
[StructLayout(LayoutKind.Auto)]
public struct AirplaneDataPacketStruct
{
	// Token: 0x04002B7E RID: 11134
	public bool Develop;

	// Token: 0x04002B7F RID: 11135
	public int ObjectId;

	// Token: 0x04002B80 RID: 11136
	public Vector3 Position;

	// Token: 0x04002B81 RID: 11137
	public Vector3 Rotation;

	// Token: 0x04002B82 RID: 11138
	public SynchronizableObjectType ObjectType;

	// Token: 0x04002B83 RID: 11139
	public bool Outdated;

	// Token: 0x04002B84 RID: 11140
	public bool IsStatic;

	// Token: 0x04002B85 RID: 11141
	public AirplaneDataPacketStruct.GStruct40 PacketData;

	// Token: 0x04002B86 RID: 11142
	private static readonly GClass1169 gclass1169_0;

	// Token: 0x0200077B RID: 1915
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct40
	{
		// Token: 0x04002B87 RID: 11143
		public GStruct37 AirplaneDataPacket;

		// Token: 0x04002B88 RID: 11144
		public GStruct36 AirdropDataPacket;

		// Token: 0x04002B89 RID: 11145
		public GStruct38 DevelopDataPacket;
	}
}
