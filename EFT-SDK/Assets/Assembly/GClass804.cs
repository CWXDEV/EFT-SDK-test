using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.Animations;
using UnityEngine;

// Token: 0x02000922 RID: 2338
public class GClass804 : GInterface34
{
	// Token: 0x060034C9 RID: 13513 RVA: 0x00002050 File Offset: 0x00000250
	public void ProcessEffectors(ProceduralWeaponAnimation pwa, float deltaTime, int nFixedFrames = 1)
	{
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyTransformations(ProceduralWeaponAnimation pwa, float dt)
	{
		throw null;
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyCameraTransformations(ProceduralWeaponAnimation pwa, float dt)
	{
		throw null;
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateTransformations(ProceduralWeaponAnimation pwa, float dt)
	{
		throw null;
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyFovAdjustments(ProceduralWeaponAnimation pwa, Player player)
	{
		throw null;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player)
	{
		throw null;
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpticCalibration(ProceduralWeaponAnimation proceduralWeaponAnimation, bool calibrate)
	{
		throw null;
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float UpdatePossibleTilt(ProceduralWeaponAnimation proceduralWeaponAnimation, float smoothedCharacterMovementSpeed, float smoothedPoseLevel)
	{
		throw null;
	}

	// Token: 0x040035B0 RID: 13744
	private readonly List<GClass804.Struct85> list_0;

	// Token: 0x02000923 RID: 2339
	[StructLayout(LayoutKind.Auto)]
	public struct Struct85
	{
		// Token: 0x040035B1 RID: 13745
		public Transform StoredTransform;

		// Token: 0x040035B2 RID: 13746
		public Vector3 Position;

		// Token: 0x040035B3 RID: 13747
		public Quaternion Rotation;
	}
}
