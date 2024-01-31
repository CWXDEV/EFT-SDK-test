using System;
using System.Runtime.CompilerServices;

// Token: 0x0200319B RID: 12699
internal abstract class Class3210
{
	// Token: 0x140003B9 RID: 953
	// (add) Token: 0x0600FA48 RID: 64072 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600FA49 RID: 64073 RVA: 0x00002050 File Offset: 0x00000250
	public event EventHandler DataStructureChanged
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

	// Token: 0x140003BA RID: 954
	// (add) Token: 0x0600FA4A RID: 64074 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600FA4B RID: 64075 RVA: 0x00002050 File Offset: 0x00000250
	public event EventHandler<Class3210.EventArgs0> DataValueChanged
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

	// Token: 0x0600FA4C RID: 64076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0()
	{
		throw null;
	}

	// Token: 0x0600FA4D RID: 64077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(Class3210.EventArgs0 data)
	{
		throw null;
	}

	// Token: 0x0600FA4E RID: 64078
	public abstract double[,] getRawData();

	// Token: 0x17002B47 RID: 11079
	// (get) Token: 0x0600FA4F RID: 64079
	public abstract Class3196 Columns { get; }

	// Token: 0x17002B48 RID: 11080
	// (get) Token: 0x0600FA50 RID: 64080
	public abstract Class3197 Rows { get; }

	// Token: 0x0400FE4B RID: 65099
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x0400FE4C RID: 65100
	[CompilerGenerated]
	private EventHandler<Class3210.EventArgs0> eventHandler_1;

	// Token: 0x0200319C RID: 12700
	public class EventArgs0 : EventArgs
	{
		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600FA51 RID: 64081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA52 RID: 64082 RVA: 0x00002050 File Offset: 0x00000250
		public Struct1049 ItemIndex
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600FA53 RID: 64083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA54 RID: 64084 RVA: 0x00002050 File Offset: 0x00000250
		public double OldValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600FA55 RID: 64085 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA56 RID: 64086 RVA: 0x00002050 File Offset: 0x00000250
		public double NewValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0600FA57 RID: 64087 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA58 RID: 64088 RVA: 0x00002050 File Offset: 0x00000250
		public bool MinMaxChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0400FE4D RID: 65101
		[CompilerGenerated]
		private Struct1049 struct1049_0;

		// Token: 0x0400FE4E RID: 65102
		[CompilerGenerated]
		private double double_0;

		// Token: 0x0400FE4F RID: 65103
		[CompilerGenerated]
		private double double_1;

		// Token: 0x0400FE50 RID: 65104
		[CompilerGenerated]
		private bool bool_0;
	}
}
