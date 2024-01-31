using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000DEC RID: 3564
	public sealed class PerfectCullingMaterialSettings : MonoBehaviour
	{
		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x00002050 File Offset: 0x00000250
		public bool IgnoreBatchedWindowsFilter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06004ACF RID: 19151 RVA: 0x00002050 File Offset: 0x00000250
		public Material[] ForceOpaqueMaterials
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x00002050 File Offset: 0x00000250
		public Material[] ForceTransparentMaterials
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsMaterialForcedOpaque(Material mat)
		{
			throw null;
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsMaterialForcedTransparent(Material mat)
		{
			throw null;
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingMaterialSettings Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400560E RID: 22030
		[SerializeField]
		private bool _ignoreBatchedWindowsFilter;

		// Token: 0x0400560F RID: 22031
		[SerializeField]
		private Material[] _forceOpaqueMaterials;

		// Token: 0x04005610 RID: 22032
		[SerializeField]
		private Material[] _forceTransparentMaterials;

		// Token: 0x04005611 RID: 22033
		private static PerfectCullingMaterialSettings perfectCullingMaterialSettings_0;

		// Token: 0x02000DED RID: 3565
		[CompilerGenerated]
		private sealed class Class704
		{
			// Token: 0x06004AD4 RID: 19156 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Material x)
			{
				throw null;
			}

			// Token: 0x04005612 RID: 22034
			public Material mat;
		}

		// Token: 0x02000DEE RID: 3566
		[CompilerGenerated]
		private sealed class Class705
		{
			// Token: 0x06004AD5 RID: 19157 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Material x)
			{
				throw null;
			}

			// Token: 0x04005613 RID: 22035
			public Material mat;
		}
	}
}
