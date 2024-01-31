using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using FilesChecker;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016CF RID: 5839
	public abstract class CommonClientApplication<T> : ClientApplication<T> where T : class, GInterface144
	{
		// Token: 0x06007E10 RID: 32272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task Start()
		{
			throw null;
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool ConfigureApplication()
		{
			throw null;
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task RunFilesChecking(ConsistencyEnsuranceMode ordinaryFileEnsuranceMode = ConsistencyEnsuranceMode.Fast, ConsistencyEnsuranceMode criticalFileEnsuranceMode = ConsistencyEnsuranceMode.Full, CancellationToken token = default(CancellationToken))
		{
			throw null;
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task DefaultBundleCheck(string bundlePath)
		{
			throw null;
		}

		// Token: 0x06007E16 RID: 32278
		protected abstract Task BundleCheck(string bundlePath);

		// Token: 0x06007E17 RID: 32279
		protected abstract Task LoadLoginScenes();

		// Token: 0x06007E18 RID: 32280
		protected abstract Task CreateBackend();

		// Token: 0x06007E19 RID: 32281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3()
		{
			throw null;
		}

		// Token: 0x040084D6 RID: 34006
		[SerializeField]
		protected bool _developMode;

		// Token: 0x040084D7 RID: 34007
		[SerializeField]
		protected int _fixedFrameRate;

		// Token: 0x040084D8 RID: 34008
		[SerializeField]
		protected float _fixedDeltaTime;

		// Token: 0x040084D9 RID: 34009
		[SerializeField]
		protected string _localGameDate;

		// Token: 0x040084DA RID: 34010
		[SerializeField]
		protected string _localGameTime;

		// Token: 0x040084DB RID: 34011
		[SerializeField]
		protected float _localGameTimeFactor;

		// Token: 0x040084DC RID: 34012
		[SerializeField]
		protected bool _resetSettings;

		// Token: 0x040084DD RID: 34013
		[SerializeField]
		protected string _version;

		// Token: 0x040084DE RID: 34014
		protected GClass1797 _objectsFactoryConfig;

		// Token: 0x040084DF RID: 34015
		protected GClass1812 _commandLineArgs;

		// Token: 0x040084E0 RID: 34016
		protected string _backendUrl;

		// Token: 0x040084E1 RID: 34017
		protected string _buildVersion;

		// Token: 0x020016D1 RID: 5841
		[CompilerGenerated]
		private sealed class Class1208
		{
			// Token: 0x06007E1E RID: 32286 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task<ICheckResult> method_0()
			{
				throw null;
			}

			// Token: 0x040084EA RID: 34026
			public IFilesChecker filesChecker;

			// Token: 0x040084EB RID: 34027
			public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode;

			// Token: 0x040084EC RID: 34028
			public ConsistencyEnsuranceMode criticalFileEnsuranceMode;

			// Token: 0x040084ED RID: 34029
			public CancellationToken token;
		}

		// Token: 0x020016D2 RID: 5842
		[CompilerGenerated]
		private sealed class Class1209
		{
			// Token: 0x06007E1F RID: 32287 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040084EE RID: 34030
			public TaskCompletionSource<bool> completionSource;
		}

		// Token: 0x020016D4 RID: 5844
		[CompilerGenerated]
		private sealed class Class1210
		{
			// Token: 0x06007E22 RID: 32290 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task<ICheckResult> method_0()
			{
				throw null;
			}

			// Token: 0x040084F8 RID: 34040
			public IFilesChecker filesChecker;

			// Token: 0x040084F9 RID: 34041
			public string resultPath;

			// Token: 0x040084FA RID: 34042
			public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode;

			// Token: 0x040084FB RID: 34043
			public ConsistencyEnsuranceMode criticalFileEnsuranceMode;
		}

		// Token: 0x020016D5 RID: 5845
		[CompilerGenerated]
		private sealed class Class1211
		{
			// Token: 0x06007E23 RID: 32291 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040084FC RID: 34044
			public TaskCompletionSource<object> completionSource;
		}
	}
}
