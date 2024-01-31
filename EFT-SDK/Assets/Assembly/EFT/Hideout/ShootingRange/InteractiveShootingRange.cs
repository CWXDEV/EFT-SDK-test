using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C0A RID: 7178
	public abstract class InteractiveShootingRange : InteractableObject
	{
		// Token: 0x0600969C RID: 38556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Enable()
		{
			throw null;
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Disable()
		{
			throw null;
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual GClass3008 InteractionStates(HideoutPlayerOwner owner)
		{
			throw null;
		}

		// Token: 0x04009D99 RID: 40345
		protected bool _enabled;
	}
}
