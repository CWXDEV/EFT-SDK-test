using System;

namespace EFT
{
	// Token: 0x02001900 RID: 6400
	public interface IPlayerVoipController
	{
		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060089D7 RID: 35287
		BindableState<EVoipControllerStatus> Status { get; }

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060089D8 RID: 35288
		BindableState<bool> HasInteraction { get; }

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060089D9 RID: 35289
		BindableState<bool> TalkDetected { get; }

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060089DA RID: 35290
		TimeSpan TimeToNextStatus { get; }

		// Token: 0x060089DB RID: 35291
		EVoipControllerStatus ToggleTalk();

		// Token: 0x060089DC RID: 35292
		EVoipControllerStatus StopTalk();

		// Token: 0x060089DD RID: 35293
		void ReportAbuse();

		// Token: 0x060089DE RID: 35294
		void ForceMuteVoIP(bool enable);

		// Token: 0x14000199 RID: 409
		// (add) Token: 0x060089DF RID: 35295
		// (remove) Token: 0x060089E0 RID: 35296
		event Action<string> AbuseNotification;
	}
}
