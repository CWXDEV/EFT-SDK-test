using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x02002232 RID: 8754
public class GClass2477<T> : IEnumerable, ICollection, IEnumerable<T>, IReadOnlyCollection<T>, IProducerConsumerCollection<T>
{
	// Token: 0x0600B29A RID: 45722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(IEnumerable<T> collection)
	{
		throw null;
	}

	// Token: 0x0600B29B RID: 45723 RVA: 0x00002050 File Offset: 0x00000250
	[OnSerializing]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x0600B29C RID: 45724 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x0600B29D RID: 45725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void ICollection.CopyTo(Array array, int index)
	{
		throw null;
	}

	// Token: 0x17001DF1 RID: 7665
	// (get) Token: 0x0600B29E RID: 45726 RVA: 0x00002050 File Offset: 0x00000250
	bool ICollection.IsSynchronized
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001DF2 RID: 7666
	// (get) Token: 0x0600B29F RID: 45727 RVA: 0x00002050 File Offset: 0x00000250
	object ICollection.SyncRoot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B2A0 RID: 45728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x17001DF3 RID: 7667
	// (get) Token: 0x0600B2A1 RID: 45729 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B2A2 RID: 45730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T[] ToArray()
	{
		throw null;
	}

	public bool TryAdd(T item)
	{
		throw new NotImplementedException();
	}

	public bool TryTake(out T item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600B2A3 RID: 45731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<T> method_3()
	{
		throw null;
	}

	// Token: 0x0600B2A4 RID: 45732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(out GClass2477<T>.GClass2478 head, out GClass2477<T>.GClass2478 tail, out int headLow, out int tailHigh)
	{
		throw null;
	}

	// Token: 0x17001DF4 RID: 7668
	// (get) Token: 0x0600B2A5 RID: 45733 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B2A6 RID: 45734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(T[] array, int index)
	{
		throw null;
	}

	// Token: 0x0600B2A7 RID: 45735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600B2A8 RID: 45736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator<T> method_5(GClass2477<T>.GClass2478 head, GClass2477<T>.GClass2478 tail, int headLow, int tailHigh)
	{
		throw null;
	}

	// Token: 0x0600B2A9 RID: 45737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enqueue(T item)
	{
		throw null;
	}

	// Token: 0x0600B2AA RID: 45738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryDequeue(out T result)
	{
		throw null;
	}

	// Token: 0x0600B2AB RID: 45739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryPeek(out T result)
	{
		throw null;
	}

	// Token: 0x0400B70C RID: 46860
	[NonSerialized]
	public volatile GClass2477<T>.GClass2478 m_head;

	// Token: 0x0400B70D RID: 46861
	[NonSerialized]
	public volatile GClass2477<T>.GClass2478 m_tail;

	// Token: 0x0400B70E RID: 46862
	private T[] gparam_0;

	// Token: 0x0400B70F RID: 46863
	private const int int_0 = 32;

	// Token: 0x0400B710 RID: 46864
	[NonSerialized]
	internal volatile int int_1;

	// Token: 0x0400B711 RID: 46865
	internal GClass2477<T>.Class1928<GClass2477<T>.GClass2478> class1928_0;

	// Token: 0x02002233 RID: 8755
	public class GClass2478
	{
		// Token: 0x0600B2AC RID: 45740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(long index, GClass2477<T> source)
		{
			throw null;
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x00002050 File Offset: 0x00000250
		internal GClass2477<T>.GClass2478 GClass2478_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600B2AE RID: 45742 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(T value)
		{
			throw null;
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2477<T>.GClass2478 method_1()
		{
			throw null;
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(T value)
		{
			throw null;
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(out T result)
		{
			throw null;
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_5(out T result)
		{
			throw null;
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_6(List<T> list, int start, int end)
		{
			throw null;
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600B2B6 RID: 45750 RVA: 0x00002050 File Offset: 0x00000250
		internal int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x00002050 File Offset: 0x00000250
		internal int Int32_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400B712 RID: 46866
		internal volatile T[] gparam_0;

		// Token: 0x0400B713 RID: 46867
		internal volatile GClass2477<T>.Struct736[] struct736_0;

		// Token: 0x0400B714 RID: 46868
		private volatile GClass2477<T>.GClass2478 gclass2478_0;

		// Token: 0x0400B715 RID: 46869
		public long m_index;

		// Token: 0x0400B716 RID: 46870
		private volatile int int_0;

		// Token: 0x0400B717 RID: 46871
		private volatile int int_1;

		// Token: 0x0400B718 RID: 46872
		private volatile GClass2477<T> gclass2477_0;
	}

	// Token: 0x02002234 RID: 8756
	[StructLayout(LayoutKind.Auto)]
	public struct Struct736
	{
		// Token: 0x0400B719 RID: 46873
		public volatile bool m_value;
	}

	// Token: 0x02002235 RID: 8757
	internal class Class1928<U>
	{
		// Token: 0x0600B2B8 RID: 45752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public U Get()
		{
			throw null;
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Return(U item)
		{
			throw null;
		}

		// Token: 0x0400B71A RID: 46874
		private readonly ConcurrentBag<U> concurrentBag_0;

		// Token: 0x0400B71B RID: 46875
		private readonly Func<U> func_0;
	}

	// Token: 0x02002236 RID: 8758
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1929
	{
		// Token: 0x0600B2BA RID: 45754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2477<T>.GClass2478 method_0()
		{
			throw null;
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2477<T>.GClass2478 method_1()
		{
			throw null;
		}

		// Token: 0x0400B71C RID: 46876
		public static readonly GClass2477<T>.Class1929 class1929_0;

		// Token: 0x0400B71D RID: 46877
		public static Func<GClass2477<T>.GClass2478> func_0;

		// Token: 0x0400B71E RID: 46878
		public static Func<GClass2477<T>.GClass2478> func_1;
	}
}
