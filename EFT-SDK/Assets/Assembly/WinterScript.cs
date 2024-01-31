using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BA1 RID: 2977
public class WinterScript : MonoBehaviour
{
	// Token: 0x06004097 RID: 16535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06004098 RID: 16536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06004099 RID: 16537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600409A RID: 16538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600409B RID: 16539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color smethod_0(Color color)
	{
		throw null;
	}

	// Token: 0x0600409D RID: 16541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600409E RID: 16542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static LinkedList<Renderer> smethod_1()
	{
		throw null;
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Vector2 smethod_2()
	{
		throw null;
	}

	// Token: 0x0400498D RID: 18829
	public float debugValue;

	// Token: 0x0400498E RID: 18830
	public bool debugWrite;

	// Token: 0x0400498F RID: 18831
	public Texture SnowTex;

	// Token: 0x04004990 RID: 18832
	public float StartTime;

	// Token: 0x04004991 RID: 18833
	public AnimationCurve SnowLevelCurve;

	// Token: 0x04004992 RID: 18834
	public AnimationCurve SnowFallingCurve;

	// Token: 0x04004993 RID: 18835
	public AnimationCurve DesaturateSunCurve;

	// Token: 0x04004994 RID: 18836
	public AnimationCurve SunIntensityCurve;

	// Token: 0x04004995 RID: 18837
	public AnimationCurve SoundsLerpCurve;

	// Token: 0x04004996 RID: 18838
	public AudioClip[] SnowStepClip;

	// Token: 0x04004997 RID: 18839
	public AudioClip SnowyWind;

	// Token: 0x04004998 RID: 18840
	public AnimationCurve MusicFadeOut;

	// Token: 0x04004999 RID: 18841
	public AnimationCurve MusicFadeIn;

	// Token: 0x0400499A RID: 18842
	public AnimationCurve BreathCurve;

	// Token: 0x0400499B RID: 18843
	public float FadeShadow;

	// Token: 0x0400499C RID: 18844
	public float FadeScratches;

	// Token: 0x0400499D RID: 18845
	public float FadeFog;

	// Token: 0x0400499E RID: 18846
	private Light light_0;

	// Token: 0x0400499F RID: 18847
	private Color color_0;

	// Token: 0x040049A0 RID: 18848
	private Color color_1;

	// Token: 0x040049A1 RID: 18849
	private float float_0;

	// Token: 0x040049A2 RID: 18850
	private float float_1;

	// Token: 0x040049A3 RID: 18851
	private float float_2;

	// Token: 0x040049A4 RID: 18852
	private AudioSource audioSource_0;

	// Token: 0x040049A5 RID: 18853
	private AudioSource audioSource_1;

	// Token: 0x040049A6 RID: 18854
	private LinkedList<WinterScript.GClass877> linkedList_0;

	// Token: 0x040049A7 RID: 18855
	public Transform BreathSystem;

	// Token: 0x040049A8 RID: 18856
	private Transform transform_0;

	// Token: 0x040049A9 RID: 18857
	private ParticleSystem particleSystem_0;

	// Token: 0x040049AA RID: 18858
	private Transform transform_1;

	// Token: 0x040049AB RID: 18859
	public LayerMask DepthRendererMask;

	// Token: 0x040049AC RID: 18860
	public Material DepthMaterial;

	// Token: 0x040049AD RID: 18861
	public Material TerrainMaterial;

	// Token: 0x040049AE RID: 18862
	private WinterScript.GClass878 gclass878_0;

	// Token: 0x040049AF RID: 18863
	public AnimationCurve TerrainDetailCurve;

	// Token: 0x040049B0 RID: 18864
	public Texture2D[] TerrainDetails;

	// Token: 0x040049B1 RID: 18865
	private static readonly int int_0;

	// Token: 0x02000BA2 RID: 2978
	public class GClass877
	{
		// Token: 0x060040A0 RID: 16544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(float f)
		{
			throw null;
		}

		// Token: 0x040049B2 RID: 18866
		private AudioClip audioClip_0;

		// Token: 0x040049B3 RID: 18867
		private float[] float_0;

		// Token: 0x040049B4 RID: 18868
		private float[] float_1;

		// Token: 0x040049B5 RID: 18869
		private float[] float_2;

		// Token: 0x040049B6 RID: 18870
		private int int_0;
	}

	// Token: 0x02000BA3 RID: 2979
	public class GClass878
	{
		// Token: 0x060040A1 RID: 16545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(float t)
		{
			throw null;
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(Color32[] source, Color32[] current, int[] green)
		{
			throw null;
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte smethod_1(byte a, int b)
		{
			throw null;
		}

		// Token: 0x040049B7 RID: 18871
		private TerrainData terrainData_0;

		// Token: 0x040049B8 RID: 18872
		private DetailPrototype[] detailPrototype_0;

		// Token: 0x040049B9 RID: 18873
		private WinterScript.GClass878.Class610[] class610_0;

		// Token: 0x040049BA RID: 18874
		private int[] int_0;

		// Token: 0x040049BB RID: 18875
		private Color32[] color32_0;

		// Token: 0x040049BC RID: 18876
		private Color32[] color32_1;

		// Token: 0x040049BD RID: 18877
		private Texture2D texture2D_0;

		// Token: 0x040049BE RID: 18878
		private float float_0;

		// Token: 0x02000BA4 RID: 2980
		private class Class610
		{
			// Token: 0x060040A4 RID: 16548 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Lerp(float t)
			{
				throw null;
			}

			// Token: 0x060040A5 RID: 16549 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static Color smethod_0(Color a, Color b, float t)
			{
				throw null;
			}

			// Token: 0x040049BF RID: 18879
			private static readonly Color color_0;

			// Token: 0x040049C0 RID: 18880
			private DetailPrototype detailPrototype_0;

			// Token: 0x040049C1 RID: 18881
			private Color color_1;

			// Token: 0x040049C2 RID: 18882
			private Color color_2;
		}
	}
}
