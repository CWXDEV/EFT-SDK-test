using System;
using System.Runtime.CompilerServices;

namespace Bsg.GameSettings
{
	// Token: 0x02000CF5 RID: 3317
	[Serializable]
	public class EquatableGameSetting<T> : StateGameSetting<T> where T : IEquatable<T>
	{
		// Token: 0x060046DE RID: 18142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool HasSameValue(GameSetting<T> other)
		{
			throw null;
		}
	}
}
