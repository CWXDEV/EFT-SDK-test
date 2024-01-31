using System;
using System.Collections.Generic;
using EFT;
using EFT.InventoryLogic;

// Token: 0x0200244B RID: 9291
public interface GInterface312
{
	// Token: 0x17002140 RID: 8512
	// (get) Token: 0x0600BA90 RID: 47760
	Inventory InventoryInfo { get; }

	// Token: 0x17002141 RID: 8513
	// (get) Token: 0x0600BA91 RID: 47761
	string ProfileId { get; }

	// Token: 0x17002142 RID: 8514
	// (get) Token: 0x0600BA92 RID: 47762
	EPlayerSide Side { get; }

	// Token: 0x17002143 RID: 8515
	// (get) Token: 0x0600BA93 RID: 47763
	string Nickname { get; }

	// Token: 0x17002144 RID: 8516
	// (get) Token: 0x0600BA94 RID: 47764
	IInventoryProfileSkillInfo SkillsInfo { get; }

	// Token: 0x17002145 RID: 8517
	// (get) Token: 0x0600BA95 RID: 47765
	// (set) Token: 0x0600BA96 RID: 47766
	int Experience { get; set; }

	// Token: 0x17002146 RID: 8518
	// (get) Token: 0x0600BA97 RID: 47767
	int MagDrillsMastering { get; }

	// Token: 0x17002147 RID: 8519
	// (get) Token: 0x0600BA98 RID: 47768
	Dictionary<string, Profile.TraderInfo> TradersInfo { get; }

	// Token: 0x0600BA99 RID: 47769
	bool ForgetInEncyclopedia(string itemId);

	// Token: 0x0600BA9A RID: 47770
	void LearnInEncyclopedia(string itemId);

	// Token: 0x0600BA9B RID: 47771
	bool IsCheckedChambers(string weaponId);

	// Token: 0x0600BA9C RID: 47772
	void CheckChamber(string weaponId);

	// Token: 0x0600BA9D RID: 47773
	void UnCheckChamber(string weaponId);

	// Token: 0x0600BA9E RID: 47774
	bool IsCheckedMagazines(string magazineId);

	// Token: 0x0600BA9F RID: 47775
	void CheckMagazines(string magazineId, int value);

	// Token: 0x0600BAA0 RID: 47776
	void UnCheckMagazines(string magazineId);

	// Token: 0x0600BAA1 RID: 47777
	int CheckMagazinesValue(string magazineId);

	// Token: 0x0600BAA2 RID: 47778
	void AddToCarriedQuestItems(string itemTemplateId);

	// Token: 0x0600BAA3 RID: 47779
	bool Examined(string templateId);
}
