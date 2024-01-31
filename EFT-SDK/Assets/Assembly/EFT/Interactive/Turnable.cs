using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027A4 RID: 10148
	public abstract class Turnable : MonoBehaviour, GInterface352
	{
		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600CB45 RID: 52037 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB46 RID: 52038 RVA: 0x00002050 File Offset: 0x00000250
		string GInterface352.IdEditable
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

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x00002050 File Offset: 0x00000250
		GameObject GInterface352.GameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600CB48 RID: 52040 RVA: 0x00002050 File Offset: 0x00000250
		string GInterface352.TypeKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x0600CB49 RID: 52041 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsDestroyed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CB4A RID: 52042 RVA: 0x00002050 File Offset: 0x00000250
		[Obsolete("Will be removed with EFT.Interactive.MapEditableGeneratorId")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CheckUniqueIdOnDuplicateEvent()
		{
			throw null;
		}

		// Token: 0x0600CB4B RID: 52043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Switch(Turnable.EState switchTo)
		{
			throw null;
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterForNetwork()
		{
			throw null;
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(DamageInfo dInfo)
		{
			throw null;
		}

		// Token: 0x0400CB5F RID: 52063
		public string Id;

		// Token: 0x0400CB60 RID: 52064
		public int NetId;

		// Token: 0x0400CB61 RID: 52065
		public Turnable.EState LampState;

		// Token: 0x0400CB62 RID: 52066
		public BallisticCollider BallisticCollider;

		// Token: 0x020027A5 RID: 10149
		public enum EState
		{
			// Token: 0x0400CB64 RID: 52068
			TurningOn,
			// Token: 0x0400CB65 RID: 52069
			TurningOff,
			// Token: 0x0400CB66 RID: 52070
			On,
			// Token: 0x0400CB67 RID: 52071
			Off,
			// Token: 0x0400CB68 RID: 52072
			Destroyed,
			// Token: 0x0400CB69 RID: 52073
			ConstantFlickering,
			// Token: 0x0400CB6A RID: 52074
			SmoothOff
		}
	}
}
