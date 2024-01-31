using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D34 RID: 11572
	public sealed class SettingDropDown : SettingControl
	{
		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x00002050 File Offset: 0x00000250
		public UiElementBlocker Blocker
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x00002050 File Offset: 0x00000250
		protected override Component TargetComponent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E3BF RID: 58303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E3C0 RID: 58304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindToEnum<T>(GameSetting<T> setting, bool twoWays = false, Func<int, bool> validator = null, Action customUpdater = null) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BindTo<T>(GameSetting<T> setting, ReadOnlyCollection<T> variants, Func<T, string> stringConverter)
		{
			throw null;
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Action BindDropDownToSetting<T>(DropDownBox dropdown, GameSetting<T> setting, ReadOnlyCollection<T> variants, Func<T, string> stringConverter)
		{
			throw null;
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0<T>(T value) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0<T>(DropDownBox dropdown, T value, ReadOnlyCollection<T> variants)
		{
			throw null;
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GClass763 BindTwoWaySettingDropDown<T>(DropDownBox dropdown, GameSetting<T> setting, ReadOnlyCollection<T> variants, Func<T, string> stringConverter)
		{
			throw null;
		}

		// Token: 0x0400E895 RID: 59541
		[SerializeField]
		private DropDownBox DropDown;

		// Token: 0x0400E896 RID: 59542
		[SerializeField]
		private UiElementBlocker _blocker;

		// Token: 0x02002D35 RID: 11573
		[CompilerGenerated]
		private sealed class Class2773<T> where T : struct, Enum
		{
			// Token: 0x0600E3C6 RID: 58310 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int index)
			{
				throw null;
			}

			// Token: 0x0400E897 RID: 59543
			public GameSetting<T> setting;

			// Token: 0x0400E898 RID: 59544
			public Action customUpdater;
		}

		// Token: 0x02002D36 RID: 11574
		[CompilerGenerated]
		private sealed class Class2774<T>
		{
			// Token: 0x0600E3C7 RID: 58311 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0(T value)
			{
				throw null;
			}

			// Token: 0x0600E3C8 RID: 58312 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600E3C9 RID: 58313 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(int index)
			{
				throw null;
			}

			// Token: 0x0400E899 RID: 59545
			public GameSetting<T> setting;

			// Token: 0x0400E89A RID: 59546
			public DropDownBox dropdown;

			// Token: 0x0400E89B RID: 59547
			public ReadOnlyCollection<T> variants;

			// Token: 0x0400E89C RID: 59548
			public Func<T, string> stringConverter;

			// Token: 0x02002D37 RID: 11575
			[StructLayout(LayoutKind.Auto)]
			public struct Struct957 : IAsyncStateMachine
			{
				// Token: 0x0600E3CA RID: 58314 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600E3CB RID: 58315 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400E89D RID: 59549
				public int int_0;

				// Token: 0x0400E89E RID: 59550
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400E89F RID: 59551
				public SettingDropDown.Class2774<T> class2774_0;

				// Token: 0x0400E8A0 RID: 59552
				public T value;

				// Token: 0x0400E8A1 RID: 59553
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02002D38 RID: 11576
		[CompilerGenerated]
		private sealed class Class2775<T>
		{
			// Token: 0x0600E3CC RID: 58316 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(T x)
			{
				throw null;
			}

			// Token: 0x0400E8A2 RID: 59554
			public DropDownBox dropdown;

			// Token: 0x0400E8A3 RID: 59555
			public ReadOnlyCollection<T> variants;
		}
	}
}
