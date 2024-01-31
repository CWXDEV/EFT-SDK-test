using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.AI
{
	// Token: 0x0200309E RID: 12446
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[ExecuteInEditMode]
	public class NavMeshModifier : MonoBehaviour
	{
		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600F432 RID: 62514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F433 RID: 62515 RVA: 0x00002050 File Offset: 0x00000250
		public bool overrideArea
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

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600F434 RID: 62516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F435 RID: 62517 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600F436 RID: 62518 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F437 RID: 62519 RVA: 0x00002050 File Offset: 0x00000250
		public bool ignoreFromBuild
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

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0600F438 RID: 62520 RVA: 0x00002050 File Offset: 0x00000250
		public static List<NavMeshModifier> activeModifiers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F439 RID: 62521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600F43A RID: 62522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600F43B RID: 62523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool AffectsAgentType(int agentTypeID)
		{
			throw null;
		}

		// Token: 0x0400FA64 RID: 64100
		[SerializeField]
		private bool m_OverrideArea;

		// Token: 0x0400FA65 RID: 64101
		[SerializeField]
		private int m_Area;

		// Token: 0x0400FA66 RID: 64102
		[SerializeField]
		private bool m_IgnoreFromBuild;

		// Token: 0x0400FA67 RID: 64103
		[SerializeField]
		private List<int> m_AffectedAgents;

		// Token: 0x0400FA68 RID: 64104
		private static readonly List<NavMeshModifier> list_0;
	}
}
