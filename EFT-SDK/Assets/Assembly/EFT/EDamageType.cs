using System;

namespace EFT
{
	// Token: 0x020015CC RID: 5580
	[Flags]
	public enum EDamageType
	{
		// Token: 0x04007E43 RID: 32323
		Undefined = 1,
		// Token: 0x04007E44 RID: 32324
		Fall = 2,
		// Token: 0x04007E45 RID: 32325
		Explosion = 4,
		// Token: 0x04007E46 RID: 32326
		Barbed = 8,
		// Token: 0x04007E47 RID: 32327
		Flame = 16,
		// Token: 0x04007E48 RID: 32328
		GrenadeFragment = 32,
		// Token: 0x04007E49 RID: 32329
		Impact = 64,
		// Token: 0x04007E4A RID: 32330
		Existence = 128,
		// Token: 0x04007E4B RID: 32331
		Medicine = 256,
		// Token: 0x04007E4C RID: 32332
		Bullet = 512,
		// Token: 0x04007E4D RID: 32333
		Melee = 1024,
		// Token: 0x04007E4E RID: 32334
		Landmine = 2048,
		// Token: 0x04007E4F RID: 32335
		Sniper = 4096,
		// Token: 0x04007E50 RID: 32336
		Blunt = 8192,
		// Token: 0x04007E51 RID: 32337
		LightBleeding = 16384,
		// Token: 0x04007E52 RID: 32338
		HeavyBleeding = 32768,
		// Token: 0x04007E53 RID: 32339
		Dehydration = 65536,
		// Token: 0x04007E54 RID: 32340
		Exhaustion = 131072,
		// Token: 0x04007E55 RID: 32341
		RadExposure = 262144,
		// Token: 0x04007E56 RID: 32342
		Stimulator = 524288,
		// Token: 0x04007E57 RID: 32343
		Poison = 1048576,
		// Token: 0x04007E58 RID: 32344
		LethalToxin = 2097152,
		// Token: 0x04007E59 RID: 32345
		Btr = 4194304
	}
}
