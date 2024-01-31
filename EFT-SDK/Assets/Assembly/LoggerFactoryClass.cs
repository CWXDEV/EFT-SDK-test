using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

// Token: 0x02001977 RID: 6519
public sealed class LoggerFactoryClass : ILoggerFactory
{
	// Token: 0x1700154B RID: 5451
	// (get) Token: 0x06008BB9 RID: 35769 RVA: 0x00002050 File Offset: 0x00000250
	public string CategoryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06008BBA RID: 35770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ILogger CreateLogger(string categoryName)
	{
		throw null;
	}

	// Token: 0x06008BBB RID: 35771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ILogger<T> CreateLogger<T>()
	{
		throw null;
	}

	// Token: 0x02001978 RID: 6520
	private sealed class Class347<T> : LoggerFactoryClass.Class346, ILogger, ILogger<T>
	{
	}

	// Token: 0x02001979 RID: 6521
	private class Class346 : LoggerClass, ILogger
	{
		// Token: 0x06008BBC RID: 35772 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
			throw null;
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEnabled(LogLevel logLevel)
		{
			throw null;
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IDisposable BeginScope<TState>(TState state)
		{
			throw null;
		}

		// Token: 0x0200197A RID: 6522
		private sealed class Class1525 : IDisposable
		{
			// Token: 0x06008BBF RID: 35775 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x04009161 RID: 37217
			public static readonly LoggerFactoryClass.Class346.Class1525 Instance;
		}
	}
}
