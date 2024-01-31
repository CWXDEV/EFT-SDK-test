using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020006FC RID: 1788
public class GrenadeSettings : ThrowableSettings
{
	// Token: 0x1700073C RID: 1852
	// (get) Token: 0x060029CC RID: 10700 RVA: 0x00002050 File Offset: 0x00000250
	public string EmmisionEffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x040027E3 RID: 10211
	public GrenadeSettings.CollisionSounds CollisionSound;

	// Token: 0x040027E4 RID: 10212
	public Transform Skoba;

	// Token: 0x020006FD RID: 1789
	public enum CollisionSounds
	{
		// Token: 0x040027E6 RID: 10214
		frag,
		// Token: 0x040027E7 RID: 10215
		smoke,
		// Token: 0x040027E8 RID: 10216
		stun,
		// Token: 0x040027E9 RID: 10217
		smokeM18,
		// Token: 0x040027EA RID: 10218
		stunM7920
	}
}
