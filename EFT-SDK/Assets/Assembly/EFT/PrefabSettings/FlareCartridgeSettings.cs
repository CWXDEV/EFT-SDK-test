using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.PrefabSettings
{
	// Token: 0x02001F16 RID: 7958
	public sealed class FlareCartridgeSettings : ThrowableSettings
	{
		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600A4B4 RID: 42164 RVA: 0x00002050 File Offset: 0x00000250
		public GameObject ProjectileAmmo
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x0600A4B5 RID: 42165 RVA: 0x00002050 File Offset: 0x00000250
		public float SuccesfullHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x0600A4B6 RID: 42166 RVA: 0x00002050 File Offset: 0x00000250
		public FlareColorType FlareColorType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x00002050 File Offset: 0x00000250
		public FlareEventType FlareEventType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x0600A4B8 RID: 42168 RVA: 0x00002050 File Offset: 0x00000250
		public float InitialSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x00002050 File Offset: 0x00000250
		public float FlareTimeAfterStart
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x0600A4BA RID: 42170 RVA: 0x00002050 File Offset: 0x00000250
		public float FlareLifetime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x00002050 File Offset: 0x00000250
		public float Weight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x0600A4BC RID: 42172 RVA: 0x00002050 File Offset: 0x00000250
		public float RigidbodyDrag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x00002050 File Offset: 0x00000250
		public float CollisionDrag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600A4BE RID: 42174 RVA: 0x00002050 File Offset: 0x00000250
		public GameObject FlareEffectPrefab
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchMeshRenderersActive(bool value)
		{
			throw null;
		}

		// Token: 0x0400AC80 RID: 44160
		[SerializeField]
		private GameObject _projectileAmmo;

		// Token: 0x0400AC81 RID: 44161
		[SerializeField]
		private List<MeshRenderer> _meshRenderers;

		// Token: 0x0400AC82 RID: 44162
		[SerializeField]
		private float _succesfullHeight;

		// Token: 0x0400AC83 RID: 44163
		[SerializeField]
		private FlareColorType _flareColorType;

		// Token: 0x0400AC84 RID: 44164
		[SerializeField]
		private FlareEventType _flareEventType;

		// Token: 0x0400AC85 RID: 44165
		[SerializeField]
		private float _initialSpeed;

		// Token: 0x0400AC86 RID: 44166
		[SerializeField]
		private float _flareTimeAfterStart;

		// Token: 0x0400AC87 RID: 44167
		[SerializeField]
		private float _flareLifetime;

		// Token: 0x0400AC88 RID: 44168
		[SerializeField]
		private float _weight;

		// Token: 0x0400AC89 RID: 44169
		[SerializeField]
		private float _rigidbodyDrag;

		// Token: 0x0400AC8A RID: 44170
		[SerializeField]
		private float _collisionDrag;

		// Token: 0x0400AC8B RID: 44171
		[SerializeField]
		private GameObject _flareEffectPrefab;
	}
}
