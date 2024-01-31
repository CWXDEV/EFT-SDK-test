using System;

namespace EFT.Hideout
{
	// Token: 0x02001A6F RID: 6767
	public interface IAudioPlaybackSettings
	{
		// Token: 0x06008ECF RID: 36559
		void Play(AudioArray audioArray, ELightStatus status, bool firstStart);

		// Token: 0x06008ED0 RID: 36560
		void Pause(AudioArray audioArray);
	}
}
