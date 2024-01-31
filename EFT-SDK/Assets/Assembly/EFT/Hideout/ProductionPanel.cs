using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using EFT.UI;
using TMPro;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AFF RID: 6911
	public sealed class ProductionPanel : AbstractPanel<bool>
	{
		// Token: 0x060091FC RID: 37372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool obj)
		{
			throw null;
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060091FF RID: 37375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Item item)
		{
			throw null;
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(string schemeId)
		{
			throw null;
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<GClass1920> method_4()
		{
			throw null;
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Item[] items, GClass1918 _)
		{
			throw null;
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(string schemeId)
		{
			throw null;
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(string value)
		{
			throw null;
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_10(GClass1920 scheme)
		{
			throw null;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11()
		{
			throw null;
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_12()
		{
			throw null;
		}

		// Token: 0x040098BB RID: 39099
		[SerializeField]
		private ProduceView _produceViewTemplate;

		// Token: 0x040098BC RID: 39100
		[SerializeField]
		private FarmingView _farmingViewTemplate;

		// Token: 0x040098BD RID: 39101
		[SerializeField]
		private PermanentProductionView _permanentViewTemplate;

		// Token: 0x040098BE RID: 39102
		[SerializeField]
		private ScavCaseView _scavCaseTemplate;

		// Token: 0x040098BF RID: 39103
		[SerializeField]
		private RectTransform _container;

		// Token: 0x040098C0 RID: 39104
		[SerializeField]
		private TextMeshProUGUI _header;

		// Token: 0x040098C1 RID: 39105
		[SerializeField]
		private ValidationInputField _searchInputField;

		// Token: 0x040098C2 RID: 39106
		private GClass1912 gclass1912_0;

		// Token: 0x040098C3 RID: 39107
		private GClass1919[] gclass1919_0;

		// Token: 0x040098C4 RID: 39108
		private Dictionary<GClass1919, GInterface167> dictionary_0;

		// Token: 0x040098C5 RID: 39109
		private GClass3076<GClass1920, ProduceView> gclass3076_0;

		// Token: 0x02001B00 RID: 6912
		[CompilerGenerated]
		private sealed class Class1632
		{
			// Token: 0x0600920C RID: 37388 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600920D RID: 37389 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ScavCaseView method_1(GClass1921 arg)
			{
				throw null;
			}

			// Token: 0x0600920E RID: 37390 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_2(GClass1921 arg)
			{
				throw null;
			}

			// Token: 0x0600920F RID: 37391 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x06009210 RID: 37392 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ProduceView method_4(GClass1920 arg)
			{
				throw null;
			}

			// Token: 0x06009211 RID: 37393 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_5(GClass1920 arg)
			{
				throw null;
			}

			// Token: 0x06009212 RID: 37394 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6(GClass1920 scheme, ProduceView view)
			{
				throw null;
			}

			// Token: 0x040098C6 RID: 39110
			public ProductionPanel productionPanel_0;

			// Token: 0x040098C7 RID: 39111
			public ItemUiContext itemUiContext;

			// Token: 0x040098C8 RID: 39112
			public bool availableSearch;
		}

		// Token: 0x02001B01 RID: 6913
		[CompilerGenerated]
		private sealed class Class1633
		{
			// Token: 0x06009213 RID: 37395 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass1921 scheme, ScavCaseView view)
			{
				throw null;
			}

			// Token: 0x040098C9 RID: 39113
			public GClass1916 scavProducer;

			// Token: 0x040098CA RID: 39114
			public ProductionPanel.Class1632 class1632_0;
		}

		// Token: 0x02001B02 RID: 6914
		[CompilerGenerated]
		private sealed class Class1634
		{
			// Token: 0x06009214 RID: 37396 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x040098CB RID: 39115
			public ProduceView view;

			// Token: 0x040098CC RID: 39116
			public ProductionPanel.Class1632 class1632_0;
		}

		// Token: 0x02001B03 RID: 6915
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1635
		{
			// Token: 0x06009215 RID: 37397 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1919 method_0(KeyValuePair<GClass1921, ScavCaseView> view)
			{
				throw null;
			}

			// Token: 0x06009216 RID: 37398 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GInterface167 method_1(KeyValuePair<GClass1921, ScavCaseView> view)
			{
				throw null;
			}

			// Token: 0x06009217 RID: 37399 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass1919 method_2(KeyValuePair<GClass1920, ProduceView> view)
			{
				throw null;
			}

			// Token: 0x06009218 RID: 37400 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GInterface167 method_3(KeyValuePair<GClass1920, ProduceView> view)
			{
				throw null;
			}

			// Token: 0x06009219 RID: 37401 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(GClass1920 scheme)
			{
				throw null;
			}

			// Token: 0x0600921A RID: 37402 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_5(GClass1920 scheme)
			{
				throw null;
			}

			// Token: 0x0600921B RID: 37403 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_6(GClass1920 scheme)
			{
				throw null;
			}

			// Token: 0x040098CD RID: 39117
			public static readonly ProductionPanel.Class1635 class1635_0;

			// Token: 0x040098CE RID: 39118
			public static Func<KeyValuePair<GClass1921, ScavCaseView>, GClass1919> func_0;

			// Token: 0x040098CF RID: 39119
			public static Func<KeyValuePair<GClass1921, ScavCaseView>, GInterface167> func_1;

			// Token: 0x040098D0 RID: 39120
			public static Func<KeyValuePair<GClass1920, ProduceView>, GClass1919> func_2;

			// Token: 0x040098D1 RID: 39121
			public static Func<KeyValuePair<GClass1920, ProduceView>, GInterface167> func_3;

			// Token: 0x040098D2 RID: 39122
			public static Func<GClass1920, bool> func_4;

			// Token: 0x040098D3 RID: 39123
			public static Func<GClass1920, int> func_5;

			// Token: 0x040098D4 RID: 39124
			public static Func<GClass1920, int> func_6;
		}

		// Token: 0x02001B05 RID: 6917
		[CompilerGenerated]
		private sealed class Class1636
		{
			// Token: 0x0600921E RID: 37406 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_0()
			{
				throw null;
			}

			// Token: 0x0600921F RID: 37407 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1()
			{
				throw null;
			}

			// Token: 0x06009220 RID: 37408 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(ItemRequirement x)
			{
				throw null;
			}

			// Token: 0x040098DA RID: 39130
			public ProductionPanel productionPanel_0;

			// Token: 0x040098DB RID: 39131
			public Item item;

			// Token: 0x040098DC RID: 39132
			public Func<ItemRequirement, bool> func_0;

			// Token: 0x02001B06 RID: 6918
			[StructLayout(LayoutKind.Auto)]
			public struct Struct504 : IAsyncStateMachine
			{
				// Token: 0x06009221 RID: 37409 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x06009222 RID: 37410 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x040098DD RID: 39133
				public int int_0;

				// Token: 0x040098DE RID: 39134
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x040098DF RID: 39135
				public ProductionPanel.Class1636 class1636_0;

				// Token: 0x040098E0 RID: 39136
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02001B07 RID: 6919
		[CompilerGenerated]
		private sealed class Class1637
		{
			// Token: 0x06009223 RID: 37411 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1919 x)
			{
				throw null;
			}

			// Token: 0x040098E1 RID: 39137
			public string schemeId;
		}

		// Token: 0x02001B08 RID: 6920
		[CompilerGenerated]
		private sealed class Class1638
		{
			// Token: 0x06009224 RID: 37412 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass1920 scheme)
			{
				throw null;
			}

			// Token: 0x040098E2 RID: 39138
			public string value;
		}
	}
}
