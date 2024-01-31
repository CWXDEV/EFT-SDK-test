using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.GlobalEvents;
using JetBrains.Annotations;

// Token: 0x02000804 RID: 2052
internal sealed class Class419 : IDisposable
{
	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x06002F47 RID: 12103 RVA: 0x00002050 File Offset: 0x00000250
	internal static LoggerClass GClass611_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x06002F48 RID: 12104 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	internal static Class419 Class419_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x06002F49 RID: 12105 RVA: 0x00002050 File Offset: 0x00000250
	public EWinterStatus Status
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000091 RID: 145
	// (add) Token: 0x06002F4A RID: 12106 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<EWinterStatus> StatusChangedEvent
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

	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x06002F4C RID: 12108 RVA: 0x00002050 File Offset: 0x00000250
	public static float SnowLevelOnTerrain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000092 RID: 146
	// (add) Token: 0x06002F4D RID: 12109 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002F4E RID: 12110 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<float> SnowLevelOnTerrainChangedEvent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000093 RID: 147
	// (add) Token: 0x06002F4F RID: 12111 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002F50 RID: 12112 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<Class419> OnInitialized
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

	// Token: 0x06002F51 RID: 12113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Run(bool isWinter)
	{
		throw null;
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(WinterReconnectEvent reconnectEvent)
	{
		throw null;
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(WinterStormStartedEvent stormStartedEvent)
	{
		throw null;
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_2(Interface3 winterVisual)
	{
		throw null;
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_3(Interface3 winterVisual)
	{
		throw null;
	}

	// Token: 0x04002E65 RID: 11877
	[CompilerGenerated]
	private static readonly LoggerClass gclass611_0;

	// Token: 0x04002E66 RID: 11878
	private Class419.Interface2 interface2_0;

	// Token: 0x04002E67 RID: 11879
	[CompilerGenerated]
	private Action<EWinterStatus> action_0;

	// Token: 0x04002E68 RID: 11880
	[CompilerGenerated]
	private static Action<Class419> action_1;

	// Token: 0x04002E69 RID: 11881
	private Interface3 interface3_0;

	// Token: 0x04002E6A RID: 11882
	private Action action_2;

	// Token: 0x02000805 RID: 2053
	private interface Interface2 : IDisposable
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002F57 RID: 12119
		EWinterStatus Status { get; }

		// Token: 0x06002F58 RID: 12120
		void HandleReconnect(Interface3 visual, EWinterStatus status);

		// Token: 0x06002F59 RID: 12121
		void StormStarted(Interface3 visual);

		// Token: 0x06002F5A RID: 12122
		void SetupVisual(Interface3 visual);
	}

	// Token: 0x02000806 RID: 2054
	private abstract class Class420
	{
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00002050 File Offset: 0x00000250
		internal Class419 Class419_0
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x00002050 File Offset: 0x00000250
		public EWinterStatus Status
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04002E6B RID: 11883
		[CompilerGenerated]
		private Class419 class419_0;

		// Token: 0x04002E6C RID: 11884
		[CompilerGenerated]
		private readonly EWinterStatus ewinterStatus_0;
	}

	// Token: 0x02000807 RID: 2055
	private sealed class Class421 : Class419.Class420, IDisposable, Class419.Interface2
	{
		// Token: 0x06002F5F RID: 12127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleReconnect(Interface3 visual, EWinterStatus status)
		{
			throw null;
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StormStarted(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupVisual(Interface3 visual)
		{
			throw null;
		}
	}

	// Token: 0x02000808 RID: 2056
	private sealed class Class422 : Class419.Class420, IDisposable, Class419.Interface2
	{
		// Token: 0x06002F62 RID: 12130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StormStarted(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupVisual(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleReconnect(Interface3 visual, EWinterStatus status)
		{
			throw null;
		}
	}

	// Token: 0x02000809 RID: 2057
	private sealed class Class423 : Class419.Class420, IDisposable, Class419.Interface2
	{
		// Token: 0x06002F65 RID: 12133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StormStarted(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupVisual(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleReconnect(Interface3 visual, EWinterStatus status)
		{
			throw null;
		}
	}

	// Token: 0x0200080A RID: 2058
	private sealed class Class424 : Class419.Class420, IDisposable, Class419.Interface2
	{
		// Token: 0x06002F68 RID: 12136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StormStarted(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupVisual(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleReconnect(Interface3 visual, EWinterStatus status)
		{
			throw null;
		}
	}

	// Token: 0x0200080B RID: 2059
	private sealed class Class425 : Class419.Class420, IDisposable, Class419.Interface2
	{
		// Token: 0x06002F6B RID: 12139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Run()
		{
			throw null;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StormStarted(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetupVisual(Interface3 visual)
		{
			throw null;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HandleReconnect(Interface3 visual, EWinterStatus status)
		{
			throw null;
		}
	}
}
