using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001CA9 RID: 7337
internal abstract class Class1721 : IConnectionHandler
{
	// Token: 0x17001772 RID: 6002
	// (get) Token: 0x0600991D RID: 39197
	protected abstract string String_0 { get; }

	// Token: 0x17001773 RID: 6003
	// (get) Token: 0x0600991E RID: 39198 RVA: 0x00002050 File Offset: 0x00000250
	protected Action<long, byte[]> Action_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001774 RID: 6004
	// (get) Token: 0x0600991F RID: 39199 RVA: 0x00002050 File Offset: 0x00000250
	protected Action<long, string> Action_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001775 RID: 6005
	// (get) Token: 0x06009920 RID: 39200
	public abstract ENotificationTransportType TransportType { get; }

	// Token: 0x17001776 RID: 6006
	// (get) Token: 0x06009921 RID: 39201 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyDictionary<string, string> UriParams
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001777 RID: 6007
	// (get) Token: 0x06009922 RID: 39202 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyDictionary<string, string> RequestHeaders
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009923 RID: 39203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IConnectionHandler.SetUri(string uri)
	{
		throw null;
	}

	// Token: 0x06009924 RID: 39204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IConnectionHandler.SetUriParam(string key, string value)
	{
		throw null;
	}

	// Token: 0x06009925 RID: 39205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IConnectionHandler.SetRequestHeader(string key, string value)
	{
		throw null;
	}

	// Token: 0x06009926 RID: 39206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IConnectionHandler.Open(Action<long, byte[]> onMessage, Action<long, string> onError)
	{
		throw null;
	}

	// Token: 0x06009927 RID: 39207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IConnectionHandler.Close()
	{
		throw null;
	}

	// Token: 0x17001778 RID: 6008
	// (get) Token: 0x06009928 RID: 39208 RVA: 0x00002050 File Offset: 0x00000250
	public bool Closed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009929 RID: 39209
	protected abstract void vmethod_0();

	// Token: 0x0600992A RID: 39210
	protected abstract void vmethod_1();

	// Token: 0x0600992B RID: 39211 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Uri method_0()
	{
		throw null;
	}

	// Token: 0x0600992C RID: 39212 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static long smethod_0(string message)
	{
		throw null;
	}

	// Token: 0x0600992D RID: 39213 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static string smethod_1(IDictionary<string, string> responseHeaders)
	{
		throw null;
	}

	// Token: 0x0600992E RID: 39214 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void smethod_2(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600992F RID: 39215 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void smethod_3(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06009930 RID: 39216 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void smethod_4(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06009931 RID: 39217 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void smethod_5(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06009932 RID: 39218 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void smethod_6(Exception e)
	{
		throw null;
	}

	// Token: 0x06009933 RID: 39219 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(long code, byte[] data)
	{
		throw null;
	}

	// Token: 0x06009934 RID: 39220 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(long code, string error)
	{
		throw null;
	}

	// Token: 0x0400A088 RID: 41096
	protected const string string_0 = "STATUS";

	// Token: 0x0400A089 RID: 41097
	private string string_1;

	// Token: 0x0400A08A RID: 41098
	private readonly Dictionary<string, string> dictionary_0;

	// Token: 0x0400A08B RID: 41099
	private readonly Dictionary<string, string> dictionary_1;

	// Token: 0x0400A08C RID: 41100
	private Action<long, byte[]> action_0;

	// Token: 0x0400A08D RID: 41101
	private Action<long, string> action_1;

	// Token: 0x02001CAA RID: 7338
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1724
	{
		// Token: 0x06009935 RID: 39221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(KeyValuePair<string, string> pair)
		{
			throw null;
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(KeyValuePair<string, string> pair)
		{
			throw null;
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(KeyValuePair<string, string> pair)
		{
			throw null;
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3(KeyValuePair<string, string> pair)
		{
			throw null;
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_4(string current, KeyValuePair<string, string> pair)
		{
			throw null;
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_5(string current, KeyValuePair<string, string> item)
		{
			throw null;
		}

		// Token: 0x0400A08E RID: 41102
		public static readonly Class1721.Class1724 class1724_0;

		// Token: 0x0400A08F RID: 41103
		public static Func<KeyValuePair<string, string>, string> func_0;

		// Token: 0x0400A090 RID: 41104
		public static Func<KeyValuePair<string, string>, string> func_1;

		// Token: 0x0400A091 RID: 41105
		public static Func<KeyValuePair<string, string>, string> func_2;

		// Token: 0x0400A092 RID: 41106
		public static Func<KeyValuePair<string, string>, string> func_3;

		// Token: 0x0400A093 RID: 41107
		public static Func<string, KeyValuePair<string, string>, string> func_4;

		// Token: 0x0400A094 RID: 41108
		public static Func<string, KeyValuePair<string, string>, string> func_5;
	}
}
