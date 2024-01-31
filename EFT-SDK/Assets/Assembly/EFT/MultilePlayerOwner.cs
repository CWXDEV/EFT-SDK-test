using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

namespace EFT
{
	// Token: 0x0200193F RID: 6463
	public class MultilePlayerOwner : InputNode
	{
		// Token: 0x06008ABD RID: 35517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MultilePlayerOwner smethod_0(Player[] players, GInterface155 inputTree)
		{
			throw null;
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008ABF RID: 35519 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface155 InputTree
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

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06008AC0 RID: 35520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008AC1 RID: 35521 RVA: 0x00002050 File Offset: 0x00000250
		private MultilePlayerOwner.EState State
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_0()
		{
			throw null;
		}

		// Token: 0x0400905B RID: 36955
		private List<ExtendedPlayerOwner> list_0;

		// Token: 0x0400905C RID: 36956
		[CompilerGenerated]
		private GInterface155 ginterface155_0;

		// Token: 0x0400905D RID: 36957
		[CompilerGenerated]
		private MultilePlayerOwner.EState estate_0;

		// Token: 0x02001940 RID: 6464
		protected enum EState
		{
			// Token: 0x0400905F RID: 36959
			None,
			// Token: 0x04009060 RID: 36960
			Started,
			// Token: 0x04009061 RID: 36961
			Stopped
		}
	}
}
