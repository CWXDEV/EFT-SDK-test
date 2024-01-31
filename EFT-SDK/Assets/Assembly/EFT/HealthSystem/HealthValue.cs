using System;
using System.Runtime.CompilerServices;

namespace EFT.HealthSystem
{
	// Token: 0x02002218 RID: 8728
	public class HealthValue
	{
		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B1EE RID: 45550 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x0600B1EF RID: 45551 RVA: 0x00002050 File Offset: 0x00000250
		public float Minimum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x0600B1F0 RID: 45552 RVA: 0x00002050 File Offset: 0x00000250
		public float Maximum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600B1F1 RID: 45553 RVA: 0x00002050 File Offset: 0x00000250
		public ValueStruct CurrentAndMaximum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600B1F2 RID: 45554 RVA: 0x00002050 File Offset: 0x00000250
		public float Normalized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600B1F3 RID: 45555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B1F4 RID: 45556 RVA: 0x00002050 File Offset: 0x00000250
		public float LastDiff
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600B1F5 RID: 45557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B1F6 RID: 45558 RVA: 0x00002050 File Offset: 0x00000250
		public float DownMult
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

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600B1F7 RID: 45559 RVA: 0x00002050 File Offset: 0x00000250
		public bool AtMinimum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600B1F8 RID: 45560 RVA: 0x00002050 File Offset: 0x00000250
		public bool AtMaximum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float cur, float min, float max)
		{
			throw null;
		}

		// Token: 0x0400B6A7 RID: 46759
		protected ValueStruct Value;
	}
}
