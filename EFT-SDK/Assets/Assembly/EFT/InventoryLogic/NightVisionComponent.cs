using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x0200229F RID: 8863
	public class NightVisionComponent : GClass2750, IItemComponent, ITogglableComponentContainer, ITogglableComponentContainer<TogglableComponent>
	{
		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600B433 RID: 46131 RVA: 0x00002050 File Offset: 0x00000250
		public TogglableComponent Togglable
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600B434 RID: 46132 RVA: 0x00002050 File Offset: 0x00000250
		ITogglableComponent ITogglableComponentContainer.Togglable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400B851 RID: 47185
		public readonly GInterface298 Template;

		// Token: 0x020022A0 RID: 8864
		public enum EMask
		{
			// Token: 0x0400B854 RID: 47188
			Thermal,
			// Token: 0x0400B855 RID: 47189
			Anvis,
			// Token: 0x0400B856 RID: 47190
			Binocular,
			// Token: 0x0400B857 RID: 47191
			GasMask,
			// Token: 0x0400B858 RID: 47192
			OldMonocular
		}
	}
}
