using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x020014AD RID: 5293
	[Serializable]
	public struct MongoID : IComparable<MongoID>, IEquatable<MongoID>
	{
		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06007198 RID: 29080 RVA: 0x00002050 File Offset: 0x00000250
		public static uint TimeStamp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x00002050 File Offset: 0x00000250
		private static ulong UInt64_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string Generate()
		{
			throw null;
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(uint timeStamp, ulong counter)
		{
			throw null;
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static uint ConvertTimeStamp(string id)
		{
			throw null;
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ulong ConvertCounter(string id)
		{
			throw null;
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MongoID Next()
		{
			throw null;
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MongoID Read(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MongoID Read(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x060071A3 RID: 29091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Write(GClass1078 writer, string id)
		{
			throw null;
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string Read(GClass1073 reader)
		{
			throw null;
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MongoID other)
		{
			throw null;
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(MongoID other)
		{
			throw null;
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_1()
		{
			throw null;
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060071AA RID: 29098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToBytes()
		{
			throw null;
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04007841 RID: 30785
		private static Random _random;

		// Token: 0x04007842 RID: 30786
		private static readonly ulong _processId;

		// Token: 0x04007843 RID: 30787
		private static uint _newIdCounter;

		// Token: 0x04007844 RID: 30788
		private readonly uint _timeStamp;

		// Token: 0x04007845 RID: 30789
		private readonly ulong _counter;

		// Token: 0x04007846 RID: 30790
		private readonly string _stringID;

		// Token: 0x04007847 RID: 30791
		public static string Default;
	}
}
