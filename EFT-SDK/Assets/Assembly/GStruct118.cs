using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;

// Token: 0x020011D0 RID: 4560
[StructLayout(LayoutKind.Auto)]
public struct GStruct118 : IDisposable
{
	// Token: 0x17000F4D RID: 3917
	// (get) Token: 0x06006165 RID: 24933 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06006166 RID: 24934 RVA: 0x00002050 File Offset: 0x00000250
	public PacketPriority Priority
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000F4E RID: 3918
	// (get) Token: 0x06006167 RID: 24935 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06006168 RID: 24936 RVA: 0x00002050 File Offset: 0x00000250
	public int PriorityCounter
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000F4F RID: 3919
	// (get) Token: 0x06006169 RID: 24937 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600616A RID: 24938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct118 Create()
	{
		throw null;
	}

	// Token: 0x0600616B RID: 24939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600616C RID: 24940 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct118 Clone()
	{
		throw null;
	}

	// Token: 0x04006B3A RID: 27450
	[CompilerGenerated]
	private PacketPriority packetPriority_0;

	// Token: 0x04006B3B RID: 27451
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04006B3C RID: 27452
	public float RemoteTime;

	// Token: 0x04006B3D RID: 27453
	public GStruct119? InteractiveObjectsStatusPacket;

	// Token: 0x04006B3E RID: 27454
	public GStruct120? SpawnQuestLootPacket;

	// Token: 0x04006B3F RID: 27455
	public GStruct121? UpdateExfiltrationPointPacket;

	// Token: 0x04006B40 RID: 27456
	public GStruct122? LampChangeStatePacket;

	// Token: 0x04006B41 RID: 27457
	public GStruct123? WindowHitPacket;

	// Token: 0x04006B42 RID: 27458
	public List<GStruct124> LootSyncPackets;

	// Token: 0x04006B43 RID: 27459
	public List<GStruct125> CorpseSyncPackets;

	// Token: 0x04006B44 RID: 27460
	public List<GStruct126> GrenadeSyncPackets;

	// Token: 0x04006B45 RID: 27461
	public List<GStruct127> PlatformSyncPackets;

	// Token: 0x04006B46 RID: 27462
	public List<GStruct128> BorderZonePackets;

	// Token: 0x04006B47 RID: 27463
	public List<AirplaneDataPacketStruct> SynchronizableObjectPackets;
}
