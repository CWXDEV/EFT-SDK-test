using System;
using System.Runtime.CompilerServices;
using MirzaBeig.Scripting.Effects;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200080F RID: 2063
public class ParticleForceFieldsDemo : MonoBehaviour
{
	// Token: 0x06002F72 RID: 12146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06002F73 RID: 12147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06002F74 RID: 12148 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReloadScene()
	{
		throw null;
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxParticles(float value)
	{
		throw null;
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParticleEmissionPerSecond(float value)
	{
		throw null;
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldRadius(float value)
	{
		throw null;
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldMaxForce(float value)
	{
		throw null;
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldArrivalRadius(float value)
	{
		throw null;
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldArrivedRadius(float value)
	{
		throw null;
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldPositionX(float value)
	{
		throw null;
	}

	// Token: 0x06002F7C RID: 12156 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldPositionY(float value)
	{
		throw null;
	}

	// Token: 0x06002F7D RID: 12157 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAttractionParticleForceFieldPositionZ(float value)
	{
		throw null;
	}

	// Token: 0x06002F7E RID: 12158 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldRadius(float value)
	{
		throw null;
	}

	// Token: 0x06002F7F RID: 12159 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldMaxForce(float value)
	{
		throw null;
	}

	// Token: 0x06002F80 RID: 12160 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldRotationX(float value)
	{
		throw null;
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldRotationY(float value)
	{
		throw null;
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldRotationZ(float value)
	{
		throw null;
	}

	// Token: 0x06002F83 RID: 12163 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldPositionX(float value)
	{
		throw null;
	}

	// Token: 0x06002F84 RID: 12164 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldPositionY(float value)
	{
		throw null;
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVortexParticleForceFieldPositionZ(float value)
	{
		throw null;
	}

	// Token: 0x04002E78 RID: 11896
	[Header("Overview")]
	public CustomTextMeshProUGUI FPSText;

	// Token: 0x04002E79 RID: 11897
	public CustomTextMeshProUGUI particleCountText;

	// Token: 0x04002E7A RID: 11898
	public Toggle postProcessingToggle;

	// Token: 0x04002E7B RID: 11899
	public MonoBehaviour postProcessing;

	// Token: 0x04002E7C RID: 11900
	[Header("Particle System Settings")]
	public ParticleSystem particleSystem;

	// Token: 0x04002E7D RID: 11901
	private ParticleSystem.MainModule mainModule_0;

	// Token: 0x04002E7E RID: 11902
	private ParticleSystem.EmissionModule emissionModule_0;

	// Token: 0x04002E7F RID: 11903
	public CustomTextMeshProUGUI maxParticlesText;

	// Token: 0x04002E80 RID: 11904
	public CustomTextMeshProUGUI particlesPerSecondText;

	// Token: 0x04002E81 RID: 11905
	public Slider maxParticlesSlider;

	// Token: 0x04002E82 RID: 11906
	public Slider particlesPerSecondSlider;

	// Token: 0x04002E83 RID: 11907
	[Header("Attraction Particle Force Field Settings")]
	public AttractionParticleForceField attractionParticleForceField;

	// Token: 0x04002E84 RID: 11908
	public CustomTextMeshProUGUI attractionParticleForceFieldRadiusText;

	// Token: 0x04002E85 RID: 11909
	public CustomTextMeshProUGUI attractionParticleForceFieldMaxForceText;

	// Token: 0x04002E86 RID: 11910
	public CustomTextMeshProUGUI attractionParticleForceFieldArrivalRadiusText;

	// Token: 0x04002E87 RID: 11911
	public CustomTextMeshProUGUI attractionParticleForceFieldArrivedRadiusText;

	// Token: 0x04002E88 RID: 11912
	public CustomTextMeshProUGUI attractionParticleForceFieldPositionTextX;

	// Token: 0x04002E89 RID: 11913
	public CustomTextMeshProUGUI attractionParticleForceFieldPositionTextY;

	// Token: 0x04002E8A RID: 11914
	public CustomTextMeshProUGUI attractionParticleForceFieldPositionTextZ;

	// Token: 0x04002E8B RID: 11915
	public Slider attractionParticleForceFieldRadiusSlider;

	// Token: 0x04002E8C RID: 11916
	public Slider attractionParticleForceFieldMaxForceSlider;

	// Token: 0x04002E8D RID: 11917
	public Slider attractionParticleForceFieldArrivalRadiusSlider;

	// Token: 0x04002E8E RID: 11918
	public Slider attractionParticleForceFieldArrivedRadiusSlider;

	// Token: 0x04002E8F RID: 11919
	public Slider attractionParticleForceFieldPositionSliderX;

	// Token: 0x04002E90 RID: 11920
	public Slider attractionParticleForceFieldPositionSliderY;

	// Token: 0x04002E91 RID: 11921
	public Slider attractionParticleForceFieldPositionSliderZ;

	// Token: 0x04002E92 RID: 11922
	[Header("Vortex Particle Force Field Settings")]
	public VortexParticleForceField vortexParticleForceField;

	// Token: 0x04002E93 RID: 11923
	public CustomTextMeshProUGUI vortexParticleForceFieldRadiusText;

	// Token: 0x04002E94 RID: 11924
	public CustomTextMeshProUGUI vortexParticleForceFieldMaxForceText;

	// Token: 0x04002E95 RID: 11925
	public CustomTextMeshProUGUI vortexParticleForceFieldRotationTextX;

	// Token: 0x04002E96 RID: 11926
	public CustomTextMeshProUGUI vortexParticleForceFieldRotationTextY;

	// Token: 0x04002E97 RID: 11927
	public CustomTextMeshProUGUI vortexParticleForceFieldRotationTextZ;

	// Token: 0x04002E98 RID: 11928
	public CustomTextMeshProUGUI vortexParticleForceFieldPositionTextX;

	// Token: 0x04002E99 RID: 11929
	public CustomTextMeshProUGUI vortexParticleForceFieldPositionTextY;

	// Token: 0x04002E9A RID: 11930
	public CustomTextMeshProUGUI vortexParticleForceFieldPositionTextZ;

	// Token: 0x04002E9B RID: 11931
	public Slider vortexParticleForceFieldRadiusSlider;

	// Token: 0x04002E9C RID: 11932
	public Slider vortexParticleForceFieldMaxForceSlider;

	// Token: 0x04002E9D RID: 11933
	public Slider vortexParticleForceFieldRotationSliderX;

	// Token: 0x04002E9E RID: 11934
	public Slider vortexParticleForceFieldRotationSliderY;

	// Token: 0x04002E9F RID: 11935
	public Slider vortexParticleForceFieldRotationSliderZ;

	// Token: 0x04002EA0 RID: 11936
	public Slider vortexParticleForceFieldPositionSliderX;

	// Token: 0x04002EA1 RID: 11937
	public Slider vortexParticleForceFieldPositionSliderY;

	// Token: 0x04002EA2 RID: 11938
	public Slider vortexParticleForceFieldPositionSliderZ;
}
