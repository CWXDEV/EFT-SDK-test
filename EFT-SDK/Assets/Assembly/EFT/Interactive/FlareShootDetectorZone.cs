using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.PrefabSettings;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002760 RID: 10080
	public class FlareShootDetectorZone : MonoBehaviour
	{
		// Token: 0x0600C9EA RID: 51690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C9EC RID: 51692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Collider collider)
		{
			throw null;
		}

		// Token: 0x0600C9ED RID: 51693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass2896 flareEvent)
		{
			throw null;
		}

		// Token: 0x0600C9EE RID: 51694 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2896 flareEvent)
		{
			throw null;
		}

		// Token: 0x0400C9DA RID: 51674
		[SerializeField]
		private string zoneID;

		// Token: 0x0400C9DB RID: 51675
		[SerializeField]
		private FlareEventType flareTypeForHandle;

		// Token: 0x0400C9DC RID: 51676
		[SerializeField]
		private List<PhysicsTriggerHandler> _triggerHandlers;

		// Token: 0x0400C9DD RID: 51677
		private HashSet<string> hashSet_0;

		// Token: 0x0400C9DE RID: 51678
		private Action action_0;
	}
}
