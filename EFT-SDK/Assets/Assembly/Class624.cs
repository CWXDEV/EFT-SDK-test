using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000C11 RID: 3089
internal class Class624
{
	// Token: 0x0600437D RID: 17277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Release()
	{
		throw null;
	}

	// Token: 0x0600437E RID: 17278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(ref RenderTexture rt)
	{
		throw null;
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseRenderTextures()
	{
		throw null;
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCameraWidth(Camera camera)
	{
		throw null;
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCameraHeight(Camera camera)
	{
		throw null;
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ResolutionMismatched(Camera camera)
	{
		throw null;
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MBOITScatter()
	{
		throw null;
	}

	// Token: 0x06004384 RID: 17284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMBOITScatterToggled()
	{
		throw null;
	}

	// Token: 0x04004C89 RID: 19593
	public CommandBuffer CmdBufCulling;

	// Token: 0x04004C8A RID: 19594
	public CommandBuffer CmdBufAfterTransparent;

	// Token: 0x04004C8B RID: 19595
	public CommandBuffer CmdBufBeforeTransparent;

	// Token: 0x04004C8C RID: 19596
	public ComputeBuffer FrustumPlanes;

	// Token: 0x04004C8D RID: 19597
	public ComputeBuffer FrustumPNFactors;

	// Token: 0x04004C8E RID: 19598
	public ComputeBuffer DrawArgsBuffer;

	// Token: 0x04004C8F RID: 19599
	public ComputeBuffer InstancesIDsAfterFrustumCulling;

	// Token: 0x04004C90 RID: 19600
	public ComputeBuffer InstancesIDsCount;

	// Token: 0x04004C91 RID: 19601
	public ComputeBuffer OcclusionComputeGroupsCountBuffer;

	// Token: 0x04004C92 RID: 19602
	public ComputeBuffer CameraProjViewMatrixBuffer;

	// Token: 0x04004C93 RID: 19603
	public ComputeBuffer CameraParameters;

	// Token: 0x04004C94 RID: 19604
	public List<Matrix4x4> ProjViewMatrix;

	// Token: 0x04004C95 RID: 19605
	public GPUInstancerHiZOcclusionGenerator HiZGenerator;

	// Token: 0x04004C96 RID: 19606
	public MBOIT_Scattering MBOITScattering;

	// Token: 0x04004C97 RID: 19607
	public DistantShadow DistantShadowComponent;

	// Token: 0x04004C98 RID: 19608
	public RenderTexture MomentsRT;

	// Token: 0x04004C99 RID: 19609
	public RenderTexture MomentsRT1;

	// Token: 0x04004C9A RID: 19610
	public RenderTexture MomentsRT_Quarter;

	// Token: 0x04004C9B RID: 19611
	public RenderTexture MomentsRT1_Quarter;

	// Token: 0x04004C9C RID: 19612
	public RenderTexture TransparentOutput_Quarter;

	// Token: 0x04004C9D RID: 19613
	public RenderTexture TransparentOutput_QuarterBlurBuf;

	// Token: 0x04004C9E RID: 19614
	public RenderTexture TransparentOutput_HiRes;

	// Token: 0x04004C9F RID: 19615
	public RenderTexture TransparentOutput_HiResBlurBuf;

	// Token: 0x04004CA0 RID: 19616
	public RenderTexture TransmittanceSumRcp;

	// Token: 0x04004CA1 RID: 19617
	public RenderTexture TransmittanceSumRcpQuarter;

	// Token: 0x04004CA2 RID: 19618
	public RenderTexture StubDepth;

	// Token: 0x04004CA3 RID: 19619
	public RenderTexture StubDepth_Quarter;

	// Token: 0x04004CA4 RID: 19620
	public RenderTexture OpaqueRT;

	// Token: 0x04004CA5 RID: 19621
	public int RenderTexturesWidth;

	// Token: 0x04004CA6 RID: 19622
	public int RenderTexturesHeight;

	// Token: 0x04004CA7 RID: 19623
	public RenderTargetIdentifier[] _oitRTIs;

	// Token: 0x04004CA8 RID: 19624
	public RenderTargetIdentifier[] _oitQuarterRTIs;

	// Token: 0x04004CA9 RID: 19625
	public RenderTargetIdentifier _oitSumRcp;

	// Token: 0x04004CAA RID: 19626
	public RenderTargetIdentifier _oitSumRcpQuarter;

	// Token: 0x04004CAB RID: 19627
	public RenderTargetIdentifier _stubDepthRTI;

	// Token: 0x04004CAC RID: 19628
	public RenderTargetIdentifier _stubDepthQuarterRTI;

	// Token: 0x04004CAD RID: 19629
	public RenderTargetIdentifier _opaqueRTI;

	// Token: 0x04004CAE RID: 19630
	public RenderTargetIdentifier _transparentOutputQuarterRTI;

	// Token: 0x04004CAF RID: 19631
	public RenderTargetIdentifier _transparentOutputQuarterBlurBufRTI;

	// Token: 0x04004CB0 RID: 19632
	public RenderTargetIdentifier _finalOutputTarget;

	// Token: 0x04004CB1 RID: 19633
	public RenderTargetIdentifier[] _rtisToClear;

	// Token: 0x04004CB2 RID: 19634
	public RenderTargetIdentifier[] _rtisQuarterToClear;

	// Token: 0x04004CB3 RID: 19635
	public SSAA _ssaa;

	// Token: 0x04004CB4 RID: 19636
	public bool _mboitScattering;

	// Token: 0x04004CB5 RID: 19637
	public bool _isScatterThermalVisionIsEnabled;

	// Token: 0x04004CB6 RID: 19638
	public bool _todScatteringEnabled;

	// Token: 0x04004CB7 RID: 19639
	public RenderTexture _distantShadowLowResDepth;
}
