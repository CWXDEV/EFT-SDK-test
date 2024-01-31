using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT
{
	// Token: 0x020016A8 RID: 5800
	public class ScenesPreset : ScriptableObject
	{
		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06007D4D RID: 32077 RVA: 0x00002050 File Offset: 0x00000250
		public string ActiveSceneName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06007D4E RID: 32078 RVA: 0x00002050 File Offset: 0x00000250
		public string PresetName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06007D4F RID: 32079 RVA: 0x00002050 File Offset: 0x00000250
		public SceneResourceKey[] ScenesResourceKeys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableServerScenes(bool val)
		{
			throw null;
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(ISceneResource scene)
		{
			throw null;
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetTotalSceneCount()
		{
			throw null;
		}

		// Token: 0x04008438 RID: 33848
		public ScenesPreset.Guid ActiveSceneGuid;

		// Token: 0x04008439 RID: 33849
		public string ServerName;

		// Token: 0x0400843A RID: 33850
		public List<ScenesPreset.Guid> ScenesGuids;

		// Token: 0x0400843B RID: 33851
		private bool bool_0;

		// Token: 0x0400843C RID: 33852
		public ScenesPreset[] ChildPresets;

		// Token: 0x0400843D RID: 33853
		[SerializeField]
		[FormerlySerializedAs("ActiveSceneName")]
		private string _activeSceneName;

		// Token: 0x0400843E RID: 33854
		[SerializeField]
		[FormerlySerializedAs("ScenesResourceKeys")]
		private List<SceneResourceKey> _scenesResourceKeys;

		// Token: 0x020016A9 RID: 5801
		[Serializable]
		public class Guid : ISceneResource
		{
			// Token: 0x170013B1 RID: 5041
			// (get) Token: 0x06007D53 RID: 32083 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007D54 RID: 32084 RVA: 0x00002050 File Offset: 0x00000250
			public bool onlyOffline
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x0400843F RID: 33855
			public string guid;

			// Token: 0x04008440 RID: 33856
			[SerializeField]
			private bool _onlyOffline;
		}

		// Token: 0x020016AA RID: 5802
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1193
		{
			// Token: 0x06007D55 RID: 32085 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(ScenesPreset x)
			{
				throw null;
			}

			// Token: 0x04008441 RID: 33857
			public static readonly ScenesPreset.Class1193 class1193_0;

			// Token: 0x04008442 RID: 33858
			public static Func<ScenesPreset, int> func_0;
		}
	}
}
