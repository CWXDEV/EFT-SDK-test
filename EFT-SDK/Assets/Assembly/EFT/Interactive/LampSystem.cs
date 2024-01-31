using System;
using System.Runtime.CompilerServices;

namespace EFT.Interactive
{
	// Token: 0x02002770 RID: 10096
	public class LampSystem : ComponentSystem<LampController, LampSystem>
	{
		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x0600CA36 RID: 51766 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool HasUpdate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x0600CA37 RID: 51767 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool HasLateUpdate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateComponent(LampController component)
		{
			throw null;
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdateComponent(LampController component)
		{
			throw null;
		}
	}
}
