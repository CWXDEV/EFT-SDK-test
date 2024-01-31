using System;
using EFT.InventoryLogic;

namespace EFT
{
	// Token: 0x02001507 RID: 5383
	public interface IKnifeController : GInterface123, GInterface124, GInterface126
	{
		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060073C9 RID: 29641
		KnifeComponent Knife { get; }

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x060073CA RID: 29642
		// (set) Token: 0x060073CB RID: 29643
		Action ComboPlanning { get; set; }

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060073CC RID: 29644
		// (set) Token: 0x060073CD RID: 29645
		Action OnAttackEnd { get; set; }

		// Token: 0x060073CE RID: 29646
		void ExamineWeapon();

		// Token: 0x060073CF RID: 29647
		bool MakeKnifeKick();

		// Token: 0x060073D0 RID: 29648
		bool MakeAlternativeKick();

		// Token: 0x060073D1 RID: 29649
		void BrakeCombo();

		// Token: 0x060073D2 RID: 29650
		void ContinueCombo();

		// Token: 0x060073D3 RID: 29651
		void SetBotParameters();
	}
}
