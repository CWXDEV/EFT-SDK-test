using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A68 RID: 6760
	public sealed class AmbianceController : SerializedMonoBehaviour
	{
		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06008EBB RID: 36539 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008EBC RID: 36540 RVA: 0x00002050 File Offset: 0x00000250
		public ELightStatus GlobalLightStatus
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IEnumerable<AreaData> datas, bool isEnergyOn)
		{
			throw null;
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnergySupplyChanged(bool isOn)
		{
			throw null;
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1()
		{
			throw null;
		}

		// Token: 0x040095FC RID: 38396
		[SerializeField]
		private List<GInterface158> _ambianceObjects;

		// Token: 0x040095FD RID: 38397
		[SerializeField]
		private HideoutAudioBackground _audioBackground;

		// Token: 0x040095FE RID: 38398
		[SerializeField]
		private MultiFlare _multiFlare;

		// Token: 0x040095FF RID: 38399
		private IEnumerable<AreaData> ienumerable_0;

		// Token: 0x04009600 RID: 38400
		[CompilerGenerated]
		private ELightStatus elightStatus_0;
	}
}
