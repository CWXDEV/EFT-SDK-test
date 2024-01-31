using System;
using System.Runtime.CompilerServices;

// Token: 0x020004FB RID: 1275
[Serializable]
public class BotGlobalLookData
{
	// Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x04001BA8 RID: 7080
	public float OLD_TIME_POINT;

	// Token: 0x04001BA9 RID: 7081
	public float WAIT_NEW_SENSOR;

	// Token: 0x04001BAA RID: 7082
	public float WAIT_NEW__LOOK_SENSOR;

	// Token: 0x04001BAB RID: 7083
	public float LOOK_AROUND_DELTA;

	// Token: 0x04001BAC RID: 7084
	public float MAX_VISION_GRASS_METERS;

	// Token: 0x04001BAD RID: 7085
	public float MAX_VISION_GRASS_METERS_FLARE;

	// Token: 0x04001BAE RID: 7086
	public float MAX_VISION_GRASS_METERS_OPT;

	// Token: 0x04001BAF RID: 7087
	public float MAX_VISION_GRASS_METERS_FLARE_OPT;

	// Token: 0x04001BB0 RID: 7088
	public float LightOnVisionDistance;

	// Token: 0x04001BB1 RID: 7089
	public float FAR_DISTANCE;

	// Token: 0x04001BB2 RID: 7090
	public float FarDeltaTimeSec;

	// Token: 0x04001BB3 RID: 7091
	public float MIDDLE_DIST;

	// Token: 0x04001BB4 RID: 7092
	public float MiddleDeltaTimeSec;

	// Token: 0x04001BB5 RID: 7093
	public float CloseDeltaTimeSec;

	// Token: 0x04001BB6 RID: 7094
	public float POSIBLE_VISION_SPACE;

	// Token: 0x04001BB7 RID: 7095
	public float GOAL_TO_FULL_DISSAPEAR;

	// Token: 0x04001BB8 RID: 7096
	public float GOAL_TO_FULL_DISSAPEAR_GREEN;

	// Token: 0x04001BB9 RID: 7097
	public float GOAL_TO_FULL_DISSAPEAR_SHOOT;

	// Token: 0x04001BBA RID: 7098
	public float BODY_DELTA_TIME_SEARCH_SEC;

	// Token: 0x04001BBB RID: 7099
	public float COME_TO_BODY_DIST;

	// Token: 0x04001BBC RID: 7100
	public float MARKSMAN_VISIBLE_DIST_COEF;

	// Token: 0x04001BBD RID: 7101
	public float VISIBLE_DISNACE_WITH_LIGHT;

	// Token: 0x04001BBE RID: 7102
	public float ENEMY_LIGHT_ADD;

	// Token: 0x04001BBF RID: 7103
	public float ENEMY_LIGHT_START_DIST;

	// Token: 0x04001BC0 RID: 7104
	public float DIST_NOT_TO_IGNORE_WALL;

	// Token: 0x04001BC1 RID: 7105
	public float DIST_CHECK_WALL;

	// Token: 0x04001BC2 RID: 7106
	public float LOOK_LAST_POSENEMY_IF_NO_DANGER_SEC;

	// Token: 0x04001BC3 RID: 7107
	public float MIN_LOOK_AROUD_TIME;

	// Token: 0x04001BC4 RID: 7108
	public bool LOOK_THROUGH_GRASS;

	// Token: 0x04001BC5 RID: 7109
	public float LOOK_THROUGH_GRASS_DIST_METERS;

	// Token: 0x04001BC6 RID: 7110
	public float SEC_REPEATED_SEEN;

	// Token: 0x04001BC7 RID: 7111
	public double DIST_SQRT_REPEATED_SEEN;

	// Token: 0x04001BC8 RID: 7112
	public double DIST_REPEATED_SEEN;

	// Token: 0x04001BC9 RID: 7113
	public float COEF_REPEATED_SEEN;

	// Token: 0x04001BCA RID: 7114
	public float MAX_DIST_CLAMP_TO_SEEN_SPEED;

	// Token: 0x04001BCB RID: 7115
	public float NIGHT_VISION_ON;

	// Token: 0x04001BCC RID: 7116
	public float NIGHT_VISION_OFF;

	// Token: 0x04001BCD RID: 7117
	public float NIGHT_VISION_DIST;

	// Token: 0x04001BCE RID: 7118
	public float VISIBLE_ANG_LIGHT;

	// Token: 0x04001BCF RID: 7119
	public float VISIBLE_ANG_NIGHTVISION;

	// Token: 0x04001BD0 RID: 7120
	public float NO_GREEN_DIST;

	// Token: 0x04001BD1 RID: 7121
	public float NO_GRASS_DIST;

	// Token: 0x04001BD2 RID: 7122
	public float INSIDE_BUSH_COEF;

	// Token: 0x04001BD3 RID: 7123
	public bool SELF_NIGHTVISION;

	// Token: 0x04001BD4 RID: 7124
	public bool FULL_SECTOR_VIEW;

	// Token: 0x04001BD5 RID: 7125
	public float LOOK_THROUGH_PERIOD_BY_HIT;

	// Token: 0x04001BD6 RID: 7126
	public bool CHECK_HEAD_ANY_DIST;

	// Token: 0x04001BD7 RID: 7127
	public bool MIDDLE_DIST_CAN_SHOOT_HEAD;

	// Token: 0x04001BD8 RID: 7128
	public bool CAN_USE_LIGHT;

	// Token: 0x04001BD9 RID: 7129
	public bool SHOOT_FROM_EYES;

	// Token: 0x04001BDA RID: 7130
	public float ANGLE_FOR_GETUP;

	// Token: 0x04001BDB RID: 7131
	public float MINIMUM_VISIBLE_DIST;

	// Token: 0x04001BDC RID: 7132
	public float CAN_USE_STRIBOSCOPE;
}
