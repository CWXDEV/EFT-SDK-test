using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200151F RID: 5407
public struct PlayerInteractPacket
{
	// Token: 0x0600740A RID: 29706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(PlayerInteractPacket other)
	{
		throw null;
	}

	// Token: 0x0600740B RID: 29707 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		throw null;
	}

	// Token: 0x0600740C RID: 29708 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		throw null;
	}

	// Token: 0x0600740D RID: 29709 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x0600740E RID: 29710 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x04007A48 RID: 31304
	public bool HasInteraction;

	// Token: 0x04007A49 RID: 31305
	public EInteractionType InteractionType;

	// Token: 0x04007A4A RID: 31306
	public byte SideId;

	// Token: 0x04007A4B RID: 31307
	public byte SlotId;

	// Token: 0x04007A4C RID: 31308
	public bool Fast;
}
