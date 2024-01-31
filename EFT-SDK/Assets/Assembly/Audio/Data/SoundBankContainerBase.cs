using System;
using UnityEngine;

namespace Audio.Data
{
	// Token: 0x02000D67 RID: 3431
	public abstract class SoundBankContainerBase<T> : ScriptableObject where T : struct, Enum
	{
		// Token: 0x060048F6 RID: 18678
		public abstract bool TryGetBank(T soundType, out SoundBankWithSettings bank);
	}
}
