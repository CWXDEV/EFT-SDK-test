using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x0200318A RID: 12682
	public abstract class SmoothPathGenerator : PathGenerator
	{
		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x0600F9F3 RID: 63987 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual int JointSmoothingLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x0600F9F4 RID: 63988 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual float JointSizeLink
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F9F5 RID: 63989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Clear()
		{
			throw null;
		}

		// Token: 0x0600F9F6 RID: 63990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600F9F7 RID: 63991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool EnsureMeshFilter()
		{
			throw null;
		}

		// Token: 0x0600F9F8 RID: 63992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMesh(Mesh mesh)
		{
			throw null;
		}

		// Token: 0x0600F9F9 RID: 63993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Quaternion LookRotation(Vector3 diff)
		{
			throw null;
		}

		// Token: 0x0600F9FA RID: 63994 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector3 from, Vector3 curr, Vector3 to)
		{
			throw null;
		}

		// Token: 0x0600F9FB RID: 63995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ModifyPath(Vector3[] path, bool closed, List<Vector3> res)
		{
			throw null;
		}

		// Token: 0x0600F9FC RID: 63996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ModifyPath(Vector3[] path, bool closed)
		{
			throw null;
		}

		// Token: 0x0400FE19 RID: 65049
		public int JointSmoothing;

		// Token: 0x0400FE1A RID: 65050
		public float JointSize;

		// Token: 0x0400FE1B RID: 65051
		protected List<int> SkipJoints;

		// Token: 0x0400FE1C RID: 65052
		private readonly List<Vector3> list_0;

		// Token: 0x0400FE1D RID: 65053
		protected List<Vector3> TmpCenters;

		// Token: 0x0400FE1E RID: 65054
		private MeshFilter meshFilter_0;

		// Token: 0x0400FE1F RID: 65055
		private Mesh mesh_0;
	}
}
