using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EFT.HealthSystem
{
	// Token: 0x02002216 RID: 8726
	[StructLayout(LayoutKind.Auto)]
	public struct ValueStruct
	{
		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600B1E8 RID: 45544 RVA: 0x00002050 File Offset: 0x00000250
		public float Normalized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600B1E9 RID: 45545 RVA: 0x00002050 File Offset: 0x00000250
		public bool AtMinimum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x00002050 File Offset: 0x00000250
		public bool AtMaximum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400B6A1 RID: 46753
		public float Current;

		// Token: 0x0400B6A2 RID: 46754
		public float Maximum;

		// Token: 0x0400B6A3 RID: 46755
		public float Minimum;

		// Token: 0x0400B6A4 RID: 46756
		public float OverDamageReceivedMultiplier;
	}
}
