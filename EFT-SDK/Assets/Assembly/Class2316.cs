using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EFT.BackEnd;
using UnityEngine.Networking;

// Token: 0x0200281B RID: 10267
internal sealed class Class2316
{
	// Token: 0x170024BC RID: 9404
	// (get) Token: 0x0600CD95 RID: 52629 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024BD RID: 9405
	// (get) Token: 0x0600CD96 RID: 52630 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024BE RID: 9406
	// (get) Token: 0x0600CD97 RID: 52631 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024BF RID: 9407
	// (get) Token: 0x0600CD98 RID: 52632 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024C0 RID: 9408
	// (get) Token: 0x0600CD99 RID: 52633 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024C1 RID: 9409
	// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x00002050 File Offset: 0x00000250
	private static string String_5
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CD9B RID: 52635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Class2316 smethod_0()
	{
		throw null;
	}

	// Token: 0x0600CD9C RID: 52636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task<Struct788[]> method_0(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600CD9D RID: 52637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<Struct788[]> method_1(CancellationToken token)
	{
		throw null;
	}

	// Token: 0x0600CD9E RID: 52638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal Task method_2()
	{
		throw null;
	}

	// Token: 0x0400CE1E RID: 52766
	private readonly Class2316.Class354 class354_0;

	// Token: 0x0400CE1F RID: 52767
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400CE20 RID: 52768
	private TaskCompletionSource<Struct788[]> taskCompletionSource_0;

	// Token: 0x0200281C RID: 10268
	private abstract class Class2317
	{
		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600CD9F RID: 52639 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDA0 RID: 52640 RVA: 0x00002050 File Offset: 0x00000250
		protected EDiagnosisSource EDiagnosisSource_0
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

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600CDA1 RID: 52641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDA2 RID: 52642 RVA: 0x00002050 File Offset: 0x00000250
		protected Class2316 Class2316_0
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

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600CDA3 RID: 52643 RVA: 0x00002050 File Offset: 0x00000250
		protected LoggerClass GClass611_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CDA4 RID: 52644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<Struct788> method_0(Class2316 context, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600CDA5 RID: 52645
		protected abstract Task<Struct788> vmethod_0(CancellationToken token);

		// Token: 0x0400CE21 RID: 52769
		[CompilerGenerated]
		private EDiagnosisSource ediagnosisSource_0;

		// Token: 0x0400CE22 RID: 52770
		[CompilerGenerated]
		private Class2316 class2316_0;
	}

	// Token: 0x0200281E RID: 10270
	private sealed class Class354 : LoggerClass
	{
		// Token: 0x0600CDA8 RID: 52648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(Struct788[] results, TimeSpan timeSpan, bool isCancellationRequested)
		{
			throw null;
		}

		// Token: 0x0400CE29 RID: 52777
		private const string string_0 = "ConnectionDiagnostics";
	}

	// Token: 0x0200281F RID: 10271
	private sealed class Class2318 : Class2316.Class2317
	{
		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2318 Class2318_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600CDAA RID: 52650 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2318 Class2318_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600CDAB RID: 52651 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDAC RID: 52652 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
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

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x0600CDAD RID: 52653 RVA: 0x00002050 File Offset: 0x00000250
		private static int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CDAE RID: 52654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<Struct788> vmethod_0(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0400CE2A RID: 52778
		[CompilerGenerated]
		private string string_0;

		// Token: 0x02002820 RID: 10272
		[CompilerGenerated]
		private sealed class Class2323
		{
			// Token: 0x0600CDAF RID: 52655 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600CDB0 RID: 52656 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task<PingReply> method_1()
			{
				throw null;
			}

			// Token: 0x0400CE2B RID: 52779
			public Ping ping;

			// Token: 0x0400CE2C RID: 52780
			public Class2316.Class2318 class2318_0;
		}
	}

