using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000DBC RID: 3516
	[CreateAssetMenu]
	[PreferBinarySerialization]
	public class PerfectCullingVolumeBakeData : PerfectCullingBakeData
	{
		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x00002050 File Offset: 0x00000250
		public int RuntimeAssetSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVolumeBakeData(Vector3 cellSize, Vector3 cellCount)
		{
			throw null;
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PrepareForBake(PerfectCullingBakingBehaviour bakingBehaviour)
		{
			throw null;
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ushort[] GetRawData(int index)
		{
			throw null;
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetRawData(int index, ushort[] indices)
		{
			throw null;
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetRawData(int index, GClass1001 indices)
		{
			throw null;
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int index, ushort[] indices)
		{
			throw null;
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CompleteBake()
		{
			throw null;
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeDownsample()
		{
			throw null;
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SampleAtIndex(int index, List<ushort> indices)
		{
			throw null;
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SampleAtIndexFast(int index, GClass1013<ushort> indices)
		{
			throw null;
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void smethod_0(int value, List<int> values)
		{
			throw null;
		}

		// Token: 0x0400554E RID: 21838
		public Vector3 cellCount;

		// Token: 0x0400554F RID: 21839
		public Vector3 cellSize;

		// Token: 0x04005550 RID: 21840
		public Vector3 originalCellSize;

		// Token: 0x04005551 RID: 21841
		public Quaternion orientation;

		// Token: 0x04005552 RID: 21842
		public PerfectCullingVolumeBakeData.VisibilitySet[] data;

		// Token: 0x04005553 RID: 21843
		public PerfectCullingVolumeBakeData.RawData[] rawData;

		// Token: 0x04005554 RID: 21844
		[NonSerialized]
		public int runtimeAssetSize;

		// Token: 0x04005555 RID: 21845
		public int maxStoredIndex;

		// Token: 0x04005556 RID: 21846
		public int numberOfGroups;

		// Token: 0x04005557 RID: 21847
		public string volumeGuid;

		// Token: 0x04005558 RID: 21848
		public string groupGuid;

		// Token: 0x04005559 RID: 21849
		public const int MaxValue = 15;

		// Token: 0x0400555A RID: 21850
		public const int HeaderBitSize = 2;

		// Token: 0x0400555B RID: 21851
		public static uint[] BITS;

		// Token: 0x0400555C RID: 21852
		private static GClass1022 gclass1022_0;

		// Token: 0x0400555D RID: 21853
		private static GClass1023 gclass1023_0;

		// Token: 0x02000DBD RID: 3517
		[Serializable]
		public struct VisibilitySet
		{
			// Token: 0x0400555E RID: 21854
			public byte[] compressed;

			// Token: 0x0400555F RID: 21855
			public ushort numDeltaValues;
		}

		// Token: 0x02000DBE RID: 3518
		[Serializable]
		public struct RawData
		{
			// Token: 0x04005560 RID: 21856
			public ushort[] uncompressed;
		}

		// Token: 0x02000DBF RID: 3519
		[CompilerGenerated]
		private sealed class Class698
		{
			// Token: 0x06004A3A RID: 19002 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0(IGrouping<int, int> groups)
			{
				throw null;
			}

			// Token: 0x04005561 RID: 21857
			public PerfectCullingVolumeBakeData perfectCullingVolumeBakeData_0;

			// Token: 0x04005562 RID: 21858
			public Vector3Int OptimizedCellSize;

			// Token: 0x04005563 RID: 21859
			public Vector3Int optDim;

			// Token: 0x04005564 RID: 21860
			public PerfectCullingVolumeBakeData tmpBakeData;

			// Token: 0x04005565 RID: 21861
			public int processedElementCount;
		}

		// Token: 0x02000DC0 RID: 3520
		[CompilerGenerated]
		private sealed class Class699
		{
			// Token: 0x06004A3B RID: 19003 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0()
			{
				throw null;
			}

			// Token: 0x04005566 RID: 21862
			public IGrouping<int, int> groups;

			// Token: 0x04005567 RID: 21863
			public PerfectCullingVolumeBakeData.Class698 class698_0;

			// Token: 0x02000DC1 RID: 3521
			[StructLayout(LayoutKind.Auto)]
			public struct Struct156 : IAsyncStateMachine
			{
				// Token: 0x06004A3C RID: 19004 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x06004A3D RID: 19005 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x04005568 RID: 21864
				public int int_0;

				// Token: 0x04005569 RID: 21865
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400556A RID: 21866
				public PerfectCullingVolumeBakeData.Class699 class699_0;
			}
		}

		// Token: 0x02000DC2 RID: 3522
		[CompilerGenerated]
		[Serializable]
		private sealed class Class700
		{
			// Token: 0x06004A3E RID: 19006 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(int val)
			{
				throw null;
			}

			// Token: 0x0400556B RID: 21867
			public static readonly PerfectCullingVolumeBakeData.Class700 class700_0;

			// Token: 0x0400556C RID: 21868
			public static Func<int, int> func_0;
		}
	}
}
