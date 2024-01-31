using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using NLog;
using UnityEngine;

// Token: 0x0200068E RID: 1678
public abstract class LoggerClass : IDisposable
{
	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x06002623 RID: 9763 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002624 RID: 9764 RVA: 0x00002050 File Offset: 0x00000250
	public static bool UnityDebugLogsEnabled
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

	// Token: 0x170006E6 RID: 1766
	// (get) Token: 0x06002625 RID: 9765 RVA: 0x00002050 File Offset: 0x00000250
	public string NLoggerName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170006E7 RID: 1767
	// (get) Token: 0x06002626 RID: 9766 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002627 RID: 9767 RVA: 0x00002050 File Offset: 0x00000250
	public LoggerMode Mode
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

	// Token: 0x06002628 RID: 9768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEnabled(LogLevel level)
	{
		throw null;
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Log(LogEventInfo logEvent)
	{
		throw null;
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogTrace(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogDebug(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfo(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfoWithStackTrace(string format)
	{
		throw null;
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string method_0(LogLevel logLevel)
	{
		throw null;
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogWarn(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogError(string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogException(Exception e)
	{
		throw null;
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Log(LogLevel logLevel, string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Log(string nlogFormat, string unityFormat, LogLevel logLevel, params object[] args)
	{
		throw null;
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void LogFormat(LogType logType, string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LogLevel ConvertLogTypeToLogLevel(LogType logType)
	{
		throw null;
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string smethod_0(object[] args)
	{
		throw null;
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Exception exception)
	{
		throw null;
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(string message, string stackTrace, LogType logType)
	{
		throw null;
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LogInfoWithColor(string color, string format, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LogInfoFieldsWithColor(string color, params object[] args)
	{
		throw null;
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LogWarnFields(params object[] args)
	{
		throw null;
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LogTraceFields(params object[] args)
	{
		throw null;
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LogInfoFields(params object[] args)
	{
		throw null;
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string LogErrorFields(params object[] args)
	{
		throw null;
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string FormatFields(params object[] args)
	{
		throw null;
	}

	// Token: 0x04002558 RID: 9560
	[CompilerGenerated]
	private static bool bool_0;

	// Token: 0x04002559 RID: 9561
	public static bool IsLogsEnabled;

	// Token: 0x0400255A RID: 9562
	private readonly bool bool_1;

	// Token: 0x0400255B RID: 9563
	protected NLog.Logger logger_0;

	// Token: 0x0400255C RID: 9564
	private LoggerClass.Class357 class357_0;

	// Token: 0x0400255D RID: 9565
	[CompilerGenerated]
	private LoggerMode loggerMode_0;

	// Token: 0x0400255E RID: 9566
	private readonly StringBuilder stringBuilder_0;

	// Token: 0x0200068F RID: 1679
	private sealed class Class357 : ILogHandler
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x00002050 File Offset: 0x00000250
		private static int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release()
		{
			throw null;
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(string loggerName, LogEventInfo logEvent)
		{
			throw null;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(string loggerName, LogLevel logLevel, string format, object[] args)
		{
			throw null;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(Exception exception)
		{
			throw null;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(string loggerName, LogType logType, string format, object[] args)
		{
			throw null;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ILogHandler.LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ILogHandler.LogException(Exception exception, UnityEngine.Object context)
		{
			throw null;
		}

		// Token: 0x0400255F RID: 9567
		private readonly object[] object_0;

		// Token: 0x04002560 RID: 9568
		private LoggerClass gclass611_0;

		// Token: 0x04002561 RID: 9569
		private ILogHandler ilogHandler_0;

		// Token: 0x04002562 RID: 9570
		private int int_0;

		// Token: 0x02000690 RID: 1680
		[CompilerGenerated]
		[Serializable]
		private sealed class Class358
		{
			// Token: 0x06002649 RID: 9801 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string current, KeyValuePair<object, object> prop)
			{
				throw null;
			}

			// Token: 0x04002563 RID: 9571
			public static readonly LoggerClass.Class357.Class358 class358_0;

			// Token: 0x04002564 RID: 9572
			public static Func<string, KeyValuePair<object, object>, string> func_0;
		}
	}
}
