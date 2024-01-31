using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001778 RID: 6008
	public sealed class Sounds : ScriptableObject
	{
		// Token: 0x0600806A RID: 32874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SurfaceSet GetSurfaceSet(BaseBallistic.ESurfaceSound surfaceSound)
		{
			throw null;
		}

		// Token: 0x040088D4 RID: 35028
		public SurfaceSet[] Sets;

		// Token: 0x040088D5 RID: 35029
		public SoundBank Gear;

		// Token: 0x040088D6 RID: 35030
		public SoundBank GearFast;

		// Token: 0x040088D7 RID: 35031
		public SoundBank GearVault;

		// Token: 0x040088D8 RID: 35032
		public SoundBank GearSprintVault;

		// Token: 0x040088D9 RID: 35033
		public SoundBank GearClimb;

		// Token: 0x040088DA RID: 35034
		public AudioClip TinnitusSound;

		// Token: 0x040088DB RID: 35035
		public AudioClip FractureSound;

		// Token: 0x040088DC RID: 35036
		public AudioClip FaceShieldOn;

		// Token: 0x040088DD RID: 35037
		public AudioClip FaceShieldOff;

		// Token: 0x040088DE RID: 35038
		public AudioClip NightVisionOn;

		// Token: 0x040088DF RID: 35039
		public AudioClip NightVisionOff;

		// Token: 0x040088E0 RID: 35040
		public AudioClip ThermalVisionOn;

		// Token: 0x040088E1 RID: 35041
		public AudioClip ThermalVisionOff;

		// Token: 0x040088E2 RID: 35042
		public AudioClip PropIn;

		// Token: 0x040088E3 RID: 35043
		public AudioClip PropOut;

		// Token: 0x040088E4 RID: 35044
		public AudioClip SwitchHeadlights;
	}
}
