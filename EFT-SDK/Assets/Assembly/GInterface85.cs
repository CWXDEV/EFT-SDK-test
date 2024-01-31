using System;
using AnimationEventSystem;

// Token: 0x02001029 RID: 4137
public interface GInterface85 : IStateBehaviour
{
	// Token: 0x17000D9F RID: 3487
	// (get) Token: 0x0600565C RID: 22108
	// (set) Token: 0x0600565D RID: 22109
	AnimationEventsContainer EventsContainer { get; set; }

	// Token: 0x17000DA0 RID: 3488
	// (get) Token: 0x0600565E RID: 22110
	int FullNameHash { get; }
}
