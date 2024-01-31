using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E5F RID: 3679
	public class ColorPicker : MonoBehaviour
	{
		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004CDA RID: 19674 RVA: 0x00002050 File Offset: 0x00000250
		public Color Color
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

		// Token: 0x06004CDB RID: 19675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOnValueChangeCallback(Action<Color> onValueChange)
		{
			throw null;
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOnValueChangeCallback(Action onValueChange)
		{
			throw null;
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(Color color, out float h, out float s, out float v)
		{
			throw null;
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_1(GameObject go, out Vector2 result)
		{
			throw null;
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector2 smethod_2(GameObject go)
		{
			throw null;
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GameObject method_0(string name)
		{
			throw null;
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Color inputColor)
		{
			throw null;
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRandomColor()
		{
			throw null;
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400582D RID: 22573
		private Color color_0;

		// Token: 0x0400582E RID: 22574
		private Action<Color> action_0;

		// Token: 0x0400582F RID: 22575
		private Action action_1;

		// Token: 0x04005830 RID: 22576
		private Action action_2;

		// Token: 0x02000E60 RID: 3680
		[CompilerGenerated]
		private sealed class Class734
		{
			// Token: 0x06004CE5 RID: 19685 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06004CE6 RID: 19686 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x06004CE7 RID: 19687 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x06004CE8 RID: 19688 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x06004CE9 RID: 19689 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x06004CEA RID: 19690 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5()
			{
				throw null;
			}

			// Token: 0x04005831 RID: 22577
			public Texture2D satvalTex;

			// Token: 0x04005832 RID: 22578
			public Color[] satvalColors;

			// Token: 0x04005833 RID: 22579
			public float Hue;

			// Token: 0x04005834 RID: 22580
			public Color[] hueColors;

			// Token: 0x04005835 RID: 22581
			public Action resetSatValTexture;

			// Token: 0x04005836 RID: 22582
			public float Saturation;

			// Token: 0x04005837 RID: 22583
			public float Value;

			// Token: 0x04005838 RID: 22584
			public GameObject result;

			// Token: 0x04005839 RID: 22585
			public ColorPicker colorPicker_0;

			// Token: 0x0400583A RID: 22586
			public GameObject hueGO;

			// Token: 0x0400583B RID: 22587
			public Action dragH;

			// Token: 0x0400583C RID: 22588
			public GameObject satvalGO;

			// Token: 0x0400583D RID: 22589
			public Action dragSV;

			// Token: 0x0400583E RID: 22590
			public Vector2 hueSz;

			// Token: 0x0400583F RID: 22591
			public Action applyHue;

			// Token: 0x04005840 RID: 22592
			public Action applySaturationValue;

			// Token: 0x04005841 RID: 22593
			public GameObject hueKnob;

			// Token: 0x04005842 RID: 22594
			public Action idle;

			// Token: 0x04005843 RID: 22595
			public Vector2 satvalSz;

			// Token: 0x04005844 RID: 22596
			public GameObject satvalKnob;
		}
	}
}
