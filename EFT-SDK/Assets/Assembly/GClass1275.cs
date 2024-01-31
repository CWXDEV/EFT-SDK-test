using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001125 RID: 4389
public sealed class GClass1275
{
	// Token: 0x06005C4A RID: 23626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(IPEndPoint senderEndPoint, Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005C4B RID: 23627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GInterface91 listener)
	{
		throw null;
	}

	// Token: 0x06005C4C RID: 23628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1<T>(T packet, IPEndPoint target) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo)
	{
		throw null;
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PollEvents()
	{
		throw null;
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendNatIntroduceRequest(string host, int port, string additionalInfo)
	{
		throw null;
	}

	// Token: 0x06005C50 RID: 23632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo)
	{
		throw null;
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass1275.Class820 req, IPEndPoint senderEndPoint)
	{
		throw null;
	}

	// Token: 0x06005C52 RID: 23634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GClass1275.Class821 req)
	{
		throw null;
	}

	// Token: 0x06005C53 RID: 23635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass1275.Class822 req, IPEndPoint senderEndPoint)
	{
		throw null;
	}

	// Token: 0x040067AD RID: 26541
	private readonly Class830 class830_0;

	// Token: 0x040067AE RID: 26542
	private readonly Queue<GClass1275.Struct173> queue_0;

	// Token: 0x040067AF RID: 26543
	private readonly Queue<GClass1275.Struct174> queue_1;

	// Token: 0x040067B0 RID: 26544
	private readonly GClass1284 gclass1284_0;

	// Token: 0x040067B1 RID: 26545
	private readonly GClass1286 gclass1286_0;

	// Token: 0x040067B2 RID: 26546
	private readonly GClass1287 gclass1287_0;

	// Token: 0x040067B3 RID: 26547
	private GInterface91 ginterface91_0;

	// Token: 0x040067B4 RID: 26548
	public const int MaxTokenLength = 256;

	// Token: 0x02001126 RID: 4390
	[StructLayout(LayoutKind.Auto)]
	public struct Struct173
	{
		// Token: 0x040067B5 RID: 26549
		public IPEndPoint LocalEndPoint;

		// Token: 0x040067B6 RID: 26550
		public IPEndPoint RemoteEndPoint;

		// Token: 0x040067B7 RID: 26551
		public string Token;
	}

	// Token: 0x02001127 RID: 4391
	[StructLayout(LayoutKind.Auto)]
	public struct Struct174
	{
		// Token: 0x040067B8 RID: 26552
		public IPEndPoint TargetEndPoint;

		// Token: 0x040067B9 RID: 26553
		public NatAddressType Type;

		// Token: 0x040067BA RID: 26554
		public string Token;
	}

	// Token: 0x02001128 RID: 4392
	private class Class820
	{
		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C55 RID: 23637 RVA: 0x00002050 File Offset: 0x00000250
		public IPEndPoint Internal
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

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06005C56 RID: 23638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C57 RID: 23639 RVA: 0x00002050 File Offset: 0x00000250
		public string Token
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

		// Token: 0x040067BB RID: 26555
		[CompilerGenerated]
		private IPEndPoint ipendPoint_0;

		// Token: 0x040067BC RID: 26556
		[CompilerGenerated]
		private string string_0;
	}

	// Token: 0x02001129 RID: 4393
	private class Class821
	{
		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06005C58 RID: 23640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C59 RID: 23641 RVA: 0x00002050 File Offset: 0x00000250
		public IPEndPoint Internal
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

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06005C5A RID: 23642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C5B RID: 23643 RVA: 0x00002050 File Offset: 0x00000250
		public IPEndPoint External
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

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C5D RID: 23645 RVA: 0x00002050 File Offset: 0x00000250
		public string Token
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

		// Token: 0x040067BD RID: 26557
		[CompilerGenerated]
		private IPEndPoint ipendPoint_0;

		// Token: 0x040067BE RID: 26558
		[CompilerGenerated]
		private IPEndPoint ipendPoint_1;

		// Token: 0x040067BF RID: 26559
		[CompilerGenerated]
		private string string_0;
	}

	// Token: 0x0200112A RID: 4394
	private class Class822
	{
		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06005C5E RID: 23646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C5F RID: 23647 RVA: 0x00002050 File Offset: 0x00000250
		public string Token
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

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06005C60 RID: 23648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C61 RID: 23649 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsExternal
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

		// Token: 0x040067C0 RID: 26560
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040067C1 RID: 26561
		[CompilerGenerated]
		private bool bool_0;
	}
}
