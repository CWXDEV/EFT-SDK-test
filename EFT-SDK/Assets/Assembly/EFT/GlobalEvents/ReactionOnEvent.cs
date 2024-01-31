using System;
using System.Collections.Generic;
using Cutscene;

namespace EFT.GlobalEvents
{
	// Token: 0x0200265B RID: 9819
	[Serializable]
	public class ReactionOnEvent
	{
		// Token: 0x0400C47F RID: 50303
		public List<string> animationBoolNames;

		// Token: 0x0400C480 RID: 50304
		public List<string> animationTriggerNames;

		// Token: 0x0400C481 RID: 50305
		public NPCGlobalEventsReacting.AnimationInt animationInt;

		// Token: 0x0400C482 RID: 50306
		public AnimationTrack lipSyncData;

		// Token: 0x0400C483 RID: 50307
		public bool clearReactionQueue;
	}
}
