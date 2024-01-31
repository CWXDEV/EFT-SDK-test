using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

// Token: 0x0200311E RID: 12574
public sealed class DependencyGraph<T> where T : GInterface395
{
	// Token: 0x0600F67F RID: 63103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DependencyGraph<T>.GClass3388 Retain(string key, [CanBeNull] IProgress<float> progress = null)
	{
		throw null;
	}

	// Token: 0x0600F680 RID: 63104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(GClass3389<T> node, List<GClass3389<T>> nodes)
	{
		throw null;
	}

	// Token: 0x0600F681 RID: 63105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task smethod_1(GClass3389<T> node, List<GClass3389<T>> nodes, CancellationToken ct)
	{
		throw null;
	}

	// Token: 0x0600F682 RID: 63106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DependencyGraph<T>.GClass3388 Retain(IEnumerable<string> keys, [CanBeNull] IProgress<float> progress, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x0600F683 RID: 63107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DependencyGraph<T>.GClass3387 RetainSeparate(IEnumerable<string> keys, [CanBeNull] IProgress<float> progress, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x0600F684 RID: 63108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<DependencyGraph<T>.GClass3387> RetainSeparateAsync(IEnumerable<string> keys, [CanBeNull] IProgress<float> progress, CancellationToken ct = default(CancellationToken))
	{
		throw null;
	}

	// Token: 0x0600F685 RID: 63109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(ICollection<GClass3389<T>> nodes)
	{
		throw null;
	}

	// Token: 0x0600F686 RID: 63110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2(List<GClass3389<T>> input, List<GClass3389<T>> temp, List<GClass3389<T>> output, [CanBeNull] Func<string, bool> shouldExclude)
	{
		throw null;
	}

	// Token: 0x0600F687 RID: 63111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_3(List<GClass3389<T>> retains, List<GClass3389<T>> releases, List<GClass3389<T>> refCountChanges)
	{
		throw null;
	}

	// Token: 0x0600F688 RID: 63112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_4(List<GClass3389<T>> refCountChanges, List<GClass3389<T>> pendingLoads, List<GClass3389<T>> pendingUnloads)
	{
		throw null;
	}

	// Token: 0x0600F689 RID: 63113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_5(List<GClass3389<T>> pendingLoads)
	{
		throw null;
	}

	// Token: 0x0600F68A RID: 63114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_6(List<GClass3389<T>> pendingUnloads, List<GClass3389<T>> refCountChanges)
	{
		throw null;
	}

	// Token: 0x0600F68B RID: 63115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x0600F68C RID: 63116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3389<T> GetNode(string key)
	{
		throw null;
	}

	// Token: 0x0600F68D RID: 63117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass3389<T> GetDefaultNode()
	{
		throw null;
	}

	// Token: 0x0400FC00 RID: 64512
	public readonly Dictionary<string, GClass3389<T>> Nodes;

	// Token: 0x0400FC01 RID: 64513
	private readonly string string_0;

	// Token: 0x0400FC02 RID: 64514
	private static int int_0;

	// Token: 0x0400FC03 RID: 64515
	private static int int_1;

	// Token: 0x0400FC04 RID: 64516
	private readonly List<DependencyGraph<T>.GClass3386> list_0;

	// Token: 0x0400FC05 RID: 64517
	private readonly List<DependencyGraph<T>.GClass3386> list_1;

	// Token: 0x0400FC06 RID: 64518
	private readonly List<GClass3389<T>> list_2;

	// Token: 0x0400FC07 RID: 64519
	private readonly List<GClass3389<T>> list_3;

	// Token: 0x0400FC08 RID: 64520
	private readonly List<GClass3389<T>> list_4;

	// Token: 0x0400FC09 RID: 64521
	private readonly List<GClass3389<T>> list_5;

	// Token: 0x0400FC0A RID: 64522
	private readonly List<GClass3389<T>> list_6;

	// Token: 0x0200311F RID: 12575
	public abstract class GClass3386
	{
		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600F68E RID: 63118 RVA: 0x00002050 File Offset: 0x00000250
		public Task LoadingJob
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600F68F RID: 63119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F690 RID: 63120 RVA: 0x00002050 File Offset: 0x00000250
		public bool Finished
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0600F691 RID: 63121 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F692 RID: 63122 RVA: 0x00002050 File Offset: 0x00000250
		public float Progress
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0600F693 RID: 63123 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F694 RID: 63124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release()
		{
			throw null;
		}

