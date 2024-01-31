using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027A0 RID: 10144
	public class TriggerWithId : MonoBehaviour, IPhysicsTrigger, GInterface102
	{
		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600CB34 RID: 52020 RVA: 0x00002050 File Offset: 0x00000250
		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600CB35 RID: 52021 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetId(string id)
		{
			throw null;
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void TriggerEnter(Player player)
		{
			throw null;
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void TriggerExit(Player player)
		{
			throw null;
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x0600CB3C RID: 52028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB3D RID: 52029 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0400CB5B RID: 52059
		[SerializeField]
		private string _id;

		// Token: 0x0400CB5C RID: 52060
		[CompilerGenerated]
		private readonly string string_0;
	}
}
