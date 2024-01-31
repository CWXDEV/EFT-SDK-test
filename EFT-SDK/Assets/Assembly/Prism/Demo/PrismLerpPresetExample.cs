using System;
using System.Runtime.CompilerServices;
using Prism.Utils;
using UnityEngine;

namespace Prism.Demo
{
	// Token: 0x02000D72 RID: 3442
	public class PrismLerpPresetExample : MonoBehaviour
	{
		// Token: 0x06004917 RID: 18711 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x040053F8 RID: 21496
		private PrismEffects prismEffects_0;

		// Token: 0x040053F9 RID: 21497
		[Header("NOTE: This is an example script, you should only have one per scene")]
		[Header("This script lerps a PRISM preset based on distance to the camera")]
		public float maxDistance;

		// Token: 0x040053FA RID: 21498
		public float t;

		// Token: 0x040053FB RID: 21499
		[Tooltip("The Prism-Preset to lerp TO")]
		public PrismPreset target;

		// Token: 0x040053FC RID: 21500
		public AnimationCurve cameraDistanceCurve;
	}
}
