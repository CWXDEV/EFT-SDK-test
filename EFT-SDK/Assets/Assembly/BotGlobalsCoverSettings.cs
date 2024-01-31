using System;
using System.Runtime.CompilerServices;

// Token: 0x02000500 RID: 1280
[Serializable]
public class BotGlobalsCoverSettings
{
	// Token: 0x06001F99 RID: 8089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x04001C7D RID: 7293
	public float RETURN_TO_ATTACK_AFTER_AMBUSH_MIN;

	// Token: 0x04001C7E RID: 7294
	public float RETURN_TO_ATTACK_AFTER_AMBUSH_MAX;

	// Token: 0x04001C7F RID: 7295
	public float SOUND_TO_GET_SPOTTED;

	// Token: 0x04001C80 RID: 7296
	public float TIME_TO_MOVE_TO_COVER;

	// Token: 0x04001C81 RID: 7297
	public float MAX_DIST_OF_COVER;

	// Token: 0x04001C82 RID: 7298
	public float CHANGE_RUN_TO_COVER_SEC;

	// Token: 0x04001C83 RID: 7299
	public float CHANGE_RUN_TO_COVER_SEC_GREANDE;

	// Token: 0x04001C84 RID: 7300
	public float MIN_DIST_TO_ENEMY;

	// Token: 0x04001C85 RID: 7301
	public float DIST_CANT_CHANGE_WAY;

	// Token: 0x04001C86 RID: 7302
	public float DIST_CHECK_SFETY;

	// Token: 0x04001C87 RID: 7303
	public float TIME_CHECK_SAFE;

	// Token: 0x04001C88 RID: 7304
	public float HIDE_TO_COVER_TIME;

	// Token: 0x04001C89 RID: 7305
	public float MAX_DIST_OF_COVER_SQR;

	// Token: 0x04001C8A RID: 7306
	public float DIST_CANT_CHANGE_WAY_SQR;

	// Token: 0x04001C8B RID: 7307
	public float SPOTTED_COVERS_RADIUS;

	// Token: 0x04001C8C RID: 7308
	public float LOOK_LAST_ENEMY_POS_MOVING;

	// Token: 0x04001C8D RID: 7309
	public float LOOK_LAST_ENEMY_POS_LONG;

	// Token: 0x04001C8E RID: 7310
	public float LOOK_LAST_ENEMY_POS_DIST;

	// Token: 0x04001C8F RID: 7311
	public float LOOK_TO_HIT_POINT_IF_LAST_ENEMY;

	// Token: 0x04001C90 RID: 7312
	public float LOOK_LAST_ENEMY_POS_LOOKAROUND;

	// Token: 0x04001C91 RID: 7313
	public int OFFSET_LOOK_ALONG_WALL_ANG;

	// Token: 0x04001C92 RID: 7314
	public float SPOTTED_GRENADE_RADIUS;

	// Token: 0x04001C93 RID: 7315
	public float MAX_SPOTTED_TIME_SEC;

	// Token: 0x04001C94 RID: 7316
	public float WAIT_INT_COVER_FINDING_ENEMY;

	// Token: 0x04001C95 RID: 7317
	public float CLOSE_DIST_POINT_SQRT;

	// Token: 0x04001C96 RID: 7318
	public float DELTA_SEEN_FROM_COVE_LAST_POS;

	// Token: 0x04001C97 RID: 7319
	public bool MOVE_TO_COVER_WHEN_TARGET;

	// Token: 0x04001C98 RID: 7320
	public bool RUN_COVER_IF_CAN_AND_NO_ENEMIES;

	// Token: 0x04001C99 RID: 7321
	public float SPOTTED_GRENADE_TIME;

	// Token: 0x04001C9A RID: 7322
	public bool DEPENDS_Y_DIST_TO_BOT;

	// Token: 0x04001C9B RID: 7323
	public float RUN_IF_FAR;

	// Token: 0x04001C9C RID: 7324
	public float RUN_IF_FAR_SQRT;

	// Token: 0x04001C9D RID: 7325
	public float STAY_IF_FAR;

