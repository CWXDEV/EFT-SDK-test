using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dissonance.Integrations.UNet_HLAPI;
using Dissonance.Networking;
using Dissonance.Networking.Server;
using JetBrains.Annotations;
using UnityEngine.Networking;

// Token: 0x02000ECF RID: 3791
public class GClass1068 : BaseServer<GClass1068, GClass1067, GStruct82>
{
	// Token: 0x06004F26 RID: 20262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Connect()
	{
		throw null;
	}

	// Token: 0x06004F27 RID: 20263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0([NotNull] NetworkMessage netmsg)
	{
		throw null;
	}

	// Token: 0x06004F28 RID: 20264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void AddClient([NotNull] ClientInfo<GStruct82> client)
	{
		throw null;
	}

	// Token: 0x06004F29 RID: 20265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Disconnect()
	{
		throw null;
	}

	// Token: 0x06004F2A RID: 20266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadMessages()
	{
		throw null;
	}

	// Token: 0x06004F2B RID: 20267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ServerState Update()
	{
		throw null;
	}

	// Token: 0x06004F2C RID: 20268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SendReliable(GStruct82 connection, ArraySegment<byte> packet)
	{
		throw null;
	}

	// Token: 0x06004F2D RID: 20269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SendUnreliable(GStruct82 connection, ArraySegment<byte> packet)
	{
		throw null;
	}

	// Token: 0x06004F2E RID: 20270 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(ArraySegment<byte> packet, GStruct82 connection, byte channel)
	{
		throw null;
	}

	// Token: 0x04005BD6 RID: 23510
	[NotNull]
	private readonly HlapiCommsNetwork hlapiCommsNetwork_0;

	// Token: 0x04005BD7 RID: 23511
	private readonly NetworkWriter networkWriter_0;

	// Token: 0x04005BD8 RID: 23512
	private readonly byte[] byte_0;

	// Token: 0x04005BD9 RID: 23513
	private readonly List<NetworkConnection> list_0;
}
