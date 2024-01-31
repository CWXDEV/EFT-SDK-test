using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027FB RID: 10235
	[RequireComponent(typeof(Collider))]
	public class ColliderReporter : MonoBehaviour, IPhysicsTrigger
	{
		// Token: 0x140002DB RID: 731
		// (add) Token: 0x0600CCE9 RID: 52457 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600CCEA RID: 52458 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ColliderReporter, Collider> OnTriggerEnterEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x140002DC RID: 732
		// (add) Token: 0x0600CCEB RID: 52459 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600CCEC RID: 52460 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ColliderReporter, Collider> OnTriggerExitEvent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600CCED RID: 52461 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddOwner(MonoBehaviour disablerCullingObject)
		{
			throw null;
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveOwner(MonoBehaviour disablerCullingObject)
		{
			throw null;
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x00002050 File Offset: 0x00000250
		[Conditional("UNITY_EDITOR")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600CCF3 RID: 52467 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CCF4 RID: 52468 RVA: 0x00002050 File Offset: 0x00000250
		bool IPhysicsTrigger.enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400CD2E RID: 52526
		[CompilerGenerated]
		private Action<ColliderReporter, Collider> action_0;

		// Token: 0x0400CD2F RID: 52527
		[CompilerGenerated]
		private Action<ColliderReporter, Collider> action_1;

		// Token: 0x0400CD30 RID: 52528
		[NonSerialized]
		public List<MonoBehaviour> Owners;

		// Token: 0x0400CD31 RID: 52529
		[NonSerialized]
		public bool IsInverse;

		// Token: 0x0400CD32 RID: 52530
		[NonSerialized]
		public bool Entered;

		// Token: 0x0400CD33 RID: 52531
		[CompilerGenerated]
		private readonly string string_0;
	}
}
