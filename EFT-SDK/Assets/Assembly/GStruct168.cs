using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02001520 RID: 5408
[StructLayout(LayoutKind.Auto)]
public struct GStruct168
{
	// Token: 0x0600740F RID: 29711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007410 RID: 29712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x06007411 RID: 29713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(GStruct168 other)
	{
		throw null;
	}

	// Token: 0x06007412 RID: 29714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	// Token: 0x06007413 RID: 29715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	// Token: 0x04007A4D RID: 31309
	public bool HasInteraction;

	// Token: 0x04007A4E RID: 31310
	public string Id;

	// Token: 0x04007A4F RID: 31311
	public GStruct168.EStationaryCommand StationaryCommand;

	// Token: 0x04007A50 RID: 31312
	public bool FinalizeObserverCrutch;

	// Token: 0x04007A51 RID: 31313
	public bool IsStationaryFinal;

	// Token: 0x02001521 RID: 5409
	public enum EStationaryCommand : byte
	{
		// Token: 0x04007A53 RID: 31315
		Occupy,
		// Token: 0x04007A54 RID: 31316
		Leave,
		// Token: 0x04007A55 RID: 31317
		Denied
	}
}
