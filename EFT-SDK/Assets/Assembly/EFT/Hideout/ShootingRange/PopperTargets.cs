using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C6B RID: 7275
	[Serializable]
	public class PopperTargets : MonoBehaviour
	{
		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x060097EB RID: 38891 RVA: 0x00002050 File Offset: 0x00000250
		public PopperTarget[] Targets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x060097EC RID: 38892 RVA: 0x00002050 File Offset: 0x00000250
		public int Cols
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140001C4 RID: 452
		// (add) Token: 0x060097ED RID: 38893 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060097EE RID: 38894 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PopperTarget, int> OnHitTarget
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

		// Token: 0x060097EF RID: 38895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnEnable()
		{
			throw null;
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnDisable()
		{
			throw null;
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(PopperTarget target, int segmentTarget)
		{
			throw null;
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Fold(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Fold(GInterface176 target, bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task[] method_1(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unfold(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unfold(GInterface176 target, bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task[] method_2(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x04009F5D RID: 40797
		[SerializeField]
		private int _rows;

		// Token: 0x04009F5E RID: 40798
		[SerializeField]
		private int _cols;

		// Token: 0x04009F5F RID: 40799
		[SerializeField]
		[Space]
		private PopperTarget[] _targets;

		// Token: 0x04009F60 RID: 40800
		[SerializeField]
		[Space]
		private AudioSource _foldAudio;

		// Token: 0x04009F61 RID: 40801
		[SerializeField]
		private AudioSource _unfoldAudio;

		// Token: 0x04009F62 RID: 40802
		private CancellationTokenSource _cancellationToken;

		// Token: 0x02001C6C RID: 7276
		[CompilerGenerated]
		private sealed class Class1704
		{
			// Token: 0x060097FB RID: 38907 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0(PopperTarget target)
			{
				throw null;
			}

			// Token: 0x04009F64 RID: 40804
			public PopperTargets popperTargets_0;

			// Token: 0x04009F65 RID: 40805
			public CancellationToken token;
		}

		// Token: 0x02001C6D RID: 7277
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1705
		{
			// Token: 0x060097FC RID: 38908 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(PopperTarget target)
			{
				throw null;
			}

			// Token: 0x060097FD RID: 38909 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(PopperTarget target)
			{
				throw null;
			}

			// Token: 0x04009F66 RID: 40806
			public static readonly PopperTargets.Class1705 class1705_0;

			// Token: 0x04009F67 RID: 40807
			public static Func<PopperTarget, bool> func_0;

			// Token: 0x04009F68 RID: 40808
			public static Func<PopperTarget, bool> func_1;
		}

		// Token: 0x02001C6E RID: 7278
		[CompilerGenerated]
		private sealed class Class1706
		{
			// Token: 0x060097FE RID: 38910 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0(PopperTarget target)
			{
				throw null;
			}

			// Token: 0x04009F69 RID: 40809
			public PopperTargets popperTargets_0;

			// Token: 0x04009F6A RID: 40810
			public CancellationToken token;
		}
	}
}
