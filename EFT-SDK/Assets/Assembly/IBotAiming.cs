using System;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x020004D1 RID: 1233
public interface IBotAiming
{
	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x06001EAD RID: 7853
	Vector3 EndTargetPoint { get; }

	// Token: 0x1700058B RID: 1419
	// (get) Token: 0x06001EAE RID: 7854
	bool IsReady { get; }

	// Token: 0x1700058C RID: 1420
	// (get) Token: 0x06001EAF RID: 7855
	bool AlwaysTurnOnLight { get; }

	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x06001EB0 RID: 7856
	Vector3 RealTargetPoint { get; }

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x06001EB1 RID: 7857
	float LastDist2Target { get; }

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x06001EB2 RID: 7858
	bool HardAim { get; }

	// Token: 0x06001EB3 RID: 7859
	void LoseTarget();

	// Token: 0x06001EB4 RID: 7860
	void SetTarget(Vector3 trg);

	// Token: 0x06001EB5 RID: 7861
	void SetNextAimingDelay(float nextAimingDelay);

	// Token: 0x06001EB6 RID: 7862
	void TriggerPressedDone();

	// Token: 0x06001EB7 RID: 7863
	void ShootDone(Weapon weapon);

	// Token: 0x06001EB8 RID: 7864
	void NodeUpdate();

	// Token: 0x06001EB9 RID: 7865
	void Panic();

	// Token: 0x06001EBA RID: 7866
	void Activate();

	// Token: 0x06001EBB RID: 7867
	void GetHit(DamageInfo damageInfo);

	// Token: 0x06001EBC RID: 7868
	void DrawGizmosSelected();

	// Token: 0x06001EBD RID: 7869
	void PermanentUpdate();

	// Token: 0x06001EBE RID: 7870
	void RotateX(float angToRotate);

	// Token: 0x06001EBF RID: 7871
	void RotateY(float deltaAngle);

	// Token: 0x06001EC0 RID: 7872
	void SetWeapon(Weapon weapon);

	// Token: 0x06001EC1 RID: 7873
	void SetTracers(bool isTracers);

	// Token: 0x06001EC2 RID: 7874
	void Move(float delta = 0f);

	// Token: 0x06001EC3 RID: 7875
	void NextShotMiss();

	// Token: 0x06001EC4 RID: 7876
	void OnDrawGizmos();

	// Token: 0x06001EC5 RID: 7877
	void DebugDraw();

	// Token: 0x06001EC6 RID: 7878
	void Dispose();

	// Token: 0x14000047 RID: 71
	// (add) Token: 0x06001EC7 RID: 7879
	// (remove) Token: 0x06001EC8 RID: 7880
	event Action<Vector3> OnSettingsTarget;
}
