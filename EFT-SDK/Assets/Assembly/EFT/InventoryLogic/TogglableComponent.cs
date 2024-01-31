using System;
using System.Runtime.CompilerServices;
using Diz.Binding;

namespace EFT.InventoryLogic
{
	// Token: 0x020022B7 RID: 8887
	public class TogglableComponent : GClass2750, IItemComponent, ITogglableComponent
	{
		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600B499 RID: 46233 RVA: 0x00002050 File Offset: 0x00000250
		bool ITogglableComponent.On
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Toggle()
		{
			throw null;
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceToggle(bool targetToggle)
		{
			throw null;
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleSilent()
		{
			throw null;
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct413<GClass2797> Set(bool value, bool simulate = false, bool silent = false)
		{
			throw null;
		}

		// Token: 0x0400B88A RID: 47242
		public bool On;

		// Token: 0x0400B88B RID: 47243
		[NonSerialized]
		public BindableEvent OnChanged;

		// Token: 0x0400B88C RID: 47244
		public float LastToggleTime;
	}
}
