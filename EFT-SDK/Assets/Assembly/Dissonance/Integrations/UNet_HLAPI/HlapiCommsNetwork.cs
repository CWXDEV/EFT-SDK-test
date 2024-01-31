using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dissonance.Datastructures;
using Dissonance.Networking;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Networking;

namespace Dissonance.Integrations.UNet_HLAPI
{
	// Token: 0x02000ECB RID: 3787
	[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Basics/Quick-Start-UNet-HLAPI/")]
	public class HlapiCommsNetwork : BaseCommsNetwork<GClass1068, GClass1067, GStruct82, Unit, Unit>
	{
		// Token: 0x06004EFD RID: 20221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass1068 CreateServer(Unit details)
		{
			throw null;
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass1067 CreateClient(Unit details)
		{
			throw null;
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Initialize()
		{
			throw null;
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool PreprocessPacketToClient(ArraySegment<byte> packet, GStruct82 destination)
		{
			throw null;
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool PreprocessPacketToServer(ArraySegment<byte> packet)
		{
			throw null;
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void NullMessageReceivedHandler([NotNull] NetworkMessage netmsg)
		{
			throw null;
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ArraySegment<byte> CopyToArraySegment([NotNull] NetworkReader msg, ArraySegment<byte> segment)
		{
			throw null;
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int CopyPacketToNetworkWriter(ArraySegment<byte> packet, [NotNull] NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x04005BC6 RID: 23494
		public byte UnreliableChannel;

		// Token: 0x04005BC7 RID: 23495
		public byte ReliableSequencedChannel;

		// Token: 0x04005BC8 RID: 23496
		public short TypeCode;

		// Token: 0x04005BC9 RID: 23497
		private readonly ConcurrentPool<byte[]> _loopbackBuffers;

		// Token: 0x04005BCA RID: 23498
		private readonly List<ArraySegment<byte>> _loopbackQueue;

		// Token: 0x04005BCB RID: 23499
		public bool Activated;

		// Token: 0x02000ECC RID: 3788
		[CompilerGenerated]
		[Serializable]
		private sealed class Class764
		{
			// Token: 0x04005BCC RID: 23500
			public static readonly HlapiCommsNetwork.Class764 class764_0;

			// Token: 0x04005BCD RID: 23501
			public static Func<byte[]> func_0;
		}
	}
}
