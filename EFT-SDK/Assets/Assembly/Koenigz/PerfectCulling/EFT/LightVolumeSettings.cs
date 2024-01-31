using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DE2 RID: 3554
	[RequireComponent(typeof(PerfectCullingLightGroupPreProcess))]
	public sealed class LightVolumeSettings : MonoBehaviour
	{
		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06004AC7 RID: 19143 RVA: 0x00002050 File Offset: 0x00000250
		public IReadOnlyCollection<LightVolumeSettings.LightSettings> LightBakeParameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LightVolumeSettings.LightSettings GetLightSettings(CullingObject light)
		{
			throw null;
		}

		// Token: 0x040055EA RID: 21994
		[SerializeField]
		private List<LightVolumeSettings.LightSettings> _lightParameters;

		// Token: 0x02000DE3 RID: 3555
		[Serializable]
		public sealed class LightSettings
		{
			// Token: 0x040055EB RID: 21995
			public CullingObject LightObject;

			// Token: 0x040055EC RID: 21996
			public Vector3 Offset;

			// Token: 0x040055ED RID: 21997
			public Quaternion Rotation;

			// Token: 0x040055EE RID: 21998
			public LightMeshQuality MeshQuality;

			// Token: 0x040055EF RID: 21999
			public float RangeModifier;

			// Token: 0x040055F0 RID: 22000
			public float CollisionMargin;

			// Token: 0x040055F1 RID: 22001
			public float SpotAngleModifier;
		}

		// Token: 0x02000DE4 RID: 3556
		[CompilerGenerated]
		private sealed class Class703
		{
			// Token: 0x06004AC9 RID: 19145 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(LightVolumeSettings.LightSettings x)
			{
				throw null;
			}

			// Token: 0x040055F2 RID: 22002
			public CullingObject light;
		}
	}
}
