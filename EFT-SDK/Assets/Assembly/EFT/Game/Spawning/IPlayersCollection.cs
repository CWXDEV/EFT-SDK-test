using System;
using System.Collections;
using System.Collections.Generic;

namespace EFT.Game.Spawning
{
	// Token: 0x0200268F RID: 9871
	public interface IPlayersCollection : IEnumerable, IEnumerable<IPlayer>
	{
		// Token: 0x140002C7 RID: 711
		// (add) Token: 0x0600C3BB RID: 50107
		// (remove) Token: 0x0600C3BC RID: 50108
		event Action<IPlayer> OnPersonAdd;
	}
}
