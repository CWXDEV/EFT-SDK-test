using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001A96 RID: 6806
	[RequireComponent(typeof(AudioArray))]
	public sealed class AreaLevelAudio : MonoBehaviour
	{
		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008F49 RID: 36681 RVA: 0x00002050 File Offset: 0x00000250
		public EAreaStatus AreaStatus
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

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06008F4B RID: 36683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008F4A RID: 36682 RVA: 0x00002050 File Offset: 0x00000250
		public ELightStatus LightStatus
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

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x00002050 File Offset: 0x00000250
		private AudioArray AudioArray_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(RelatedSounds soundsData, ELightStatus lightStatus = ELightStatus.None, EAreaStatus areaStatus = EAreaStatus.NotSet)
		{
			throw null;
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Resume()
		{
			throw null;
		}

		// Token: 0x06008F4F RID: 36687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select()
		{
			throw null;
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LevelChanged()
		{
			throw null;
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayOneShot(AudioClip sound, bool volumetric)
		{
			throw null;
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayOneShot(EAreaActivityType soundType, bool volumetric)
		{
			throw null;
		}

		// Token: 0x06008F53 RID: 36691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ELightStatus lightStatus, EAreaStatus areaStatus)
		{
			throw null;
		}

		// Token: 0x06008F54 RID: 36692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06008F55 RID: 36693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Pause()
		{
			throw null;
		}

		// Token: 0x04009686 RID: 38534
		private RelatedSounds relatedSounds_0;

		// Token: 0x04009687 RID: 38535
		private EAreaStatus eareaStatus_0;

		// Token: 0x04009688 RID: 38536
		private EAreaStatus eareaStatus_1;

		// Token: 0x04009689 RID: 38537
		private ELightStatus elightStatus_0;

		// Token: 0x0400968A RID: 38538
		private ELightStatus elightStatus_1;

		// Token: 0x0400968B RID: 38539
		private AudioSequence audioSequence_0;

		// Token: 0x0400968C RID: 38540
		private AudioArray audioArray_0;
	}
}
