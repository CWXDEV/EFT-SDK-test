using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A6D RID: 6765
	public abstract class AmbianceObject<T> : SerializedMonoBehaviour, GInterface158
	{
		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06008EC9 RID: 36553 RVA: 0x00002050 File Offset: 0x00000250
		public EAreaType AreaType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(AreaTemplate areaTemplate)
		{
			throw null;
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool ImmediateInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<bool> PerformInteraction(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x0400960D RID: 38413
		[SerializeField]
		private bool _isActive;

		// Token: 0x0400960E RID: 38414
		[SerializeField]
		private EAreaType _areaType;

		// Token: 0x0400960F RID: 38415
		[SerializeField]
		protected Dictionary<ELightStatus, Pattern<T>> Patterns;

		// Token: 0x04009610 RID: 38416
		private Dictionary<ELightStatus, float> dictionary_0;
	}
}