	// Token: 0x02002822 RID: 10274
	private sealed class Class2319 : Class2316.Class2317
	{
		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x0600CDB3 RID: 52659 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2319 Class2319_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x0600CDB4 RID: 52660 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2319 Class2319_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600CDB5 RID: 52661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDB6 RID: 52662 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
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

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x0600CDB7 RID: 52663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDB8 RID: 52664 RVA: 0x00002050 File Offset: 0x00000250
		private string String_1
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

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<Struct788> vmethod_0(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<Struct788> method_1(Process process)
		{
			throw null;
		}

		// Token: 0x0400CE35 RID: 52789
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400CE36 RID: 52790
		[CompilerGenerated]
		private string string_1;

		// Token: 0x02002823 RID: 10275
		[CompilerGenerated]
		private sealed class Class2324
		{
			// Token: 0x0600CDBB RID: 52667 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400CE37 RID: 52791
			public Process process;
		}

		// Token: 0x02002825 RID: 10277
		[CompilerGenerated]
		private sealed class Class2325
		{
			// Token: 0x0600CDBE RID: 52670 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(object sender, DataReceivedEventArgs e)
			{
				throw null;
			}

			// Token: 0x0600CDBF RID: 52671 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(object sender, DataReceivedEventArgs e)
			{
				throw null;
			}

			// Token: 0x0600CDC0 RID: 52672 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(object sender, EventArgs e)
			{
				throw null;
			}

			// Token: 0x0400CE3E RID: 52798
			public StringBuilder stringBuilder;

			// Token: 0x0400CE3F RID: 52799
			public Process process;

			// Token: 0x0400CE40 RID: 52800
			public bool succeed;

			// Token: 0x0400CE41 RID: 52801
			public TaskCompletionSource<bool> completionSource;
		}
	}

	// Token: 0x02002827 RID: 10279
	private sealed class Class2320 : Class2316.Class2317
	{
		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600CDC3 RID: 52675 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2320 Class2320_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600CDC4 RID: 52676 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2320 Class2320_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600CDC5 RID: 52677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDC6 RID: 52678 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
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

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x0600CDC7 RID: 52679 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDC8 RID: 52680 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
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

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x0600CDC9 RID: 52681 RVA: 0x00002050 File Offset: 0x00000250
		private static TimeSpan TimeSpan_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<Struct788> vmethod_0(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0400CE49 RID: 52809
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400CE4A RID: 52810
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x02002828 RID: 10280
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2326
		{
			// Token: 0x0600CDCB RID: 52683 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPAddress ip)
			{
				throw null;
			}

			// Token: 0x0400CE4B RID: 52811
			public static readonly Class2316.Class2320.Class2326 class2326_0;

			// Token: 0x0400CE4C RID: 52812
			public static Func<IPAddress, bool> func_0;
		}
	}

	// Token: 0x0200282A RID: 10282
	private sealed class Class2321 : Class2316.Class2317
	{
		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x0600CDCE RID: 52686 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2321 Class2321_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x0600CDCF RID: 52687 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2321 Class2321_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDD1 RID: 52689 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
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

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x0600CDD2 RID: 52690 RVA: 0x00002050 File Offset: 0x00000250
		private static int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<Struct788> vmethod_0(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0400CE57 RID: 52823
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0200282B RID: 10283
		[CompilerGenerated]
		private sealed class Class2327
		{
			// Token: 0x0400CE58 RID: 52824
			public StringBuilder stringBuilder;
		}

		// Token: 0x0200282C RID: 10284
		[CompilerGenerated]
		private sealed class Class2328
		{
			// Token: 0x0600CDD4 RID: 52692 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400CE59 RID: 52825
			public UnityWebRequest request;

			// Token: 0x0400CE5A RID: 52826
			public Class2316.Class2321.Class2327 class2327_0;
		}
	}

	// Token: 0x0200282E RID: 10286
	private sealed class Class2322 : Class2316.Class2317
	{
		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x0600CDD7 RID: 52695 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2322 Class2322_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x00002050 File Offset: 0x00000250
		internal static Class2316.Class2322 Class2322_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x0600CDD9 RID: 52697 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDDA RID: 52698 RVA: 0x00002050 File Offset: 0x00000250
		private string String_0
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

		// Token: 0x0600CDDB RID: 52699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task<Struct788> vmethod_0(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0400CE63 RID: 52835
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0200282F RID: 10287
		[CompilerGenerated]
		private sealed class Class2329
		{
			// Token: 0x0400CE64 RID: 52836
			public StringBuilder stringBuilder;
		}

		// Token: 0x02002830 RID: 10288
		[CompilerGenerated]
		private sealed class Class2330
		{
			// Token: 0x0600CDDC RID: 52700 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400CE65 RID: 52837
			public HttpWebRequest request;

			// Token: 0x0400CE66 RID: 52838
			public Class2316.Class2322.Class2329 class2329_0;
		}
	}

	// Token: 0x02002832 RID: 10290
	[CompilerGenerated]
	private sealed class Class2331
	{
		// Token: 0x0600CDDF RID: 52703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400CE74 RID: 52852
		public CancellationTokenSource cancellationSource;
	}
}
