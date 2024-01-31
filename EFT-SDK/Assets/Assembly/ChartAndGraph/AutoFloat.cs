using System;
using System.Runtime.CompilerServices;

namespace ChartAndGraph
{
	// Token: 0x0200313B RID: 12603
	[Serializable]
	public struct AutoFloat
	{
		// Token: 0x0600F721 RID: 63265 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600F722 RID: 63266 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0400FC75 RID: 64629
		public bool Automatic;

		// Token: 0x0400FC76 RID: 64630
		public float Value;
	}
}
