using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F38 RID: 7992
public class GClass2230 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x0600A550 RID: 42320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2230 CreateInstance()
	{
		throw null;
	}

	// Token: 0x17001B2F RID: 6959
	// (get) Token: 0x0600A551 RID: 42321 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A552 RID: 42322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A553 RID: 42323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A554 RID: 42324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A555 RID: 42325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD29 RID: 44329
	public GClass2230.EHeadDeviceType DeviceType;

	// Token: 0x0400AD2A RID: 44330
	public bool IsActive;

	// Token: 0x02001F39 RID: 7993
	public enum EHeadDeviceType
	{
		// Token: 0x0400AD2C RID: 44332
		FaceShield,
		// Token: 0x0400AD2D RID: 44333
		NightVision,
		// Token: 0x0400AD2E RID: 44334
		ThermalVision
	}
}
