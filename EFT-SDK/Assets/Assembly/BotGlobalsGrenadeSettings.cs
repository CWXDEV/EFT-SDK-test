using System;
using System.Runtime.CompilerServices;

// Token: 0x020004FE RID: 1278
[Serializable]
public class BotGlobalsGrenadeSettings
{
	// Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x04001C3C RID: 7228
	public float DELTA_NEXT_ATTEMPT_FROM_COVER;

	// Token: 0x04001C3D RID: 7229
	public float DELTA_NEXT_ATTEMPT;

	// Token: 0x04001C3E RID: 7230
	public float MIN_DIST_NOT_TO_THROW;

	// Token: 0x04001C3F RID: 7231
	public float NEAR_DELTA_THROW_TIME_SEC;

	// Token: 0x04001C40 RID: 7232
	public float MIN_THROW_GRENADE_DIST;

	// Token: 0x04001C41 RID: 7233
	public float MIN_THROW_GRENADE_DIST_SQRT;

	// Token: 0x04001C42 RID: 7234
	public float MIN_DIST_NOT_TO_THROW_SQR;

	// Token: 0x04001C43 RID: 7235
	public float RUN_AWAY;

	// Token: 0x04001C44 RID: 7236
	public float RUN_AWAY_SQR;

	// Token: 0x04001C45 RID: 7237
	public float ADD_GRENADE_AS_DANGER;

	// Token: 0x04001C46 RID: 7238
	public float ADD_GRENADE_AS_DANGER_SQR;

	// Token: 0x04001C47 RID: 7239
	public float CHANCE_TO_NOTIFY_ENEMY_GR_100;

	// Token: 0x04001C48 RID: 7240
	public float GrenadePerMeter;

	// Token: 0x04001C49 RID: 7241
	public float REQUEST_DIST_MUST_THROW_SQRT;

	// Token: 0x04001C4A RID: 7242
	public float REQUEST_DIST_MUST_THROW;

	// Token: 0x04001C4B RID: 7243
	public int BEWARE_TYPE;

	// Token: 0x04001C4C RID: 7244
	public float SHOOT_TO_SMOKE_CHANCE_100;

	// Token: 0x04001C4D RID: 7245
	public float CHANCE_RUN_FLASHED_100;

	// Token: 0x04001C4E RID: 7246
	public float MAX_FLASHED_DIST_TO_SHOOT;

	// Token: 0x04001C4F RID: 7247
	public float MAX_FLASHED_DIST_TO_SHOOT_SQRT;

	// Token: 0x04001C50 RID: 7248
	public float FLASH_GRENADE_TIME_COEF;

	// Token: 0x04001C51 RID: 7249
	public float SIZE_SPOTTED_COEF;

	// Token: 0x04001C52 RID: 7250
	public float BE_ATTENTION_COEF;

	// Token: 0x04001C53 RID: 7251
	public float TIME_SHOOT_TO_FLASH;

	// Token: 0x04001C54 RID: 7252
	public float CLOSE_TO_SMOKE_TO_SHOOT;

	// Token: 0x04001C55 RID: 7253
	public float CLOSE_TO_SMOKE_TO_SHOOT_SQRT;

	// Token: 0x04001C56 RID: 7254
	public float CLOSE_TO_SMOKE_TIME_DELTA;

	// Token: 0x04001C57 RID: 7255
	public float SMOKE_CHECK_DELTA;

	// Token: 0x04001C58 RID: 7256
	public float DELTA_GRENADE_START_TIME;

	// Token: 0x04001C59 RID: 7257
	public float AMBUSH_IF_SMOKE_IN_ZONE_100;

	// Token: 0x04001C5A RID: 7258
	public float AMBUSH_IF_SMOKE_RETURN_TO_ATTACK_SEC;

	// Token: 0x04001C5B RID: 7259
	public bool NO_RUN_FROM_AI_GRENADES;

	// Token: 0x04001C5C RID: 7260
	public float MAX_THROW_POWER;

	// Token: 0x04001C5D RID: 7261
	public float GrenadePrecision;

	// Token: 0x04001C5E RID: 7262
	public bool STOP_WHEN_THROW_GRENADE;

	// Token: 0x04001C5F RID: 7263
	public float WAIT_TIME_TURN_AWAY;

	// Token: 0x04001C60 RID: 7264
	public float SMOKE_SUPPRESS_DELTA;

	// Token: 0x04001C61 RID: 7265
	public float DAMAGE_GRENADE_SUPPRESS_DELTA;

	// Token: 0x04001C62 RID: 7266
	public float STUN_SUPPRESS_DELTA;

	// Token: 0x04001C63 RID: 7267
	public bool CHEAT_START_GRENADE_PLACE;

	// Token: 0x04001C64 RID: 7268
	public bool CAN_THROW_STRAIGHT_CONTACT;

	// Token: 0x04001C65 RID: 7269
	public float STRAIGHT_CONTACT_DELTA_SEC;

	// Token: 0x04001C66 RID: 7270
	public int ANG_TYPE;

	// Token: 0x04001C67 RID: 7271
	public float MIN_THROW_DIST_PERCENT_0_1;

	// Token: 0x04001C68 RID: 7272
	public float FLASH_MODIF_IS_NIGHTVISION;

	// Token: 0x04001C69 RID: 7273
	public float FIRST_TIME_SEEN_DELTA_CAN_THROW;

	// Token: 0x04001C6A RID: 7274
	public bool SHALL_GETUP;

	// Token: 0x04001C6B RID: 7275
	public bool CAN_LAY;

	// Token: 0x04001C6C RID: 7276
	public bool IGNORE_SMOKE_GRENADE;
}
