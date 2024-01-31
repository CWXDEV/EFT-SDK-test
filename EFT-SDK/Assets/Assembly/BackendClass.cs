using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;

// Token: 0x0200178E RID: 6030
internal abstract class BackendClass<T> : Class258 where T : GInterface144
{
	// Token: 0x170013F5 RID: 5109
	// (get) Token: 0x060080AC RID: 32940 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060080AD RID: 32941 RVA: 0x00002050 File Offset: 0x00000250
	public BackendStatus Status
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

	// Token: 0x170013F6 RID: 5110
	// (get) Token: 0x060080AE RID: 32942 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060080AF RID: 32943 RVA: 0x00002050 File Offset: 0x00000250
	public T Session
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x060080B0 RID: 32944 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<GClass798>> Login(string login, string password)
	{
		throw null;
	}

	// Token: 0x060080B1 RID: 32945 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task Logout()
	{
		throw null;
	}

	// Token: 0x060080B2 RID: 32946 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Destroy()
	{
		throw null;
	}

	// Token: 0x060080B3 RID: 32947
	protected abstract T vmethod_0(GClass1190 loginResponse);

	// Token: 0x060080B4 RID: 32948 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableDiagnostics(bool webDiagnosticsEnabled)
	{
		throw null;
	}

	// Token: 0x060080B5 RID: 32949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterDevice(string email, string activateCode, Callback callback)
	{
		throw null;
	}

	// Token: 0x060080B6 RID: 32950 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RegenerateToken()
	{
		throw null;
	}

	// Token: 0x060080B7 RID: 32951 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ValidateVersion()
	{
		throw null;
	}

	// Token: 0x060080B8 RID: 32952 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1397> GetMainMenuLocalization(string locale)
	{
		throw null;
	}

	// Token: 0x060080B9 RID: 32953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Dictionary<string, string>> GetAvailableLanguages()
	{
		throw null;
	}

	// Token: 0x060080BA RID: 32954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<T> CreateClientSession()
	{
		throw null;
	}

	// Token: 0x0400896D RID: 35181
	[CompilerGenerated]
	private BackendStatus backendStatus_0;

	// Token: 0x0400896E RID: 35182
	[CompilerGenerated]
	private T gparam_0;

	// Token: 0x0400896F RID: 35183
	protected readonly string string_2;

	// Token: 0x04008970 RID: 35184
	protected readonly GClass1403 gclass1403_0;

	// Token: 0x04008971 RID: 35185
	protected readonly string string_3;

	// Token: 0x04008972 RID: 35186
	protected readonly bool bool_2;

	// Token: 0x0200178F RID: 6031
	[CompilerGenerated]
	private sealed class Class1263
	{
		// Token: 0x060080BB RID: 32955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass1190> result)
		{
			throw null;
		}

		// Token: 0x04008973 RID: 35187
		public TaskCompletionSource<Result<GClass1190>> loginTaskSource;
	}
}
