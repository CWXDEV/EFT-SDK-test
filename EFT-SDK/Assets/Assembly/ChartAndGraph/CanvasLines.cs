using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace ChartAndGraph
{
	// Token: 0x02003147 RID: 12615
	public class CanvasLines : MaskableGraphic
	{
		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0600F769 RID: 63337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F76A RID: 63338 RVA: 0x00002050 File Offset: 0x00000250
		public float Tiling
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

		// Token: 0x140003A0 RID: 928
		// (add) Token: 0x0600F76B RID: 63339 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F76C RID: 63340 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, Vector2> Hover
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

		// Token: 0x140003A1 RID: 929
		// (add) Token: 0x0600F76D RID: 63341 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F76E RID: 63342 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, Vector2> Click
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

		// Token: 0x140003A2 RID: 930
		// (add) Token: 0x0600F76F RID: 63343 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600F770 RID: 63344 RVA: 0x00002050 File Offset: 0x00000250
		public event Action Leave
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

		// Token: 0x0600F771 RID: 63345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetViewRect(Rect r, Rect uvRect)
		{
			throw null;
		}

		// Token: 0x0600F772 RID: 63346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChartItemEffect LockHoverObject(int index)
		{
			throw null;
		}

		// Token: 0x0600F773 RID: 63347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ChartItemEffect obj)
		{
			throw null;
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHoverPrefab(ChartItemEffect prefab)
		{
			throw null;
		}

		// Token: 0x0600F775 RID: 63349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MakePointRender(float pointSize)
		{
			throw null;
		}

		// Token: 0x0600F776 RID: 63350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MakeFillRender(Rect fillRect, bool stretchY)
		{
			throw null;
		}

		// Token: 0x0600F777 RID: 63351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(List<Vector4> lines)
		{
			throw null;
		}

		// Token: 0x0600F778 RID: 63352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(List<CanvasLines.Class3188> lines)
		{
			throw null;
		}

		// Token: 0x0600F779 RID: 63353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateMaterial()
		{
			throw null;
		}

		// Token: 0x0600F77A RID: 63354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector3 point, Vector3 dir, Vector3 normal, float dist, float size, float z, out Vector3 p1, out Vector3 p2)
		{
			throw null;
		}

		// Token: 0x0600F77B RID: 63355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600F77C RID: 63356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0600F77D RID: 63357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F77E RID: 63358 RVA: 0x00002050 File Offset: 0x00000250
		public override Material material
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

		// Token: 0x0600F77F RID: 63359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		// Token: 0x0600F780 RID: 63360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<UIVertex> method_4()
		{
			throw null;
		}

		// Token: 0x0600F781 RID: 63361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector2 method_5(Vector2 uv)
		{
			throw null;
		}

		// Token: 0x0600F782 RID: 63362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<UIVertex> method_6()
		{
			throw null;
		}

		// Token: 0x0600F783 RID: 63363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<UIVertex> method_7()
		{
			throw null;
		}

		// Token: 0x0600F784 RID: 63364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<UIVertex> method_8()
		{
			throw null;
		}

		// Token: 0x0600F785 RID: 63365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			throw null;
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPopulateMesh(Mesh m)
		{
			throw null;
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(Vector3 mouse, out int segment, out int line)
		{
			throw null;
		}

		// Token: 0x0600F788 RID: 63368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(Vector3 mouse, out int i, out int j)
		{
			throw null;
		}

		// Token: 0x0600F789 RID: 63369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(Vector3 mouse, out int segment, out int point)
		{
			throw null;
		}

		// Token: 0x0600F78A RID: 63370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13([CanBeNull] ChartItemEffect hover)
		{
			throw null;
		}

		// Token: 0x0600F78C RID: 63372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(float x1, float y1, float x2, float y2, bool xAxis, bool oposite, ref Vector2 from, ref Vector2 to)
		{
			throw null;
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(Rect r, ref Vector2 from, ref Vector2 to)
		{
			throw null;
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(ChartItemEffect hover)
		{
			throw null;
		}

		// Token: 0x0600F78F RID: 63375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(ChartItemEffect hover)
		{
			throw null;
		}

		// Token: 0x0600F790 RID: 63376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(Vector3 mouse, bool leave)
		{
			throw null;
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleMouseMove()
		{
			throw null;
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleMouseMove(bool force)
		{
			throw null;
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x0400FCA0 RID: 64672
		public float Thickness;

		// Token: 0x0400FCA1 RID: 64673
		private float float_0;

		// Token: 0x0400FCA2 RID: 64674
		private bool bool_0;

		// Token: 0x0400FCA3 RID: 64675
		private bool bool_1;

		// Token: 0x0400FCA4 RID: 64676
		private float float_1;

		// Token: 0x0400FCA5 RID: 64677
		private Rect rect_0;

		// Token: 0x0400FCA6 RID: 64678
		private bool bool_2;

		// Token: 0x0400FCA7 RID: 64679
		private Material material_0;

		// Token: 0x0400FCA8 RID: 64680
		private SensitivityControl sensitivityControl_0;

		// Token: 0x0400FCA9 RID: 64681
		private ChartItemEffect chartItemEffect_0;

		// Token: 0x0400FCAA RID: 64682
		private ChartItemEffect chartItemEffect_1;

		// Token: 0x0400FCAB RID: 64683
		private List<ChartItemEffect> list_0;

		// Token: 0x0400FCAC RID: 64684
		private List<ChartItemEffect> list_1;

		// Token: 0x0400FCAD RID: 64685
		private List<CanvasLines.Class3188> list_2;

		// Token: 0x0400FCAE RID: 64686
		private bool bool_3;

		// Token: 0x0400FCAF RID: 64687
		private float float_2;

		// Token: 0x0400FCB0 RID: 64688
		private float float_3;

		// Token: 0x0400FCB1 RID: 64689
		private float float_4;

		// Token: 0x0400FCB2 RID: 64690
		private float float_5;

		// Token: 0x0400FCB3 RID: 64691
		private int int_0;

		// Token: 0x0400FCB4 RID: 64692
		private int int_1;

		// Token: 0x0400FCB5 RID: 64693
		private Vector2 vector2_0;

		// Token: 0x0400FCB6 RID: 64694
		private GraphicRaycaster graphicRaycaster_0;

		// Token: 0x0400FCB7 RID: 64695
		[CompilerGenerated]
		private Action<int, Vector2> action_0;

		// Token: 0x0400FCB8 RID: 64696
		[CompilerGenerated]
		private Action<int, Vector2> action_1;

		// Token: 0x0400FCB9 RID: 64697
		[CompilerGenerated]
		private Action action_2;

		// Token: 0x0400FCBA RID: 64698
		private Rect? nullable_0;

		// Token: 0x0400FCBB RID: 64699
		private GClass3397 gclass3397_0;

		// Token: 0x0400FCBC RID: 64700
		private Rect? nullable_1;

		// Token: 0x0400FCBD RID: 64701
		private bool bool_4;

		// Token: 0x0400FCBE RID: 64702
		public int refrenceIndex;

		// Token: 0x0400FCBF RID: 64703
		private UIVertex[] uivertex_0;

		// Token: 0x0400FCC0 RID: 64704
		private static readonly int int_2;

		// Token: 0x02003148 RID: 12616
		[StructLayout(LayoutKind.Auto)]
		public struct Struct1047
		{
			// Token: 0x17002AAC RID: 10924
			// (get) Token: 0x0600F794 RID: 63380 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F795 RID: 63381 RVA: 0x00002050 File Offset: 0x00000250
			public bool Degenerated
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

			// Token: 0x17002AAD RID: 10925
			// (get) Token: 0x0600F796 RID: 63382 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F797 RID: 63383 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 P1
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

			// Token: 0x17002AAE RID: 10926
			// (get) Token: 0x0600F798 RID: 63384 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F799 RID: 63385 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 P2
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

			// Token: 0x17002AAF RID: 10927
			// (get) Token: 0x0600F79A RID: 63386 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F79B RID: 63387 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 P3
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

			// Token: 0x17002AB0 RID: 10928
			// (get) Token: 0x0600F79C RID: 63388 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F79D RID: 63389 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 P4
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

			// Token: 0x17002AB1 RID: 10929
			// (get) Token: 0x0600F79E RID: 63390 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F79F RID: 63391 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 From
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

			// Token: 0x17002AB2 RID: 10930
			// (get) Token: 0x0600F7A0 RID: 63392 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F7A1 RID: 63393 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 To
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

			// Token: 0x17002AB3 RID: 10931
			// (get) Token: 0x0600F7A2 RID: 63394 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F7A3 RID: 63395 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 Dir
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

			// Token: 0x17002AB4 RID: 10932
			// (get) Token: 0x0600F7A4 RID: 63396 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F7A5 RID: 63397 RVA: 0x00002050 File Offset: 0x00000250
			public float Mag
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

			// Token: 0x17002AB5 RID: 10933
			// (get) Token: 0x0600F7A6 RID: 63398 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600F7A7 RID: 63399 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 Normal
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

			// Token: 0x0400FCC1 RID: 64705
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x0400FCC2 RID: 64706
			[CompilerGenerated]
			private Vector3 vector3_0;

			// Token: 0x0400FCC3 RID: 64707
			[CompilerGenerated]
			private Vector3 vector3_1;

			// Token: 0x0400FCC4 RID: 64708
			[CompilerGenerated]
			private Vector3 vector3_2;

			// Token: 0x0400FCC5 RID: 64709
			[CompilerGenerated]
			private Vector3 vector3_3;

			// Token: 0x0400FCC6 RID: 64710
			[CompilerGenerated]
			private Vector3 vector3_4;

			// Token: 0x0400FCC7 RID: 64711
			[CompilerGenerated]
			private Vector3 vector3_5;

			// Token: 0x0400FCC8 RID: 64712
			[CompilerGenerated]
			private Vector3 vector3_6;

			// Token: 0x0400FCC9 RID: 64713
			[CompilerGenerated]
			private float float_0;

			// Token: 0x0400FCCA RID: 64714
			[CompilerGenerated]
			private Vector3 vector3_7;
		}

		// Token: 0x02003149 RID: 12617
		internal class Class3188
		{
			// Token: 0x0600F7A8 RID: 63400 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ModifiyLines(List<Vector4> v)
			{
				throw null;
			}

			// Token: 0x17002AB6 RID: 10934
			// (get) Token: 0x0600F7A9 RID: 63401 RVA: 0x00002050 File Offset: 0x00000250
			public int PointCount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002AB7 RID: 10935
			// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x00002050 File Offset: 0x00000250
			public int LineCount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600F7AB RID: 63403 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector4 getPoint(int index)
			{
				throw null;
			}

			// Token: 0x0600F7AC RID: 63404 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void GetLine(int index, out Vector3 from, out Vector3 to)
			{
				throw null;
			}

			// Token: 0x0600F7AD RID: 63405 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public CanvasLines.Struct1047 GetLine(int index, float halfThickness, bool hasPrev, bool hasNext)
			{
				throw null;
			}

			// Token: 0x0400FCCB RID: 64715
			private List<Vector4> list_0;

			// Token: 0x0200314A RID: 12618
			[CompilerGenerated]
			[Serializable]
			private sealed class Class3189
			{
				// Token: 0x0600F7AE RID: 63406 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal Vector4 method_0(Vector3 x)
				{
					throw null;
				}

				// Token: 0x0400FCCC RID: 64716
				public static readonly CanvasLines.Class3188.Class3189 class3189_0;

				// Token: 0x0400FCCD RID: 64717
				public static Func<Vector3, Vector4> func_0;
			}
		}
	}
}
