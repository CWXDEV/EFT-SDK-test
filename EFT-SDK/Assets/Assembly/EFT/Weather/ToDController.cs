using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EFT.Weather
{
	// Token: 0x02001DED RID: 7661
	[Serializable]
	public class ToDController
	{
		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DAE RID: 40366 RVA: 0x00002050 File Offset: 0x00000250
		public SphericalHarmonicsL2 SH
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

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06009DAF RID: 40367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DB0 RID: 40368 RVA: 0x00002050 File Offset: 0x00000250
		public Color TopHorizontSkyColor
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

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06009DB1 RID: 40369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DB2 RID: 40370 RVA: 0x00002050 File Offset: 0x00000250
		public Color EnvironmentColor
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

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06009DB3 RID: 40371 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DB4 RID: 40372 RVA: 0x00002050 File Offset: 0x00000250
		public float HarmonicsDaylight
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

		// Token: 0x06009DB5 RID: 40373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ToDController.GStruct253 CalculateSphericalHarmonics(TOD_Sky todSky, float t, float t01)
		{
			throw null;
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Color smethod_0(Color color)
		{
			throw null;
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color SaturateColor(Color color, float t)
		{
			throw null;
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Color ContrastColor(Color color, float t)
		{
			throw null;
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Color smethod_1(float light, Color color, float t)
		{
			throw null;
		}

		// Token: 0x0400A591 RID: 42385
		[Header("midnight(-1) sunrize/sunset(0) midday(1)")]
		public Vector2 RayleighMultiplierMinMax;

		// Token: 0x0400A592 RID: 42386
		public AnimationCurve RayleighMultiplier;

		// Token: 0x0400A593 RID: 42387
		public Vector2 MieMultiplierMinMax;

		// Token: 0x0400A594 RID: 42388
		public AnimationCurve MieMultiplier;

		// Token: 0x0400A595 RID: 42389
		[Header("1 - DirectionalityMult * Directionality")]
		public float DirectionalityMult;

		// Token: 0x0400A596 RID: 42390
		public AnimationCurve Directionality;

		// Token: 0x0400A597 RID: 42391
		public Vector2 BrightnessMinMax;

		// Token: 0x0400A598 RID: 42392
		public AnimationCurve Brightness;

		// Token: 0x0400A599 RID: 42393
		public float ScatteringBrightnessMultiplier;

		// Token: 0x0400A59A RID: 42394
		public AnimationCurve ScatteringBrightness;

		// Token: 0x0400A59B RID: 42395
		public float BrightnessOvercast;

		// Token: 0x0400A59C RID: 42396
		public Vector2 ContrastMinMax;

		// Token: 0x0400A59D RID: 42397
		public AnimationCurve Contrast;

		// Token: 0x0400A59E RID: 42398
		public Vector2 MoonLightMinMax;

		// Token: 0x0400A59F RID: 42399
		[Space(16f)]
		public Gradient LightColor;

		// Token: 0x0400A5A0 RID: 42400
		[Header("SHAmbient")]
		public AmbientLight AmbientLightScript;

		// Token: 0x0400A5A1 RID: 42401
		public AmbientHighlight AmbientHighlightScript;

		// Token: 0x0400A5A2 RID: 42402
		public bool HighlightWithoutTopHarmonics;

		// Token: 0x0400A5A3 RID: 42403
		[Space(16f)]
		public AnimationCurve TopHarmonicIntensity;

		// Token: 0x0400A5A4 RID: 42404
		public AnimationCurve HorizontHarmonicIntensity;

		// Token: 0x0400A5A5 RID: 42405
		public AnimationCurve BounceHarmonicIntensity;

		// Token: 0x0400A5A6 RID: 42406
		public AnimationCurve ForwarHarmonicIntensity;

		// Token: 0x0400A5A7 RID: 42407
		[Space(16f)]
		public Gradient ForwarHarmonicMultiplyer;

		// Token: 0x0400A5A8 RID: 42408
		public Gradient BackwardHarmonicMultiplyer;

		// Token: 0x0400A5A9 RID: 42409
		[Space(16f)]
		public Gradient AddTopAmbient;

		// Token: 0x0400A5AA RID: 42410
		public Gradient AddAmbient;

		// Token: 0x0400A5AB RID: 42411
		[Space(16f)]
		public AnimationCurve AmbientBrightness;

		// Token: 0x0400A5AC RID: 42412
		public AnimationCurve AmbientSaturation;

		// Token: 0x0400A5AD RID: 42413
		public AnimationCurve AmbientContrast;

		// Token: 0x0400A5AE RID: 42414
		public Color CloudnessLightColor;

		// Token: 0x0400A5B3 RID: 42419
		private readonly Vector3[] _dirs;

		// Token: 0x0400A5B4 RID: 42420
		private readonly float[] _qualityUpdateIntervals;

		// Token: 0x02001DEE RID: 7662
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct253
		{
			// Token: 0x0400A5B5 RID: 42421
			public SphericalHarmonicsL2 FullSH;

			// Token: 0x0400A5B6 RID: 42422
			public SphericalHarmonicsL2 SHWithoutTop;
		}
	}
}
