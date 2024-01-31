using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Networking;

// Token: 0x020014BF RID: 5311
public class GClass1638
{
	// Token: 0x060071D5 RID: 29141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Cleanup()
	{
		throw null;
	}

	// Token: 0x060071D6 RID: 29142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddHandler(short command, Action<NetworkConnection, NetworkReader> handler)
	{
		throw null;
	}

	// Token: 0x060071D7 RID: 29143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveHandler(short command)
	{
		throw null;
	}

	// Token: 0x060071D8 RID: 29144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(NetworkConnection[] destination, short commandKey, byte[] data)
	{
		throw null;
	}

	// Token: 0x060071D9 RID: 29145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(NetworkConnection[] destination, short commandKey, byte[] data, int count)
	{
		throw null;
	}

	// Token: 0x060071DA RID: 29146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(NetworkConnection[] destination, short commandKey, byte[] data, int offset, int count)
	{
		throw null;
	}

	// Token: 0x060071DB RID: 29147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060071DC RID: 29148 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(NetworkConnection connection, int id)
	{
		throw null;
	}

	// Token: 0x060071DD RID: 29149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(NetworkConnection connection, int id)
	{
		throw null;
	}

	// Token: 0x060071DE RID: 29150 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(NetworkConnection connection, int id)
	{
		throw null;
	}

	// Token: 0x060071DF RID: 29151 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPartialCommand(NetworkMessage message)
	{
		throw null;
	}

	// Token: 0x060071E0 RID: 29152 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(ValueTuple<NetworkConnection, int> deliveryKey)
	{
		throw null;
	}

	// Token: 0x060071E1 RID: 29153 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(NetworkConnection connection, int id, short commandKey, byte[] buffer)
	{
		throw null;
	}

	// Token: 0x04007872 RID: 30834
	public const short MsgPartialCommand = 185;

	// Token: 0x04007873 RID: 30835
	public const short MAX_RESEND_COUNT = 2;

	// Token: 0x04007874 RID: 30836
	private static readonly TimeSpan timeSpan_0;

	// Token: 0x04007875 RID: 30837
	private static readonly TimeSpan timeSpan_1;

	// Token: 0x04007876 RID: 30838
	private const ushort ushort_0 = 32767;

	// Token: 0x04007877 RID: 30839
	private readonly NetworkWriter networkWriter_0;

	// Token: 0x04007878 RID: 30840
	private int int_0;

	// Token: 0x04007879 RID: 30841
	private readonly Dictionary<ValueTuple<NetworkConnection, int>, GClass1638.Struct233> dictionary_0;

	// Token: 0x0400787A RID: 30842
	private readonly Dictionary<ValueTuple<NetworkConnection, int>, GClass1638.Struct232> dictionary_1;

	// Token: 0x0400787B RID: 30843
	private readonly byte[] byte_0;

	// Token: 0x0400787C RID: 30844
	private readonly Dictionary<short, Action<NetworkConnection, NetworkReader>> dictionary_2;

	// Token: 0x0400787D RID: 30845
	private readonly HashSet<int> hashSet_0;

	// Token: 0x0400787E RID: 30846
	private GClass1638.GClass626 gclass626_0;

	// Token: 0x0400787F RID: 30847
	private readonly List<ValueTuple<NetworkConnection, int>> list_0;

	// Token: 0x020014C0 RID: 5312
	private enum EIncomeMessageType : byte
	{
		// Token: 0x04007881 RID: 30849
		DataBegin,
		// Token: 0x04007882 RID: 30850
		Data,
		// Token: 0x04007883 RID: 30851
		Confirm,
		// Token: 0x04007884 RID: 30852
		Retry
	}

	// Token: 0x020014C1 RID: 5313
	public sealed class GClass626 : LoggerClass
	{
	}

	// Token: 0x020014C2 RID: 5314
	[StructLayout(LayoutKind.Auto)]
	public struct Struct229
	{
		// Token: 0x060071E2 RID: 29154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x04007885 RID: 30853
		public short CommandKey;

		// Token: 0x04007886 RID: 30854
		public int Id;

		// Token: 0x04007887 RID: 30855
		public byte PartNum;

		// Token: 0x04007888 RID: 30856
		public int Offset;

		// Token: 0x04007889 RID: 30857
		public byte PartsCount;

		// Token: 0x0400788A RID: 30858
		public int Size;

		// Token: 0x0400788B RID: 30859
		public ushort PartSize;

		// Token: 0x0400788C RID: 30860
		public ArraySegment<byte> BufferLink;
	}

	// Token: 0x020014C3 RID: 5315
	[StructLayout(LayoutKind.Auto)]
	public struct Struct230
	{
		// Token: 0x060071E3 RID: 29155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0400788D RID: 30861
		public int Id;
	}

	// Token: 0x020014C4 RID: 5316
	[StructLayout(LayoutKind.Auto)]
	public struct Struct231
	{
		// Token: 0x060071E4 RID: 29156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x0400788E RID: 30862
		public int Id;
	}

	// Token: 0x020014C5 RID: 5317
	[StructLayout(LayoutKind.Auto)]
	public struct Struct232
	{
		// Token: 0x0400788F RID: 30863
		public short CommandKey;

		// Token: 0x04007890 RID: 30864
		public long ReceivedParts1;

		// Token: 0x04007891 RID: 30865
		public long ReceivedParts2;

		// Token: 0x04007892 RID: 30866
		public long TotalReceivedParts1;

		// Token: 0x04007893 RID: 30867
		public long TotalReceivedParts2;

		// Token: 0x04007894 RID: 30868
		public byte[] Data;

		// Token: 0x04007895 RID: 30869
		public DateTime LastDataTime;
	}

	// Token: 0x020014C6 RID: 5318
	[StructLayout(LayoutKind.Auto)]
	public struct Struct233 : IDisposable
	{
		// Token: 0x060071E5 RID: 29157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04007896 RID: 30870
		public short CommandKey;

		// Token: 0x04007897 RID: 30871
		public byte[] Data;

		// Token: 0x04007898 RID: 30872
		public DateTime LastDataTime;

		// Token: 0x04007899 RID: 30873
		public int ResendCount;
	}
}
