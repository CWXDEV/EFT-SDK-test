using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

namespace Koenigz.PerfectCulling
{
	// Token: 0x02000D81 RID: 3457
	[RequireComponent(typeof(Camera))]
	public class PerfectCullingCamera : MonoBehaviour
	{
		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600491E RID: 18718 RVA: 0x00002050 File Offset: 0x00000250
		public bool VisualizeFrustumCulling
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004920 RID: 18720 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 ObservePosition
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ScriptableRenderContext context, Camera camera)
		{
			throw null;
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Camera camera)
		{
			throw null;
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2()
		{
			throw null;
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3()
		{
			throw null;
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Camera camera)
		{
			throw null;
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_5()
		{
			throw null;
		}

		// Token: 0x0400548C RID: 21644
		public static List<PerfectCullingCamera> AllCameras;

		// Token: 0x0400548D RID: 21645
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400548E RID: 21646
		[CompilerGenerated]
		private Vector3 vector3_0;

		// Token: 0x0400548F RID: 21647
		private static int int_0;

		// Token: 0x04005490 RID: 21648
		private static int int_1;

		// Token: 0x04005491 RID: 21649
		private static int int_2;

		// Token: 0x04005492 RID: 21650
		private Camera camera_0;

		// Token: 0x04005493 RID: 21651
		private GClass1013<int> gclass1013_0;

		// Token: 0x04005494 RID: 21652
		private GClass1013<int> gclass1013_1;

		// Token: 0x04005495 RID: 21653
		private JobHandle? nullable_0;
	}
}
