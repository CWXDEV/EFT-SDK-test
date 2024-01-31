using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.InputSystem
{
	// Token: 0x02001A5A RID: 6746
	public abstract class InputNode : InputNodeAbstract
	{
		// Token: 0x06008E85 RID: 36485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecacheChildren()
		{
			throw null;
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateInput(List<ECommand> commands, ref float[] axes, ref ECursorResult shouldLockCursor)
		{
			throw null;
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static InputNode.ETranslateResult GetDefaultBlockResult(ECommand command)
		{
			throw null;
		}

		// Token: 0x06008E88 RID: 36488
		protected abstract InputNode.ETranslateResult TranslateCommand(ECommand command);

		// Token: 0x06008E89 RID: 36489
		protected abstract void TranslateAxes(ref float[] axes);

		// Token: 0x06008E8A RID: 36490
		protected abstract ECursorResult ShouldLockCursor();

		// Token: 0x040095CD RID: 38349
		private static readonly HashSet<ECommand> hashSet_0;

		// Token: 0x02001A5B RID: 6747
		public enum ETranslateResult
		{
			// Token: 0x040095CF RID: 38351
			Ignore,
			// Token: 0x040095D0 RID: 38352
			Block,
			// Token: 0x040095D1 RID: 38353
			BlockAll
		}
	}
}
