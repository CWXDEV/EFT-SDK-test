using System;
using UnityEngine;

namespace Prism.Utils
{
	// Token: 0x02000D7D RID: 3453
	[Serializable]
	public class PrismPreset : ScriptableObject
	{
		// Token: 0x04005431 RID: 21553
		public string PresetDescription;

		// Token: 0x04005432 RID: 21554
		public PrismPresetType presetType;

		// Token: 0x04005433 RID: 21555
		[SerializeField]
		public bool useBloom;

		// Token: 0x04005434 RID: 21556
		[SerializeField]
		public BloomType bloomType;

		// Token: 0x04005435 RID: 21557
		[SerializeField]
		public bool bloomUseScreenBlend;

		// Token: 0x04005436 RID: 21558
		[SerializeField]
		public int bloomDownsample;

		// Token: 0x04005437 RID: 21559
		[SerializeField]
		public int bloomBlurPasses;

		// Token: 0x04005438 RID: 21560
		[SerializeField]
		public float bloomIntensity;

		// Token: 0x04005439 RID: 21561
		[SerializeField]
		public float bloomThreshold;

		// Token: 0x0400543A RID: 21562
		[SerializeField]
		public bool useBloomStability;

		// Token: 0x0400543B RID: 21563
		[SerializeField]
		public bool useBloomLensdirt;

		// Token: 0x0400543C RID: 21564
		[SerializeField]
		public float bloomLensdirtIntensity;

		// Token: 0x0400543D RID: 21565
		[SerializeField]
		public Texture2D bloomLensdirtTexture;

		// Token: 0x0400543E RID: 21566
		[SerializeField]
		public bool useFullScreenBlur;

		// Token: 0x0400543F RID: 21567
		[SerializeField]
		public bool useUIBlur;

		// Token: 0x04005440 RID: 21568
		[SerializeField]
		public int uiBlurGrabTextureFromPassNumber;

		// Token: 0x04005441 RID: 21569
		[SerializeField]
		public bool useFog;

		// Token: 0x04005442 RID: 21570
		[SerializeField]
		public bool fogAffectSkybox;

		// Token: 0x04005443 RID: 21571
		[SerializeField]
		public float fogIntensity;

		// Token: 0x04005444 RID: 21572
		[SerializeField]
		public float fogHeight;

		// Token: 0x04005445 RID: 21573
		[SerializeField]
		public float fogStartPoint;

		// Token: 0x04005446 RID: 21574
		[SerializeField]
		public float fogDistance;

		// Token: 0x04005447 RID: 21575
		[SerializeField]
		public Color fogColor;

		// Token: 0x04005448 RID: 21576
		[SerializeField]
		public Color fogEndColor;

		// Token: 0x04005449 RID: 21577
		[SerializeField]
		public bool useDoF;

		// Token: 0x0400544A RID: 21578
		[SerializeField]
		public float dofRadius;

		// Token: 0x0400544B RID: 21579
		[SerializeField]
		public DoFSamples dofSampleCount;

		// Token: 0x0400544C RID: 21580
		[SerializeField]
		public float dofBokehFactor;

		// Token: 0x0400544D RID: 21581
		[SerializeField]
		public float dofFocusPoint;

		// Token: 0x0400544E RID: 21582
		[SerializeField]
		public float dofFocusDistance;

		// Token: 0x0400544F RID: 21583
		[SerializeField]
		public bool useNearBlur;

		// Token: 0x04005450 RID: 21584
		[SerializeField]
		public bool dofBlurSkybox;

		// Token: 0x04005451 RID: 21585
		[SerializeField]
		public float dofNearFocusDistance;

		// Token: 0x04005452 RID: 21586
		[SerializeField]
		public bool dofForceEnableMedian;

		// Token: 0x04005453 RID: 21587
		[SerializeField]
		public bool useAmbientObscurance;

		// Token: 0x04005454 RID: 21588
		[SerializeField]
		public float aoIntensity;

		// Token: 0x04005455 RID: 21589
		[SerializeField]
		public float aoRadius;

		// Token: 0x04005456 RID: 21590
		[SerializeField]
		public float aoBias;

		// Token: 0x04005457 RID: 21591
		[SerializeField]
		public bool aoDownsample;

		// Token: 0x04005458 RID: 21592
		[SerializeField]
		public int aoBlurIterations;

		// Token: 0x04005459 RID: 21593
		[SerializeField]
		public float aoBlurFilterDistance;

		// Token: 0x0400545A RID: 21594
		[SerializeField]
		public bool useAODistanceCutoff;

		// Token: 0x0400545B RID: 21595
		[SerializeField]
		public float aoDistanceCutoffLength;

