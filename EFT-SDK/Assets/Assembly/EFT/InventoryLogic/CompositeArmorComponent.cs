using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x02002262 RID: 8802
	public class CompositeArmorComponent : ArmorComponent
	{
		// Token: 0x0600B37A RID: 45946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ShotMatches(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider)
		{
			throw null;
		}

		// Token: 0x0400B7C9 RID: 47049
		[CanBeNull]
		public readonly TogglableComponent Togglable;
	}
}
