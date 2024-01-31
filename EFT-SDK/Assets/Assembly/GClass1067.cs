using System;
using System.Runtime.CompilerServices;
using Dissonance.Integrations.UNet_HLAPI;
using Dissonance.Networking;
using JetBrains.Annotations;
using UnityEngine.Networking;

// Token: 0x02000ECA RID: 3786
public class GClass1067 : BaseClient<GClass1068, GClass1067, GStruct82>
{
	// Token: 0x06004EF5 RID: 20213 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Connect()
	{
		throw null;
	}

	// Token: 0x06004EF6 RID: 20214 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Disconnect()
	{
		throw null;
	}

	// Token: 0x06004EF7 RID: 20215 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SendVoiceData(ArraySegment<byte> encodedAudio)
	{
		throw null;
	}

	// Token: 0x06004EF8 RID: 20216 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0([CanBeNull] NetworkMessage netMsg)
	{
		throw null;
	}

	// Token: 0x06004EF9 RID: 20217 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadMessages()
	{
		throw null;
	}

	// Token: 0x06004EFA RID: 20218 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SendReliable(ArraySegment<byte> packet)
	{
		throw null;
	}

	// Token: 0x06004EFB RID: 20219 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SendUnreliable(ArraySegment<byte> packet)
	{
		throw null;
	}

	// Token: 0x06004EFC RID: 20220 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(ArraySegment<byte> packet, byte channel)
	{
		throw null;
	}

	// Token: 0x04005BC3 RID: 23491
	private readonly HlapiCommsNetwork hlapiCommsNetwork_0;

	// Token: 0x04005BC4 RID: 23492
	private readonly NetworkWriter networkWriter_0;

	// Token: 0x04005BC5 RID: 23493
	private readonly byte[] byte_0;

	public GClass1067([NotNull] ICommsNetworkState network) : base(network)
	{
	}
}
