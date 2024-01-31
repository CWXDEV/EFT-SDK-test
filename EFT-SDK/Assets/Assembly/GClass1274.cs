using System;
using System.Net;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001122 RID: 4386
public class GClass1274 : GInterface91
{
	// Token: 0x14000103 RID: 259
	// (add) Token: 0x06005C3E RID: 23614 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C3F RID: 23615 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1274.GDelegate52 NatIntroductionRequest
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000104 RID: 260
	// (add) Token: 0x06005C40 RID: 23616 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C41 RID: 23617 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1274.GDelegate53 NatIntroductionSuccess
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface91.OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token)
	{
		throw null;
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface91.OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token)
	{
		throw null;
	}

	// Token: 0x040067AB RID: 26539
	[CompilerGenerated]
	private GClass1274.GDelegate52 gdelegate52_0;

	// Token: 0x040067AC RID: 26540
	[CompilerGenerated]
	private GClass1274.GDelegate53 gdelegate53_0;

	// Token: 0x02001123 RID: 4387
	// (Invoke) Token: 0x06005C44 RID: 23620
	public delegate void GDelegate52(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

	// Token: 0x02001124 RID: 4388
	// (Invoke) Token: 0x06005C47 RID: 23623
	public delegate void GDelegate53(IPEndPoint targetEndPoint, NatAddressType type, string token);
}
