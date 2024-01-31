using System;

namespace EFT.Vaulting
{
	// Token: 0x02001E60 RID: 7776
	public interface IVaultingComponent
	{
		// Token: 0x06009F62 RID: 40802
		void DoVaultingTick();

		// Token: 0x06009F63 RID: 40803
		bool TryVaulting();

		// Token: 0x06009F64 RID: 40804
		bool CanDamageLegs(EVaultingStrategy strategy);

		// Token: 0x06009F65 RID: 40805
		bool CanDamageLeftHand(EVaultingStrategy strategy);

		// Token: 0x06009F66 RID: 40806
		bool CanDamageRightHand(EVaultingStrategy strategy);
	}
}
