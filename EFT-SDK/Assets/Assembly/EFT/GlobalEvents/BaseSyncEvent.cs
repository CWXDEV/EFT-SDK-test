using System;

namespace EFT.GlobalEvents
{
	// Token: 0x0200261E RID: 9758
	public abstract class BaseSyncEvent : GClass2885, GInterface341, GInterface342
	{
		// Token: 0x0600C1D2 RID: 49618
		public abstract void Serialize(ref GInterface79 writerStream);

		// Token: 0x0600C1D3 RID: 49619
		public abstract void Deserialize(ref GInterface76 readerStream);
	}
}
