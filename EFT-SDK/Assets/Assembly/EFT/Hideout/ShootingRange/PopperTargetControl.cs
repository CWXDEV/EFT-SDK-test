using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout.ShootingRange
{
	// Token: 0x02001C12 RID: 7186
	public class PopperTargetControl : InteractiveShootingRange
	{
		// Token: 0x060096BF RID: 38591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Disable()
		{
			throw null;
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOnEnergy()
		{
			throw null;
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TurnOffEnergy()
		{
			throw null;
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GClass3008 InteractionStates(HideoutPlayerOwner owner)
		{
			throw null;
		}

		// Token: 0x060096C3 RID: 38595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x060096C4 RID: 38596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060096C5 RID: 38597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x060096CB RID: 38603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060096CC RID: 38604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x060096D2 RID: 38610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04009DBF RID: 40383
		[Space]
		[SerializeField]
		private RailTargets _railTargets;

		// Token: 0x04009DC0 RID: 40384
		[SerializeField]
		private PopperTargets _popperTargets;

		// Token: 0x04009DC1 RID: 40385
		[Space]
		[SerializeField]
		private SharedTargetControl _sharedTargetControl;

		// Token: 0x04009DC2 RID: 40386
		[SerializeField]
		private GClass1939.Setting _popperTargetStandSettings;

		// Token: 0x04009DC3 RID: 40387
		[SerializeField]
		private GClass1947.Setting _shootTrainingSettings;

		// Token: 0x04009DC4 RID: 40388
		[Space]
		[SerializeField]
		private ShootingScoreInterface _shootingScoreInterface;

		// Token: 0x04009DC5 RID: 40389
		[SerializeField]
		private AudioSource _clickAudio;

		// Token: 0x04009DC6 RID: 40390
		private GClass1939 gclass1939_0;

		// Token: 0x04009DC7 RID: 40391
		private GClass1947 gclass1947_0;

		// Token: 0x04009DC8 RID: 40392
		private GClass1938 gclass1938_0;

		// Token: 0x04009DC9 RID: 40393
		private GClass1940 gclass1940_0;

		// Token: 0x04009DCA RID: 40394
		private GClass3008 gclass3008_0;

		// Token: 0x04009DCB RID: 40395
		private bool bool_0;

		// Token: 0x04009DCC RID: 40396
		private bool bool_1;

		// Token: 0x04009DCD RID: 40397
		private int int_0;

		// Token: 0x02001C13 RID: 7187
		[CompilerGenerated]
		private sealed class Class1694
		{
			// Token: 0x060096D4 RID: 38612 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x060096D5 RID: 38613 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04009DCE RID: 40398
			public HideoutPlayerOwner owner;

			// Token: 0x04009DCF RID: 40399
			public PopperTargetControl popperTargetControl_0;
		}

		// Token: 0x02001C14 RID: 7188
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1695
		{
			// Token: 0x060096D6 RID: 38614 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(GClass1947.PhaseSetting v)
			{
				throw null;
			}

			// Token: 0x04009DD0 RID: 40400
			public static readonly PopperTargetControl.Class1695 class1695_0;

			// Token: 0x04009DD1 RID: 40401
			public static Func<GClass1947.PhaseSetting, float> func_0;
		}
	}
}
