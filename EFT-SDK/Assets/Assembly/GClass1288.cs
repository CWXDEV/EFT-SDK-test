using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200115F RID: 4447
public class GClass1288
{
	// Token: 0x06005DE7 RID: 24039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterNestedType<T>() where T : struct, GInterface93
	{
		throw null;
	}

	// Token: 0x06005DE8 RID: 24040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterNestedType<T>(Func<T> constructor) where T : class, GInterface93
	{
		throw null;
	}

	// Token: 0x06005DE9 RID: 24041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterNestedType<T>(Action<GClass1286, T> writer, Func<GClass1284, T> reader)
	{
		throw null;
	}

	// Token: 0x06005DEA RID: 24042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass1288.Class862<T> method_0<T>()
	{
		throw null;
	}

	// Token: 0x06005DEB RID: 24043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register<T>()
	{
		throw null;
	}

	// Token: 0x06005DEC RID: 24044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Deserialize<T>(GClass1284 reader) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DED RID: 24045 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Deserialize<T>(GClass1284 reader, T target) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DEE RID: 24046 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize<T>(GClass1286 writer, T obj) where T : class, new()
	{
		throw null;
	}

	// Token: 0x06005DEF RID: 24047 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public byte[] Serialize<T>(T obj) where T : class, new()
	{
		throw null;
	}

	// Token: 0x040068EE RID: 26862
	private GClass1286 gclass1286_0;

	// Token: 0x040068EF RID: 26863
	private readonly int int_0;

	// Token: 0x040068F0 RID: 26864
	private readonly Dictionary<Type, GClass1288.Class863> dictionary_0;

	// Token: 0x02001160 RID: 4448
	private enum CallType
	{
		// Token: 0x040068F2 RID: 26866
		Basic,
		// Token: 0x040068F3 RID: 26867
		Array,
		// Token: 0x040068F4 RID: 26868
		List
	}

	// Token: 0x02001161 RID: 4449
	private abstract class Class840<T>
	{
		// Token: 0x06005DF0 RID: 24048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(MethodInfo getMethod, MethodInfo setMethod, GClass1288.CallType type)
		{
			throw null;
		}

		// Token: 0x06005DF1 RID: 24049
		public abstract void Read(T inf, GClass1284 r);

		// Token: 0x06005DF2 RID: 24050
		public abstract void Write(T inf, GClass1286 w);

		// Token: 0x06005DF3 RID: 24051
		public abstract void ReadArray(T inf, GClass1284 r);

		// Token: 0x06005DF4 RID: 24052
		public abstract void WriteArray(T inf, GClass1286 w);

		// Token: 0x06005DF5 RID: 24053
		public abstract void ReadList(T inf, GClass1284 r);

		// Token: 0x06005DF6 RID: 24054
		public abstract void WriteList(T inf, GClass1286 w);

		// Token: 0x040068F5 RID: 26869
		public GClass1288.CallType Type;
	}

