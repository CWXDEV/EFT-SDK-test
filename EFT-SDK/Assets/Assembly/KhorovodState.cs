using System;

// Token: 0x02000540 RID: 1344
[Serializable]
public class KhorovodState
{
	// Token: 0x04001F42 RID: 8002
	public float RotationVelocity;

	// Token: 0x04001F43 RID: 8003
	public float BotsVelocity;

	// Token: 0x04001F44 RID: 8004
	public float Radius;

	// Token: 0x04001F45 RID: 8005
	public EGesture Gesture;

	// Token: 0x04001F46 RID: 8006
	public EPhraseTrigger Phrase;

	// Token: 0x04001F47 RID: 8007
	public int speakersLimit;

	// Token: 0x04001F48 RID: 8008
	public bool HaveGesture;

	// Token: 0x04001F49 RID: 8009
	public bool RandomGesture;

	// Token: 0x04001F4A RID: 8010
	public bool HavePhrase;

	// Token: 0x04001F4B RID: 8011
	public bool RandomPhrase;

	// Token: 0x04001F4C RID: 8012
	public bool ForcedAutomaticFireMode;

	// Token: 0x04001F4D RID: 8013
	public bool Shooting;

	// Token: 0x04001F4E RID: 8014
	public float LookHeight;

	// Token: 0x04001F4F RID: 8015
	public bool skip;

	// Token: 0x04001F50 RID: 8016
	public float StateDuration;
}
