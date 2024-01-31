using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.InputSystem
{
	// Token: 0x02001A5C RID: 6748
	public abstract class InputNodeAbstract : MonoBehaviour
	{
		// Token: 0x06008E8B RID: 36491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDuplicateChildren()
		{
			throw null;
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void TranslateInput(List<ECommand> commands, ref float[] axes, ref ECursorResult shouldLockCursor)
		{
			throw null;
		}

		// Token: 0x040095D2 RID: 38354
		[SerializeField]
		protected List<InputNode> _children;
	}
}
