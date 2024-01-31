using System;
using System.Runtime.CompilerServices;

namespace EFT.Visual
{
	// Token: 0x02001A19 RID: 6681
	public class FlickerSystem : ComponentSystem<Flicker, FlickerSystem>
	{
		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool HasUpdate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool HasLateUpdate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateComponent(Flicker component)
		{
			throw null;
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdateComponent(Flicker component)
		{
			throw null;
		}
	}
}
