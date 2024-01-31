using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UI.Hideout;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B45 RID: 6981
	public sealed class WorkoutBehaviour : GClass1924, GInterface170
	{
		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06009316 RID: 37654 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06009317 RID: 37655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartQte(HideoutPlayerOwner owner, QteHandleData qteData)
		{
			throw null;
		}

		// Token: 0x06009318 RID: 37656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(QteData qteData)
		{
			throw null;
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_12(QuickTimeEvent[] quickTimeEvents)
		{
			throw null;
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(bool succeed, GClass1934 qteResult)
		{
			throw null;
		}

		// Token: 0x0600931C RID: 37660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(bool succeed)
		{
			throw null;
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(string soundBank)
		{
			throw null;
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(int coef)
		{
			throw null;
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18()
		{
			throw null;
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_20(QteEffect effect)
		{
			throw null;
		}

		// Token: 0x0400998F RID: 39311
		private const int int_0 = 0;

		// Token: 0x04009990 RID: 39312
		private const int int_1 = 1000;

		// Token: 0x04009991 RID: 39313
		private const int int_2 = 2500;

		// Token: 0x04009992 RID: 39314
		private const int int_3 = 1000;

		// Token: 0x04009993 RID: 39315
		private const int int_4 = 2000;

		// Token: 0x04009994 RID: 39316
		private const int int_5 = 500;

		// Token: 0x04009995 RID: 39317
		private const string string_0 = "WorkoutBrokenArmBlockerMessage";

		// Token: 0x04009996 RID: 39318
		private const string string_1 = "WorkoutTiredBlockerMessage";

		// Token: 0x04009997 RID: 39319
		private const string string_2 = "arm broke";

		// Token: 0x04009998 RID: 39320
		private HideoutPlayerOwner hideoutPlayerOwner_0;

		// Token: 0x04009999 RID: 39321
		private HealthControllerClass gclass2415_0;

		// Token: 0x0400999A RID: 39322
		private float float_0;

		// Token: 0x0400999B RID: 39323
		private float float_1;

		// Token: 0x0400999C RID: 39324
		private float float_2;

		// Token: 0x0400999D RID: 39325
		private float float_3;

		// Token: 0x0400999E RID: 39326
		private QTEController qtecontroller_0;

		// Token: 0x0400999F RID: 39327
		private QteHandleData qteHandleData_0;

		// Token: 0x040099A0 RID: 39328
		private List<QteHandleData.PropsData> list_1;

		// Token: 0x040099A1 RID: 39329
		private List<Transform> list_2;

		// Token: 0x040099A2 RID: 39330
		private HideoutClass gclass1904_0;

		// Token: 0x02001B46 RID: 6982
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1647
		{
			// Token: 0x06009323 RID: 37667 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Requirement requirement)
			{
				throw null;
			}

			// Token: 0x06009324 RID: 37668 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(QteEffect x)
			{
				throw null;
			}

			// Token: 0x06009325 RID: 37669 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(QteEffect x)
			{
				throw null;
			}

			// Token: 0x040099A3 RID: 39331
			public static readonly WorkoutBehaviour.Class1647 class1647_0;

			// Token: 0x040099A4 RID: 39332
			public static Func<Requirement, bool> func_0;

			// Token: 0x040099A5 RID: 39333
			public static Func<QteEffect, bool> func_1;

			// Token: 0x040099A6 RID: 39334
			public static Func<QteEffect, bool> func_2;
		}

		// Token: 0x02001B47 RID: 6983
		[CompilerGenerated]
		private sealed class Class1648
		{
			// Token: 0x06009326 RID: 37670 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(QteHandleData.PropsData p)
			{
				throw null;
			}

			// Token: 0x040099A7 RID: 39335
			public int triggerLevel;
		}
	}
}
