using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Diz.Utils
{
	// Token: 0x020030A7 RID: 12455
	public sealed class AsyncWorker : MonoBehaviour
	{
		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600F48C RID: 62604 RVA: 0x00002050 File Offset: 0x00000250
		private static GClass3258 GClass3258_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F48D RID: 62605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600F48E RID: 62606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600F48F RID: 62607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600F490 RID: 62608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600F491 RID: 62609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RunInMainTread(Action action)
		{
			throw null;
		}

		// Token: 0x0600F492 RID: 62610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task RunOnBackgroundThread(Action function)
		{
			throw null;
		}

		// Token: 0x0600F493 RID: 62611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<TResult> RunOnBackgroundThread<TResult>(Func<TResult> function)
		{
			throw null;
		}

		// Token: 0x0600F494 RID: 62612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CheckIsMainThread()
		{
			throw null;
		}

		// Token: 0x0400FA9C RID: 64156
		[CompilerGenerated]
		private static readonly GClass3258 gclass3258_0;

		// Token: 0x020030A8 RID: 12456
		[CompilerGenerated]
		private sealed class Class3134
		{
			// Token: 0x0600F495 RID: 62613 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_0()
			{
				throw null;
			}

			// Token: 0x0600F496 RID: 62614 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400FA9D RID: 64157
			public Action function;

			// Token: 0x0400FA9E RID: 64158
			public TaskCompletionSource<object> completionSource;

			// Token: 0x0400FA9F RID: 64159
			public Action action_0;
		}

		// Token: 0x020030A9 RID: 12457
		[CompilerGenerated]
		private sealed class Class3135
		{
			// Token: 0x0600F497 RID: 62615 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400FAA0 RID: 64160
			public Exception e;

			// Token: 0x0400FAA1 RID: 64161
			public AsyncWorker.Class3134 class3134_0;
		}

		// Token: 0x020030AA RID: 12458
		[CompilerGenerated]
		private sealed class Class3136<T>
		{
			// Token: 0x0600F498 RID: 62616 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Action method_0()
			{
				throw null;
			}

			// Token: 0x0400FAA2 RID: 64162
			public Func<T> function;

			// Token: 0x0400FAA3 RID: 64163
			public TaskCompletionSource<T> completionSource;
		}

		// Token: 0x020030AB RID: 12459
		[CompilerGenerated]
		private sealed class Class3137<T>
		{
			// Token: 0x0600F499 RID: 62617 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400FAA4 RID: 64164
			public T result;

			// Token: 0x0400FAA5 RID: 64165
			public AsyncWorker.Class3136<T> class3136_0;
		}

		// Token: 0x020030AC RID: 12460
		[CompilerGenerated]
		private sealed class Class3138<T>
		{
			// Token: 0x0600F49A RID: 62618 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400FAA6 RID: 64166
			public Exception e;

			// Token: 0x0400FAA7 RID: 64167
			public AsyncWorker.Class3136<T> class3136_0;
		}
	}
}
