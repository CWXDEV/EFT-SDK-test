using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.UI.Screens;

// Token: 0x02002D08 RID: 11528
public class UserInterfaceClass<T> : GInterface375 where T : struct, Enum
{
	// Token: 0x14000326 RID: 806
	// (add) Token: 0x0600E294 RID: 58004 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600E295 RID: 58005 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<T> OnScreenChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1700279D RID: 10141
	// (get) Token: 0x0600E296 RID: 58006 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface373<T> CurrentScreenController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700279E RID: 10142
	// (get) Token: 0x0600E297 RID: 58007 RVA: 0x00002050 File Offset: 0x00000250
	public T RootScreenType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700279F RID: 10143
	// (get) Token: 0x0600E298 RID: 58008 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600E299 RID: 58009 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual GInterface374<T> CurrentBaseScreenController
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

	// Token: 0x170027A0 RID: 10144
	// (get) Token: 0x0600E29A RID: 58010 RVA: 0x00002050 File Offset: 0x00000250
	Enum GInterface375.CurrentScreenType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600E29B RID: 58011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	Task<bool> GInterface375.CloseAllScreens(bool forced)
	{
		throw null;
	}

	// Token: 0x0600E29C RID: 58012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseScreen<TController, TScreen>(T screenType, BaseScreen<TController, TScreen, T> screen) where TController : UserInterfaceClass<T>.GClass3108<TController, TScreen> where TScreen : BaseScreen<TController, TScreen, T>
	{
		throw null;
	}

	// Token: 0x0600E29D RID: 58013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterScreen<TController, TScreen>(T screenType, BaseScreen<TController, TScreen, T> screen) where TController : UserInterfaceClass<T>.GClass3108<TController, TScreen> where TScreen : BaseScreen<TController, TScreen, T>
	{
		throw null;
	}

	// Token: 0x0600E29E RID: 58014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> TryCloseAllScreens()
	{
		throw null;
	}

	// Token: 0x0600E29F RID: 58015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseAllScreensForced()
	{
		throw null;
	}

	// Token: 0x0600E2A0 RID: 58016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseCurrentScreenForced()
	{
		throw null;
	}

	// Token: 0x0600E2A1 RID: 58017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> ShowScreenSequence(bool rootFirstScreen, bool queueLastScreen, params GInterface374<T>[] controllers)
	{
		throw null;
	}

	// Token: 0x0600E2A2 RID: 58018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ToggleScreen(T screenType, Action showAction = null)
	{
		throw null;
	}

	// Token: 0x0600E2A3 RID: 58019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCurrentScreen(T screenType)
	{
		throw null;
	}

	// Token: 0x0600E2A4 RID: 58020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> TryReturnToKeyScreen()
	{
		throw null;
	}

	// Token: 0x0600E2A5 RID: 58021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> TryReturnToRootScreen()
	{
		throw null;
	}

	// Token: 0x0600E2A6 RID: 58022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_0(bool forced)
	{
		throw null;
	}

	// Token: 0x0600E2A7 RID: 58023 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TryGetScreen(T screenType, out UIScreen screen)
	{
		throw null;
	}

	// Token: 0x0400E77C RID: 59260
	private static UserInterfaceClass<T> gclass3106_0;

	// Token: 0x0400E77D RID: 59261
	[CompilerGenerated]
	private Action<T> action_0;

	// Token: 0x0400E77E RID: 59262
	private readonly Dictionary<T, UIScreen> dictionary_0;

	// Token: 0x0400E77F RID: 59263
	private GInterface374<T> ginterface374_0;

