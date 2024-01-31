using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Console.Core;

// Token: 0x02001C93 RID: 7315
public class GClass1952
{
	// Token: 0x060098DC RID: 39132 RVA: 0x00002050 File Offset: 0x00000250
	[ConsoleCommand("quit", "", null, "", new string[] { "q" })]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Quit()
	{
		throw null;
	}

	// Token: 0x060098DD RID: 39133 RVA: 0x00002050 File Offset: 0x00000250
	[ConsoleCommand("quit_with_code", "", null, "", new string[] { })]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void QuitWithCode(int code)
	{
		throw null;
	}

	// Token: 0x060098DE RID: 39134 RVA: 0x00002050 File Offset: 0x00000250
	[ConsoleCommand("fps", "", null, "", new string[] { })]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Fps([ConsoleArgument("0", "0..3 - view format")] int mode)
	{
		throw null;
	}

	// Token: 0x060098DF RID: 39135 RVA: 0x00002050 File Offset: 0x00000250
	[ConsoleCommand("perftest", "perftest", "", "", new string[] { })]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task PerfTest(int overall, int every, string label)
	{
		throw null;
	}

	// Token: 0x02001C94 RID: 7316
	[CompilerGenerated]
	private sealed class Class1714
	{
		// Token: 0x060098E0 RID: 39136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400A012 RID: 40978
		public TaskCompletionSource<bool> executeComplete;
	}
}
