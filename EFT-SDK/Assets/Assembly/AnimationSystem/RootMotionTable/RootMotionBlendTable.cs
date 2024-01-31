using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AnimationSystem.RootMotionTable
{
	// Token: 0x02001014 RID: 4116
	[CreateAssetMenu]
	public class RootMotionBlendTable : ScriptableObject, GInterface83
	{
		// Token: 0x06005612 RID: 22034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadNodes()
		{
			throw null;
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValidStateToStoreRotation(string stateName)
		{
			throw null;
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValidClipForCurvesDP(string clipName)
		{
			throw null;
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RootMotionBlendTable.ParameterSettings GetParameter(int paramHash)
		{
			throw null;
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RootMotionBlendTable.ParameterSettings GetParameter(string paramName)
		{
			throw null;
		}

		// Token: 0x04006235 RID: 25141
		public TextAsset GeneratedData;

		// Token: 0x04006236 RID: 25142
		public string AnimatorPath;

		// Token: 0x04006237 RID: 25143
		public string ClipsKeeperPath;

		// Token: 0x04006238 RID: 25144
		public string RootBoneName;

		// Token: 0x04006239 RID: 25145
		public List<RootMotionBlendTable.ParameterSettings> Parameters;

		// Token: 0x0400623A RID: 25146
		public List<string> StoreRotationStatesWhitelist;

		// Token: 0x0400623B RID: 25147
		public List<string> UsingCurvesForDPClipNames;

		// Token: 0x0400623C RID: 25148
		[NonSerialized]
		public Dictionary<int, GClass1237> _loadedNodes;

		// Token: 0x02001015 RID: 4117
		[Serializable]
		public class ParameterSettings
		{
			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x06005617 RID: 22039 RVA: 0x00002050 File Offset: 0x00000250
			public float Range
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x06005618 RID: 22040 RVA: 0x00002050 File Offset: 0x00000250
			public int TotalSteps
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005619 RID: 22041 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetValue(int step)
			{
				throw null;
			}

			// Token: 0x0600561A RID: 22042 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void GetStep(out int indexA, out int indexB, out float t, float value)
			{
				throw null;
			}

			// Token: 0x0400623D RID: 25149
			public string ParamName;

			// Token: 0x0400623E RID: 25150
			public float MinValue;

			// Token: 0x0400623F RID: 25151
			public float MaxValue;

			// Token: 0x04006240 RID: 25152
			public float StepDensity;

			// Token: 0x04006241 RID: 25153
			private int _cachedTotalSteps;

			// Token: 0x04006242 RID: 25154
			private bool _isCachedTotalSteps;
		}

		// Token: 0x02001016 RID: 4118
		[Serializable]
		public struct ParameterRelatedCurve
		{
			// Token: 0x04006243 RID: 25155
			public AnimationCurve curve;

			// Token: 0x04006244 RID: 25156
			public int parameterHash;
		}
	}
}
