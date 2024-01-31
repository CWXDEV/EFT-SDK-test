using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Build.Pipeline;

namespace Diz.Resources
{
	// Token: 0x02003116 RID: 12566
	public sealed class EasyAssets : MonoBehaviour, IEasyAssets
	{
		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0600F663 RID: 63075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F664 RID: 63076 RVA: 0x00002050 File Offset: 0x00000250
		public DependencyGraph<IEasyBundle> System
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

		// Token: 0x0600F665 RID: 63077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<EasyAssets> Create(GameObject gameObject, [CanBeNull] IBundleLock bundleLock, string defaultKey, string rootPath, string platformName, [CanBeNull] Func<string, bool> shouldExclude, [CanBeNull] Func<string, Task> bundleCheck)
		{
			throw null;
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0([CanBeNull] IBundleLock bundleLock, string defaultKey, string rootPath, string platformName, [CanBeNull] Func<string, bool> shouldExclude, [CanBeNull] Func<string, Task> bundleCheck)
		{
			throw null;
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400FBC7 RID: 64455
		public List<string> Log;

		// Token: 0x0400FBC8 RID: 64456
		[CompilerGenerated]
		private DependencyGraph<IEasyBundle> gclass3385_0;

		// Token: 0x0400FBC9 RID: 64457
		private Class3174[] class3174_0;

		// Token: 0x0400FBCA RID: 64458
		public CompatibilityAssetBundleManifest Manifest;

		// Token: 0x02003117 RID: 12567
		[StructLayout(LayoutKind.Auto)]
		public struct Struct1041
		{
			// Token: 0x0400FBCB RID: 64459
			public string FileName;

			// Token: 0x0400FBCC RID: 64460
			public uint Crc;

			// Token: 0x0400FBCD RID: 64461
			public string[] Dependencies;
		}

		// Token: 0x02003119 RID: 12569
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3173
		{
			// Token: 0x0600F66A RID: 63082 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(KeyValuePair<string, EasyAssets.Struct1041> x)
			{
				throw null;
			}

			// Token: 0x0600F66B RID: 63083 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal BundleDetails method_1(KeyValuePair<string, EasyAssets.Struct1041> x)
			{
				throw null;
			}

			// Token: 0x0400FBD9 RID: 64473
			public static readonly EasyAssets.Class3173 class3173_0;

			// Token: 0x0400FBDA RID: 64474
			public static Func<KeyValuePair<string, EasyAssets.Struct1041>, string> func_0;

			// Token: 0x0400FBDB RID: 64475
			public static Func<KeyValuePair<string, EasyAssets.Struct1041>, BundleDetails> func_1;
		}
	}
}
