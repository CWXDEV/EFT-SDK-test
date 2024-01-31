using System;
using System.Runtime.CompilerServices;

// Token: 0x02000501 RID: 1281
[Serializable]
public class BotGlobalPatrolSettings
{
	// Token: 0x06001F9A RID: 8090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x04001CC0 RID: 7360
	public float LOOK_TIME_BASE;

	// Token: 0x04001CC1 RID: 7361
	public float RESERVE_TIME_STAY;

	// Token: 0x04001CC2 RID: 7362
	public float RESERVE_LOOT_TIME_STAY;

	// Token: 0x04001CC3 RID: 7363
	public float FRIEND_SEARCH_SEC;

	// Token: 0x04001CC4 RID: 7364
	public float TALK_DELAY;

	// Token: 0x04001CC5 RID: 7365
	public float MIN_TALK_DELAY;

	// Token: 0x04001CC6 RID: 7366
	public float TALK_DELAY_BIG;

	// Token: 0x04001CC7 RID: 7367
	public float CHANGE_WAY_TIME;

	// Token: 0x04001CC8 RID: 7368
	public float MIN_DIST_TO_CLOSE_TALK;

	// Token: 0x04001CC9 RID: 7369
	public float VISION_DIST_COEF_PEACE;

	// Token: 0x04001CCA RID: 7370
	public float MIN_DIST_TO_CLOSE_TALK_SQR;

	// Token: 0x04001CCB RID: 7371
	public float CHANCE_TO_CUT_WAY_0_100;

	// Token: 0x04001CCC RID: 7372
	public float CUT_WAY_MIN_0_1;

	// Token: 0x04001CCD RID: 7373
	public float CUT_WAY_MAX_0_1;

	// Token: 0x04001CCE RID: 7374
	public float CHANCE_TO_CHANGE_WAY_0_100;

	// Token: 0x04001CCF RID: 7375
	public int CHANCE_TO_SHOOT_DEADBODY;

	// Token: 0x04001CD0 RID: 7376
	public float SUSPETION_PLACE_LIFETIME;

	// Token: 0x04001CD1 RID: 7377
	public float RESERVE_OUT_TIME;

	// Token: 0x04001CD2 RID: 7378
	public float CLOSE_TO_SELECT_RESERV_WAY;

	// Token: 0x04001CD3 RID: 7379
	public float MAX_YDIST_TO_START_WARN_REQUEST_TO_REQUESTER;

	// Token: 0x04001CD4 RID: 7380
	public float MAX_YDIST_TO_START_WARN_REQUEST_TO_REQUESTER_ALLY;

	// Token: 0x04001CD5 RID: 7381
	public bool CAN_CHOOSE_RESERV;

	// Token: 0x04001CD6 RID: 7382
	public bool USE_ONLY_RESERV;

	// Token: 0x04001CD7 RID: 7383
	public float HEAD_PERIOD_TIME;

	// Token: 0x04001CD8 RID: 7384
	public float HEAD_FRONT_PERIOD_TIME;

	// Token: 0x04001CD9 RID: 7385
	public float CHANCE_TO_PLAY_GESTURE_WHEN_CLOSE;

	// Token: 0x04001CDA RID: 7386
	public float HEAD_TURN_SPEED;

	// Token: 0x04001CDB RID: 7387
	public float HEAD_ANG_ROTATE;

	// Token: 0x04001CDC RID: 7388
	public float CHANCE_TO_PLAY_VOICE_WHEN_CLOSE;

	// Token: 0x04001CDD RID: 7389
	public float GO_TO_NEXT_POINT_DELTA;

	// Token: 0x04001CDE RID: 7390
	public float GO_TO_NEXT_POINT_DELTA_RESERV_WAY;

	// Token: 0x04001CDF RID: 7391
	public float DEAD_BODY_SEE_DIST;

	// Token: 0x04001CE0 RID: 7392
	public float DEAD_BODY_LEAVE_DIST;

	// Token: 0x04001CE1 RID: 7393
	public bool CAN_LOOK_TO_DEADBODIES;

	// Token: 0x04001CE2 RID: 7394
	public float GESTURE_LENGTH;

	// Token: 0x04001CE3 RID: 7395
	public bool SHALL_STOP_IN_PEACEFUL_ACTION;

	// Token: 0x04001CE4 RID: 7396
	public bool FORCE_OPPONENT_TO_PEAEFUL;

	// Token: 0x04001CE5 RID: 7397
	public float RESERVE_USE_SURGE_TIME_STAY;

	// Token: 0x04001CE6 RID: 7398
	public bool RESERV_CAN_USE_MEDS;

	// Token: 0x04001CE7 RID: 7399
	public bool USE_PATROL_POINT_ACTION_MOVE_BY_RESERVE_WAY;

	// Token: 0x04001CE8 RID: 7400
	public float USE_SURGIAL_KIT_OVER_THE_BODY_CAHNCE_100;

	// Token: 0x04001CE9 RID: 7401
	public float USE_SURGIAL_KIT_OVER_THE_BODY_SECOND_CAHNCE_100;

	// Token: 0x04001CEA RID: 7402
	public float FOLLOWER_START_MOVE_DELAY;

	// Token: 0x04001CEB RID: 7403
	public bool USE_CHACHE_WAYS;

	// Token: 0x04001CEC RID: 7404
	public string ITEMS_TO_DROP;

	// Token: 0x04001CED RID: 7405
	public float SPRINT_BETWEEN_CACHED_POINTS;

	// Token: 0x04001CEE RID: 7406
	public float CHECK_MAGAZIN_PERIOD;

	// Token: 0x04001CEF RID: 7407
	public float EAT_DRINK_PERIOD;

	// Token: 0x04001CF0 RID: 7408
	public float WATCH_SECOND_WEAPON_PERIOD;

	// Token: 0x04001CF1 RID: 7409
	public bool CAN_WATCH_SECOND_WEAPON;

	// Token: 0x04001CF2 RID: 7410
	public float DEAD_BODY_LOOK_PERIOD;

	// Token: 0x04001CF3 RID: 7411
	public bool CAN_HARD_AIM;

	// Token: 0x04001CF4 RID: 7412
	public bool CAN_PEACEFUL_LOOK;

	// Token: 0x04001CF5 RID: 7413
	public bool CAN_FRIENDLY_TILT;

	// Token: 0x04001CF6 RID: 7414
	public bool CAN_GESTUS;

	// Token: 0x04001CF7 RID: 7415
	public bool TRY_CHOOSE_RESERV_WAY_ON_START;

	// Token: 0x04001CF8 RID: 7416
	public bool CAN_CHECK_MAGAZINE;

	// Token: 0x04001CF9 RID: 7417
	public bool PICKUP_ITEMS_TO_BACKPACK_OR_CONTAINER;

	// Token: 0x04001CFA RID: 7418
	public bool DO_RANDOM_DROP_ITEM;
}
