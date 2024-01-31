using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT.SynchronizableObjects
{
	// Token: 0x02001E3E RID: 7742
	public class SynchronizableObject : MonoBehaviour
	{
		// Token: 0x06009EC8 RID: 40648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLogic(ISynchronizableObject synchronizableObject)
		{
			throw null;
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(int objectId, Vector3 position, Vector3 rotation)
		{
			throw null;
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitStaticObject()
		{
			throw null;
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSyncObjectData(ref AirplaneDataPacketStruct packet)
		{
			throw null;
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Serialize(NetworkWriter writer)
		{
			throw null;
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Deserialize(NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CollisionEnter(Collider collider)
		{
			throw null;
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TakeFromPool()
		{
			throw null;
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReturnToPool()
		{
			throw null;
		}

		// Token: 0x0400A756 RID: 42838
		private ISynchronizableObject ginterface187_0;

		// Token: 0x0400A757 RID: 42839
		public SynchronizableObjectType Type;

		// Token: 0x0400A758 RID: 42840
		public int ObjectId;

		// Token: 0x0400A759 RID: 42841
		public int UniqueId;

		// Token: 0x0400A75A RID: 42842
		public bool IsActive;

		// Token: 0x0400A75B RID: 42843
		public bool IsInited;

		// Token: 0x0400A75C RID: 42844
		public bool IsStatic;
	}
}
