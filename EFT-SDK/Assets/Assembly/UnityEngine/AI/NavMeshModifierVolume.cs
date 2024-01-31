using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.AI
{
	// Token: 0x0200309F RID: 12447
	[ExecuteInEditMode]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0600F43C RID: 62524 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F43D RID: 62525 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 size
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

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0600F43E RID: 62526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F43F RID: 62527 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 center
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

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0600F440 RID: 62528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F441 RID: 62529 RVA: 0x00002050 File Offset: 0x00000250
		public int area
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

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600F442 RID: 62530 RVA: 0x00002050 File Offset: 0x00000250
		public static List<NavMeshModifierVolume> activeModifiers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F443 RID: 62531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600F444 RID: 62532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600F445 RID: 62533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AffectsAgentType(int agentTypeID)
		{
			throw null;
		}

		// Token: 0x0400FA69 RID: 64105
		[SerializeField]
		private Vector3 m_Size;

		// Token: 0x0400FA6A RID: 64106
		[SerializeField]
		private Vector3 m_Center;

		// Token: 0x0400FA6B RID: 64107
		[SerializeField]
		private int m_Area;

		// Token: 0x0400FA6C RID: 64108
		[SerializeField]
		private List<int> m_AffectedAgents;

		// Token: 0x0400FA6D RID: 64109
		private static readonly List<NavMeshModifierVolume> list_0;
	}
}
