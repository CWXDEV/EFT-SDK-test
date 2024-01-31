using System;
using System.Runtime.CompilerServices;
using EFT.SpeedTree;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DF7 RID: 7671
	public class WindController : MonoBehaviour
	{
		// Token: 0x06009DFE RID: 40446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWind(TreeWind.Settings[] windSettings)
		{
			throw null;
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWind(Vector2 wind)
		{
			throw null;
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector2 wind)
		{
			throw null;
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400A630 RID: 42544
		private static readonly int int_0;

		// Token: 0x0400A631 RID: 42545
		private static readonly int int_1;

		// Token: 0x0400A632 RID: 42546
		private static readonly int int_2;

		// Token: 0x0400A633 RID: 42547
		private static readonly int int_3;

		// Token: 0x0400A634 RID: 42548
		public ComputeShader _windShader;

		// Token: 0x0400A635 RID: 42549
		public WiresController Wires;

		// Token: 0x0400A636 RID: 42550
		public float RainWindMultiplier;

		// Token: 0x0400A637 RID: 42551
		public float CloudWindMultiplier;

		// Token: 0x0400A638 RID: 42552
		public float BilboardTreesWindMultiplier;

		// Token: 0x0400A639 RID: 42553
		[SerializeField]
		private Vector2 defaultWindVector;

		// Token: 0x0400A63A RID: 42554
		private Vector2 vector2_0;

		// Token: 0x0400A63B RID: 42555
		private Class1797 class1797_0;

		// Token: 0x02001DF8 RID: 7672
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1798
		{
			// Token: 0x06009E04 RID: 40452 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GStruct256 method_0(TreeWind.Settings settings)
			{
				throw null;
			}

			// Token: 0x0400A63C RID: 42556
			public static readonly WindController.Class1798 class1798_0;

			// Token: 0x0400A63D RID: 42557
			public static Func<TreeWind.Settings, GStruct256> func_0;
		}
	}
}
