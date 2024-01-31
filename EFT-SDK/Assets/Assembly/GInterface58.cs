using System;
using Audio.Data;

// Token: 0x02000D6A RID: 3434
public interface GInterface58 : IDisposable
{
	// Token: 0x06004900 RID: 18688
	void Play(EAudioMovementState movementState, EnvironmentType environment, float distance = 0f, float baseStepVolume = 1f, float blendParameter = 0f, bool stereo = false, float customRolloff = 0f);

	// Token: 0x06004901 RID: 18689
	void UpdateSoundRolloff(float rolloff);

	// Token: 0x06004902 RID: 18690
	void UpdateSurface(BaseBallistic.ESurfaceSound surface);

	// Token: 0x06004903 RID: 18691
	void UpdateUnderRoofStatus(bool isUnderRoof);
}
