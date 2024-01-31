using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EFT;
using Microsoft.Extensions.ObjectPool;

// Token: 0x02000568 RID: 1384
internal sealed class DataHandler
{
	// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_0(IDictionary<string, string> responseHeaders)
	{
		throw null;
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] method_0(byte[] data, string encryption)
	{
		throw null;
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] smethod_1(byte[] cipherText, int cipherBytesLength, byte[] Key, byte[] IV)
	{
		throw null;
	}

	// Token: 0x1700062A RID: 1578
	// (get) Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime LastSucceedResponse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1400004F RID: 79
	// (add) Token: 0x06002158 RID: 8536 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002159 RID: 8537 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EBackendErrorCode, string> OnSessionError
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

	// Token: 0x14000050 RID: 80
	// (add) Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<ERequestErrorHandlingResult> OnErrorHandledWithResult
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

	// Token: 0x1700062B RID: 1579
	// (get) Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
	private Interface1 Interface1_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700062C RID: 1580
	// (get) Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
	private GClass557.GClass614 GClass614_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700062D RID: 1581
	// (get) Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
	public bool WebDiagnosticsEnabled
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

	// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> SendAndHandleRetries<T>(Class266 backRequest)
	{
		throw null;
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToString(IDictionary<string, string> responseHeaders, string separator = "\n")
	{
		throw null;
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<DataHandler.Struct22<T>> method_1<T>(Class266 backRequest)
	{
		throw null;
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<string, string> method_3(Class266 bRequest)
	{
		throw null;
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private T method_4<T>(Class266 backRequest, GClass556 backResponse)
	{
		throw null;
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_5(Class266 backRequest, GClass556 bResponse)
	{
		throw null;
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(IDictionary<string, string> responseHeaders)
	{
		throw null;
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private T method_7<T>(Class266 backRequest, string responseJsonText)
	{
		throw null;
	}

	// Token: 0x04001FEB RID: 8171
	private const int int_0 = 16;

	// Token: 0x04001FEC RID: 8172
	private static readonly byte[] byte_0;

	// Token: 0x04001FED RID: 8173
	private static readonly ObjectPool<byte[]> objectPool_0;

	// Token: 0x04001FEE RID: 8174
	private DateTime dateTime_0;

	// Token: 0x04001FEF RID: 8175
	[CompilerGenerated]
	private Action<EBackendErrorCode, string> action_0;

	// Token: 0x04001FF0 RID: 8176
	[CompilerGenerated]
	private Action<ERequestErrorHandlingResult> action_1;

	// Token: 0x04001FF1 RID: 8177
	private readonly bool bool_0;

	// Token: 0x04001FF2 RID: 8178
	private readonly GDelegate7 gdelegate7_0;

	// Token: 0x04001FF3 RID: 8179
	private StringBuilder stringBuilder_0;

	// Token: 0x04001FF4 RID: 8180
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x02000569 RID: 1385
	public class Class268 : IPooledObjectPolicy<byte[]>
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] Create()
		{
			throw null;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Return(byte[] obj)
		{
			throw null;
		}
	}

	// Token: 0x0200056A RID: 1386
	[StructLayout(LayoutKind.Auto)]
	public struct Struct22<T>
	{
		// Token: 0x04001FF5 RID: 8181
		public T ParsedObject;

		// Token: 0x04001FF6 RID: 8182
		public string ResponseText;
	}

	// Token: 0x0200056B RID: 1387
	[CompilerGenerated]
	private sealed class Class269<T>
	{
		// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ERequestErrorHandlingResult method_0(int code, string message)
		{
			throw null;
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ERequestErrorHandlingResult method_1(GException4 netwExc)
		{
			throw null;
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x04001FF7 RID: 8183
		public DataHandler class267_0;

		// Token: 0x04001FF8 RID: 8184
		public Class266 backRequest;
	}

	// Token: 0x0200056D RID: 1389
	[CompilerGenerated]
	private sealed class Class270
	{
		// Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(string current, KeyValuePair<string, string> item)
		{
			throw null;
		}

		// Token: 0x04002006 RID: 8198
		public string separator;
	}

	// Token: 0x0200056E RID: 1390
	[CompilerGenerated]
	private sealed class Class271<T>
	{
		// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal T method_0()
		{
			throw null;
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1()
		{
			throw null;
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal T method_2()
		{
			throw null;
		}

		// Token: 0x04002007 RID: 8199
		public Class266 backRequest;

		// Token: 0x04002008 RID: 8200
		public DataHandler class267_0;

		// Token: 0x04002009 RID: 8201
		public GClass556 responseData;

		// Token: 0x0400200A RID: 8202
		public string responseText;
	}

	// Token: 0x02000570 RID: 1392
	[CompilerGenerated]
	[Serializable]
	private sealed class Class272
	{
		// Token: 0x06002176 RID: 8566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04002015 RID: 8213
		public static readonly DataHandler.Class272 class272_0;

		// Token: 0x04002016 RID: 8214
		public static Action action_0;
	}
}
