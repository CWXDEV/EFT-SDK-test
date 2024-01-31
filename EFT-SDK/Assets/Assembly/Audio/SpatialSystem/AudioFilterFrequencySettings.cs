using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D27 RID: 3367
	[Serializable]
	public class AudioFilterFrequencySettings
	{
		// Token: 0x060047A6 RID: 18342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetLowerFrequency(Vector3 soundPosition, Vector3 listenerPosition, float obstruction, float propagation, bool isolated = false)
		{
			throw null;
		}

		// Token: 0x0400528B RID: 21131
		[Range(100f, 22000f)]
		[SerializeField]
		private float _defaultIndoorOcclusionFrequency;

		// Token: 0x0400528C RID: 21132
		[SerializeField]
		[Range(100f, 22000f)]
		private float _defaultOutdoorOcclusionFrequency;

		// Token: 0x0400528D RID: 21133
		[SerializeField]
		[Range(100f, 22000f)]
		private float _lowerOcclusionFrequency;

		// Token: 0x0400528E RID: 21134
		[SerializeField]
		[Range(100f, 22000f)]
		private float _upperOcclusionFrequency;

		// Token: 0x0400528F RID: 21135
		[Range(100f, 22000f)]
		[SerializeField]
		private float _wallOcclusionFrequency;

		// Token: 0x04005290 RID: 21136
		[Range(100f, 22000f)]
		[SerializeField]
		private float _fullOcclusionFrequency;

		// Token: 0x04005291 RID: 21137
		[SerializeField]
		[Range(100f, 22000f)]
		private float _differentEnvironmentsFrequency;
	}
}
