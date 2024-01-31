using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Settings.Graphics;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x020019BD RID: 6589
[StructLayout(LayoutKind.Auto)]
public struct GStruct235 : IEquatable<GStruct235>
{
	// Token: 0x06008C7F RID: 35967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(GStruct235 other)
	{
		throw null;
	}

	// Token: 0x06008C80 RID: 35968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	// Token: 0x06008C81 RID: 35969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	// Token: 0x0400927E RID: 37502
	public byte Display;

	// Token: 0x0400927F RID: 37503
	[JsonConverter(typeof(GClass1877))]
	public FullScreenMode FullScreenMode;

	// Token: 0x04009280 RID: 37504
	public EftResolution Resolution;

	// Token: 0x04009281 RID: 37505
	public AspectRatio AspectRatio;
}
