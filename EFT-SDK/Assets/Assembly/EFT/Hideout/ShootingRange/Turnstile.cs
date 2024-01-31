using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C80 RID: 7296
	public class Turnstile : InteractiveShootingRange
	{
		// Token: 0x06009865 RID: 39013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass3008 InteractionStates(HideoutPlayerOwner owner)
		{
			throw null;
		}

		// Token: 0x06009866 RID: 39014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Open()
		{
			throw null;
		}

		// Token: 0x06009868 RID: 39016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x06009869 RID: 39017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1(Quaternion leftRotation, Quaternion rightRotation)
		{
			throw null;
		}

		// Token: 0x04009FC0 RID: 40896
		[Range(0f, 1f)]
		[SerializeField]
		private float _duration;

		// Token: 0x04009FC1 RID: 40897
		[SerializeField]
		private bool _opened;

		// Token: 0x04009FC2 RID: 40898
		private Quaternion quaternion_0;

		// Token: 0x04009FC3 RID: 40899
		private Quaternion quaternion_1;

		// Token: 0x04009FC4 RID: 40900
		private float float_0;

		// Token: 0x04009FC5 RID: 40901
		private Tween tween_0;
	}
}
