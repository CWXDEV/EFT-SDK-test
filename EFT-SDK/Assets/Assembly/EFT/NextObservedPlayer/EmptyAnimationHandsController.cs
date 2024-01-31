using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02001FAA RID: 8106
	public class EmptyAnimationHandsController : BaseAnimationHandsController
	{
		// Token: 0x0600A7EE RID: 42990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnWeapIn()
		{
			throw null;
		}

		// Token: 0x0400AEBD RID: 44733
		private static readonly Dictionary<Type, Func<GInterface223>> dictionary_0;
	}
}
