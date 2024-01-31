using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x020022B5 RID: 8885
	public class ThermalVisionComponent : GClass2750, IItemComponent, ITogglableComponentContainer, ITogglableComponentContainer<TogglableComponent>
	{
		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600B497 RID: 46231 RVA: 0x00002050 File Offset: 0x00000250
		public TogglableComponent Togglable
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x0600B498 RID: 46232 RVA: 0x00002050 File Offset: 0x00000250
		ITogglableComponent ITogglableComponentContainer.Togglable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400B883 RID: 47235
		public readonly GInterface303 Template;

		// Token: 0x020022B6 RID: 8886
		public enum SelectablePalette
		{
			// Token: 0x0400B886 RID: 47238
			Fusion,
			// Token: 0x0400B887 RID: 47239
			Rainbow,
			// Token: 0x0400B888 RID: 47240
			WhiteHot,
			// Token: 0x0400B889 RID: 47241
			BlackHot
		}
	}
}
