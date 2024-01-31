using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InputSystem;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BB2 RID: 11186
	public sealed class CaptchaHandler : UIInputNode, GInterface143
	{
		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x0600DC92 RID: 56466 RVA: 0x00002050 File Offset: 0x00000250
		public CaptchaWindow CaptchaWindow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DC93 RID: 56467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(ISession session)
		{
			throw null;
		}

		// Token: 0x0600DC94 RID: 56468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			throw null;
		}

		// Token: 0x0600DC95 RID: 56469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		// Token: 0x0600DC96 RID: 56470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GInterface143.RequestCaptcha(object operation, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600DC97 RID: 56471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(object operation, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600DC98 RID: 56472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<ECaptchaResult>> RequestCaptcha()
		{
			throw null;
		}

		// Token: 0x0600DC99 RID: 56473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<Result<ECaptchaResult>> method_1()
		{
			throw null;
		}

		// Token: 0x0600DC9A RID: 56474 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<CaptchaHandler.Class2652<IEnumerable<string>>> method_2(string code, string title, string description, string[] items)
		{
			throw null;
		}

		// Token: 0x0600DC9B RID: 56475 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<Result<ECaptchaResult>> method_3(IEnumerable<string> items)
		{
			throw null;
		}

		// Token: 0x0600DC9C RID: 56476 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4(string errorMessage)
		{
			throw null;
		}

		// Token: 0x0600DC9D RID: 56477 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<CaptchaHandler.Class2652<T>> method_5<T>(Task<T> task)
		{
			throw null;
		}

		// Token: 0x0600DC9E RID: 56478 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DC9F RID: 56479 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0400E0DE RID: 57566
		private const string string_0 = "captcha/too frequent attempts";

		// Token: 0x0400E0DF RID: 57567
		[SerializeField]
		private CaptchaWindow _captchaWindow;

		// Token: 0x0400E0E0 RID: 57568
		[SerializeField]
		private GameObject _lockScreen;

		// Token: 0x0400E0E1 RID: 57569
		private Profile profile_0;

		// Token: 0x0400E0E2 RID: 57570
		private ISession ginterface145_0;

		// Token: 0x0400E0E3 RID: 57571
		private TraderControllerClass gclass2754_0;

		// Token: 0x0400E0E4 RID: 57572
		private bool bool_0;

		// Token: 0x0400E0E5 RID: 57573
		private bool bool_1;

		// Token: 0x0400E0E6 RID: 57574
		private string string_1;

		// Token: 0x0400E0E7 RID: 57575
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400E0E8 RID: 57576
		private GClass3087 gclass3087_0;

		// Token: 0x02002BB3 RID: 11187
		private sealed class Class2652<T>
		{
			// Token: 0x1700269F RID: 9887
			// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x00002050 File Offset: 0x00000250
			public static CaptchaHandler.Class2652<T> CancelledResult
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600DCA3 RID: 56483 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool TryGetResult(out T result)
			{
				throw null;
			}

			// Token: 0x0400E0E9 RID: 57577
			private readonly T gparam_0;

			// Token: 0x0400E0EA RID: 57578
			public readonly bool Cancelled;
		}

		// Token: 0x02002BB7 RID: 11191
		[CompilerGenerated]
		private sealed class Class2653
		{
			// Token: 0x0600DCAA RID: 56490 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(List<string> resultItems)
			{
				throw null;
			}

			// Token: 0x0600DCAB RID: 56491 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400E0FF RID: 57599
			public TaskCompletionSource<IEnumerable<string>> captchaWindowTaskSource;

			// Token: 0x0400E100 RID: 57600
			public CancellationTokenSource cancellationSourceCache;
		}

		// Token: 0x02002BB8 RID: 11192
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2654
		{
			// Token: 0x0600DCAC RID: 56492 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(string item)
			{
				throw null;
			}

			// Token: 0x0400E101 RID: 57601
			public static readonly CaptchaHandler.Class2654 class2654_0;

			// Token: 0x0400E102 RID: 57602
			public static Func<string, Item> func_0;
		}

		// Token: 0x02002BBB RID: 11195
		[CompilerGenerated]
		private sealed class Class2655
		{
			// Token: 0x0600DCB1 RID: 56497 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E114 RID: 57620
			public TaskCompletionSource<bool> messageTaskSource;
		}
	}
}
