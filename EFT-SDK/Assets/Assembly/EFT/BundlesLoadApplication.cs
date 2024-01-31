using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016D7 RID: 5847
	public class BundlesLoadApplication : AbstractApplication
	{
		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x00002050 File Offset: 0x00000250
		protected override EUpdateQueue PlayerUpdateQueue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override GClass635 CreateLogConfigurator()
		{
			throw null;
		}

		// Token: 0x06007E28 RID: 32296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task Start()
		{
			throw null;
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task smethod_1(DependencyGraph<IEasyBundle>.GClass3388 poolBundles)
		{
			throw null;
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnGUI()
		{
			throw null;
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1()
		{
			throw null;
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(string log)
		{
			throw null;
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_5(Item item)
		{
			throw null;
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(GStruct117 p)
		{
			throw null;
		}

		// Token: 0x04008504 RID: 34052
		public string BundleName;

		// Token: 0x04008505 RID: 34053
		public string BundleName1;

		// Token: 0x04008506 RID: 34054
		private IEasyAssets ginterface394_0;

		// Token: 0x04008507 RID: 34055
		private Task task_0;

		// Token: 0x04008508 RID: 34056
		private GameObject gameObject_0;

		// Token: 0x04008509 RID: 34057
		public string LocationLootFile;

		// Token: 0x0400850A RID: 34058
		public bool LoadAllLoot;

		// Token: 0x0400850B RID: 34059
		private string string_0;

		// Token: 0x0400850C RID: 34060
		[SerializeField]
		private int _maxConcurrentLoadOperations;

		// Token: 0x0400850D RID: 34061
		private BundleLock gclass3384_0;

		// Token: 0x0400850E RID: 34062
		private LocationSettingsClass.Location location_0;

		// Token: 0x0400850F RID: 34063
		public bool LoadLootFromTheStart;

		// Token: 0x04008510 RID: 34064
		public string _itemTemplateId;

		// Token: 0x020016D9 RID: 5849
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1212
		{
			// Token: 0x06007E35 RID: 32309 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(float f)
			{
				throw null;
			}

			// Token: 0x06007E36 RID: 32310 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(float f)
			{
				throw null;
			}

			// Token: 0x06007E37 RID: 32311 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_2(LootItemPositionClass x)
			{
				throw null;
			}

			// Token: 0x06007E38 RID: 32312 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_3(KeyValuePair<string, GClass1200> pair)
			{
				throw null;
			}

			// Token: 0x06007E39 RID: 32313 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(Item x)
			{
				throw null;
			}

			// Token: 0x06007E3A RID: 32314 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<ResourceKey> method_5(Item x)
			{
				throw null;
			}

			// Token: 0x04008517 RID: 34071
			public static readonly BundlesLoadApplication.Class1212 class1212_0;

			// Token: 0x04008518 RID: 34072
			public static Action<float> action_0;

			// Token: 0x04008519 RID: 34073
			public static Action<float> action_1;

			// Token: 0x0400851A RID: 34074
			public static Func<LootItemPositionClass, Item> func_0;

			// Token: 0x0400851B RID: 34075
			public static Func<KeyValuePair<string, GClass1200>, Item> func_1;

			// Token: 0x0400851C RID: 34076
			public static Func<Item, bool> func_2;

			// Token: 0x0400851D RID: 34077
			public static Func<Item, IEnumerable<ResourceKey>> func_3;
		}
	}
}