	// Token: 0x02001162 RID: 4450
	private abstract class Class841<T, U> : GClass1288.Class840<T>
	{
		// Token: 0x06005DF7 RID: 24055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadList(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteList(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected U[] method_0(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected U[] method_1(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected List<U> method_2(T inf, GClass1284 r, out int len)
		{
			throw null;
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected List<U> method_3(T inf, GClass1286 w, out int len)
		{
			throw null;
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(MethodInfo getMethod, MethodInfo setMethod, GClass1288.CallType type)
		{
			throw null;
		}

		// Token: 0x040068F6 RID: 26870
		protected Func<T, U> func_0;

		// Token: 0x040068F7 RID: 26871
		protected Action<T, U> action_0;

		// Token: 0x040068F8 RID: 26872
		protected Func<T, U[]> func_1;

		// Token: 0x040068F9 RID: 26873
		protected Action<T, U[]> action_1;

		// Token: 0x040068FA RID: 26874
		protected Func<T, List<U>> func_2;

		// Token: 0x040068FB RID: 26875
		protected Action<T, List<U>> action_2;
	}

	// Token: 0x02001163 RID: 4451
	private abstract class Class842<T, U> : GClass1288.Class841<T, U>
	{
		// Token: 0x06005E00 RID: 24064
		protected abstract void vmethod_0(GClass1284 r, out U prop);

		// Token: 0x06005E01 RID: 24065
		protected abstract void vmethod_1(GClass1286 w, ref U prop);

		// Token: 0x06005E02 RID: 24066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001164 RID: 4452
	private sealed class Class845<T, U> : GClass1288.Class841<T, U>
	{
		// Token: 0x06005E06 RID: 24070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadList(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteList(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x040068FC RID: 26876
		private readonly Action<GClass1286, U> action_3;

		// Token: 0x040068FD RID: 26877
		private readonly Func<GClass1284, U> func_3;
	}

	// Token: 0x02001165 RID: 4453
	private sealed class Class846<T, U> : GClass1288.Class841<T, U> where U : struct, GInterface93
	{
		// Token: 0x06005E0C RID: 24076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadList(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteList(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x040068FE RID: 26878
		private U gparam_0;
	}

	// Token: 0x02001166 RID: 4454
	private sealed class Class847<T, U> : GClass1288.Class841<T, U> where U : class, GInterface93
	{
		// Token: 0x06005E12 RID: 24082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadList(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteList(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x040068FF RID: 26879
		private readonly Func<U> func_3;
	}

	// Token: 0x02001167 RID: 4455
	private class Class848<T> : GClass1288.Class841<T, int>
	{
		// Token: 0x06005E18 RID: 24088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001168 RID: 4456
	private class Class849<T> : GClass1288.Class841<T, uint>
	{
		// Token: 0x06005E1C RID: 24092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001169 RID: 4457
	private class Class850<T> : GClass1288.Class841<T, short>
	{
		// Token: 0x06005E20 RID: 24096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x0200116A RID: 4458
	private class Class851<T> : GClass1288.Class841<T, ushort>
	{
		// Token: 0x06005E24 RID: 24100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x0200116B RID: 4459
	private class Class852<T> : GClass1288.Class841<T, long>
	{
		// Token: 0x06005E28 RID: 24104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x0200116C RID: 4460
	private class Class853<T> : GClass1288.Class841<T, ulong>
	{
		// Token: 0x06005E2C RID: 24108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x0200116D RID: 4461
	private class Class854<T> : GClass1288.Class841<T, byte>
	{
		// Token: 0x06005E30 RID: 24112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x0200116E RID: 4462
	private class Class855<T> : GClass1288.Class841<T, sbyte>
	{
		// Token: 0x06005E34 RID: 24116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x0200116F RID: 4463
	private class Class856<T> : GClass1288.Class841<T, float>
	{
		// Token: 0x06005E38 RID: 24120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001170 RID: 4464
	private class Class857<T> : GClass1288.Class841<T, double>
	{
		// Token: 0x06005E3C RID: 24124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001171 RID: 4465
	private class Class858<T> : GClass1288.Class841<T, bool>
	{
		// Token: 0x06005E40 RID: 24128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001172 RID: 4466
	private class Class843<T> : GClass1288.Class842<T, char>
	{
		// Token: 0x06005E44 RID: 24132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_1(GClass1286 w, ref char prop)
		{
			throw null;
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0(GClass1284 r, out char prop)
		{
			throw null;
		}
	}

	// Token: 0x02001173 RID: 4467
	private class Class844<T> : GClass1288.Class842<T, IPEndPoint>
	{
		// Token: 0x06005E46 RID: 24134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_1(GClass1286 w, ref IPEndPoint prop)
		{
			throw null;
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void vmethod_0(GClass1284 r, out IPEndPoint prop)
		{
			throw null;
		}
	}

	// Token: 0x02001174 RID: 4468
	private class Class859<T> : GClass1288.Class841<T, string>
	{
		// Token: 0x06005E48 RID: 24136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x04006900 RID: 26880
		private readonly int int_0;
	}

	// Token: 0x02001175 RID: 4469
	private class Class860<T> : GClass1288.Class840<T>
	{
		// Token: 0x06005E4C RID: 24140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadArray(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteArray(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ReadList(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteList(T inf, GClass1286 w)
		{
			throw null;
		}

		// Token: 0x04006901 RID: 26881
		protected readonly PropertyInfo propertyInfo_0;

		// Token: 0x04006902 RID: 26882
		protected readonly Type type_0;
	}

	// Token: 0x02001176 RID: 4470
	private class Class861<T> : GClass1288.Class860<T>
	{
		// Token: 0x06005E52 RID: 24146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Read(T inf, GClass1284 r)
		{
			throw null;
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(T inf, GClass1286 w)
		{
			throw null;
		}
	}

	// Token: 0x02001177 RID: 4471
	private sealed class Class862<T>
	{
		// Token: 0x06005E54 RID: 24148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(T obj, GClass1286 writer)
		{
			throw null;
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Read(T obj, GClass1284 reader)
		{
			throw null;
		}

		// Token: 0x04006903 RID: 26883
		public static GClass1288.Class862<T> Instance;

		// Token: 0x04006904 RID: 26884
		private readonly GClass1288.Class840<T>[] class840_0;

		// Token: 0x04006905 RID: 26885
		private readonly int int_0;
	}

	// Token: 0x02001178 RID: 4472
	private abstract class Class863
	{
		// Token: 0x06005E56 RID: 24150
		public abstract GClass1288.Class840<T> Get<T>();
	}

	// Token: 0x02001179 RID: 4473
	private sealed class Class864<T> : GClass1288.Class863 where T : struct, GInterface93
	{
		// Token: 0x06005E57 RID: 24151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass1288.Class840<U> Get<U>()
		{
			throw null;
		}
	}

	// Token: 0x0200117A RID: 4474
	private sealed class Class865<T> : GClass1288.Class863 where T : class, GInterface93
	{
		// Token: 0x06005E58 RID: 24152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass1288.Class840<U> Get<U>()
		{
			throw null;
		}

		// Token: 0x04006906 RID: 26886
		private readonly Func<T> func_0;
	}

	// Token: 0x0200117B RID: 4475
	private sealed class Class866<T> : GClass1288.Class863
	{
		// Token: 0x06005E59 RID: 24153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass1288.Class840<U> Get<U>()
		{
			throw null;
		}

		// Token: 0x04006907 RID: 26887
		private readonly Action<GClass1286, T> action_0;

		// Token: 0x04006908 RID: 26888
		private readonly Func<GClass1284, T> func_0;
	}
}
