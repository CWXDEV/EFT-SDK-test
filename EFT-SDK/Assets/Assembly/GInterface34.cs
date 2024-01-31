using System;
using EFT;
using EFT.Animations;

// Token: 0x02000921 RID: 2337
public interface GInterface34
{
	// Token: 0x060034C1 RID: 13505
	void ApplyCameraTransformations(ProceduralWeaponAnimation pwa, float dt);

	// Token: 0x060034C2 RID: 13506
	void ProcessEffectors(ProceduralWeaponAnimation pwa, float deltaTime, int nFixedFrames = 1);

	// Token: 0x060034C3 RID: 13507
	void ApplyTransformations(ProceduralWeaponAnimation pwa, float dt);

	// Token: 0x060034C4 RID: 13508
	void LateTransformations(ProceduralWeaponAnimation pwa, float dt);

	// Token: 0x060034C5 RID: 13509
	void ApplyFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player);

	// Token: 0x060034C6 RID: 13510
	void ResetFovAdjustments(ProceduralWeaponAnimation proceduralWeaponAnimation, Player player);

	// Token: 0x060034C7 RID: 13511
	void OpticCalibration(ProceduralWeaponAnimation proceduralWeaponAnimation, bool calibrate);

	// Token: 0x060034C8 RID: 13512
	float UpdatePossibleTilt(ProceduralWeaponAnimation proceduralWeaponAnimation, float smoothedCharacterMovementSpeed, float smoothedPoseLevel);
}
