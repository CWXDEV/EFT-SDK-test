using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000704 RID: 1796
[StructLayout(LayoutKind.Auto)]
public struct GStruct33
{
	// Token: 0x060029EC RID: 10732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct33 Read(NetworkReader reader)
	{
		throw null;
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write(NetworkWriter writer)
	{
		throw null;
	}

	// Token: 0x04002805 RID: 10245
	public Vector3 Position;

	// Token: 0x04002806 RID: 10246
	public string Id;

	// Token: 0x04002807 RID: 10247
	public string Template;

	// Token: 0x04002808 RID: 10248
	public int Time;

	// Token: 0x04002809 RID: 10249
	public Quaternion Orientation;

	// Token: 0x0400280A RID: 10250
	public short PlatformId;
}