	// Token: 0x02002D09 RID: 11529
	public abstract class GClass3108<U, V> : GInterface373<T>, GInterface374<T> where U : UserInterfaceClass<T>.GClass3108<U, V> where V : BaseScreen<U, V, T>
	{
		// Token: 0x14000327 RID: 807
		// (add) Token: 0x0600E2A8 RID: 58024 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E2A9 RID: 58025 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnClose
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000328 RID: 808
		// (add) Token: 0x0600E2AA RID: 58026 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E2AB RID: 58027 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnShow
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool KeyScreen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool Disabled { get; set; }
		public GInterface374<T> PreviousScreen { get; }
		public GInterface374<T> RootScreen { get; }

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x0600E2AD RID: 58029
		public abstract T ScreenType { get; }

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x0600E2AE RID: 58030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2AF RID: 58031 RVA: 0x00002050 File Offset: 0x00000250
		public bool Queued
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

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0600E2B0 RID: 58032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2B1 RID: 58033 RVA: 0x00002050 File Offset: 0x00000250
		public bool Root
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

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0600E2B2 RID: 58034 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool QueuePreviousScreen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x00002050 File Offset: 0x00000250
		protected GInterface374<T> GInterface374_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600E2B4 RID: 58036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2B5 RID: 58037 RVA: 0x00002050 File Offset: 0x00000250
		private GInterface374<T> GInterface374_1
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x0600E2B6 RID: 58038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E2B7 RID: 58039 RVA: 0x00002050 File Offset: 0x00000250
		public bool Closed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x0600E2B8 RID: 58040 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E2B9 RID: 58041 RVA: 0x00002050 File Offset: 0x00000250
		public void QueueScreen(EScreenState screenState)
		{
			throw new NotImplementedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ShowScreen(EScreenState screenState)
		{
			throw null;
		}

		// Token: 0x0600E2BA RID: 58042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<bool> ShowScreenAsync(EScreenState screenState, bool forced = false)
		{
			throw null;
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PrepareEnvironment()
		{
			throw null;
		}

		// Token: 0x0600E2BC RID: 58044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseScreen()
		{
			throw null;
		}

		// Token: 0x0600E2BD RID: 58045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseScreenForced()
		{
			throw null;
		}

		// Token: 0x0600E2BE RID: 58046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> TryCloseScreen()
		{
			throw null;
		}

		// Token: 0x0600E2BF RID: 58047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> CloseSelf(bool forced)
		{
			throw null;
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> ShowPreviousKeyScreen()
		{
			throw null;
		}

		// Token: 0x0600E2C1 RID: 58049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> ReturnToRootScreen()
		{
			throw null;
		}

		// Token: 0x0600E2C2 RID: 58050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CloseAction(bool moveForward)
		{
			throw null;
		}

		// Token: 0x0600E2C3 RID: 58051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task DisplayScreen()
		{
			throw null;
		}

		// Token: 0x0600E2C4 RID: 58052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task<bool> CloseScreenInterruption(bool moveForward)
		{
			throw null;
		}

		// Token: 0x0600E2C5 RID: 58053 RVA: 0x00002050 File Offset: 0x00000250
		public void RestoreScreen()
		{
			throw new NotImplementedException();
		}

		void GInterface374<T>.ShowScreenAsPrevious()
		{
			throw new NotImplementedException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool ShowScreenAsPrevious()
		{
			throw null;
		}

		// Token: 0x0600E2C6 RID: 58054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void method_0()
		{
			throw null;
		}

		// Token: 0x0600E2C7 RID: 58055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowAction(V screen)
		{
			throw null;
		}

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task<bool> CloseCurrentScreen(bool forced)
		{
			throw null;
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_1(EScreenState screenState, bool forced)
		{
			throw null;
		}

		// Token: 0x0600E2CA RID: 58058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(EScreenState screenState, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600E2CB RID: 58059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_3(bool forced, EScreenOrder order)
		{
			throw null;
		}

		// Token: 0x0600E2CC RID: 58060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(EScreenOrder order)
		{
			throw null;
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GInterface374<T> method_5(EScreenOrder order)
		{
			throw null;
		}

		// Token: 0x0600E2CE RID: 58062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void method_7(EStateSwitcher switcher, Action<bool> action)
		{
			throw null;
		}

		// Token: 0x0400E780 RID: 59264
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400E781 RID: 59265
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x0400E782 RID: 59266
		protected V gparam_0;

		// Token: 0x0400E783 RID: 59267
		private bool bool_0;

		// Token: 0x0400E784 RID: 59268
		private bool bool_1;

		// Token: 0x0400E785 RID: 59269
		private TaskCompletionSource<bool> taskCompletionSource_0;

		// Token: 0x0400E786 RID: 59270
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400E787 RID: 59271
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400E788 RID: 59272
		[CompilerGenerated]
		private GInterface374<T> ginterface374_0;
	}

	// Token: 0x02002D0E RID: 11534
	[CompilerGenerated]
	private sealed class Class2756
	{
		// Token: 0x0600E2D8 RID: 58072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task method_0()
		{
			throw null;
		}

		// Token: 0x0400E7A5 RID: 59301
		public UserInterfaceClass<T> gclass3106_0;

		// Token: 0x0400E7A6 RID: 59302
		public T screenType;

		// Token: 0x0400E7A7 RID: 59303
		public Action showAction;

		// Token: 0x02002D0F RID: 11535
		[StructLayout(LayoutKind.Auto)]
		public struct Struct953 : IAsyncStateMachine
		{
			// Token: 0x0600E2D9 RID: 58073 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.MoveNext()
			{
				throw null;
			}

			// Token: 0x0600E2DA RID: 58074 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400E7A8 RID: 59304
			public int int_0;

			// Token: 0x0400E7A9 RID: 59305
			public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

			// Token: 0x0400E7AA RID: 59306
			public UserInterfaceClass<T>.Class2756 class2756_0;

			// Token: 0x0400E7AB RID: 59307
			private TaskAwaiter<bool> taskAwaiter_0;
		}
	}
}
