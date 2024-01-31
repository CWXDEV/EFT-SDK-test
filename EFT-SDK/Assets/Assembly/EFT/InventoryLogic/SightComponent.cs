using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.InventoryLogic
{
	// Token: 0x020022AF RID: 8879
	public class SightComponent : GClass2750
	{
		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600B46C RID: 46188 RVA: 0x00002050 File Offset: 0x00000250
		public int ScopesCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600B46D RID: 46189 RVA: 0x00002050 File Offset: 0x00000250
		public string CustomAimPlane
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x0600B46E RID: 46190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B46F RID: 46191 RVA: 0x00002050 File Offset: 0x00000250
		public int SelectedScopeIndex
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

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x0600B470 RID: 46192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B471 RID: 46193 RVA: 0x00002050 File Offset: 0x00000250
		public int SelectedScopeMode
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

		// Token: 0x0600B472 RID: 46194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetScopeMode(int scopeIndex, int mode)
		{
			throw null;
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetScopeModesCount(int scopeIndex)
		{
			throw null;
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int[] GetScopeCalibrationDistances(int scopeIndex)
		{
			throw null;
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600B475 RID: 46197 RVA: 0x00002050 File Offset: 0x00000250
		public float GetCurrentSensitivity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0(int scopeIndex)
		{
			throw null;
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasOpticCalibrationPoints(int scopeIndex)
		{
			throw null;
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetScopeCaliabrationPoints(int scopeIndex, Vector3[] points)
		{
			throw null;
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetCurrentOpticCalibrationPoint()
		{
			throw null;
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedOpticCalibrationPoint(int scope, int index)
		{
			throw null;
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCurrentOpticCalibrationDistance()
		{
			throw null;
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetCurrentOpticZoom()
		{
			throw null;
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasCurrentZoomGreaterThenOne()
		{
			throw null;
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpticCalibrationPointUp()
		{
			throw null;
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OpticCalibrationPointDown()
		{
			throw null;
		}

		// Token: 0x0400B87A RID: 47226
		public Vector3[][] OpticCalibrationPoints;

		// Token: 0x0400B87B RID: 47227
		private GInterface301 _template;

		// Token: 0x0400B87C RID: 47228
		public int[] ScopesCurrentCalibPointIndexes;

		// Token: 0x0400B87D RID: 47229
		public int[] ScopesSelectedModes;

		// Token: 0x0400B87E RID: 47230
		public int SelectedScope;
	}
}
