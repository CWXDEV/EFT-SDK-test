using System;
using System.Runtime.CompilerServices;
using EFT.Vaulting.Models;
using UnityEngine;

namespace EFT.Vaulting.Debug.View
{
	// Token: 0x02001E7B RID: 7803
	public class EditorGridView : MonoBehaviour
	{
		// Token: 0x140001F4 RID: 500
		// (add) Token: 0x0600A003 RID: 40963 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600A004 RID: 40964 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnUpdateTransform
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x140001F5 RID: 501
		// (add) Token: 0x0600A005 RID: 40965 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600A006 RID: 40966 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnUpdateDrawGrid
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDataModel(GStruct263 dataModel)
		{
			throw null;
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Vector3 position, Color color)
		{
			throw null;
		}

		// Token: 0x0400A828 RID: 43048
		[SerializeField]
		private bool _drawRootPoint;

		// Token: 0x0400A829 RID: 43049
		[SerializeField]
		private bool _drawHitPoints;

		// Token: 0x0400A82A RID: 43050
		private GStruct263 gstruct263_0;

		// Token: 0x0400A82B RID: 43051
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400A82C RID: 43052
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x02001E7C RID: 7804
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1810
		{
			// Token: 0x0600A00C RID: 40972 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(VaultingPoint _)
			{
				throw null;
			}

			// Token: 0x0400A82D RID: 43053
			public static readonly EditorGridView.Class1810 class1810_0;

			// Token: 0x0400A82E RID: 43054
			public static Func<VaultingPoint, float> func_0;
		}
	}
}