	// Token: 0x04001C9E RID: 7326
	public float STAY_IF_FAR_SQRT;

	// Token: 0x04001C9F RID: 7327
	public bool CHECK_COVER_ENEMY_LOOK;

	// Token: 0x04001CA0 RID: 7328
	public int SHOOT_NEAR_TO_LEAVE;

	// Token: 0x04001CA1 RID: 7329
	public float SHOOT_NEAR_SEC_PERIOD;

	// Token: 0x04001CA2 RID: 7330
	public int HITS_TO_LEAVE_COVER;

	// Token: 0x04001CA3 RID: 7331
	public int HITS_TO_LEAVE_COVER_UNKNOWN;

	// Token: 0x04001CA4 RID: 7332
	public float DOG_FIGHT_AFTER_LEAVE;

	// Token: 0x04001CA5 RID: 7333
	public bool NOT_LOOK_AT_WALL_IS_DANGER;

	// Token: 0x04001CA6 RID: 7334
	public float MIN_DEFENCE_LEVEL;

	// Token: 0x04001CA7 RID: 7335
	public bool REWORK_NOT_TO_SHOOT;

	// Token: 0x04001CA8 RID: 7336
	public bool DELETE_POINTS_BEHIND_ENEMIES;

	// Token: 0x04001CA9 RID: 7337
	public float GOOD_DIST_TO_POINT_COEF;

	// Token: 0x04001CAA RID: 7338
	public float ENEMY_DIST_TO_GO_OUT;

	// Token: 0x04001CAB RID: 7339
	public bool CHECK_CLOSEST_FRIEND;

	// Token: 0x04001CAC RID: 7340
	public float MIN_TO_ENEMY_TO_BE_NOT_SAFE_SQRT;

	// Token: 0x04001CAD RID: 7341
	public float MIN_TO_ENEMY_TO_BE_NOT_SAFE;

	// Token: 0x04001CAE RID: 7342
	public bool SIT_DOWN_WHEN_HOLDING;

	// Token: 0x04001CAF RID: 7343
	public float STATIONARY_WEAPON_NO_ENEMY_GETUP;

	// Token: 0x04001CB0 RID: 7344
	public float STATIONARY_WEAPON_MAX_DIST_TO_USE;

	// Token: 0x04001CB1 RID: 7345
	public int STATIONARY_SPOTTED_TIMES_TO_LEAVE;

	// Token: 0x04001CB2 RID: 7346
	public bool STATIONARY_CAN_USE;

	// Token: 0x04001CB3 RID: 7347
	public bool CAN_END_SHOOT_FROM_COVER_CAUSE_STATIONARY;

	// Token: 0x04001CB4 RID: 7348
	public float CAN_END_SHOOT_FROM_COVER_CAUSE_STATIONARY_DELTA;

	// Token: 0x04001CB5 RID: 7349
	public float CAN_END_SHOOT_FROM_COVER_CAUSE_STATIONARY_RADIUS;

	// Token: 0x04001CB6 RID: 7350
	public float END_HOLD_IF_ENEMY_CLOSE_AND_VISIBLE;

	// Token: 0x04001CB7 RID: 7351
	public float DIST_MAX_REWORK_NOT_TO_SHOOT;

	// Token: 0x04001CB8 RID: 7352
	public float SDIST_MAX_REWORK_NOT_TO_SHOOT;

	// Token: 0x04001CB9 RID: 7353
	public bool USE_DANGER_AREAS;

	// Token: 0x04001CBA RID: 7354
	public int MAX_ITERATIONS;

	// Token: 0x04001CBB RID: 7355
	public float CHANGE_COVER_IF_CANT_SHOOT_SEC;

	// Token: 0x04001CBC RID: 7356
	public bool SHALL_CHANGE_COVER_IF_CAN_SHOOT;

	// Token: 0x04001CBD RID: 7357
	public float CHECK_CLOSEST_FRIEND_DIST;

	// Token: 0x04001CBE RID: 7358
	public float CAN_LAY_TO_COVER_DIST_LOOK_TO_ENEMY;

	// Token: 0x04001CBF RID: 7359
	public bool CAN_LAY_TO_COVER;
}
