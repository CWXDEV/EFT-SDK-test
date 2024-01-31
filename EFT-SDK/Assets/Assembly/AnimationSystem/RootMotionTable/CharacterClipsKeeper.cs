using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AnimationSystem.RootMotionTable
{
	// Token: 0x02001006 RID: 4102
	public sealed class CharacterClipsKeeper : ScriptableObject
	{
		// Token: 0x060055B1 RID: 21937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetClipIndex(int layerIndex, AnimationClip clip)
		{
			throw null;
		}

		// Token: 0x040061EE RID: 25070
		public CharacterClipsKeeper.LayerData[] Clips;

		// Token: 0x02001007 RID: 4103
		[Serializable]
		public struct LayerData
		{
			// Token: 0x040061EF RID: 25071
			public CharacterClipsKeeper.AnimationClipData[] clips;
		}

		// Token: 0x02001008 RID: 4104
		[Serializable]
		public struct AnimationClipData
		{
			// Token: 0x040061F0 RID: 25072
			public AnimationClip clip;

			// Token: 0x040061F1 RID: 25073
			public RootMotionBlendTable.ParameterRelatedCurve[] parameterRelatedCurves;
		}
	}
}
