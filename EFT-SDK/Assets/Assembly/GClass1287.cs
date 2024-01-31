using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001152 RID: 4434
public class GClass1287
{
	// Token: 0x06005DC1 RID: 24001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual ulong GetHash<T>()
	{
		throw null;
	}

	// Token: 0x06005DC2 RID: 24002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GClass1287.SubscribeDelegate GetCallbackFromData(GClass1284 reader)
	{
		throw null;
	}

	// Token: 0x06005DC3 RID: 24003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void WriteHash<T>(GClass1286 writer)
	{
		throw null;
	}

	// Token: 0x06005DC4 RID: 24004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterNestedType<T>() where T : struct, GInterface93
	{
		throw null;
	}

	// Token: 0x06005DC5 RID: 24005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterNestedType<T>(Action<GClass1286, T> writeDelegate, Func<GClass1284, T> readDelegate)
	{
		throw null;
	}

	// Token: 0x06005DC6 RID: 24006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterNestedType<T>(Func<T> constructor) where T : class, GInterface93
	{
		throw null;
	}

	// Token: 0x06005DC7 RID: 24007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadAllPackets(GClass1284 reader)
	{
		throw null;
	}

	// Token: 0x06005DC8 RID: 24008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadAllPackets(GClass1284 reader, object userData)
	{
		throw null;
	}

	// Token: 0x06005DC9 RID: 24009 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadPacket(GClass1284 reader)
	{
		throw null;
	}

	// Token: 0x06005DCA RID: 24010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send<T>(GClass1279 peer, T packet, DeliveryMethod options) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DCB RID: 24011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendNetSerializable<T>(GClass1279 peer, T packet, DeliveryMethod options) where T : GInterface93
	{
		throw null;
	}

	// Token: 0x06005DCC RID: 24012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send<T>(GClass1278 manager, T packet, DeliveryMethod options) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DCD RID: 24013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendNetSerializable<T>(GClass1278 manager, T packet, DeliveryMethod options) where T : GInterface93
	{
		throw null;
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Write<T>(GClass1286 writer, T packet) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteNetSerializable<T>(GClass1286 writer, T packet) where T : GInterface93
	{
		throw null;
	}

	// Token: 0x06005DD0 RID: 24016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Write<T>(T packet) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] WriteNetSerializable<T>(T packet) where T : GInterface93
	{
		throw null;
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadPacket(GClass1284 reader, object userData)
	{
		throw null;
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeReusable<T>(Action<T> onReceive) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DD7 RID: 24023 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : GInterface93
	{
		throw null;
	}

	// Token: 0x06005DD8 RID: 24024 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeNetSerializable<T>(Action<T> onReceive, Func<T> packetConstructor) where T : GInterface93
	{
		throw null;
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive) where T : GInterface93, new()
	{
		throw null;
	}

	// Token: 0x06005DDA RID: 24026 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeNetSerializable<T>(Action<T> onReceive) where T : GInterface93, new()
	{
		throw null;
	}

	// Token: 0x06005DDB RID: 24027 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveSubscription<T>()
	{
		throw null;
	}

	// Token: 0x040068D6 RID: 26838
	private readonly GClass1288 gclass1288_0;

	// Token: 0x040068D7 RID: 26839
	private readonly Dictionary<ulong, GClass1287.SubscribeDelegate> dictionary_0;

	// Token: 0x040068D8 RID: 26840
	private readonly GClass1286 gclass1286_0;

	// Token: 0x02001153 RID: 4435
	private static class Class831<T>
	{
		// Token: 0x040068D9 RID: 26841
		public static readonly ulong Id;
	}

	// Token: 0x02001154 RID: 4436
	// (Invoke) Token: 0x06005DDC RID: 24028
	protected delegate void SubscribeDelegate(GClass1284 reader, object userData);

	// Token: 0x02001155 RID: 4437
	[CompilerGenerated]
	private sealed class Class832<T> where T : class, new()
	{
		// Token: 0x06005DDF RID: 24031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068DA RID: 26842
		public Func<T> packetConstructor;

		// Token: 0x040068DB RID: 26843
		public GClass1287 gclass1287_0;

		// Token: 0x040068DC RID: 26844
		public Action<T> onReceive;
	}

	// Token: 0x02001156 RID: 4438
	[CompilerGenerated]
	private sealed class Class833<T, U> where T : class, new()
	{
		// Token: 0x06005DE0 RID: 24032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068DD RID: 26845
		public Func<T> packetConstructor;

		// Token: 0x040068DE RID: 26846
		public GClass1287 gclass1287_0;

		// Token: 0x040068DF RID: 26847
		public Action<T, U> onReceive;
	}

	// Token: 0x02001157 RID: 4439
	[CompilerGenerated]
	private sealed class Class834<T> where T : class, new()
	{
		// Token: 0x06005DE1 RID: 24033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068E0 RID: 26848
		public GClass1287 gclass1287_0;

		// Token: 0x040068E1 RID: 26849
		public T reference;

		// Token: 0x040068E2 RID: 26850
		public Action<T> onReceive;
	}

	// Token: 0x02001158 RID: 4440
	[CompilerGenerated]
	private sealed class Class835<T, U> where T : class, new()
	{
		// Token: 0x06005DE2 RID: 24034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068E3 RID: 26851
		public GClass1287 gclass1287_0;

		// Token: 0x040068E4 RID: 26852
		public T reference;

		// Token: 0x040068E5 RID: 26853
		public Action<T, U> onReceive;
	}

	// Token: 0x02001159 RID: 4441
	[CompilerGenerated]
	private sealed class Class836<T, U> where T : GInterface93
	{
		// Token: 0x06005DE3 RID: 24035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068E6 RID: 26854
		public Func<T> packetConstructor;

		// Token: 0x040068E7 RID: 26855
		public Action<T, U> onReceive;
	}

	// Token: 0x0200115A RID: 4442
	[CompilerGenerated]
	private sealed class Class837<T> where T : GInterface93
	{
		// Token: 0x06005DE4 RID: 24036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068E8 RID: 26856
		public Func<T> packetConstructor;

		// Token: 0x040068E9 RID: 26857
		public Action<T> onReceive;
	}

	// Token: 0x0200115B RID: 4443
	[CompilerGenerated]
	private sealed class Class838<T, U> where T : GInterface93, new()
	{
		// Token: 0x06005DE5 RID: 24037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068EA RID: 26858
		public T reference;

		// Token: 0x040068EB RID: 26859
		public Action<T, U> onReceive;
	}

	// Token: 0x0200115C RID: 4444
	[CompilerGenerated]
	private sealed class Class839<T> where T : GInterface93, new()
	{
		// Token: 0x06005DE6 RID: 24038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass1284 reader, object userData)
		{
			throw null;
		}

		// Token: 0x040068EC RID: 26860
		public T reference;

		// Token: 0x040068ED RID: 26861
		public Action<T> onReceive;
	}
}