		// Token: 0x0600F695 RID: 63125
		protected abstract void ReleaseInternal();

		// Token: 0x0600F696 RID: 63126
		internal abstract void vmethod_0();

		// Token: 0x0400FC0B RID: 64523
		protected readonly TaskCompletionSource<object> taskCompletionSource_0;

		// Token: 0x0400FC0C RID: 64524
		[CanBeNull]
		protected IProgress<float> iprogress_0;

		// Token: 0x0400FC0D RID: 64525
		protected bool bool_0;

		// Token: 0x0400FC0E RID: 64526
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400FC0F RID: 64527
		[CompilerGenerated]
		private float float_0;
	}

	// Token: 0x02003120 RID: 12576
	public sealed class GClass3387 : DependencyGraph<T>.GClass3386
	{
		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0600F697 RID: 63127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F698 RID: 63128 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<string, DependencyGraph<T>.GClass3388> TokenDict
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

		// Token: 0x0600F699 RID: 63129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReleaseInternal()
		{
			throw null;
		}

		// Token: 0x0600F69A RID: 63130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_0()
		{
			throw null;
		}

		// Token: 0x0400FC10 RID: 64528
		private CancellationToken cancellationToken_0;

		// Token: 0x0400FC11 RID: 64529
		[CompilerGenerated]
		private Dictionary<string, DependencyGraph<T>.GClass3388> dictionary_0;

		// Token: 0x0400FC12 RID: 64530
		private readonly HashSet<GClass3389<T>> hashSet_0;

		// Token: 0x02003121 RID: 12577
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3175
		{
			// Token: 0x0600F69B RID: 63131 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(DependencyGraph<T>.GClass3388 x)
			{
				throw null;
			}

			// Token: 0x0400FC13 RID: 64531
			public static readonly DependencyGraph<T>.GClass3387.Class3175 class3175_0;

			// Token: 0x0400FC14 RID: 64532
			public static Action<DependencyGraph<T>.GClass3388> action_0;
		}
	}

	// Token: 0x02003122 RID: 12578
	public sealed class GClass3388 : DependencyGraph<T>.GClass3386
	{
		// Token: 0x0600F69C RID: 63132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReleaseInternal()
		{
			throw null;
		}

		// Token: 0x0600F69D RID: 63133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_0()
		{
			throw null;
		}

		// Token: 0x0600F69E RID: 63134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400FC15 RID: 64533
		internal readonly List<GClass3389<T>> list_0;

		// Token: 0x0400FC16 RID: 64534
		internal readonly CancellationToken cancellationToken_0;

		// Token: 0x0400FC17 RID: 64535
		private readonly DependencyGraph<T> gclass3385_0;

		// Token: 0x02003123 RID: 12579
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3176
		{
			// Token: 0x0600F69F RID: 63135 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(GClass3389<T> node)
			{
				throw null;
			}

			// Token: 0x0400FC18 RID: 64536
			public static readonly DependencyGraph<T>.GClass3388.Class3176 class3176_0;

			// Token: 0x0400FC19 RID: 64537
			public static Func<GClass3389<T>, string> func_0;
		}
	}

	// Token: 0x02003124 RID: 12580
	[CompilerGenerated]
	private sealed class Class3177
	{
		// Token: 0x0400FC1A RID: 64538
		public Func<string, bool> shouldExclude;

		// Token: 0x0400FC1B RID: 64539
		public DependencyGraph<T> gclass3385_0;
	}

	// Token: 0x02003125 RID: 12581
	[CompilerGenerated]
	private sealed class Class3178
	{
		// Token: 0x0600F6A0 RID: 63136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass3389<T>> method_0(string x)
		{
			throw null;
		}

		// Token: 0x0400FC1C RID: 64540
		public T loadable;

		// Token: 0x0400FC1D RID: 64541
		public DependencyGraph<T>.Class3177 class3177_0;
	}
}