		// Token: 0x0400545C RID: 21596
		[SerializeField]
		public float aoDistanceCutoffStart;

		// Token: 0x0400545D RID: 21597
		[SerializeField]
		public SampleCount aoSampleCount;

		// Token: 0x0400545E RID: 21598
		[SerializeField]
		public AOBlurType aoBlurType;

		// Token: 0x0400545F RID: 21599
		[SerializeField]
		public float aoLightingContribution;

		// Token: 0x04005460 RID: 21600
		[SerializeField]
		public bool useChromaticAb;

		// Token: 0x04005461 RID: 21601
		[SerializeField]
		public AberrationType aberrationType;

		// Token: 0x04005462 RID: 21602
		[SerializeField]
		public float chromIntensity;

		// Token: 0x04005463 RID: 21603
		[SerializeField]
		public float chromStart;

		// Token: 0x04005464 RID: 21604
		[SerializeField]
		public float chromEnd;

		// Token: 0x04005465 RID: 21605
		[SerializeField]
		public bool useChromaticBlur;

		// Token: 0x04005466 RID: 21606
		[SerializeField]
		public float chromaticBlurWidth;

		// Token: 0x04005467 RID: 21607
		[SerializeField]
		public bool useVignette;

		// Token: 0x04005468 RID: 21608
		[SerializeField]
		public float vignetteStart;

		// Token: 0x04005469 RID: 21609
		[SerializeField]
		public float vignetteEnd;

		// Token: 0x0400546A RID: 21610
		[SerializeField]
		public float vignetteIntensity;

		// Token: 0x0400546B RID: 21611
		[SerializeField]
		public Color vignetteColor;

		// Token: 0x0400546C RID: 21612
		[SerializeField]
		public bool useNoise;

		// Token: 0x0400546D RID: 21613
		[SerializeField]
		public float noiseIntensity;

		// Token: 0x0400546E RID: 21614
		[SerializeField]
		public bool useTonemap;

		// Token: 0x0400546F RID: 21615
		[SerializeField]
		public TonemapType toneType;

		// Token: 0x04005470 RID: 21616
		[SerializeField]
		public Vector3 toneValues;

		// Token: 0x04005471 RID: 21617
		[SerializeField]
		public Vector3 secondaryToneValues;

		// Token: 0x04005472 RID: 21618
		[SerializeField]
		public bool useGammaCorrection;

		// Token: 0x04005473 RID: 21619
		[SerializeField]
		public float gammaValue;

		// Token: 0x04005474 RID: 21620
		[SerializeField]
		public bool useExposure;

		// Token: 0x04005475 RID: 21621
		[SerializeField]
		public float exposureSpeed;

		// Token: 0x04005476 RID: 21622
		[SerializeField]
		public float exposureMiddleGrey;

		// Token: 0x04005477 RID: 21623
		[SerializeField]
		public float exposureLowerLimit;

		// Token: 0x04005478 RID: 21624
		[SerializeField]
		public float exposureUpperLimit;

		// Token: 0x04005479 RID: 21625
		[SerializeField]
		public bool useLUT;

		// Token: 0x0400547A RID: 21626
		[SerializeField]
		public string lutPath;

		// Token: 0x0400547B RID: 21627
		[SerializeField]
		public float lutIntensity;

		// Token: 0x0400547C RID: 21628
		[SerializeField]
		public Texture2D twoDLookupTex;

		// Token: 0x0400547D RID: 21629
		[SerializeField]
		public bool useSecondLut;

		// Token: 0x0400547E RID: 21630
		[SerializeField]
		public string secondaryLutPath;

		// Token: 0x0400547F RID: 21631
		[SerializeField]
		public Texture2D secondaryTwoDLookupTex;

		// Token: 0x04005480 RID: 21632
		[SerializeField]
		public float secondaryLutLerpAmount;

		// Token: 0x04005481 RID: 21633
		[SerializeField]
		public bool useNV;

		// Token: 0x04005482 RID: 21634
		[SerializeField]
		public Color nvColor;

		// Token: 0x04005483 RID: 21635
		[SerializeField]
		public Color nvBleachColor;

		// Token: 0x04005484 RID: 21636
		[SerializeField]
		public float nvLightingContrib;

		// Token: 0x04005485 RID: 21637
		[SerializeField]
		public float nvLightSensitivity;

		// Token: 0x04005486 RID: 21638
		[SerializeField]
		public bool useRays;

		// Token: 0x04005487 RID: 21639
		[SerializeField]
		public float rayWeight;

		// Token: 0x04005488 RID: 21640
		[SerializeField]
		public Color rayColor;

		// Token: 0x04005489 RID: 21641
		[SerializeField]
		public Color rayThreshold;
	}
}
