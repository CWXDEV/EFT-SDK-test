using System;
using EFT.SynchronizableObjects;
using UnityEngine;

// Token: 0x02001E3C RID: 7740
public interface ISynchronizableObject
{
	// Token: 0x06009EBE RID: 40638
	void SetSyncObject(SynchronizableObject syncObject);

	// Token: 0x06009EBF RID: 40639
	void Init(int objectId, Vector3 position, Vector3 rotation);

	// Token: 0x06009EC0 RID: 40640
	void InitStaticObject();

	// Token: 0x06009EC1 RID: 40641
	void ManualUpdate(float deltaTime);

	// Token: 0x06009EC2 RID: 40642
	void UpdateSyncObjectData(ref AirplaneDataPacketStruct packet);

	// Token: 0x06009EC3 RID: 40643
	void TakeFromPool();

	// Token: 0x06009EC4 RID: 40644
	void ReturnToPool();

	// Token: 0x06009EC5 RID: 40645
	void CollisionEnter(Collider collider);
}
