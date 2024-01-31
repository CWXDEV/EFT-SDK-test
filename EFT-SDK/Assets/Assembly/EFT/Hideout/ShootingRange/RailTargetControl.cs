using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C15 RID: 7189
	public class RailTargetControl : InteractiveShootingRange
	{
		// Token: 0x060096D7 RID: 38615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Disable()
		{
			throw null;
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOnEnergy()
		{
			throw null;
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOffEnergy()
		{
			throw null;
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass3008 InteractionStates(HideoutPlayerOwner owner)
		{
			throw null;
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x060096DC RID: 38620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060096DD RID: 38621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060096DE RID: 38622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_6()
		{
			throw null;
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x04009DD2 RID: 40402
		[Space]
		[SerializeField]
		private RailTargets _targets;

		// Token: 0x04009DD3 RID: 40403
		[SerializeField]
		private Transform _switch;

		// Token: 0x04009DD4 RID: 40404
		[SerializeField]
		[Space]
		private SharedTargetControl _sharedTargetControl;

		// Token: 0x04009DD5 RID: 40405
		[Space]
		[SerializeField]
		private AudioSource _clickAudio;

		// Token: 0x04009DD6 RID: 40406
		[SerializeField]
		private AudioSource _switchAudio;

		// Token: 0x04009DD7 RID: 40407
		private GClass3008 gclass3008_0;

		// Token: 0x04009DD8 RID: 40408
		private const int int_0 = 2;

		// Token: 0x04009DD9 RID: 40409
		private int int_1;

		// Token: 0x04009DDA RID: 40410
		private bool bool_0;

		// Token: 0x04009DDB RID: 40411
		private bool bool_1;

		// Token: 0x04009DDC RID: 40412
		private GClass1945 gclass1945_0;

		// Token: 0x04009DDD RID: 40413
		private GClass1946 gclass1946_0;

		// Token: 0x04009DDE RID: 40414
		private GClass1944 gclass1944_0;

		// Token: 0x04009DDF RID: 40415
		private GClass1943 gclass1943_0;

		// Token: 0x04009DE0 RID: 40416
		private Vector3[] vector3_0;

		// Token: 0x02001C16 RID: 7190
		[CompilerGenerated]
		private sealed class Class1696
		{
			// Token: 0x060096E5 RID: 38629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04009DE1 RID: 40417
			public HideoutPlayerOwner owner;

			// Token: 0x04009DE2 RID: 40418
			public RailTargetControl railTargetControl_0;
		}
	}
}
