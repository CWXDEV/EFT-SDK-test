using System;
using Audio.Data;

// Token: 0x02000D55 RID: 3413
public interface GInterface55 : IDisposable
{
	// Token: 0x17000B8E RID: 2958
	// (get) Token: 0x060048BC RID: 18620
	bool IsPlaying { get; }

	// Token: 0x060048BD RID: 18621
	void Play(SoundBankWithSettings bank, bool stereo = false);

	// Token: 0x060048BE RID: 18622
	void ManualUpdate(float dt = 0f);

	// Token: 0x060048BF RID: 18623
	void Stop();
}
