using System;

namespace EFT.InventoryLogic
{
	// Token: 0x020024CD RID: 9421
	[Flags]
	public enum EWeaponModType
	{
		// Token: 0x0400BF71 RID: 49009
		mod_mount = 1,
		// Token: 0x0400BF72 RID: 49010
		mod_scope = 2,
		// Token: 0x0400BF73 RID: 49011
		mod_tactical = 4,
		// Token: 0x0400BF74 RID: 49012
		mod_stock = 8,
		// Token: 0x0400BF75 RID: 49013
		mod_magazine = 16,
		// Token: 0x0400BF76 RID: 49014
		mod_barrel = 32,
		// Token: 0x0400BF77 RID: 49015
		mod_handguard = 64,
		// Token: 0x0400BF78 RID: 49016
		mod_muzzle = 128,
		// Token: 0x0400BF79 RID: 49017
		mod_sight_front = 256,
		// Token: 0x0400BF7A RID: 49018
		mod_sight_rear = 512,
		// Token: 0x0400BF7B RID: 49019
		mod_foregrip = 1024,
		// Token: 0x0400BF7C RID: 49020
		mod_reciever = 2048,
		// Token: 0x0400BF7D RID: 49021
		mod_charge = 4096,
		// Token: 0x0400BF7E RID: 49022
		mod_pistol_grip = 8192,
		// Token: 0x0400BF7F RID: 49023
		mod_launcher = 16384,
		// Token: 0x0400BF80 RID: 49024
		mod_bipod = 32768,
		// Token: 0x0400BF81 RID: 49025
		mod_mag_shaft = 65536,
		// Token: 0x0400BF82 RID: 49026
		mod_silencer = 131072,
		// Token: 0x0400BF83 RID: 49027
		mod_tactical_2 = 262144,
		// Token: 0x0400BF84 RID: 49028
		chamber0 = 524288,
		// Token: 0x0400BF85 RID: 49029
		chamber1 = 1048576,
		// Token: 0x0400BF86 RID: 49030
		patron_in_weapon = 2097152,
		// Token: 0x0400BF87 RID: 49031
		mod_gas_block = 4194304,
		// Token: 0x0400BF88 RID: 49032
		mod_equipment = 8388608,
		// Token: 0x0400BF89 RID: 49033
		mod_equipment_000 = 16777216,
		// Token: 0x0400BF8A RID: 49034
		mod_equipment_001 = 33554432,
		// Token: 0x0400BF8B RID: 49035
		mod_nvg = 67108864,
		// Token: 0x0400BF8C RID: 49036
		mod_flashlight = 134217728,
		// Token: 0x0400BF8D RID: 49037
		mod_muzzle_001 = 268435456
	}
}
