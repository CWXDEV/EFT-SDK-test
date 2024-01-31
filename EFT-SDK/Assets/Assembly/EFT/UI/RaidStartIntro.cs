using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028C6 RID: 10438
	public sealed class RaidStartIntro : UIElement
	{
		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x0600D077 RID: 53367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D078 RID: 53368 RVA: 0x00002050 File Offset: 0x00000250
		public float AlphaMultiplier
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

		// Token: 0x0600D079 RID: 53369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowIntro(long raidNumber, DateTime registrationDate, GameDateTime locationTime, EPlayerSide side, string playerName, string location)
		{
			throw null;
		}

		// Token: 0x0600D07A RID: 53370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D07B RID: 53371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x0600D07C RID: 53372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_1(CustomTextMeshProUGUI label, string to)
		{
			throw null;
		}

		// Token: 0x0600D07D RID: 53373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2(CustomTextMeshProUGUI label)
		{
			throw null;
		}

		// Token: 0x0600D07E RID: 53374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		// Token: 0x0400D14A RID: 53578
		private const float float_0 = 0.3f;

		// Token: 0x0400D14B RID: 53579
		private const float float_1 = 4f;

		// Token: 0x0400D14C RID: 53580
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400D14D RID: 53581
		[SerializeField]
		private CustomTextMeshProUGUI _raidNumberLabel;

		// Token: 0x0400D14E RID: 53582
		[SerializeField]
		private CustomTextMeshProUGUI _dayLabel;

		// Token: 0x0400D14F RID: 53583
		[SerializeField]
		private CustomTextMeshProUGUI _nameLabel;

		// Token: 0x0400D150 RID: 53584
		[SerializeField]
		private CustomTextMeshProUGUI _locationLabel;

		// Token: 0x0400D151 RID: 53585
		private string string_0;

		// Token: 0x0400D152 RID: 53586
		private DateTime dateTime_0;

		// Token: 0x0400D153 RID: 53587
		private GameDateTime gameDateTime_0;

		// Token: 0x0400D154 RID: 53588
		private bool bool_0;

		// Token: 0x0400D155 RID: 53589
		private float float_2;

		// Token: 0x0400D156 RID: 53590
		private float float_3;

		// Token: 0x020028C7 RID: 10439
		[CompilerGenerated]
		private sealed class Class2371
		{
			// Token: 0x0600D07F RID: 53375 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D080 RID: 53376 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600D081 RID: 53377 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600D082 RID: 53378 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x0400D157 RID: 53591
			public RaidStartIntro raidStartIntro_0;

			// Token: 0x0400D158 RID: 53592
			public string playerName;

			// Token: 0x0400D159 RID: 53593
			public string location;

			// Token: 0x0400D15A RID: 53594
			public Action action_0;

			// Token: 0x0400D15B RID: 53595
			public Action action_1;

			// Token: 0x0400D15C RID: 53596
			public Action action_2;
		}
	}
}
