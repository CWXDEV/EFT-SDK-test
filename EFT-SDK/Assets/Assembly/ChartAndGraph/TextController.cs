using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ChartAndGraph
{
	// Token: 0x0200318F RID: 12687
	[RequireComponent(typeof(ChartItem))]
	[ExecuteInEditMode]
	public class TextController : MonoBehaviour
	{
		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600FA13 RID: 64019 RVA: 0x00002050 File Offset: 0x00000250
		internal List<BillboardText> List_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600FA14 RID: 64020 RVA: 0x00002050 File Offset: 0x00000250
		private Canvas Canvas_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600FA15 RID: 64021 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FA16 RID: 64022 RVA: 0x00002050 File Offset: 0x00000250
		internal AnyChart AnyChart_0
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

		// Token: 0x0600FA17 RID: 64023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600FA18 RID: 64024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600FA19 RID: 64025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600FA1A RID: 64026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600FA1B RID: 64027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyAll()
		{
			throw null;
		}

		// Token: 0x0600FA1C RID: 64028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddText(BillboardText billboard)
		{
			throw null;
		}

		// Token: 0x0600FA1D RID: 64029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Camera method_2()
		{
			throw null;
		}

		// Token: 0x0600FA1E RID: 64030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Camera method_3(Camera cam)
		{
			throw null;
		}

		// Token: 0x0600FA1F RID: 64031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyTextPosition()
		{
			throw null;
		}

		// Token: 0x0400FE2B RID: 65067
		public Camera Camera;

		// Token: 0x0400FE2C RID: 65068
		public float PlaneDistance;

		// Token: 0x0400FE2D RID: 65069
		private const float PreviousScale = -1f;

		// Token: 0x0400FE2E RID: 65070
		private Canvas _canvas;

		// Token: 0x0400FE2F RID: 65071
		private bool _invalidated;

		// Token: 0x0400FE30 RID: 65072
		private AnyChart _privateParent;

		// Token: 0x0400FE31 RID: 65073
		private readonly List<BillboardText> _textList;

		// Token: 0x02003190 RID: 12688
		[CompilerGenerated]
		private sealed class Class3206
		{
			// Token: 0x0600FA20 RID: 64032 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BillboardText x)
			{
				throw null;
			}

			// Token: 0x0400FE32 RID: 65074
			public TextController textController_0;

			// Token: 0x0400FE33 RID: 65075
			public float scale;
		}
	}
}
