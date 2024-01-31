using System;

namespace EFT
{
	// Token: 0x020012B9 RID: 4793
	public interface ISerializer<T>
	{
		// Token: 0x0600638C RID: 25484
		T Deserialize();

		// Token: 0x0600638D RID: 25485
		object Serialize(T t);
	}
}
