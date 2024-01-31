using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C67 RID: 7271
	[RequireComponent(typeof(FoldingPopperTarget))]
	public class PopperTarget : MonoBehaviour, GInterface176
	{
		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x060097D3 RID: 38867 RVA: 0x00002050 File Offset: 0x00000250
		public int Row
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060097D4 RID: 38868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x060097D5 RID: 38869 RVA: 0x00002050 File Offset: 0x00000250
		public bool Unfolded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x060097D6 RID: 38870 RVA: 0x00002050 File Offset: 0x00000250
		public bool Folded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x060097D7 RID: 38871 RVA: 0x00002050 File Offset: 0x00000250
		public bool Ready
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x060097D8 RID: 38872 RVA: 0x00002050 File Offset: 0x00000250
		public float ReadyTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140001C3 RID: 451
		// (add) Token: 0x060097D9 RID: 38873 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060097DA RID: 38874 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x060097DB RID: 38875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnEnable()
		{
			throw null;
		}

		// Token: 0x060097DC RID: 38876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnDisable()
		{
			throw null;
		}

		// Token: 0x060097DD RID: 38877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(TargetColliderType targetColliderType, int segmentTarget)
		{
			throw null;
		}

		// Token: 0x060097DE RID: 38878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Fold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Unfold(bool mute, CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Rocking(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x04009F4C RID: 40780
		[SerializeField]
		private int _row;

		// Token: 0x04009F4D RID: 40781
		[SerializeField]
		[Space]
		private PaperTarget _paperTarget;

		// Token: 0x04009F4E RID: 40782
		private FoldingPopperTarget _foldingPopperTarget;

		// Token: 0x04009F50 RID: 40784
		private CancellationTokenSource _cancellationToken;
	}
}
