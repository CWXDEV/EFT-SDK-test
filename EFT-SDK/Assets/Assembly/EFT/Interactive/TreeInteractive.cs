using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200279F RID: 10143
	public class TreeInteractive : MonoBehaviour, IPhysicsTrigger, IPhysicsTriggerWithStay
	{
		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600CB2D RID: 52013 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnTriggerStay(Collider col)
		{
			throw null;
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector3 soundPosition, BetterSource source, GInterface94 player, bool forceStereo = false)
		{
			throw null;
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CB33 RID: 52019 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0400CB4D RID: 52045
		public Terrain Terrain;

		// Token: 0x0400CB4E RID: 52046
		public int InstanceIndex;

		// Token: 0x0400CB4F RID: 52047
		[SerializeField]
		public SoundBank _soundBank;

		// Token: 0x0400CB50 RID: 52048
		private Dictionary<Collider, BetterSource> dictionary_0;

		// Token: 0x0400CB51 RID: 52049
		private const float float_0 = 1f;

		// Token: 0x0400CB52 RID: 52050
		private Dictionary<Collider, GInterface94> dictionary_1;

		// Token: 0x0400CB53 RID: 52051
		private float float_1;

		// Token: 0x0400CB54 RID: 52052
		private const float float_2 = -0.33f;

		// Token: 0x0400CB55 RID: 52053
		private const float float_3 = 4.5f;

		// Token: 0x0400CB56 RID: 52054
		private const float float_4 = 0.1f;

		// Token: 0x0400CB57 RID: 52055
		private const float float_5 = 0.0233f;

		// Token: 0x0400CB58 RID: 52056
		private const float float_6 = 0.5f;

		// Token: 0x0400CB59 RID: 52057
		private float float_7;

		// Token: 0x0400CB5A RID: 52058
		[CompilerGenerated]
		private readonly string string_0;
	}
}
