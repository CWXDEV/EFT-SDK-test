using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027D0 RID: 10192
	public class BetterPropagationGroups : MonoBehaviour
	{
		// Token: 0x0600CC4A RID: 52298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetVolumes(Vector3 position, in List<BetterPropagationVolume> buffer)
		{
			throw null;
		}

		// Token: 0x0600CC4B RID: 52299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BetterPropagationVolume> GetIsolatedVolumes(Vector3 position, List<BetterPropagationVolume> volumesBuffer)
		{
			throw null;
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Collect volumes")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400CC55 RID: 52309
		[Header("Keep Area size: X < Z and Y < W")]
		public BetterPropagationGroups.Volumes[] Groups;

		// Token: 0x0400CC56 RID: 52310
		private List<BetterPropagationVolume> list_0;

		// Token: 0x020027D1 RID: 10193
		[Serializable]
		public class Volumes
		{
			// Token: 0x0600CC4D RID: 52301 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Contains2dPoint(Vector3 position)
			{
				throw null;
			}

			// Token: 0x0400CC57 RID: 52311
			public Vector4 Area;

			// Token: 0x0400CC58 RID: 52312
			public BetterPropagationVolume[] PropagationVolumes;
		}

		// Token: 0x020027D2 RID: 10194
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2306
		{
			// Token: 0x0600CC4E RID: 52302 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(BetterPropagationVolume v)
			{
				throw null;
			}

			// Token: 0x0400CC59 RID: 52313
			public static readonly BetterPropagationGroups.Class2306 class2306_0;

			// Token: 0x0400CC5A RID: 52314
			public static Func<BetterPropagationVolume, float> func_0;
		}
	}
}
