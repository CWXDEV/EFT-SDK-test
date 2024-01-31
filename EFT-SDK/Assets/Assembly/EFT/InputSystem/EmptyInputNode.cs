using System;
using System.Runtime.CompilerServices;

namespace EFT.InputSystem
{
	// Token: 0x02001A2C RID: 6700
	public class EmptyInputNode : InputNode
	{
		// Token: 0x06008DFC RID: 36348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddChildNode(InputNode node)
		{
			throw null;
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveChildNode(InputNode node)
		{
			throw null;
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}
	}
}
